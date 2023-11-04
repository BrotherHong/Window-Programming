
using System.Diagnostics;

namespace Practice7_1
{
    partial class Form1
    {

        private void menuItem_file_new_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void menuItem_file_open_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Todo File(*.todo)|*.todo|Text File(*.txt)|*.txt|All File(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ResetAll();

                    savePath = ofd.FileName;
                    ReadVocabularies();
                    UpdateAllWords();
                }
            }
        }

        private void ReadVocabularies()
        {
            Debug.Assert(savePath != null);
            FileInfo fileInfo = new FileInfo(savePath);
            StreamReader reader = fileInfo.OpenText();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine()!;
                string[] data = line.Split(' ');
                Vocabulary voc = new Vocabulary(data[0], data[1], data[2]);
                vocabularies.Add(voc);
            }

            reader.Close();
        }

        private void menuItem_file_save_Click(object sender, EventArgs e)
        {
            ResetAndCloseFeaturePanel();
            if (savePath == null)
            {
                if (AskSavePath())
                {
                    SaveTxt();
                }
                return;
            }
            SaveTxt();
        }

        private void menuItem_file_saveAs_Click(object sender, EventArgs e)
        {
            ResetAndCloseFeaturePanel();
            if (AskSavePath())
            {
                SaveTxt();
            }
        }

        private void SaveTxt()
        {
            Debug.Assert(savePath != null);

            FileInfo fileInfo = new FileInfo(savePath);
            StreamWriter writer = fileInfo.CreateText();

            foreach (Vocabulary voc in vocabularies)
            {
                writer.WriteLine(voc.ToString());
            }

            writer.Close();
        }

        private bool AskSavePath()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File(*.txt)|*.txt|All File(*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    savePath = sfd.FileName;
                    return true;
                }
            }
            return false;
        }

        private void menuItem_file_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
