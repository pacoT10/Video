using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wmp_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp.uiMode = "none";

            StreamReader sr = new StreamReader("lista.txt");

            string linea;

            while(sr.EndOfStream==false)
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(',') ;
                cboCancion.Items.Add(datos[1]);

            }

            cboCancion.SelectedIndex = 0;
            sr.Close();
            sr.Dispose();
        }

        private void cboCancion_SelectedIndexChanged(object sender, EventArgs e)
        { 
           string cancion=  "tema"+ (cboCancion.SelectedIndex+1).ToString()+".mp4";
            wmp.URL = cancion;
        }
    }
}
