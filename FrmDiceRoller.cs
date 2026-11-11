namespace GUI26111102
{
    public partial class FrmDiceRoller : Form
    {
        public FrmDiceRoller()
        {
            InitializeComponent();

            btnRoll.Click += BtnRollClick;
        }

        private void BtnRollClick(object? sender, EventArgs e)
        {
            bool succeed  = int.TryParse(txtNumberOfDice.Text, out int noDice);
            if (!succeed)
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: "Számot írjá' be more!", 
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
                txtNumberOfDice.SelectAll();
                txtNumberOfDice.Focus();
            }
            else
            {
                lblDiceRolls.Text = string.Empty;
                for (int n = 0; n < noDice; n++)
                {
                    int rndNumber = Random.Shared.Next(1, 7);
                    lblDiceRolls.Text += $"{rndNumber} ";
                }
            }


        }
    }
}
