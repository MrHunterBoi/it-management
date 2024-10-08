namespace Lab
{
    partial class Form1
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
            this.width_text = new System.Windows.Forms.TextBox();
            this.height_text = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.create_rect_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rectangle = new System.Windows.Forms.Panel();
            this.color_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // width_text
            // 
            this.width_text.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_text.Location = new System.Drawing.Point(133, 48);
            this.width_text.Name = "width_text";
            this.width_text.Size = new System.Drawing.Size(100, 34);
            this.width_text.TabIndex = 0;
            this.width_text.Text = "0";
            this.width_text.TextChanged += new System.EventHandler(this.width_text_TextChanged);
            // 
            // height_text
            // 
            this.height_text.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_text.Location = new System.Drawing.Point(133, 115);
            this.height_text.Name = "height_text";
            this.height_text.Size = new System.Drawing.Size(100, 34);
            this.height_text.TabIndex = 1;
            this.height_text.Text = "0";
            this.height_text.TextChanged += new System.EventHandler(this.height_text_TextChanged);
            // 
            // create_rect_btn
            // 
            this.create_rect_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_rect_btn.Location = new System.Drawing.Point(35, 753);
            this.create_rect_btn.Name = "create_rect_btn";
            this.create_rect_btn.Size = new System.Drawing.Size(156, 64);
            this.create_rect_btn.TabIndex = 2;
            this.create_rect_btn.Text = "Create rectangle";
            this.create_rect_btn.UseVisualStyleBackColor = true;
            this.create_rect_btn.Click += new System.EventHandler(this.create_rect_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 850);
            this.panel1.TabIndex = 3;
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(434, 287);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(0, 0);
            this.rectangle.TabIndex = 0;
            // 
            // color_btn
            // 
            this.color_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_btn.Location = new System.Drawing.Point(133, 179);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(100, 41);
            this.color_btn.TabIndex = 4;
            this.color_btn.Text = "Color...";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height:";
            // 
            // color_panel
            // 
            this.color_panel.BackColor = System.Drawing.Color.DarkViolet;
            this.color_panel.ForeColor = System.Drawing.Color.Black;
            this.color_panel.Location = new System.Drawing.Point(35, 179);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(43, 40);
            this.color_panel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.color_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_rect_btn);
            this.Controls.Add(this.height_text);
            this.Controls.Add(this.width_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox width_text;
        private System.Windows.Forms.TextBox height_text;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button create_rect_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.Panel rectangle;
    }
}

