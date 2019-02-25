using System;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormEquip : Form
    {
        EQUIPS equip2;

        public FormEquip()
        {
            InitializeComponent();
        }

        public FormEquip(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

        public FormEquip(string titulo, EQUIPS equip)
        {
            InitializeComponent();
            this.Text = titulo;
            equip2 = equip;
        }

        //Tanca el formulari una vegada fem clic al botó cancel·lar.
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Al fer clic al botó acceptar [...]
        private void buttonAcceptar_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomEquip.Text;
            
            bool discapacitat = false;
            if (radioButtonSi.Checked)
            {
                discapacitat = true;
            }




            MessageBox.Show("Equip introduït correctament.");
        }

        private void FormEquip_Load(object sender, EventArgs e)
        {
            if (this.Text == "Afegir equip")
            {

            }
            else
            {

            }
        }


        
        
        //CODE:
        //· buttonAcceptar_Click()
        //1. Funcion insert.
        //2. Funcion update.
        //· FormEquip_Load()
        //1. Rellenar los combobox con los datos de la BD.


    }
}
