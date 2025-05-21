namespace WindowsForms
{
    partial class ClimaAppView
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            subMenuSalirDeLaApp = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(655, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem2 });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(137, 29);
            iconMenuItem1.Text = "Acerca de..";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(188, 34);
            iconMenuItem2.Text = "Nosotros";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { subMenuSalirDeLaApp });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(85, 29);
            iconMenuItem3.Text = "Salir";
            // 
            // subMenuSalirDeLaApp
            // 
            subMenuSalirDeLaApp.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            subMenuSalirDeLaApp.IconColor = Color.Black;
            subMenuSalirDeLaApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuSalirDeLaApp.Name = "subMenuSalirDeLaApp";
            subMenuSalirDeLaApp.Size = new Size(270, 34);
            subMenuSalirDeLaApp.Text = "Salir de la app.";
            subMenuSalirDeLaApp.Click += subMenuSalirDeLaApp_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolStripButton1, iconToolStripButton2 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(655, 45);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.IconSize = 36;
            iconToolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            iconToolStripButton1.ImageTransparentColor = Color.Magenta;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(40, 40);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconToolStripButton2
            // 
            iconToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconToolStripButton2.IconColor = Color.Black;
            iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton2.IconSize = 36;
            iconToolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            iconToolStripButton2.ImageTransparentColor = Color.Magenta;
            iconToolStripButton2.Name = "iconToolStripButton2";
            iconToolStripButton2.Size = new Size(40, 40);
            iconToolStripButton2.Text = "iconToolStripButton2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 463);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ClimaAppView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 497);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "ClimaAppView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App del clima hoy : 2do año 2025 : TDSD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem subMenuSalirDeLaApp;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private Label label1;
    }
}