using System.Text;

namespace BarlangokGUI
{
    public partial class FrmMain : Form
    {
        const string SOLDIR = "H:\\repos\\Barlangok\\src";

        List<Barlang> barlangok = new();
        Barlang b;
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMainLoad;
            searchBtn.Click += SearchBtnClick;
            saveBtn.Click += SaveBtnClick;
        }

        private void ResetField()
        {
            idTbx.Text = "";
            nameLbl.Text = $"A barlang neve:";
            lengthTbx.Text = $"";
            depthTbx.Text = $"";
            lengthTbx.Enabled = false;
            depthTbx.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void SaveBtnClick(object? sender, EventArgs e)
        {
            int depth = int.Parse(depthTbx.Text);
            int length = int.Parse(lengthTbx.Text);
            int id = int.Parse(idTbx.Text);

            if ( depth < b.Melyseg || length < b.Hossz)
            {
                MessageBox.Show("A mélység és a hossz nem lehet kisebb, mint az eredeti érték!");
            }
            else
            {
                b.Hossz = length;
                b.Melyseg = depth;
            }
            ResetField();
        }

        private void SearchBtnClick(object? sender, EventArgs e)
        {
            string id = idTbx.Text;
            int idInt = int.Parse(id);
            b = barlangok.Find(x => x.Azon == idInt);
            
            if (b == null || id.Length == 0)
            {
                MessageBox.Show(
                    text: "Ezzel az azonosítóval nem létezik barlang!",
                    caption: "Hiba!");

                ResetField();
            }
            else
            {
                nameLbl.Text = $"A barlang neve: {b.Nev}";
                lengthTbx.Text = $"{b.Hossz}";
                depthTbx.Text = $"{b.Melyseg}";
                lengthTbx.Enabled = true;
                depthTbx.Enabled = true;
                saveBtn.Enabled = true;
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
