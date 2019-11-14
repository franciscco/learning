namespace link_saver
{
    partial class Form1
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
            this.url = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.Label();
            this.tags = new System.Windows.Forms.Label();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.organization_textbox = new System.Windows.Forms.TextBox();
            this.tags_textbox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(121, 59);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(20, 13);
            this.url.TabIndex = 0;
            this.url.Text = "Url";
            // 
            // organization
            // 
            this.organization.AutoSize = true;
            this.organization.Location = new System.Drawing.Point(227, 59);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(66, 13);
            this.organization.TabIndex = 1;
            this.organization.Text = "Organization";
            // 
            // tags
            // 
            this.tags.AutoSize = true;
            this.tags.Location = new System.Drawing.Point(333, 59);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(31, 13);
            this.tags.TabIndex = 2;
            this.tags.Text = "Tags";
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(124, 75);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(100, 20);
            this.url_textbox.TabIndex = 3;
            // 
            // organization_textbox
            // 
            this.organization_textbox.Location = new System.Drawing.Point(230, 75);
            this.organization_textbox.Name = "organization_textbox";
            this.organization_textbox.Size = new System.Drawing.Size(100, 20);
            this.organization_textbox.TabIndex = 4;
            // 
            // tags_textbox
            // 
            this.tags_textbox.Location = new System.Drawing.Point(336, 75);
            this.tags_textbox.Name = "tags_textbox";
            this.tags_textbox.Size = new System.Drawing.Size(100, 20);
            this.tags_textbox.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(442, 73);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tags_textbox);
            this.Controls.Add(this.organization_textbox);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.organization);
            this.Controls.Add(this.url);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Label organization;
        private System.Windows.Forms.Label tags;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.TextBox organization_textbox;
        private System.Windows.Forms.TextBox tags_textbox;
        private System.Windows.Forms.Button save;
    }
}

