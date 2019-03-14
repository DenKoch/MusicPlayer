namespace MusicPlayerWithDB {
    partial class NewPlaylistDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Confirm_bt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirm_bt
            // 
            this.Confirm_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm_bt.Location = new System.Drawing.Point(115, 121);
            this.Confirm_bt.Name = "Confirm_bt";
            this.Confirm_bt.Size = new System.Drawing.Size(75, 42);
            this.Confirm_bt.TabIndex = 0;
            this.Confirm_bt.Text = "Confirm";
            this.Confirm_bt.UseVisualStyleBackColor = true;
            this.Confirm_bt.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(50, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_bt.Location = new System.Drawing.Point(233, 121);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(75, 42);
            this.Cancel_bt.TabIndex = 2;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = true;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new playlist title:";
            // 
            // NewPlaylistDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(421, 191);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Confirm_bt);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NewPlaylistDialog";
            this.Text = "New Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm_bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel_bt;
        private System.Windows.Forms.Label label1;
    }
}