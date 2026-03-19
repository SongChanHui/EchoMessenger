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
        {// 1. 빈 칸 전송 차단
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            // 2. [핵심] 기존에 리스트 마지막에 있던 "현재 대화" 줄을 찾아서 지운다.
            if (lstChat.Items.Count > 0)
            {
                string lastItem = lstChat.Items[lstChat.Items.Count - 1].ToString();
                if (lastItem.StartsWith("▶ 현재 대화:"))
                {
                    lstChat.Items.RemoveAt(lstChat.Items.Count - 1);
                }
            }

            // 3. 메시지 가공 (공백 제거 + 시간 추가)
            string typed_msg = txtInput.Text.Trim();
            string time_stamp_msg = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}";

            // 4. 새 메시지 추가
            lstChat.Items.Add(time_stamp_msg);

            // 5. [핵심] 메시지 바로 밑에 새로운 개수 표시 줄을 추가한다.
            lstChat.Items.Add($"▶ 현재 대화: {lstChat.Items.Count}개");

            // 6. 입력창 초기화 및 커서 이동
            txtInput.Clear();
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

        private void lstChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    