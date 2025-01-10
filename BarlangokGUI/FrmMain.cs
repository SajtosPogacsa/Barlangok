using System.Text;

namespace BarlangokGUI
{
    public partial class FrmMain : Form
    {
        const string SOLDIR = "H:\\repos\\Barlangok\\src";

        List<Barlang> barlangok = new();

        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMainLoad;
            searchBtn.Click += SearchBtnClick;
        }

        private void SearchBtnClick(object? sender, EventArgs e)
        {
            string id = idTbx.Text;
            Barlang b = barlangok.Find(x => x.Azon == int.TryParse(id, out idInt));
            
            if (b == null || id.Length == 0)
            {
                MessageBox.Show(
                    text: "Ezzel az azonosítóval nem létezik barlang!",
                    caption: "Hiba!");

                idTbx.Text = "";
            }

        }

        private void FrmMainLoad(object? sender, EventArgs e)
        {

            using (StreamReader sr = new($"{SOLDIR}\\barlangok.txt", Encoding.UTF8))
            {
                _ = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Barlang b = new(sr.ReadLine());
                    barlangok.Add(b);
                }
            }
        }
    }
}
