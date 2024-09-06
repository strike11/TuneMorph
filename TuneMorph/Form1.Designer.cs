using System.Windows.Forms;

namespace TuneMorph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            API_btn = new Button();
            pictureBox1 = new PictureBox();
            movies_btn = new Button();
            music_btn = new Button();
            git_btn = new Button();
            logo = new Label();
            pan_movie = new Panel();
            search_btn = new Button();
            savesett_btn = new Button();
            label4 = new Label();
            minrate_input = new TextBox();
            label3 = new Label();
            country_input = new TextBox();
            label2 = new Label();
            year_input = new TextBox();
            label1 = new Label();
            genre_input = new TextBox();
            h1_movies = new Label();
            pan_songs = new Panel();
            search_song = new Button();
            save_song = new Button();
            label5 = new Label();
            artist__song = new TextBox();
            label6 = new Label();
            lang__song = new TextBox();
            label7 = new Label();
            year__song = new TextBox();
            label8 = new Label();
            genre__song = new TextBox();
            label9 = new Label();
            panel4 = new Panel();
            output = new RichTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pan_movie.SuspendLayout();
            pan_songs.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(22, 19, 29);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1274, 29);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(32, 28, 35);
            panel2.Controls.Add(API_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(movies_btn);
            panel2.Controls.Add(music_btn);
            panel2.Controls.Add(git_btn);
            panel2.Controls.Add(logo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1274, 56);
            panel2.TabIndex = 1;
            // 
            // API_btn
            // 
            API_btn.BackColor = System.Drawing.Color.Transparent;
            API_btn.Dock = DockStyle.Right;
            API_btn.FlatAppearance.BorderSize = 0;
            API_btn.FlatStyle = FlatStyle.Flat;
            API_btn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            API_btn.ForeColor = System.Drawing.Color.White;
            API_btn.Location = new System.Drawing.Point(550, 0);
            API_btn.Name = "API_btn";
            API_btn.Size = new System.Drawing.Size(181, 56);
            API_btn.TabIndex = 6;
            API_btn.Text = "GEMINI API";
            API_btn.UseVisualStyleBackColor = false;
            API_btn.Click += GeminiAPI_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(78, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // movies_btn
            // 
            movies_btn.BackColor = System.Drawing.Color.Transparent;
            movies_btn.Dock = DockStyle.Right;
            movies_btn.FlatAppearance.BorderSize = 0;
            movies_btn.FlatStyle = FlatStyle.Flat;
            movies_btn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            movies_btn.ForeColor = System.Drawing.Color.White;
            movies_btn.Location = new System.Drawing.Point(731, 0);
            movies_btn.Name = "movies_btn";
            movies_btn.Size = new System.Drawing.Size(181, 56);
            movies_btn.TabIndex = 4;
            movies_btn.Text = "Movies";
            movies_btn.UseVisualStyleBackColor = false;
            movies_btn.Click += movies_btn_Click;
            // 
            // music_btn
            // 
            music_btn.BackColor = System.Drawing.Color.Transparent;
            music_btn.Dock = DockStyle.Right;
            music_btn.FlatAppearance.BorderSize = 0;
            music_btn.FlatStyle = FlatStyle.Flat;
            music_btn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            music_btn.ForeColor = System.Drawing.Color.White;
            music_btn.Location = new System.Drawing.Point(912, 0);
            music_btn.Name = "music_btn";
            music_btn.Size = new System.Drawing.Size(181, 56);
            music_btn.TabIndex = 3;
            music_btn.Text = "Songs";
            music_btn.UseVisualStyleBackColor = false;
            music_btn.Click += music_btn_Click;
            // 
            // git_btn
            // 
            git_btn.BackColor = System.Drawing.Color.Transparent;
            git_btn.Dock = DockStyle.Right;
            git_btn.FlatAppearance.BorderSize = 0;
            git_btn.FlatStyle = FlatStyle.Flat;
            git_btn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            git_btn.ForeColor = System.Drawing.Color.White;
            git_btn.Location = new System.Drawing.Point(1093, 0);
            git_btn.Name = "git_btn";
            git_btn.Size = new System.Drawing.Size(181, 56);
            git_btn.TabIndex = 1;
            git_btn.Text = "GITHUB";
            git_btn.UseVisualStyleBackColor = false;
            git_btn.Click += git_btn_Click;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Left;
            logo.AutoSize = true;
            logo.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logo.ForeColor = System.Drawing.Color.White;
            logo.Location = new System.Drawing.Point(96, 3);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(213, 44);
            logo.TabIndex = 0;
            logo.Text = "TuneMorph";
            // 
            // pan_movie
            // 
            pan_movie.BackColor = System.Drawing.Color.FromArgb(32, 28, 35);
            pan_movie.Controls.Add(search_btn);
            pan_movie.Controls.Add(savesett_btn);
            pan_movie.Controls.Add(label4);
            pan_movie.Controls.Add(minrate_input);
            pan_movie.Controls.Add(label3);
            pan_movie.Controls.Add(country_input);
            pan_movie.Controls.Add(label2);
            pan_movie.Controls.Add(year_input);
            pan_movie.Controls.Add(label1);
            pan_movie.Controls.Add(genre_input);
            pan_movie.Controls.Add(h1_movies);
            pan_movie.Location = new System.Drawing.Point(12, 90);
            pan_movie.Name = "pan_movie";
            pan_movie.Size = new System.Drawing.Size(200, 565);
            pan_movie.TabIndex = 2;
            // 
            // search_btn
            // 
            search_btn.BackColor = System.Drawing.Color.FromArgb(63, 49, 77);
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search_btn.ForeColor = System.Drawing.Color.White;
            search_btn.Location = new System.Drawing.Point(24, 457);
            search_btn.Name = "search_btn";
            search_btn.Size = new System.Drawing.Size(154, 46);
            search_btn.TabIndex = 1;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // savesett_btn
            // 
            savesett_btn.BackColor = System.Drawing.Color.FromArgb(63, 49, 77);
            savesett_btn.FlatAppearance.BorderSize = 0;
            savesett_btn.FlatStyle = FlatStyle.Flat;
            savesett_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            savesett_btn.ForeColor = System.Drawing.Color.White;
            savesett_btn.Location = new System.Drawing.Point(30, 524);
            savesett_btn.Name = "savesett_btn";
            savesett_btn.Size = new System.Drawing.Size(140, 31);
            savesett_btn.TabIndex = 9;
            savesett_btn.Text = "Save";
            savesett_btn.UseVisualStyleBackColor = false;
            savesett_btn.Click += savesett_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(30, 333);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(148, 52);
            label4.TabIndex = 8;
            label4.Text = "Minimum film\nrating";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minrate_input
            // 
            minrate_input.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            minrate_input.BorderStyle = BorderStyle.None;
            minrate_input.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            minrate_input.ForeColor = System.Drawing.Color.White;
            minrate_input.Location = new System.Drawing.Point(15, 397);
            minrate_input.Name = "minrate_input";
            minrate_input.Size = new System.Drawing.Size(171, 22);
            minrate_input.TabIndex = 7;
            minrate_input.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(35, 256);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 26);
            label3.TabIndex = 6;
            label3.Text = "Film Country";
            // 
            // country_input
            // 
            country_input.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            country_input.BorderStyle = BorderStyle.None;
            country_input.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            country_input.ForeColor = System.Drawing.Color.White;
            country_input.Location = new System.Drawing.Point(15, 285);
            country_input.Name = "country_input";
            country_input.Size = new System.Drawing.Size(171, 22);
            country_input.TabIndex = 5;
            country_input.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(26, 179);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 26);
            label2.TabIndex = 4;
            label2.Text = "Year of the film";
            // 
            // year_input
            // 
            year_input.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            year_input.BorderStyle = BorderStyle.None;
            year_input.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            year_input.ForeColor = System.Drawing.Color.White;
            year_input.Location = new System.Drawing.Point(15, 208);
            year_input.Name = "year_input";
            year_input.Size = new System.Drawing.Size(171, 22);
            year_input.TabIndex = 3;
            year_input.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(64, 105);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 26);
            label1.TabIndex = 2;
            label1.Text = "Genre";
            // 
            // genre_input
            // 
            genre_input.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            genre_input.BorderStyle = BorderStyle.None;
            genre_input.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            genre_input.ForeColor = System.Drawing.Color.White;
            genre_input.Location = new System.Drawing.Point(15, 134);
            genre_input.Name = "genre_input";
            genre_input.Size = new System.Drawing.Size(171, 22);
            genre_input.TabIndex = 1;
            genre_input.TextAlign = HorizontalAlignment.Center;
            // 
            // h1_movies
            // 
            h1_movies.Anchor = AnchorStyles.Top;
            h1_movies.AutoSize = true;
            h1_movies.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            h1_movies.ForeColor = System.Drawing.Color.White;
            h1_movies.Location = new System.Drawing.Point(3, 10);
            h1_movies.Name = "h1_movies";
            h1_movies.Size = new System.Drawing.Size(196, 81);
            h1_movies.TabIndex = 0;
            h1_movies.Text = "Recommendation\nsettings\n(movies)";
            h1_movies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pan_songs
            // 
            pan_songs.BackColor = System.Drawing.Color.FromArgb(32, 28, 35);
            pan_songs.Controls.Add(search_song);
            pan_songs.Controls.Add(save_song);
            pan_songs.Controls.Add(label5);
            pan_songs.Controls.Add(artist__song);
            pan_songs.Controls.Add(label6);
            pan_songs.Controls.Add(lang__song);
            pan_songs.Controls.Add(label7);
            pan_songs.Controls.Add(year__song);
            pan_songs.Controls.Add(label8);
            pan_songs.Controls.Add(genre__song);
            pan_songs.Controls.Add(label9);
            pan_songs.Location = new System.Drawing.Point(12, 90);
            pan_songs.Name = "pan_songs";
            pan_songs.Size = new System.Drawing.Size(200, 565);
            pan_songs.TabIndex = 10;
            pan_songs.Visible = false;
            // 
            // search_song
            // 
            search_song.BackColor = System.Drawing.Color.FromArgb(63, 49, 77);
            search_song.FlatAppearance.BorderSize = 0;
            search_song.FlatStyle = FlatStyle.Flat;
            search_song.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search_song.ForeColor = System.Drawing.Color.White;
            search_song.Location = new System.Drawing.Point(24, 457);
            search_song.Name = "search_song";
            search_song.Size = new System.Drawing.Size(154, 46);
            search_song.TabIndex = 1;
            search_song.Text = "Search";
            search_song.UseVisualStyleBackColor = false;
            search_song.Click += searchsong_Click;
            // 
            // save_song
            // 
            save_song.BackColor = System.Drawing.Color.FromArgb(63, 49, 77);
            save_song.FlatAppearance.BorderSize = 0;
            save_song.FlatStyle = FlatStyle.Flat;
            save_song.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            save_song.ForeColor = System.Drawing.Color.White;
            save_song.Location = new System.Drawing.Point(30, 524);
            save_song.Name = "save_song";
            save_song.Size = new System.Drawing.Size(140, 31);
            save_song.TabIndex = 9;
            save_song.Text = "Save";
            save_song.UseVisualStyleBackColor = false;
            save_song.Click += save_song_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(21, 333);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 26);
            label5.TabIndex = 8;
            label5.Text = "Artist (optional)";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artist__song
            // 
            artist__song.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            artist__song.BorderStyle = BorderStyle.None;
            artist__song.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            artist__song.ForeColor = System.Drawing.Color.White;
            artist__song.Location = new System.Drawing.Point(15, 371);
            artist__song.Name = "artist__song";
            artist__song.Size = new System.Drawing.Size(171, 22);
            artist__song.TabIndex = 7;
            artist__song.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(47, 256);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 26);
            label6.TabIndex = 6;
            label6.Text = "Language";
            // 
            // lang__song
            // 
            lang__song.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            lang__song.BorderStyle = BorderStyle.None;
            lang__song.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lang__song.ForeColor = System.Drawing.Color.White;
            lang__song.Location = new System.Drawing.Point(15, 285);
            lang__song.Name = "lang__song";
            lang__song.Size = new System.Drawing.Size(171, 22);
            lang__song.TabIndex = 5;
            lang__song.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(21, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(165, 26);
            label7.TabIndex = 4;
            label7.Text = "Year of the song";
            // 
            // year__song
            // 
            year__song.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            year__song.BorderStyle = BorderStyle.None;
            year__song.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            year__song.ForeColor = System.Drawing.Color.White;
            year__song.Location = new System.Drawing.Point(15, 208);
            year__song.Name = "year__song";
            year__song.Size = new System.Drawing.Size(171, 22);
            year__song.TabIndex = 3;
            year__song.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(64, 105);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 26);
            label8.TabIndex = 2;
            label8.Text = "Genre";
            // 
            // genre__song
            // 
            genre__song.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            genre__song.BorderStyle = BorderStyle.None;
            genre__song.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            genre__song.ForeColor = System.Drawing.Color.White;
            genre__song.Location = new System.Drawing.Point(15, 134);
            genre__song.Name = "genre__song";
            genre__song.Size = new System.Drawing.Size(171, 22);
            genre__song.TabIndex = 1;
            genre__song.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(4, 10);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(196, 81);
            label9.TabIndex = 0;
            label9.Text = "Recommendation\r\nsettings\r\n(songs)";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(32, 28, 35);
            panel4.Controls.Add(output);
            panel4.Location = new System.Drawing.Point(231, 90);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1031, 565);
            panel4.TabIndex = 3;
            // 
            // output
            // 
            output.BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            output.BorderStyle = BorderStyle.None;
            output.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            output.ForeColor = System.Drawing.Color.White;
            output.Location = new System.Drawing.Point(15, 10);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new System.Drawing.Size(1001, 545);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(41, 35, 46);
            ClientSize = new System.Drawing.Size(1274, 661);
            Controls.Add(pan_songs);
            Controls.Add(panel4);
            Controls.Add(pan_movie);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TuneMorph";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pan_movie.ResumeLayout(false);
            pan_movie.PerformLayout();
            pan_songs.ResumeLayout(false);
            pan_songs.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button git_btn;
        private System.Windows.Forms.Button movies_btn;
        private System.Windows.Forms.Button music_btn;
        private System.Windows.Forms.Panel pan_movie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label h1_movies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minrate_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox country_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox year_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox genre_input;
        private System.Windows.Forms.Button savesett_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button search_btn;
        private Panel pan_songs;
        private Button search_song;
        private Button save_song;
        private Label label5;
        private TextBox artist__song;
        private Label label6;
        private TextBox lang__song;
        private Label label7;
        private TextBox year__song;
        private Label label8;
        private TextBox genre__song;
        private Label label9;
        private Button API_btn;
    }
}
