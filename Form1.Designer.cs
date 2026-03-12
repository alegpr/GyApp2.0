namespace GyApp2._0
{
    partial class frmMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            picLike = new PictureBox();
            picDislike = new PictureBox();
            picProfilo = new PictureBox();
            lblNomeCompleto = new Label();
            lblRuolo = new Label();
            txtDettagli = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDislike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfilo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(picLike, 0, 0);
            tableLayoutPanel1.Controls.Add(picDislike, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 1807);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1270, 317);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picLike
            // 
            picLike.Dock = DockStyle.Fill;
            picLike.Image = Properties.Resources.accept;
            picLike.Location = new Point(4, 4);
            picLike.Margin = new Padding(4);
            picLike.Name = "picLike";
            picLike.Size = new Size(627, 309);
            picLike.SizeMode = PictureBoxSizeMode.Zoom;
            picLike.TabIndex = 0;
            picLike.TabStop = false;
            picLike.Click += picLike_Click;
            // 
            // picDislike
            // 
            picDislike.Dock = DockStyle.Fill;
            picDislike.Image = Properties.Resources.delete;
            picDislike.Location = new Point(639, 4);
            picDislike.Margin = new Padding(4);
            picDislike.Name = "picDislike";
            picDislike.Size = new Size(627, 309);
            picDislike.SizeMode = PictureBoxSizeMode.Zoom;
            picDislike.TabIndex = 1;
            picDislike.TabStop = false;
            picDislike.Click += picDislike_Click;
            // 
            // picProfilo
            // 
            picProfilo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picProfilo.Location = new Point(0, 0);
            picProfilo.Margin = new Padding(4);
            picProfilo.Name = "picProfilo";
            picProfilo.Size = new Size(1270, 1807);
            picProfilo.SizeMode = PictureBoxSizeMode.Zoom;
            picProfilo.TabIndex = 1;
            picProfilo.TabStop = false;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCompleto.ForeColor = Color.White;
            lblNomeCompleto.Location = new Point(47, 1245);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(413, 149);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "NOME";
            // 
            // lblRuolo
            // 
            lblRuolo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRuolo.AutoSize = true;
            lblRuolo.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRuolo.ForeColor = Color.White;
            lblRuolo.Location = new Point(75, 1394);
            lblRuolo.Name = "lblRuolo";
            lblRuolo.Size = new Size(148, 50);
            lblRuolo.TabIndex = 3;
            lblRuolo.Text = "RUOLO";
            // 
            // txtDettagli
            // 
            txtDettagli.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDettagli.Location = new Point(75, 1447);
            txtDettagli.Multiline = true;
            txtDettagli.Name = "txtDettagli";
            txtDettagli.ReadOnly = true;
            txtDettagli.Size = new Size(672, 285);
            txtDettagli.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1270, 2124);
            Controls.Add(txtDettagli);
            Controls.Add(lblRuolo);
            Controls.Add(lblNomeCompleto);
            Controls.Add(picProfilo);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GyApp";
            Load += frmMain_Load;
            Resize += frmMain_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDislike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfilo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picLike;
        private PictureBox picDislike;
        private PictureBox picProfilo;
        private Label lblNomeCompleto;
        private Label lblRuolo;
        private TextBox txtDettagli;
    }
}
