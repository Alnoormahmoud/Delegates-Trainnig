namespace Delegates
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            HH = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // HH
            // 
            HH.Animated = true;
            HH.AnimatedGIF = true;
            HH.AutoRoundedCorners = true;
            HH.BackColor = SystemColors.ControlText;
            HH.BorderColor = Color.CadetBlue;
            HH.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            HH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            HH.CustomBorderColor = Color.Yellow;
            HH.CustomizableEdges = customizableEdges3;
            HH.DefaultAutoSize = true;
            HH.DisabledState.BorderColor = Color.DarkGray;
            HH.DisabledState.CustomBorderColor = Color.DarkGray;
            HH.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            HH.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            HH.FillColor = Color.RosyBrown;
            HH.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            HH.ForeColor = SystemColors.ButtonHighlight;
            HH.Location = new Point(551, 365);
            HH.Name = "HH";
            HH.PressedColor = Color.BlueViolet;
            HH.ShadowDecoration.CustomizableEdges = customizableEdges4;
            HH.Size = new Size(86, 42);
            HH.TabIndex = 4;
            HH.Text = "Open";
            HH.Click += guna2Button1_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AcceptsReturn = true;
            guna2TextBox1.BackColor = SystemColors.ActiveCaptionText;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.Window;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(277, 132);
            guna2TextBox1.Margin = new Padding(7, 8, 7, 8);
            guna2TextBox1.Multiline = true;
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(729, 137);
            guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 577);
            Controls.Add(guna2TextBox1);
            Controls.Add(HH);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2vScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button HH;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
