using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace iTechGmail
{
    public partial class ITechGmail : Form
    {
        private string tokenPath = "token.json/Google.Apis.Auth.OAuth2.Responses.TokenResponse-user";
        private int page = 0;
        private int nMessagesOnPage = 20;
        private List<Google.Apis.Gmail.v1.Data.Message> listMessages;
        private int nPages;
 
        public ITechGmail()
        {
            InitializeComponent();
            SetupDataGridView();
            if (File.Exists(tokenPath))
                Authorization();
        }
        
        private void SetupDataGridView()
        {
            messagesDataGridView.ColumnCount = 4;
            messagesDataGridView.Columns[0].Name = "To";
            messagesDataGridView.Columns[1].Name = "From";
            messagesDataGridView.Columns[2].Name = "Subject";
            messagesDataGridView.Columns[3].Name = "Date";
        }

        private void FillInDataGridView()
        {
            pageNumericUpDown.Value = page + 1;
            messagesDataGridView.Rows.Clear();
            try
            {
                for (int i = page * nMessagesOnPage; i < page * nMessagesOnPage + nMessagesOnPage; i++)
                {
                    MessageInfo messageInfo = GMail.GetMessageInfo(GMail.GetMessage(listMessages[i].Id));
                    messagesDataGridView.Rows.Add(
                        messageInfo.To,
                        messageInfo.From,
                        messageInfo.Subject,
                        messageInfo.Date);
                }
            }
            catch { return; }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization();
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(tokenPath);
            Authorization();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(tokenPath);
            messagesDataGridView.Rows.Clear();
        }

        private void btPreviousPage_Click(object sender, EventArgs e)
        {
            if (page - 1 >= 0)
                page--;
            else
                return;
            FillInDataGridView();
        }

        private void btNextPage_Click(object sender, EventArgs e)
        {
            if (page + 1 <= nPages - 1)
                page++;
            else
                return;
            FillInDataGridView();
        }

        private void Authorization()
        {
            GMail.UserAuthorization();
            LoadListMessages();
            FillInDataGridView();
        }

        private void btGoToPage_Click(object sender, EventArgs e)
        {
            page = (int)pageNumericUpDown.Value - 1;
            FillInDataGridView();
        }

        private void LoadListMessages()
        {
            listMessages = GMail.ListMessages();
            page = 0;
            nPages = (listMessages.Count + nMessagesOnPage - 1) / nMessagesOnPage;
            pageNumericUpDown.Maximum = nPages;
        }
    }
}
