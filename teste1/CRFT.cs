using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace teste1
{
    public partial class File_Destino : Form
    {
        public File_Destino()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { 
                if (FB_Origem.ShowDialog() == DialogResult.OK)
                {
                    TXT_Origem.Text = FB_Origem.SelectedPath;
                    
                }
            }else if (radioButton2.Checked)
            {
                if(fileorigem.ShowDialog() == DialogResult.OK)
                {
                    TXT_Origem.Text = fileorigem.FileName;
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor, especifique o tipo de transferência.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                         
                if (FB_Destino.ShowDialog() == DialogResult.OK)
                {
                    TXT_Destino.Text = FB_Destino.SelectedPath;
                }
                
           
        }


        

        private void button3_Click(object sender, EventArgs e) 
            {
            if (radioButton1.Checked) { 
                var caminhoOrigem = FB_Origem.SelectedPath;
                var caminhoDestino = FB_Destino.SelectedPath;

                Process My_Process = new Process();
                ProcessStartInfo My_Process_Info = new ProcessStartInfo();

               

                My_Process_Info.FileName = "cmd.exe";

                

                if (caminhoOrigem != "" && caminhoDestino != "")
                {
                    

                    My_Process_Info.WorkingDirectory = @"c:\temp";
                    My_Process_Info.Arguments = "/k robocopy \"" + caminhoOrigem + "\"" + " " + "\"" + caminhoDestino + "\"" + " /e /z /eta /v /bytes" + " /log:" + '\u0022' + "c:\"temp\"logpasta.txt" + '\u0022' + " /tee";
                    My_Process_Info.CreateNoWindow = false;
                    My_Process_Info.UseShellExecute = false;
                    My_Process_Info.RedirectStandardOutput = false;
                    My_Process_Info.RedirectStandardError = false;
                    My_Process.EnableRaisingEvents = true;
                    My_Process.StartInfo = My_Process_Info;
                    My_Process.Start();
                    My_Process.WaitForExit();

                }
                    //if(caminhoOrigem != "" && caminhoDestino != "")
                    DialogResult dialogResult = MessageBox.Show("Deseja verificar os detalhes da trânsferência?", "Concluído", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    System.Diagnostics.Process.Start(@"c:\temp\templog.txt");
                    TXT_Destino.Clear();
                    TXT_Origem.Clear();
                }
                else
                {
                    TXT_Origem.Clear();
                    TXT_Destino.Clear();
                }

                

            }else if (radioButton2.Checked)
            {
                var caminhoOrigem = fileorigem.FileName;
                var caminhoDestino = FB_Destino.SelectedPath;

                Process My_Process = new Process();
                ProcessStartInfo My_Process_Info = new ProcessStartInfo();


                My_Process_Info.FileName = "cmd.exe";



                if (caminhoOrigem != "" && caminhoDestino != "")
                {
                    
                    My_Process_Info.WorkingDirectory = @"c:\temp";
                    My_Process_Info.Arguments = "/c copy \"" + caminhoOrigem + "\"" + " " + "\"" + caminhoDestino + "\"";
                    My_Process_Info.CreateNoWindow = false;
                    My_Process_Info.UseShellExecute = false;
                    My_Process_Info.RedirectStandardOutput = false;
                    My_Process_Info.RedirectStandardError = false;
                    My_Process.EnableRaisingEvents = true;
                    My_Process.StartInfo = My_Process_Info;
                    My_Process.Start();
                    My_Process.WaitForExit(); 

                    MessageBox.Show("Transferência concluída.", "Concluído", MessageBoxButtons.OK);

                    TXT_Destino.Clear();
                    TXT_Origem.Clear();
                    caminhoOrigem = "";
                    caminhoDestino = "";
                }
                
                //DialogResult dialogResult = MessageBox.Show("Transferência concluida!", "Concluído", MessageBoxButtons.OK);

                    
               
            }
                else
                {
                    string ndselect = "Por favor, Verifique os caminhos de origem e destino.";
                    MessageBox.Show(ndselect);
            }

            }





        }


    }

