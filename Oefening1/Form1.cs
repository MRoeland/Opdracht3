namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stapel<int> intStapel = new Stapel<int>();
        Stapel<String> stringStapel = new Stapel<string>();
        Stapel<BasicClass> classStapel = new Stapel<BasicClass>();

        private void btnAddInt_Click(object sender, EventArgs e)
        {
            intStapel.Toevoegen(int.Parse(tbInputInt.Text));
        }

        private void btnRemoveInt_Click_1(object sender, EventArgs e)
        {
            int removedInt = intStapel.Verwijderen();
            tbOutputInt.Text = "Verwijderde int: " + removedInt.ToString();
        }

        private void btnClearInt_Click(object sender, EventArgs e)
        {
            intStapel.LeegMaken();
            tbOutputInt.Text = "De int stapel is nu leeg";
        }

        private void btnCountInt_Click(object sender, EventArgs e)
        {
            tbOutputInt.Text = intStapel.ToString();
        }

        private void btnIsPresentInt_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbInputInt.Text);
            bool aanwezig = intStapel.IsAanwezig(i);
            tbOutputInt.Text = aanwezig.ToString();
        }

        private void btnCopyInt_Click(object sender, EventArgs e)
        {
            Stapel<int> nieuweIntStapel = new Stapel<int>();
            nieuweIntStapel = intStapel.Copy();
        }

        private void btnAddString_Click(object sender, EventArgs e)
        {
            stringStapel.Toevoegen(tbInputString.Text);
        }

        private void btnRemoveString_Click(object sender, EventArgs e)
        {
            String removedString = stringStapel.Verwijderen();
            tbOutputString.Text = removedString;
        }

        private void btnClearString_Click(object sender, EventArgs e)
        {
            stringStapel.LeegMaken();
            tbOutputString.Text = "De string stapel is nu leeg";
        }

        private void btnCountString_Click(object sender, EventArgs e)
        {
            tbOutputString.Text = stringStapel.ToString();
        }

        private void btnIsPresentString_Click(object sender, EventArgs e)
        {
            String s = tbInputString.Text;
            bool aanwezig = stringStapel.IsAanwezig(s);
            tbOutputString.Text = aanwezig.ToString();
        }

        private void btnCopyString_Click(object sender, EventArgs e)
        {
            Stapel<String> nieuweStringStapel = new Stapel<string>();
            nieuweStringStapel = stringStapel.Copy();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            classStapel.Toevoegen(new BasicClass(tbInputClass.Text));
        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            BasicClass removedClass = classStapel.Verwijderen();
            tbOutputClass.Text = removedClass.ToString();
        }

        private void btnClearClass_Click(object sender, EventArgs e)
        {
            classStapel.LeegMaken();
            tbOutputClass.Text = "De basic class stapel is nu leeg";
        }

        private void btnCountClass_Click(object sender, EventArgs e)
        {
            tbOutputClass.Text = classStapel.ToString();
        }

        private void btnIsPresentClass_Click(object sender, EventArgs e)
        {
            BasicClass b = new BasicClass(tbInputClass.Text);
            bool aanwezig = classStapel.IsAanwezig(b);
            tbOutputClass.Text = aanwezig.ToString();
        }

        private void btnCopyClass_Click(object sender, EventArgs e)
        {
            Stapel<BasicClass> nieuweBasicClassStapel = new Stapel<BasicClass>();
            nieuweBasicClassStapel = classStapel.Copy();
        }
    }
}