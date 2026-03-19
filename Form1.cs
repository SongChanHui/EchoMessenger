namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [디자인 창에서 전송 버튼의 Click 이벤트 이름을 btnSend_Click으로 꼭 맞춰주세요]
        private void btnSend_Click(object sender, EventArgs e)
        {
            // 글자 수 50자 제한 확인
            if (txtInput.Text.Length > 50)
            {
                MessageBox.Show("50자 이내로 입력해주세요.");
                return;
            }

            // 1. 빈 칸 전송 차단
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            // 2. 기존에 리스트 마지막에 있던 "현재 대화" 줄을 찾아서 지운다.
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

            // 5. 메시지 바로 밑에 새로운 개수 표시 줄을 추가한다.
            lstChat.Items.Add($"▶ 현재 대화: {lstChat.Items.Count}개");

            // 6. 입력창 초기화 및 커서 이동
            txtInput.Clear();
            txtInput.Focus();
        }

        // [선택 삭제 버튼 클릭 시]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstChat.SelectedIndex == -1) // 선택 안 했을 때
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해주세요.");
                return;
            }

            // 선택한 항목 삭제
            lstChat.Items.RemoveAt(lstChat.SelectedIndex);

            // 마지막 줄 개수 표시 갱신
            RefreshChatCount();
        }

        // [전체 기록 삭제 버튼 클릭 시]
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
            this.Text = "Echo Messenger";
            MessageBox.Show("모든 기록이 삭제되었습니다.");
        }

        private void RefreshChatCount()
        {
            if (lstChat.Items.Count > 0 && lstChat.Items[lstChat.Items.Count - 1].ToString().Contains("현재 대화:"))
            {
                lstChat.Items.RemoveAt(lstChat.Items.Count - 1);
            }
            if (lstChat.Items.Count > 0)
            {
                lstChat.Items.Add($"▶ 현재 대화: {lstChat.Items.Count}개");
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        // 아래는 필요 없는 자동 생성 함수들입니다.
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void lstChat_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}