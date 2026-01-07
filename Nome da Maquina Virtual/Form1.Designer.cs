namespace Nome_da_Maquina_Virtual
{
    partial class FormMaquina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNomeDaMaquina = new Button();
            txtNomeDaMaquina = new TextBox();
            btnOutrasCaracteristicas = new Button();
            dgvOutrasCaracteristicas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOutrasCaracteristicas).BeginInit();
            SuspendLayout();
            // 
            // btnNomeDaMaquina
            // 
            btnNomeDaMaquina.Location = new Point(12, 28);
            btnNomeDaMaquina.Name = "btnNomeDaMaquina";
            btnNomeDaMaquina.Size = new Size(172, 29);
            btnNomeDaMaquina.TabIndex = 0;
            btnNomeDaMaquina.Text = "1: Nome da Maquina";
            btnNomeDaMaquina.UseVisualStyleBackColor = true;
            btnNomeDaMaquina.Click += nomeDaMaquina_Click;
            // 
            // txtNomeDaMaquina
            // 
            txtNomeDaMaquina.Location = new Point(12, 63);
            txtNomeDaMaquina.Name = "txtNomeDaMaquina";
            txtNomeDaMaquina.Size = new Size(172, 23);
            txtNomeDaMaquina.TabIndex = 1;
            // 
            // btnOutrasCaracteristicas
            // 
            btnOutrasCaracteristicas.Location = new Point(12, 103);
            btnOutrasCaracteristicas.Name = "btnOutrasCaracteristicas";
            btnOutrasCaracteristicas.Size = new Size(183, 29);
            btnOutrasCaracteristicas.TabIndex = 2;
            btnOutrasCaracteristicas.Text = "2: Outras Caracteristicas do PC";
            btnOutrasCaracteristicas.UseVisualStyleBackColor = true;
            btnOutrasCaracteristicas.Click += btnOutrasCaracteristicas_Click;
            // 
            // dgvOutrasCaracteristicas
            // 
            dgvOutrasCaracteristicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutrasCaracteristicas.Location = new Point(12, 138);
            dgvOutrasCaracteristicas.Name = "dgvOutrasCaracteristicas";
            dgvOutrasCaracteristicas.Size = new Size(728, 277);
            dgvOutrasCaracteristicas.TabIndex = 3;
            // 
            // FormMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOutrasCaracteristicas);
            Controls.Add(btnOutrasCaracteristicas);
            Controls.Add(txtNomeDaMaquina);
            Controls.Add(btnNomeDaMaquina);
            Name = "FormMaquina";
            Text = "Informações da Maquina";
            ((System.ComponentModel.ISupportInitialize)dgvOutrasCaracteristicas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNomeDaMaquina;
        private TextBox txtNomeDaMaquina;
        private Button btnOutrasCaracteristicas;
        private DataGridView dgvOutrasCaracteristicas;
    }
}
