namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 1. 입력창(txtInput)에 타이핑한 내용을 변수에 저장
            string typed_msg = txtInput.Text;

            // 2. 리스트박스(lstChat)의 Items 주머니에 추가
            lstChat.Items.Add(typed_msg);

            // 3. 다음 입력을 위해 입력창을 비움
            txtInput.Clear();
        }
    }
}
    