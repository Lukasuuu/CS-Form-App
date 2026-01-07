namespace Nome_da_Maquina_Virtual
{
    public partial class FormMaquina : Form
    {
        public FormMaquina()
        {
            InitializeComponent();
        }

        private void nomeDaMaquina_Click(object sender, EventArgs e)
        {
            txtNomeDaMaquina.Text = Environment.MachineName;
        }

        private void btnOutrasCaracteristicas_Click(object sender, EventArgs e)
        {
            //criar as linhas com as informações adicionais e criar as colunas
            dgvOutrasCaracteristicas.Columns.Clear();
            dgvOutrasCaracteristicas.Rows.Clear();

            //adicionar colunas
            dgvOutrasCaracteristicas.Columns.Add("Caracteristica", "Característica");
            dgvOutrasCaracteristicas.Columns.Add("Valor", "Valor");
            //ajustar o tamanho das colunas
            dgvOutrasCaracteristicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvOutrasCaracteristicas.Rows.Add("Nome do Usuário", Environment.UserName);
            dgvOutrasCaracteristicas.Rows.Add("Sistema Operacional", Environment.OSVersion);
            dgvOutrasCaracteristicas.Rows.Add("Diretório Atual", Environment.CurrentDirectory);
            dgvOutrasCaracteristicas.Rows.Add("Processadores Lógicos", Environment.ProcessorCount);
            dgvOutrasCaracteristicas.Rows.Add("Versão do .NET", Environment.Version.ToString());

            //Mostrar a RAM da máquina em GB
            long memoriaRamBytes = (long)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
                        double memoriaRamGB = memoriaRamBytes / (1024.0 * 1024) / 1024.0;
            dgvOutrasCaracteristicas.Rows.Add("Memória RAM Total (GB)", memoriaRamGB.ToString("F2"));




        }
    }
}
