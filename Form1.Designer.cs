namespace WindowsFormsApplication1
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.Seleciona = new System.Windows.Forms.Button();
            this.Salva = new System.Windows.Forms.Button();
            this.EscalaCinza = new System.Windows.Forms.Button();
            this.bt_limpar_resultado = new System.Windows.Forms.Button();
            this.bt_limpar_original = new System.Windows.Forms.Button();
            this.bt_negativo = new System.Windows.Forms.Button();
            this.bt_blur = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bt_sepia = new System.Windows.Forms.Button();
            this.bt_RGB = new System.Windows.Forms.Button();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.flp_RGB = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Ausencia = new System.Windows.Forms.Button();
            this.flp_ausencia = new System.Windows.Forms.FlowLayoutPanel();
            this.rb_blue_ausencia = new System.Windows.Forms.RadioButton();
            this.rb_green_ausencia = new System.Windows.Forms.RadioButton();
            this.rb_red_ausencia = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flp_RGB.SuspendLayout();
            this.flp_ausencia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(24, 30);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(339, 388);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Click += new System.EventHandler(this.PictureBoxOriginal_Click);
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResultado.Location = new System.Drawing.Point(24, 30);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(339, 388);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResultado.TabIndex = 2;
            this.pictureBoxResultado.TabStop = false;
            // 
            // Seleciona
            // 
            this.Seleciona.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.Seleciona.Location = new System.Drawing.Point(263, 424);
            this.Seleciona.Name = "Seleciona";
            this.Seleciona.Size = new System.Drawing.Size(100, 28);
            this.Seleciona.TabIndex = 3;
            this.Seleciona.Text = "Selecionar Imagem";
            this.Seleciona.UseVisualStyleBackColor = true;
            this.Seleciona.Click += new System.EventHandler(this.Seleciona_Click);
            // 
            // Salva
            // 
            this.Salva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salva.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.Salva.Location = new System.Drawing.Point(263, 424);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(100, 28);
            this.Salva.TabIndex = 4;
            this.Salva.Text = "Salvar";
            this.Salva.UseVisualStyleBackColor = false;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // EscalaCinza
            // 
            this.EscalaCinza.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.EscalaCinza.Location = new System.Drawing.Point(10, 58);
            this.EscalaCinza.Name = "EscalaCinza";
            this.EscalaCinza.Size = new System.Drawing.Size(100, 28);
            this.EscalaCinza.TabIndex = 27;
            this.EscalaCinza.Text = "Aplicar";
            this.EscalaCinza.UseVisualStyleBackColor = true;
            this.EscalaCinza.Click += new System.EventHandler(this.EscalaCinza_Click);
            // 
            // bt_limpar_resultado
            // 
            this.bt_limpar_resultado.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.bt_limpar_resultado.Location = new System.Drawing.Point(24, 424);
            this.bt_limpar_resultado.Name = "bt_limpar_resultado";
            this.bt_limpar_resultado.Size = new System.Drawing.Size(100, 28);
            this.bt_limpar_resultado.TabIndex = 29;
            this.bt_limpar_resultado.Text = "Limpar";
            this.bt_limpar_resultado.UseVisualStyleBackColor = true;
            this.bt_limpar_resultado.Click += new System.EventHandler(this.Bt_limpar_resultado_Click);
            // 
            // bt_limpar_original
            // 
            this.bt_limpar_original.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.bt_limpar_original.Location = new System.Drawing.Point(24, 424);
            this.bt_limpar_original.Name = "bt_limpar_original";
            this.bt_limpar_original.Size = new System.Drawing.Size(100, 28);
            this.bt_limpar_original.TabIndex = 30;
            this.bt_limpar_original.Text = "Limpar";
            this.bt_limpar_original.UseVisualStyleBackColor = true;
            this.bt_limpar_original.Click += new System.EventHandler(this.Bt_limpar_original_Click);
            // 
            // bt_negativo
            // 
            this.bt_negativo.BackColor = System.Drawing.Color.White;
            this.bt_negativo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_negativo.BackgroundImage")));
            this.bt_negativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_negativo.Location = new System.Drawing.Point(136, 58);
            this.bt_negativo.Name = "bt_negativo";
            this.bt_negativo.Size = new System.Drawing.Size(100, 28);
            this.bt_negativo.TabIndex = 32;
            this.bt_negativo.Text = "Aplicar";
            this.bt_negativo.UseVisualStyleBackColor = false;
            this.bt_negativo.Click += new System.EventHandler(this.Bt_negativo_Click);
            // 
            // bt_blur
            // 
            this.bt_blur.BackColor = System.Drawing.Color.White;
            this.bt_blur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_blur.BackgroundImage")));
            this.bt_blur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_blur.Location = new System.Drawing.Point(255, 59);
            this.bt_blur.Name = "bt_blur";
            this.bt_blur.Size = new System.Drawing.Size(100, 28);
            this.bt_blur.TabIndex = 33;
            this.bt_blur.Text = "Aplicar";
            this.bt_blur.UseVisualStyleBackColor = false;
            this.bt_blur.Click += new System.EventHandler(this.Bt_blur_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 46);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 34;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.updateBlur);
            // 
            // bt_sepia
            // 
            this.bt_sepia.BackColor = System.Drawing.Color.White;
            this.bt_sepia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sepia.BackgroundImage")));
            this.bt_sepia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_sepia.Location = new System.Drawing.Point(255, 58);
            this.bt_sepia.Name = "bt_sepia";
            this.bt_sepia.Size = new System.Drawing.Size(100, 28);
            this.bt_sepia.TabIndex = 36;
            this.bt_sepia.Text = "Aplicar";
            this.bt_sepia.UseVisualStyleBackColor = false;
            this.bt_sepia.Click += new System.EventHandler(this.Bt_sepia_Click);
            // 
            // bt_RGB
            // 
            this.bt_RGB.BackColor = System.Drawing.Color.White;
            this.bt_RGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_RGB.BackgroundImage")));
            this.bt_RGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_RGB.Location = new System.Drawing.Point(256, 63);
            this.bt_RGB.Name = "bt_RGB";
            this.bt_RGB.Size = new System.Drawing.Size(99, 26);
            this.bt_RGB.TabIndex = 37;
            this.bt_RGB.Text = "Aplicar";
            this.bt_RGB.UseVisualStyleBackColor = false;
            this.bt_RGB.Click += new System.EventHandler(this.Bt_RGB_Click);
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(113, 3);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(69, 17);
            this.rb_red.TabIndex = 38;
            this.rb_red.Text = "Vermelho";
            this.rb_red.UseVisualStyleBackColor = true;
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Location = new System.Drawing.Point(54, 3);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(53, 17);
            this.rb_green.TabIndex = 39;
            this.rb_green.Text = "Verde";
            this.rb_green.UseVisualStyleBackColor = true;
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Checked = true;
            this.rb_blue.Location = new System.Drawing.Point(3, 3);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(45, 17);
            this.rb_blue.TabIndex = 40;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Azul";
            this.rb_blue.UseVisualStyleBackColor = true;
            // 
            // flp_RGB
            // 
            this.flp_RGB.Controls.Add(this.rb_blue);
            this.flp_RGB.Controls.Add(this.rb_green);
            this.flp_RGB.Controls.Add(this.rb_red);
            this.flp_RGB.Location = new System.Drawing.Point(10, 61);
            this.flp_RGB.Name = "flp_RGB";
            this.flp_RGB.Size = new System.Drawing.Size(204, 28);
            this.flp_RGB.TabIndex = 41;
            // 
            // bt_Ausencia
            // 
            this.bt_Ausencia.BackColor = System.Drawing.Color.Gray;
            this.bt_Ausencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Ausencia.BackgroundImage")));
            this.bt_Ausencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Ausencia.Location = new System.Drawing.Point(255, 65);
            this.bt_Ausencia.Name = "bt_Ausencia";
            this.bt_Ausencia.Size = new System.Drawing.Size(100, 26);
            this.bt_Ausencia.TabIndex = 43;
            this.bt_Ausencia.Text = "Aplicar";
            this.bt_Ausencia.UseVisualStyleBackColor = false;
            this.bt_Ausencia.Click += new System.EventHandler(this.Bt_Ausencia_Click);
            // 
            // flp_ausencia
            // 
            this.flp_ausencia.Controls.Add(this.rb_blue_ausencia);
            this.flp_ausencia.Controls.Add(this.rb_green_ausencia);
            this.flp_ausencia.Controls.Add(this.rb_red_ausencia);
            this.flp_ausencia.Location = new System.Drawing.Point(11, 65);
            this.flp_ausencia.Name = "flp_ausencia";
            this.flp_ausencia.Size = new System.Drawing.Size(196, 26);
            this.flp_ausencia.TabIndex = 42;
            this.flp_ausencia.Paint += new System.Windows.Forms.PaintEventHandler(this.Flp_ausencia_Paint);
            // 
            // rb_blue_ausencia
            // 
            this.rb_blue_ausencia.AutoSize = true;
            this.rb_blue_ausencia.Checked = true;
            this.rb_blue_ausencia.Location = new System.Drawing.Point(3, 3);
            this.rb_blue_ausencia.Name = "rb_blue_ausencia";
            this.rb_blue_ausencia.Size = new System.Drawing.Size(45, 17);
            this.rb_blue_ausencia.TabIndex = 40;
            this.rb_blue_ausencia.TabStop = true;
            this.rb_blue_ausencia.Text = "Azul";
            this.rb_blue_ausencia.UseVisualStyleBackColor = true;
            // 
            // rb_green_ausencia
            // 
            this.rb_green_ausencia.AutoSize = true;
            this.rb_green_ausencia.Location = new System.Drawing.Point(54, 3);
            this.rb_green_ausencia.Name = "rb_green_ausencia";
            this.rb_green_ausencia.Size = new System.Drawing.Size(53, 17);
            this.rb_green_ausencia.TabIndex = 39;
            this.rb_green_ausencia.Text = "Verde";
            this.rb_green_ausencia.UseVisualStyleBackColor = true;
            this.rb_green_ausencia.CheckedChanged += new System.EventHandler(this.Rb_green_ausencia_CheckedChanged);
            // 
            // rb_red_ausencia
            // 
            this.rb_red_ausencia.AutoSize = true;
            this.rb_red_ausencia.Location = new System.Drawing.Point(113, 3);
            this.rb_red_ausencia.Name = "rb_red_ausencia";
            this.rb_red_ausencia.Size = new System.Drawing.Size(69, 17);
            this.rb_red_ausencia.TabIndex = 38;
            this.rb_red_ausencia.Text = "Vermelho";
            this.rb_red_ausencia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_limpar_original);
            this.panel1.Controls.Add(this.Seleciona);
            this.panel1.Controls.Add(this.pictureBoxOriginal);
            this.panel1.Location = new System.Drawing.Point(1, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 500);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(397, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 500);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_limpar_resultado);
            this.panel3.Controls.Add(this.Salva);
            this.panel3.Controls.Add(this.pictureBoxResultado);
            this.panel3.Location = new System.Drawing.Point(793, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 500);
            this.panel3.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.flp_ausencia);
            this.panel4.Controls.Add(this.bt_Ausencia);
            this.panel4.Location = new System.Drawing.Point(7, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 94);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.bt_RGB);
            this.panel5.Controls.Add(this.flp_RGB);
            this.panel5.Location = new System.Drawing.Point(7, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 94);
            this.panel5.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ausência de cor ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "RGB";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.trackBar1);
            this.panel6.Controls.Add(this.bt_blur);
            this.panel6.Location = new System.Drawing.Point(7, 229);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 94);
            this.panel6.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Box Blur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "%";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.EscalaCinza);
            this.panel7.Controls.Add(this.bt_negativo);
            this.panel7.Controls.Add(this.bt_sepia);
            this.panel7.Location = new System.Drawing.Point(7, 329);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(367, 94);
            this.panel7.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sépia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Negativo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Escala de Cinza";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1182, 92);
            this.panel8.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione a imagem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Escolha o filtro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(933, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "e aplique!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(764, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.ClientSize = new System.Drawing.Size(1187, 599);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 638);
            this.MinimumSize = new System.Drawing.Size(1203, 638);
            this.Name = "Form";
            this.Text = "PhotoSociesc";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flp_RGB.ResumeLayout(false);
            this.flp_RGB.PerformLayout();
            this.flp_ausencia.ResumeLayout(false);
            this.flp_ausencia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Button Seleciona;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button EscalaCinza;
        private System.Windows.Forms.Button bt_limpar_resultado;
        private System.Windows.Forms.Button bt_limpar_original;
        private System.Windows.Forms.Button bt_negativo;
        private System.Windows.Forms.Button bt_blur;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button bt_sepia;
        private System.Windows.Forms.Button bt_RGB;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.FlowLayoutPanel flp_RGB;
        private System.Windows.Forms.Button bt_Ausencia;
        private System.Windows.Forms.FlowLayoutPanel flp_ausencia;
        private System.Windows.Forms.RadioButton rb_blue_ausencia;
        private System.Windows.Forms.RadioButton rb_green_ausencia;
        private System.Windows.Forms.RadioButton rb_red_ausencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}

