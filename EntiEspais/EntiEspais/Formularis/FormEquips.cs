using EntiEspais.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormEquips : Form
    {
        public FormEquips()
        {
            InitializeComponent();
        }

        //Omple la GridView amb tots els equips que hi hagi a la base de dades.
        private void RefrescarEquips()
        {
            bindingSourceEquips.DataSource = ORM.EquipsORM.SelectAllEquips();
        }

        //Cada tick del rellotge posa l'hora en una label.
        private void Reloj_Tick_1(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormEquips_Load(object sender, EventArgs e)
        {
            Reloj.Start();

            RefrescarEquips();
           
        }
        
        private void buttonAfegirEquipo_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerAfegir();
        }

        private void FormEquips_Activated(object sender, EventArgs e)
        {
            RefrescarEquips();
        }

        private void buttonModificarEquipo_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerModificar((EQUIPS)dataGridViewEquips.SelectedRows[0].DataBoundItem);
        }

        private void buttonEliminarEquipo_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            DialogResult resultado = MessageBox.Show("¿Estàs segur d'eliminar aquest equip?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                mensaje = ORM.EquipsORM.DeleteEquip((EQUIPS)dataGridViewEquips.SelectedRows[0].DataBoundItem);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    RefrescarEquips();
                }
            }
            else
            {
                
            }
        }
    }
}
