namespace ExercicioTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string massage = "Isto é um teste de código C#.";
            string caption = "Isto é o Título";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(massage, caption, buttons,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes) 
            {
                MessageBox.Show("Escolheu Sim");
            } 
            if (result == DialogResult.No) 
            {
                MessageBox.Show("Escolheu Não");
            } 
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Escolheu Cancelar");
            }
        }
    }
}
