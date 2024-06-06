using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_Imagens
{
    public partial class FrVisualizador : Form
    {
        private bool isAutoMode = false; // Variável para indicar modo automático

        // Declare a variável currentIndex como um campo da classe
        private int currentIndex = 0;

        private bool folderDialogOpened = false; // Variável para controlar se a caixa de diálogo já foi aberta
        public FrVisualizador()
        {
            InitializeComponent();

            // Adiciona o evento Click ao menu Abrir
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;

            // Adiciona o evento SelectedIndexChanged ao ListBox
            Limagem.SelectedIndexChanged += Limagem_SelectedIndexChanged;

            // Adiciona o evento Click ao botão Abrir
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;

            // Adiciona o evento Click ao botão Limpar
            BtnLimpar.Click += BtnLimpar_Click;

            // Adiciona o evento Click ao botão Iniciar Auto
            BtnAuto.Click += BtnAuto_Click;

            // Adiciona o evento Click ao botão Parar Auto
            BtnParar.Click += BtnParar_Click;

            // Adiciona o evento Click ao menu Sair
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!folderDialogOpened) // Verifica se a caixa de diálogo já foi aberta
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        folderDialogOpened = true; // Define como true para indicar que a caixa de diálogo foi aberta
                        Limagem.Items.Clear();
                        string selectedPath = folderDialog.SelectedPath;
                        string[] imageFiles = Directory.GetFiles(selectedPath, "*.*", SearchOption.AllDirectories)
                                                       .Where(s => s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                                   s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                                   s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                                   s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                                   s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                                       .ToArray();

                        foreach (string imageFile in imageFiles)
                        {
                            Limagem.Items.Add(imageFile);
                        }
                    }
                }
            }
        }
        private void Limagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o número total de imagens
            int totalImages = Limagem.Items.Count;

            // Obtém o índice da imagem selecionada (começando de 1)
            int selectedIndex = Limagem.SelectedIndex + 1;

            // Exibe o número da imagem atual em relação ao número total de imagens
            Lblimagem.Text = $"Imagem {selectedIndex} de {totalImages}";

            // Obtém o caminho da imagem selecionada
            if (Limagem.SelectedItem != null)
            {
                string selectedImagePath = Limagem.SelectedItem.ToString();

                // Carrega e exibe a imagem no PictureBox
                picImagem.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            // Verifica se há itens no ListBox
            if (Limagem.Items.Count > 0)
            {
                // Verifica se não está no primeiro item
                if (Limagem.SelectedIndex > 0)
                {
                    // Decrementa o índice selecionado
                    Limagem.SelectedIndex--;
                    // Faz o scroll acompanhar a seleção
                    EnsureVisible(Limagem, Limagem.SelectedIndex);
                }
                else
                {
                    // Exibe mensagem de aviso ao usuário
                    MessageBox.Show("Voçê Esta No inicio da Lista de imagens.", "Inicio da Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSeguinte_Click(object sender, EventArgs e)
        {
            if (Limagem.Items.Count > 0)
            {
                if (Limagem.SelectedIndex < Limagem.Items.Count - 1)
                {
                    int nextIndex = Limagem.SelectedIndex + 1;

                    string imagePath = Limagem.Items[nextIndex].ToString();
                    picImagem.Image = Image.FromFile(imagePath);

                    Limagem.SelectedIndex = nextIndex;
                    Lblimagem.Text = $"Imagem {nextIndex + 1} de {Limagem.Items.Count}";
                }
                else
                {
                    // Exibe mensagem de aviso ao usuário
                    MessageBox.Show("Você está no fim da lista de imagens.", "Fim da Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void EnsureVisible(ListBox listBox, int index)
        {
            // Verifica se o item está acima da área visível
            if (index < listBox.TopIndex)
            {
                listBox.TopIndex = index;
            }
            // Verifica se o item está abaixo da área visível
            else if (index >= listBox.TopIndex + listBox.ClientSize.Height / listBox.ItemHeight)
            {
                listBox.TopIndex = index - listBox.ClientSize.Height / listBox.ItemHeight + 1;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limagem.Items.Clear();
            picImagem.Image = null;
            Lblimagem.Text = "Imagem 0 de 0";
            MessageBox.Show("Visualizador Limpo Com Sucesso!...",
                "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void Fechar()
        {
          if(MessageBox.Show("Deseja Sair do Programa?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)return;
                Application.Exit(); // Fecha o programa se o usuário escolher "Sim"

        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            isAutoMode = true; // Definir modo automático como true
            timer1.Start();
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isAutoMode = false; // Definir modo automático como false
            MessageBox.Show("A sua Apresentação esta Parada!...", "Apresentação",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAutoMode)
            {
                if (currentIndex < Limagem.Items.Count)
                {
                    // Obtém o caminho da próxima imagem
                    string imagePath = Limagem.Items[currentIndex].ToString();
                    picImagem.Image = Image.FromFile(imagePath);

                    // Atualiza o índice atual
                    currentIndex++;

                    // Atualiza a label com o número da imagem
                    Lblimagem.Text = $"Imagem {currentIndex} de {Limagem.Items.Count}";

                    // Seleciona a próxima imagem na ListBox
                    Limagem.SelectedIndex = currentIndex - 1;
                }
                else
                {
                    // Parar o timer quando todas as imagens forem exibidas
                    timer1.Stop();

                    // Exibe a mensagem de fim de apresentação
                    DialogResult result = MessageBox.Show("Apresentação Automática Concluída. Deseja reiniciar?", "Fim da Apresentação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Reinicia a apresentação
                        currentIndex = 0;
                        timer1.Start();
                    }
                    else
                    {
                        // Mantém na posição final
                        currentIndex = Limagem.Items.Count;
                    }
                }
            }
        }

    }
}
