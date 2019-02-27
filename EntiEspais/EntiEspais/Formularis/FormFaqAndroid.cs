using EntiEspais.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormFaqAndroid : Form
    {
        public FAQS f;
        public FormFaqAndroid()
        {
            this.Text = "NOVA FAQ";
            f = new FAQS();
            InitializeComponent();
        }

        public FormFaqAndroid(FAQS faq)
        {
            this.Text = "MODIFICAR FAQ";
            f = faq;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFaqAndroid_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR FAQ"))
            {
                textBoxPregunta.Text = this.f.pregunta.ToString();
                textBoxResposta.Text = this.f.descripción.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxPregunta.Text.Equals(""))
            {
                MessageBox.Show("Pregunta buida!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxPregunta.Select();
            }
            else if (textBoxResposta.Text.Equals(""))
            {
                MessageBox.Show("Resposta buida!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxResposta.Select();
            }
            else if (this.Text.Equals("NOVA FAQ"))
            {
                String missatge = "";

                this.f.pregunta = textBoxPregunta.Text.ToString();
                this.f.descripción = textBoxResposta.Text.ToString();

                missatge = FaqsAndroidORM.InsertFaq(this.f);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }
            else if (this.Text.Equals("MODIFICAR FAQ"))
            {
                String missatge = "";

                this.f.pregunta = textBoxPregunta.Text.ToString();
                this.f.descripción = textBoxResposta.Text.ToString();

                missatge = FaqsAndroidORM.UpdateFaq(this.f);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
    }
}
