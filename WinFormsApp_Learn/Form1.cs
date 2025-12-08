using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Learn
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task LoadImageSafe(string url)
        {
            try
            {
                using HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                var stream = await client.GetStreamAsync(url);
                picbox_00.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image: " + ex.Message);
            }
        }

        private async void but_Album_Click(object sender, EventArgs e)
        {
            lblHellowWorld.Text = "Hello World";

            AlbumsDAO albumsDAO = new AlbumsDAO();
            //Album a1 = new Album
            //{
            //    ID = 1,
            //    AlbumName = "My first album",
            //    ArtistName = "Thanet Yan",
            //    Year = 1975,
            //    ImageURL = "Not Yet",
            //    Description = "Nothing Special"
            //};
            //Album a2 = new Album
            //{
            //    ID = 2,
            //    AlbumName = "My second album",
            //    ArtistName = "Thanet Yan",
            //    Year = 1976,
            //    ImageURL = "Not Yet",
            //    Description = "Nothing Special"
            //};

            //albumsDAO.albums.Add(a1);
            //albumsDAO.albums.Add (a2);

            // connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            dgv_Album.DataSource = albumBindingSource;  // we can use   albumsDAO.albums;


            //picbox_00.Load("https://upload.wikimedia.org/wikipedia/en/e/ec/Revolver_%28album_cover%29.jpg");
            await LoadImageSafe("https://upload.wikimedia.org/wikipedia/en/2/2e/Please_Please_Me.png");
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            // connect the list to the grid view control
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.searchTitles
                (txt_Search.Text);

            dgv_Album.DataSource = albumBindingSource;  // we can use   albumsDAO.albums;

        }

        private async void dgv_Album_CellClick(object sender, 
            DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clicked");
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You Clicked row " + rowClicked) ;

            String imageURL = dataGridView.Rows[rowClicked]
                .Cells[4].Value.ToString();
            //MessageBox.Show("URL= " +  imageURL);

            // call function loadpicture

            await LoadImageSafe(imageURL);

        }
    }
}
