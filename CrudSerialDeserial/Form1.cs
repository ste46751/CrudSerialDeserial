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

namespace CrudSerialDeserial
{
    public partial class Form1 : Form
    {
        List<Person> lista;
        public Form1()
        {
            InitializeComponent();
            //Creazione della lista all'avvio
            lista = new List<Person>();
        }

        class Person
        {
            public string _nome { get; set; }
            public string _cognome { get; set; }
            public Person(string nome, string cognome)
            {
                this._nome = nome;
                this._cognome = cognome;
            }
            public Person()
            {

            }
            public string Serializzazione()
            {
                string s = $"{_nome};{_cognome}";
                return s;

            }

            public void Deserializzazione()
            {
                string s = Serializzazione();
                string[] array = new string[2];
                array = s.Split(';');

            }


            public void Scrivi(List<Person> lista)
            {
                StreamWriter sw = new StreamWriter("ListaE.txt");

                for (int i = 0; i < lista.Count; i++)
                {
                    sw.WriteLine($"{lista[i]._nome};{lista[i]._cognome}");
                }
                sw.Close();

            }
        }

        private void Btn_Create_Click_1(object sender, EventArgs e)
        {
            string n = txt_nome.Text;
            string c = txt_cognome.Text;

            //Person person = new Person(n,c);

            lista.Add(new Person(n, c));
            lstbx_lista.Items.Add($"{n};{c}");
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Person person = new Person();
            person.Scrivi(lista);
        }

        private void Btn_Read_Click_1(object sender, EventArgs e)
        {
            for (int i = 0;i < lstbx_lista.Items.Count;i++)
            {
                if(txt_nome.Text == lista[i]._nome)
                {
                    lstbx_lista.SelectedIndex = i;
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string n = txt_nome.Text;

            string c = txt_cognome.Text;

            string n1 = txt_ncambia.Text;
            string c1 = txt_ccambia.Text;

            for (int i = 0;i < lista.Count;i++)
            {
                if (n == lista[i]._nome && c == lista[i]._cognome)
                {
                    lista[i]._nome=n1;
                    lista[i]._cognome=c1;
                }
                else
                {

                }
            }
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            string n = txt_nome.Text;
            string c = txt_cognome.Text;

            string n1 = txt_ncambia.Text;
            string c1 = txt_ccambia.Text;

            for (int i = 0; i < lista.Count; i++)
            {
                if (n == lista[i]._nome && c == lista[i]._cognome)
                {
                    lista.Remove(lista[i]);
                    lstbx_lista.Items.RemoveAt(i);
                }
                else
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("ListaE.txt") == false)
            {
                StreamReader sr = new StreamReader("ListaE.txt");
                do
                {
                    string line = sr.ReadLine();


                }while( sr.EndOfStream );
                sr.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("ListaE.txt");
                string[] array = new string[2];
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    if (linea != null)
                    {
                        array = linea.Split(';');
                        Person person = new Person(array[0], array[1]);
                        lista.Add(person);
                    }
                    linea = sr.ReadLine();
                }
                sr.Close();
            }
        }

        
    }
}
