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

            //빈 문자열이나 공백만 있을 경우 전송을 차단한다.
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;
            
            //입력창(txtInput)에 타이핑한 내용을 변수에 저장
            string typed_msg = txtInput.Text;

            //리스트박스(lstChat)의 Items 주머니에 추가
            lstChat.Items.Add(typed_msg);

            //다음 입력을 위해 입력창을 비움
            txtInput.Clear();

            //다음 입력을 위해 입력창(txtInput)으로 커서를 자동 이동시킨다.
            txtInput.Focus();

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter 키를 누르면 전송 버튼 클릭 효과 발생
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}
    