using LiteDB;
namespace risk_manager
{
    public partial class Form1 : Form
    {
        string dbPath = "MoslerRiesgos.db";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnIrEvaluacion_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1; // se va a la pestaña Evaluación       }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int C = (int)nudC.Value;
            int E = (int)nudE.Value;
            int P = (int)nudP.Value;
            int A = (int)nudA.Value;
            int V = (int)nudV.Value;
            int F = (int)nudF.Value;

            // MEDIA (PROMEDIO)
            double R = (C + E + P + A + V + F) / 6.0;

            txtResultado.Text = R.ToString("0.00");

            if (R <= 2.5) txtNivel.Text = "Bajo";
            else if (R <= 3.5) txtNivel.Text = "Medio";
            else txtNivel.Text = "Alto";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Completa ID y Nombre.");
                tabControl1.SelectedIndex = 0;
                return;
            }

            if (!double.TryParse(txtResultado.Text, out double rValor))
            {
                MessageBox.Show("Calcula el riesgo antes de guardar.");
                return;
            }

            var r = new Riesgo
            {
                Codigo = txtID.Text,
                Nombre = txtNombre.Text,
                Area = cmbArea.Text,
                Responsable = txtResponsable.Text,
                Problema = rtbDescripcion.Text,
                C = (int)nudC.Value,
                E = (int)nudE.Value,
                P = (int)nudP.Value,
                A = (int)nudA.Value,
                V = (int)nudV.Value,
                F = (int)nudF.Value,
                R = rValor,
                Nivel = txtNivel.Text
            };

            using (var db = new LiteDatabase(dbPath))
            {
                var col = db.GetCollection<Riesgo>("riesgos");
                col.Insert(r);
            }

            MessageBox.Show("Guardado.");
        }

        private void btnCargarHistorial_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase("MoslerRiesgos.db"))
            {
                var col = db.GetCollection<Riesgo>("riesgos");
                var lista = col.FindAll().ToList();
                dgvHistorial.DataSource = lista;
            }
        }
    }
}
