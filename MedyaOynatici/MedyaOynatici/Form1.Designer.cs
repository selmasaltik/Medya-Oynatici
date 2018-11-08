namespace MedyaOynatici
{
    partial class frmMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.Location = new System.Drawing.Point(313, 232);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 46);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Location = new System.Drawing.Point(57, 232);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 46);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVideo.Location = new System.Drawing.Point(185, 205);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(120, 46);
            this.btnVideo.TabIndex = 9;
            this.btnVideo.Text = "VİDEO";
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResim.ImageKey = "(none)";
            this.btnResim.Location = new System.Drawing.Point(185, 37);
            this.btnResim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(120, 46);
            this.btnResim.TabIndex = 8;
            this.btnResim.Text = "RESİM";
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKapat.Location = new System.Drawing.Point(313, 12);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 46);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoster.Location = new System.Drawing.Point(57, 12);
            this.btnGoster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(120, 46);
            this.btnGoster.TabIndex = 13;
            this.btnGoster.Text = "GOSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 299);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnResim);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMediaPlayer";
            this.Text = "MediaPlayer";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGoster;


    }
}

