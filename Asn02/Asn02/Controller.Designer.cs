namespace Asn02
{
    partial class Controller
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
            this.btn_Toggle = new System.Windows.Forms.Button();
            this.num_S = new System.Windows.Forms.NumericUpDown();
            this.num_G = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_G)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Toggle
            // 
            this.btn_Toggle.Location = new System.Drawing.Point(33, 12);
            this.btn_Toggle.Name = "btn_Toggle";
            this.btn_Toggle.Size = new System.Drawing.Size(135, 23);
            this.btn_Toggle.TabIndex = 0;
            this.btn_Toggle.Text = "Toggle Background";
            this.btn_Toggle.UseVisualStyleBackColor = true;
            this.btn_Toggle.Click += new System.EventHandler(this.btn_ToggleClick);
            // 
            // num_S
            // 
            this.num_S.Location = new System.Drawing.Point(48, 41);
            this.num_S.Name = "num_S";
            this.num_S.Size = new System.Drawing.Size(120, 20);
            this.num_S.TabIndex = 1;
            this.num_S.ValueChanged += new System.EventHandler(this.numSChanged);
            // 
            // num_G
            // 
            this.num_G.Location = new System.Drawing.Point(48, 67);
            this.num_G.Name = "num_G";
            this.num_G.Size = new System.Drawing.Size(120, 20);
            this.num_G.TabIndex = 2;
            this.num_G.ValueChanged += new System.EventHandler(this.numGChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "g";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 103);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_G);
            this.Controls.Add(this.num_S);
            this.Controls.Add(this.btn_Toggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Controller";
            this.Text = "Controller";
            ((System.ComponentModel.ISupportInitialize)(this.num_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_G)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Toggle;
        private System.Windows.Forms.NumericUpDown num_S;
        private System.Windows.Forms.NumericUpDown num_G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}