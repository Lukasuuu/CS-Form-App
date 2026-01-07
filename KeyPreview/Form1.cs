namespace KeyPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown +=  new KeyEventHandler(Form_KeyDown!);
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Escape Pressionado!");

            }
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Ajuda em linha...");
            }
        }
    }
}
