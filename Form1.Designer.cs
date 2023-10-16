namespace Web_Browser_Oluşturma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngoogle = new System.Windows.Forms.Button();
            this.btnface = new System.Windows.Forms.Button();
            this.btnins = new System.Windows.Forms.Button();
            this.btnwp = new System.Windows.Forms.Button();
            this.btnyoutube = new System.Windows.Forms.Button();
            this.btntwitter = new System.Windows.Forms.Button();
            this.btnsahibinden = new System.Windows.Forms.Button();
            this.btntrans = new System.Windows.Forms.Button();
            this.btnchat = new System.Windows.Forms.Button();
            this.btnlink = new System.Windows.Forms.Button();
            this.btngithub = new System.Windows.Forms.Button();
            this.btnmail = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btngit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngoogle
            // 
            this.btngoogle.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.google;
            this.btngoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoogle.Location = new System.Drawing.Point(17, 186);
            this.btngoogle.Name = "btngoogle";
            this.btngoogle.Size = new System.Drawing.Size(239, 141);
            this.btngoogle.TabIndex = 0;
            this.btngoogle.UseVisualStyleBackColor = true;
            this.btngoogle.Click += new System.EventHandler(this.btngoogle_Click);
            // 
            // btnface
            // 
            this.btnface.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.face;
            this.btnface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnface.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnface.Location = new System.Drawing.Point(262, 333);
            this.btnface.Name = "btnface";
            this.btnface.Size = new System.Drawing.Size(239, 141);
            this.btnface.TabIndex = 1;
            this.btnface.UseVisualStyleBackColor = true;
            this.btnface.Click += new System.EventHandler(this.btnface_Click);
            // 
            // btnins
            // 
            this.btnins.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.insta;
            this.btnins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnins.Location = new System.Drawing.Point(17, 333);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(239, 141);
            this.btnins.TabIndex = 2;
            this.btnins.UseVisualStyleBackColor = true;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // btnwp
            // 
            this.btnwp.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.watsap;
            this.btnwp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnwp.Location = new System.Drawing.Point(507, 333);
            this.btnwp.Name = "btnwp";
            this.btnwp.Size = new System.Drawing.Size(239, 141);
            this.btnwp.TabIndex = 3;
            this.btnwp.UseVisualStyleBackColor = true;
            this.btnwp.Click += new System.EventHandler(this.btnwp_Click);
            // 
            // btnyoutube
            // 
            this.btnyoutube.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.youtube;
            this.btnyoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyoutube.Location = new System.Drawing.Point(17, 480);
            this.btnyoutube.Name = "btnyoutube";
            this.btnyoutube.Size = new System.Drawing.Size(239, 141);
            this.btnyoutube.TabIndex = 4;
            this.btnyoutube.UseVisualStyleBackColor = true;
            this.btnyoutube.Click += new System.EventHandler(this.btnyoutube_Click);
            // 
            // btntwitter
            // 
            this.btntwitter.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.twitter;
            this.btntwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntwitter.Location = new System.Drawing.Point(507, 480);
            this.btntwitter.Name = "btntwitter";
            this.btntwitter.Size = new System.Drawing.Size(239, 141);
            this.btntwitter.TabIndex = 5;
            this.btntwitter.UseVisualStyleBackColor = true;
            this.btntwitter.Click += new System.EventHandler(this.btntwitter_Click);
            // 
            // btnsahibinden
            // 
            this.btnsahibinden.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.sahibinden;
            this.btnsahibinden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsahibinden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsahibinden.Location = new System.Drawing.Point(262, 480);
            this.btnsahibinden.Name = "btnsahibinden";
            this.btnsahibinden.Size = new System.Drawing.Size(239, 141);
            this.btnsahibinden.TabIndex = 6;
            this.btnsahibinden.UseVisualStyleBackColor = true;
            this.btnsahibinden.Click += new System.EventHandler(this.btnsahibinden_Click);
            // 
            // btntrans
            // 
            this.btntrans.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.translate;
            this.btntrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntrans.Location = new System.Drawing.Point(507, 186);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(239, 141);
            this.btntrans.TabIndex = 11;
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // btnchat
            // 
            this.btnchat.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.chat_gbt;
            this.btnchat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnchat.Location = new System.Drawing.Point(17, 627);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(239, 141);
            this.btnchat.TabIndex = 10;
            this.btnchat.UseVisualStyleBackColor = true;
            this.btnchat.Click += new System.EventHandler(this.btnchat_Click);
            // 
            // btnlink
            // 
            this.btnlink.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.linkedin;
            this.btnlink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlink.Location = new System.Drawing.Point(262, 627);
            this.btnlink.Name = "btnlink";
            this.btnlink.Size = new System.Drawing.Size(239, 141);
            this.btnlink.TabIndex = 9;
            this.btnlink.UseVisualStyleBackColor = true;
            this.btnlink.Click += new System.EventHandler(this.btnlink_Click);
            // 
            // btngithub
            // 
            this.btngithub.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.github;
            this.btngithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngithub.Location = new System.Drawing.Point(507, 627);
            this.btngithub.Name = "btngithub";
            this.btngithub.Size = new System.Drawing.Size(239, 141);
            this.btngithub.TabIndex = 8;
            this.btngithub.UseVisualStyleBackColor = true;
            this.btngithub.Click += new System.EventHandler(this.btngithub_Click);
            // 
            // btnmail
            // 
            this.btnmail.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.gmail;
            this.btnmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmail.Location = new System.Drawing.Point(262, 186);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(239, 141);
            this.btnmail.TabIndex = 7;
            this.btnmail.UseVisualStyleBackColor = true;
            this.btnmail.Click += new System.EventHandler(this.btnmail_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(819, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1212, 920);
            this.webBrowser1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Url Adresi:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(168, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 30);
            this.textBox1.TabIndex = 14;
            // 
            // btngit
            // 
            this.btngit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngit.Location = new System.Drawing.Point(666, 58);
            this.btngit.Name = "btngit";
            this.btngit.Size = new System.Drawing.Size(114, 30);
            this.btngit.TabIndex = 15;
            this.btngit.Text = "Git";
            this.btngit.UseVisualStyleBackColor = true;
            this.btngit.Click += new System.EventHandler(this.btngit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(666, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.sagok;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(17, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Web_Browser_Oluşturma.Properties.Resources.solok;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(17, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 30);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.btnlink);
            this.Controls.Add(this.btngithub);
            this.Controls.Add(this.btnmail);
            this.Controls.Add(this.btnsahibinden);
            this.Controls.Add(this.btntwitter);
            this.Controls.Add(this.btnyoutube);
            this.Controls.Add(this.btnwp);
            this.Controls.Add(this.btnins);
            this.Controls.Add(this.btnface);
            this.Controls.Add(this.btngoogle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoogle;
        private System.Windows.Forms.Button btnface;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Button btnwp;
        private System.Windows.Forms.Button btnyoutube;
        private System.Windows.Forms.Button btntwitter;
        private System.Windows.Forms.Button btnsahibinden;
        private System.Windows.Forms.Button btntrans;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.Button btnlink;
        private System.Windows.Forms.Button btngithub;
        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btngit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

