using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CasorioDD
{
    public partial class Form1 : Form
    {
        public int ticket;
        public List<int> ticketsQueSalieron;
        private List<int> sorteado = new List<int>();
        public Random random;

        public string premio1 = ""; 
        public string premio2 = "";
        public string premio3 = "";
        public string premio4 = "";
        public string premio5 = "";
        public string premio6 = "";
        public string premio7 = "";
        public string premio8 = "";
        public string premio9 = "";
        public string premio10 = "";
        public string premio11 = "";

        public int contador = 10;
        public Form1()
        {
            InitializeComponent();
            this.ticketsQueSalieron = new List<int>();
            this.random = new Random();

            this.lblNumero1.Text = "";
            this.lblNumero2.Text = "";
            this.lblNumero3.Text = "";

            this.lblPremio10.Visible = false;
            this.lblPremio9.Visible = false;
            this.lblPremio8.Visible = false;
            this.lblPremio7.Visible = false;
            this.lblPremio6.Visible = false;
            this.lblPremio5.Visible = false;
            this.lblPremio4.Visible = false;
            this.lblPremio3.Visible = false;
            this.lblPremio2.Visible = false;
            this.lblPremio1.Visible = false;
            this.panel10.Visible = false;
            this.panel8.Visible = false;
            this.panel9.Visible = false;
            this.panel8.Visible = false;
            this.panel7.Visible = false;
            this.panel6.Visible = false;
            this.panel5.Visible = false;
            this.panel4.Visible = false;
            this.panel3.Visible = false;
            this.panel2.Visible = false;
            this.panel1.Visible = false;

            this.pbxGracias.Visible = false;
        }
        

        public void mostrarLista(int n, string s) {
            switch (n)
            {
                case 10:
                    this.premio10 = s;
                    this.lblPremio10.Visible = true;
                    this.lblPremio10.Text = n + "° Número: " + premio10 + "\n";
                    this.panel10.Visible = true;
                    break;
                case 9:
                    this.premio9 = s;
                    this.lblPremio9.Visible = true;
                    this.lblPremio9.Text = n + "° Número: " + premio9 + "\n";  
                    this.panel9.Visible = true;                    
                    break;
                case 8:
                    this.premio8 = s;
                    this.lblPremio8.Visible = true;
                    this.lblPremio8.Text = n + "° Número: " + premio8 + "\n";
                    this.panel8.Visible = true;
                    break;
                case 7:
                    this.premio7 = s;
                    this.lblPremio7.Visible = true;
                    this.lblPremio7.Text = n + "° Número: " + premio7 + "\n";
                    this.panel7.Visible = true;
                    break;
                case 6:
                    this.premio6 = s;
                    this.lblPremio6.Visible = true;
                    this.lblPremio6.Text = n + "° Número: " + premio6 + "\n";
                    this.panel6.Visible = true;
                    break;
                case 5:
                    this.premio5 = s;
                    this.lblPremio5.Visible = true;
                    this.lblPremio5.Text = n + "° Número: " + premio5 + "\n";
                    this.panel5.Visible = true;
                    break;
                case 4:
                    this.premio4 = s;
                    this.lblPremio4.Visible = true;
                    this.lblPremio4.Text = n + "° Número: " + premio4 + "\n";
                    this.panel4.Visible = true;
                    break;
                case 3:
                    this.premio3 = s;
                    this.lblPremio3.Visible = true;
                    this.lblPremio3.Text = n + "° Número: " + premio3 + "\n"; 
                    this.panel3.Visible = true;
                    break;
                case 2:
                    this.premio2 = s;
                    this.lblPremio2.Visible = true;
                    this.lblPremio2.Text = n + "° Número: " + premio2 + "\n";
                    this.panel2.Visible = true;
                    break;
                case 1:
                    this.premio1 = s;
                    this.lblPremio1.Visible = true;
                    this.lblPremio1.Text = n + "° Número: " + premio1 + "\n";
                    this.panel1.Visible = true;
                    break;
                default: terminar(); break; ;
            }            
        }


        private async void btnSorteo_Click(object sender, EventArgs e)
        {
            if (sorteado.Count <= 11)
            {
                int timer = this.random.Next(4000, 6000);
                int res = 0;
                do
                {
                    res = this.random.Next(1, 101);
                } while (sorteado.Contains(res));

                sorteado.Add(res);

                await girarRuleta2(timer);
                mostrarValores(res);

                mostrarLista(this.contador--, res.ToString());
            } else {
                terminar();
            }
        }

        public void mostrarValores(int val) { //TODO Ver error cuando toca un numero d 1 digito
            int valorParsed = val;
            this.lblNumero1.Text = (valorParsed / 100).ToString();
            this.lblNumero2.Text = (valorParsed / 10 % 10).ToString();
            this.lblNumero3.Text = (valorParsed % 10).ToString();
        }

        private async Task girarRuleta2(int timer)
        {
            if (sorteado.Count < 11)
            {
                for (int i = 0; i < timer; i += 150)
                {
                    this.lblNumero1.Text = this.random.Next(10).ToString();
                    this.lblNumero2.Text = this.random.Next(10).ToString();
                    this.lblNumero3.Text = this.random.Next(10).ToString();
                    await Task.Delay(150);
                }
            }
        }

        public void terminar()
        {
            this.pbxGracias.Visible = true;

            this.btnSorteo.Visible = false;
            this.lblPremio10.Visible = false;
            this.lblPremio9.Visible = false;
            this.lblPremio8.Visible = false;
            this.lblPremio7.Visible = false;
            this.lblPremio6.Visible = false;
            this.lblPremio5.Visible = false;
            this.lblPremio4.Visible = false;
            this.lblPremio3.Visible = false;
            this.lblPremio2.Visible = false;
            this.lblPremio1.Visible = false;
            this.panel10.Visible = false;
            this.panel8.Visible = false;
            this.panel9.Visible = false;
            this.panel8.Visible = false;
            this.panel7.Visible = false;
            this.panel6.Visible = false;
            this.panel5.Visible = false;
            this.panel4.Visible = false;
            this.panel3.Visible = false;
            this.panel2.Visible = false;
            this.panel1.Visible = false;
        }
    }
}
