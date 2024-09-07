namespace capa_presentacion
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.docentes = new FontAwesome.Sharp.IconMenuItem();
            this.admin = new FontAwesome.Sharp.IconMenuItem();
            this.reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.docentes,
            this.admin,
            this.reportes,
            this.iconMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 50;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(122, 69);
            this.menuusuario.Text = "INICIO";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // docentes
            // 
            this.docentes.AutoSize = false;
            this.docentes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.docentes.IconColor = System.Drawing.Color.Black;
            this.docentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.docentes.IconSize = 50;
            this.docentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.docentes.Name = "docentes";
            this.docentes.Size = new System.Drawing.Size(122, 69);
            this.docentes.Text = "DOCENTES";
            this.docentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.docentes.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = false;
            this.admin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.admin.IconColor = System.Drawing.Color.Black;
            this.admin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admin.IconSize = 50;
            this.admin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(122, 69);
            this.admin.Text = "ADMINISTRACION";
            this.admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.admin.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // reportes
            // 
            this.reportes.AutoSize = false;
            this.reportes.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.reportes.IconColor = System.Drawing.Color.Black;
            this.reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportes.IconSize = 50;
            this.reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(122, 69);
            this.reportes.Text = "REPORTES";
            this.reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(748, 48);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menu_titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE CONTROL DE ASISTENCIA";
            // 
            // contenedor
            // 
            this.contenedor.AutoSize = true;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(748, 214);
            this.contenedor.TabIndex = 3;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem1.Text = "JUSTIFICACIONES ";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 335);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem docentes;
        private FontAwesome.Sharp.IconMenuItem admin;
        private FontAwesome.Sharp.IconMenuItem reportes;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

