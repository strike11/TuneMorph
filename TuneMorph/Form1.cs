using System;
using System.IO;
using System.Windows.Forms;
using GenerativeAI.Models;
using GenerativeAI.Types;
using Microsoft.VisualBasic;

namespace TuneMorph
{
    public partial class Form1 : Form
    {
        string GEMINI_API_KEY;
        string settings_dir = @"C:\Program Files (x86)\TuneMorph";
        string movies_settings = @"C:\Program Files (x86)\TuneMorph\movies.conf";
        string songs_settings = @"C:\Program Files (x86)\TuneMorph\songs.conf";
        string api_conf = @"C:\Program Files (x86)\TuneMorph\api.conf";
        string genre, year, country, rating,
            genre_song, year_song, language_song, artist_song;
        public Form1()
        {
            InitializeComponent();
            ReadSettings();
        }

        private void savesett_btn_Click(object sender, EventArgs e)
        {
            genre = genre_input.Text;
            year = year_input.Text;
            country = country_input.Text;
            rating = minrate_input.Text;
            if (!Directory.Exists(settings_dir))
            {
                Directory.CreateDirectory(settings_dir);
                File.Create(movies_settings);
                File.WriteAllText(movies_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre, year, country, rating));
            }
            else if (Directory.Exists(settings_dir) && !File.Exists(movies_settings))
            {
                File.Create(settings_dir + @"\settings.conf");
                File.WriteAllText(movies_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre, year, country, rating));
            }
            else
            {
                File.WriteAllText(movies_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre, year, country, rating));
            }

        }

        private void GeminiAPI_Click(object sender, EventArgs e)
        {
            string API = Interaction.InputBox("Enter your Gemini API key", "GeminiAPI key");
            MessageBox.Show("Your API key is: " + API + "\nSaved!", "GEMINI API KEY SAVED!");
            File.WriteAllText(api_conf, API);
            GEMINI_API_KEY = File.ReadAllText(api_conf);
        }

        private async void RecomendFilm()
        {
            var model = new GenerativeModel(GEMINI_API_KEY);
            var chat = model.StartChat(new StartChatParams());
            try
            {
                var res = await model.GenerateContentAsync(String.Format("Recommend me 10 films based on the following criteria:" +
                "\r\n\r\n1) Genre {0}\r\n2) Year of manufacture {1}\r\n3) Country {2}\r\n4) Rating {3} and give a little description", genre, year, country_input, rating));
                output.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void RecomendSong()
        {
            var model = new GenerativeModel(GEMINI_API_KEY);
            var chat = model.StartChat(new StartChatParams());
            try
            {
                var res = await model.GenerateContentAsync(String.Format("Recommend me 10 songs based on these criteria" +
                    "\r\nSong genre: {0}\r\nYear: {1}\r\nLanguage: {2}\r\n" +
                    "Artist: {3}\r\n\r\nIf the artist is empty, then recommend songs from other artists!", genre_song, year_song, language_song, artist_song));
                output.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReadSettings()
        {
            if (!File.Exists(api_conf))
            {
                File.Create(api_conf);
            }
            else
            {
                GEMINI_API_KEY = File.ReadAllText(api_conf);
            }
            if (File.Exists(movies_settings))
            {
                try
                {
                    string[] lines = File.ReadAllLines(movies_settings);
                    if (lines.Length >= 4)
                    {
                        genre = lines[0];
                        year = lines[1];
                        country = lines[2];
                        rating = lines[3];

                        genre_input.Text = genre;
                        year_input.Text = year;
                        country_input.Text = country;
                        minrate_input.Text = rating;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the settings file! Error: " + ex.Message);
                }
            }

            if (File.Exists(songs_settings))
            {
                try
                {
                    string[] lines = File.ReadAllLines(songs_settings);
                    if (lines.Length >= 4)
                    {
                        genre_song = lines[0];
                        year_song = lines[1];
                        language_song = lines[2];
                        artist_song = lines[3];

                        genre__song.Text = genre_song;
                        year__song.Text = year_song;
                        lang__song.Text = language_song;
                        artist__song.Text = artist_song;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the settings file! Error: " + ex.ToString());
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            RecomendFilm();
        }
        private void searchsong_Click(object sender, EventArgs e)
        {
            RecomendSong();
        }
        private void movies_btn_Click(object sender, EventArgs e)
        {
            pan_movie.Visible = true;
            pan_songs.Visible = false;
        }

        private void music_btn_Click(object sender, EventArgs e)
        {
            pan_movie.Visible = false;
            pan_songs.Visible = true;
        }

        private void save_song_Click(object sender, EventArgs e)
        {
            genre_song = genre__song.Text;
            year_song = year__song.Text;
            language_song = lang__song.Text;
            artist_song = artist__song.Text;
            if (!Directory.Exists(settings_dir))
            {
                Directory.CreateDirectory(settings_dir);
                File.Create(songs_settings);
                File.WriteAllText(songs_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre_song, year_song, language_song, artist_song));
            }
            else if (Directory.Exists(settings_dir) && !File.Exists(songs_settings))
            {
                File.Create(songs_settings);
                File.WriteAllText(songs_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre_song, year_song, language_song, artist_song));
            }
            else
            {
                File.WriteAllText(songs_settings, String.Format("{0}\n{1}\n{2}\n{3}", genre_song, year_song, language_song, artist_song));
            }
        }

        private void git_btn_Click(object sender, EventArgs e)
        {
            string git_url = "https://github.com/strike11/TuneMorph";
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = git_url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
