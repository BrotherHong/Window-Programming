using System.Text;

namespace Practice3_1
{
    public partial class Form1 : Form
    {
        private static string[] analysis = {
            "���B�j��",
            "�a�x�D�{�ܬG",
            "�Ʒ~���B�C���A���ɩx�i��",
            "�Ʒ~�_��j",
            "�ˤH�f���n��",
            "�Q�]�����U",
            "����@�|����" };

        private static string[] suggest = {
            "�ְ��a�ơA�]�����h�F�`�פT���v",
            "�O������A�@�s�٦��@�s���A���J�٦����J�|",
            "���ݥL�H�A���n���N�J���O�H�A���D�A�Ԥ���",
            "���I��ı�A���n�M�ۦۤv���o��A�N���N���]",
            "�p�ߤp�H�A�i�ׯB���ཪ��A����w�L�U���s",
            "���n���i�A�A�b��ı���ɭԡA����H�٦b�W�Z��",
            "���d�Ĥ@�A�w�������ˬd���԰O��ͫ�򻡡Adoctor!",
            "í�w�����A���Ѥ��}�ߨS���Y�A�ϥ����Ѥ]���|�}��",
        };

        private Random random;

        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanelEnter();
        }

        private void ShowPanelEnter()
        {
            InitializePanelEnter();
            panelResult.Visible = false;
            panelEnter.Visible = true;
        }

        private void InitializePanelEnter()
        {
            txtEnterName.Text = "";
            txtEnterGender.Text = "";
            txtEnterBirth.Text = "";
            txtEnterDate.Text = "";
            txtEnterCatDog.Text = "";
            labelHintName.Text = "";
            labelHintGender.Text = "";
            labelHintBirth.Text = "";
            labelHintDate.Text = "";
            labelHintCatDog.Text = "";
        }

        private void ShowPanelResult()
        {
            InitializePanelResult();
            panelEnter.Visible = false;
            panelResult.Visible = true;
        }

        private void InitializePanelResult()
        {
            labelResultName.Text = txtEnterName.Text;
            labelResultGender.Text = txtEnterGender.Text;
            labelResultBirth.Text = txtEnterBirth.Text;
            labelResultDate.Text = txtEnterDate.Text;
            labelResultCatDog.Text = txtEnterCatDog.Text;

            labelResultAnalysis.Text = GenerateAnalysis();
        }

        private string GenerateAnalysis()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("�B��:{0}", analysis[random.Next(analysis.Length)]));
            sb.AppendLine();
            sb.AppendLine(string.Format("��ĳ:{0}", suggest[random.Next(suggest.Length)]));

            return sb.ToString();
        }

        private void btnToResult_Click(object sender, EventArgs e)
        {
            bool pass = true;

            pass = CheckTextBoxNull(txtEnterName, labelHintName) && pass;
            pass = CheckTextBoxNull(txtEnterGender, labelHintGender) && CheckGender(txtEnterGender, labelHintGender) && pass;
            pass = CheckTextBoxNull(txtEnterBirth, labelHintBirth) && pass;
            pass = CheckTextBoxNull(txtEnterDate, labelHintDate) && pass;
            pass = CheckTextBoxNull(txtEnterCatDog, labelHintCatDog) && CheckCatDog(txtEnterCatDog, labelHintCatDog) && pass;

            if (pass)
            {
                ShowPanelResult();
            }
        }

        private bool CheckTextBoxNull(TextBox box, Label hint)
        {
            if (box.Text.Length == 0)
            {
                hint.Text = "���楼��g";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private bool CheckGender(TextBox box, Label hint)
        {
            if (box.Text != "�k" && box.Text != "�k")
            {
                hint.Text = "��J�����kor�k";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private bool CheckCatDog(TextBox box, Label hint)
        {
            if (box.Text != "��" && box.Text != "��")
            {
                hint.Text = "��J������or��";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private void btnBackEnter_Click(object sender, EventArgs e)
        {
            ShowPanelEnter();
        }
    }
}