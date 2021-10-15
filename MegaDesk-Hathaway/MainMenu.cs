using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hathaway
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Closes the MainMenu with the exit btn
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Add Quote event, opens form
        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();
            this.Hide();
        }

        // Add View event, opens form
        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuoteForm = new ViewAllQuotes(this);
            viewQuoteForm.Show();
            this.Hide();
        }

        
        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotesFrom = new SearchQuotes(this);
            searchQuotesFrom.Show();
            this.Hide();
        }
    }
}
