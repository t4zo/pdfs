using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnirPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelectDirEnt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSelectDirEnt.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btSelectDirSai_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSelectDirSai.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btUnir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSelectDirEnt.Text) && String.IsNullOrEmpty(txtSelectDirSai.Text))
            {
                MessageBox.Show("Informe os Diretórios de Entrada e Saída!");
            }
            else
            {
                // Cria Lista com os Subdiretórios do Diretório de Entrada
                var diretorios = Directory.GetDirectories(txtSelectDirEnt.Text).ToList();
                var qtdArquivos = diretorios.Count();

                if (qtdArquivos == 0)
                {
                    MessageBox.Show("Nenhuma pasta encontrada! Por favor informe outro caminho!");
                }
                else
                {
                    try
                    {
                        progressBar1.Maximum = qtdArquivos;
                        progressBar1.Value = 0;

                        diretorios.ForEach(diretorio =>
                        {
                            var nomeArquivo = diretorio.Substring(txtSelectDirEnt.Text.Length, diretorio.Length - txtSelectDirEnt.Text.Length);

                            // Define o nome e o local de saída do Arquivo Unido
                            string saidaArquivo = txtSelectDirSai.Text + nomeArquivo + ".pdf";

                            List<string> pdfs = new List<string>();

                            var arquivos = Directory.GetFiles(diretorio, "*.pdf").ToList();
                            if (arquivos.Count() == 0)
                            {
                                MessageBox.Show("Nenhum arquivo encontrado em " + diretorio + "!");
                            }
                            else
                            {
                                arquivos.ForEach(arquivo => pdfs.Add(arquivo));

                                MergePdfFiles(pdfs, saidaArquivo);

                                log(nomeArquivo);

                                // Verifica se é para apagar os Arquivos
                                if (checkBoxApagar.Checked)
                                {
                                    arquivos.ForEach(arquivo => 
                                    {
                                        File.Delete(arquivo);
                                    });

                                    Directory.Delete(diretorio);
                                }
                            }
                        });

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Tarefa concluída!");
                }
            }
        }

        private void MergePdfFiles(List<string> arquivosPDF, string caminhoSaidaCompleto)
        {
            if (arquivosPDF.Count > 0)
            {
                PDFMergerUtility pdfMerger = new PDFMergerUtility();

                pdfMerger.setDestinationFileName(caminhoSaidaCompleto);

                try
                {

                    arquivosPDF.ForEach(arquivoPDF =>
                    {
                        pdfMerger.addSource(arquivoPDF);
                        progressBar1.Increment(1);
                    });

                    pdfMerger.mergeDocuments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void log(string arquivo)
        {
            var message = String.IsNullOrEmpty(rtbLogger.Text) ? "" : "\n";
            rtbLogger.Text += message + arquivo;
        }
    }
}
