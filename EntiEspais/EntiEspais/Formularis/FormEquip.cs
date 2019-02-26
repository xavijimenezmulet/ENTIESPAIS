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
            if (textBoxNomEquip.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("Nom obligatori!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNomEquip.Focus();
            }
            else if (!radioButtonSi.Checked && !radioButtonNo.Checked)
            {
                DialogResult mensaje = MessageBox.Show("Marcar discapacitat incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( comboBoxEntitat.SelectedIndex == -1 )
            {
                DialogResult mensaje = MessageBox.Show("Entitat incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEntitat.Focus();
            }
            else if ( comboBoxCompeticio.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Competició incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCompeticio.Focus();
            }
            else if ( comboBoxCategoriaEdat.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Categoria edat incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategoriaEdat.Focus();
            }
            else if ( comboBoxCategoriaEquip.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Categoria de l'equip incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategoriaEquip.Focus();
            }
            else if ( comboBoxSexe.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Sexe incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSexe.Focus();
            }
            else if (comboBoxEsport.SelectedIndex == -1)
            {
                DialogResult mensaje = MessageBox.Show("Esport incorrecte!", "ATENCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEsport.Focus();
            }
            else
            {
                if (this.Text == "Afegir equip")
                {
                    EQUIPS equip3 = new EQUIPS();
                    String missatge = "";
                    equip3.nom = textBoxNomEquip.Text;

                    if (radioButtonSi.Checked)
                    {
                        equip3.te_discapacitat = true;
                    } else { equip3.te_discapacitat = false; }

                    equip3.id_entitat = int.Parse(comboBoxEntitat.SelectedValue.ToString());
                    equip3.temporada = Classes.Utilitats.tempActual();
                    equip3.id_competicio = int.Parse(comboBoxCompeticio.SelectedValue.ToString());
                    equip3.id_categoria_edat = int.Parse(comboBoxCategoriaEdat.SelectedValue.ToString());
                    equip3.id_categoria_equip = int.Parse(comboBoxCategoriaEquip.SelectedValue.ToString());
                    equip3.id_sexe = int.Parse(comboBoxSexe.SelectedValue.ToString());
                    equip3.id_esport = int.Parse(comboBoxEsport.SelectedValue.ToString());

                    missatge = ORM.EquipsORM.InsertEquip(equip3);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Equip introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    String missatge = "";
                    equip2.nom = textBoxNomEquip.Text;

                    if (radioButtonSi.Checked)
                    {
                        equip2.te_discapacitat = true;
                    }
                    else { equip2.te_discapacitat = false; }

                    equip2.id_entitat = int.Parse(comboBoxEntitat.SelectedValue.ToString());
                    equip2.temporada = Classes.Utilitats.tempActual();
                    equip2.id_competicio = int.Parse(comboBoxCompeticio.SelectedValue.ToString());
                    equip2.id_categoria_edat = int.Parse(comboBoxCategoriaEdat.SelectedValue.ToString());
                    equip2.id_categoria_equip = int.Parse(comboBoxCategoriaEquip.SelectedValue.ToString());
                    equip2.id_sexe = int.Parse(comboBoxSexe.SelectedValue.ToString());
                    equip2.id_esport = int.Parse(comboBoxEsport.SelectedValue.ToString());

                    missatge = ORM.EquipsORM.UpdateEquip(equip2);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Equip modificat!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
        }

        //Omple tots els controls de ComboBox amb les dades de la BD.
        private void RellenarComboBox()
        {
            comboBoxCompeticio.DataSource = ORM.CompeticionsORM.SelectAllCompeticions();
            comboBoxCompeticio.ValueMember = "id";
            comboBoxCompeticio.DisplayMember = "nom";
            //
            comboBoxEntitat.DataSource = ORM.EntitatsORM.SelectAllEntities();
            comboBoxEntitat.ValueMember = "id";
            comboBoxEntitat.DisplayMember = "nom";
            //
            comboBoxCategoriaEdat.DataSource = ORM.CategoriaPerEdatORM.SelectAllCategoriesPerEdat();
            comboBoxCategoriaEdat.ValueMember = "id";
            comboBoxCategoriaEdat.DisplayMember = "nom";
            //
            comboBoxCategoriaEquip.DataSource = ORM.CategoriaDelEquipORM.SelectAllCategoriesEquips();
            comboBoxCategoriaEquip.ValueMember = "id";
            comboBoxCategoriaEquip.DisplayMember = "nom";
            //
            comboBoxSexe.DataSource = ORM.SexeORM.SelectAllSexes();
            comboBoxSexe.ValueMember = "id";
            comboBoxSexe.DisplayMember = "tipus";
            //
            comboBoxEsport.DataSource = ORM.EsportsORM.SelectAllEsports();
            comboBoxEsport.ValueMember = "id";
            comboBoxEsport.DisplayMember = "nom";

        }
        private void FormEquip_Load(object sender, EventArgs e)
        {
            RellenarComboBox();

            if (this.Text == "Afegir equip")
            {
                labelid.Visible = false;
                textBoxid.Visible = false;
            }
            else
            {
                labelid.Visible = true;
                textBoxid.Visible = true;
                textBoxid.Enabled = false;

                textBoxid.Text = equip2.id.ToString();
                textBoxNomEquip.Text = equip2.nom;

                if (equip2.te_discapacitat)
                {
                    radioButtonNo.Checked = false;
                    radioButtonSi.Checked = true;
                }
                else
                {
                    radioButtonSi.Checked = false;
                    radioButtonNo.Checked = true;
                }


                comboBoxCompeticio.SelectedValue = equip2.id_competicio;


                comboBoxEntitat.SelectedValue = equip2.id_entitat;


                comboBoxCategoriaEdat.SelectedValue = equip2.id_categoria_edat;


                comboBoxCategoriaEquip.SelectedValue = equip2.id_categoria_equip;


                comboBoxSexe.SelectedValue = equip2.id_sexe;


                comboBoxEsport.SelectedValue = equip2.id_esport;

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
