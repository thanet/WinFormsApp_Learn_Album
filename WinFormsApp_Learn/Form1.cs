using Microsoft.VisualBasic;

namespace WinFormsApp_Learn
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void but_Album_Click(object sender, EventArgs e)
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

        }
    }
}
