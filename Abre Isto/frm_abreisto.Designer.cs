namespace Abre_Isto
{
    partial class frm_abreisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abreisto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nao = new System.Windows.Forms.Button();
            this.btn_sim = new System.Windows.Forms.Button();
            this.lbl_sabia = new System.Windows.Forms.Label();
            this.lbl_frase = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pic_dog = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_nao);
            this.panel1.Controls.Add(this.btn_sim);
            this.panel1.Controls.Add(this.lbl_sabia);
            this.panel1.Controls.Add(this.lbl_frase);
            this.panel1.Controls.Add(this.pic_dog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 474);
            this.panel1.TabIndex = 1;
            // 
            // btn_nao
            // 
            this.btn_nao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nao.FlatAppearance.BorderSize = 0;
            this.btn_nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nao.ForeColor = System.Drawing.Color.White;
            this.btn_nao.Location = new System.Drawing.Point(210, 115);
            this.btn_nao.Name = "btn_nao";
            this.btn_nao.Size = new System.Drawing.Size(109, 34);
            this.btn_nao.TabIndex = 2;
            this.btn_nao.Text = "Não";
            this.btn_nao.UseVisualStyleBackColor = false;
            this.btn_nao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_nao_MouseMove);
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sim.FlatAppearance.BorderSize = 0;
            this.btn_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sim.ForeColor = System.Drawing.Color.White;
            this.btn_sim.Location = new System.Drawing.Point(58, 115);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(109, 34);
            this.btn_sim.TabIndex = 1;
            this.btn_sim.Text = "Sim";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // lbl_sabia
            // 
            this.lbl_sabia.AutoSize = true;
            this.lbl_sabia.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sabia.Location = new System.Drawing.Point(107, 58);
            this.lbl_sabia.Name = "lbl_sabia";
            this.lbl_sabia.Size = new System.Drawing.Size(154, 30);
            this.lbl_sabia.TabIndex = 5;
            this.lbl_sabia.Text = "Sempre soube";
            this.lbl_sabia.Visible = false;
            // 
            // lbl_frase
            // 
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_frase.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frase.Location = new System.Drawing.Point(127, 59);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(107, 29);
            this.lbl_frase.TabIndex = 0;
            this.lbl_frase.Text = "És burro?";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_top.Location = new System.Drawing.Point(0, -72);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(382, 100);
            this.pnl_top.TabIndex = 2;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "😏";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::Abre_Isto.Properties.Resources.minimize_sign__1___1_;
            this.btn_minimize.Location = new System.Drawing.Point(324, 72);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Abre_Isto.Properties.Resources.close__1___1___1_;
            this.btn_close.Location = new System.Drawing.Point(352, 72);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 28);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pic_dog
            // 
            this.pic_dog.BackColor = System.Drawing.Color.Transparent;
            this.pic_dog.Image = global::Abre_Isto.Properties.Resources.dog_smile;
            this.pic_dog.Location = new System.Drawing.Point(90, 91);
            this.pic_dog.Name = "pic_dog";
            this.pic_dog.Size = new System.Drawing.Size(189, 315);
            this.pic_dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dog.TabIndex = 3;
            this.pic_dog.TabStop = false;
            this.pic_dog.Visible = false;
            // 
            // frm_abreisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 502);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_abreisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abre Isto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nao;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Label lbl_sabia;
        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.PictureBox pic_dog;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
    }
}

