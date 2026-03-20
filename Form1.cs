namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Enter 키로 전송하도록 KeyDown 이벤트 연결
            txtInput.KeyDown += txtInput_KeyDown;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            // 공백 또는 플레이스홀더만 있는 경우 전송하지 않음
            string typed_msg = txtInput.Text?.Trim() ?? string.Empty; // 입력한 메시지 typed_msg에 저장
            if (string.IsNullOrWhiteSpace(typed_msg) || typed_msg == "여기에 입력하세요.")
            {
                // 입력 필드가 비어있으면 포커스만 되돌리고 아무 작업도 하지 않음
                txtInput.Focus();
                return;
            }

            lstOutput.Items.Add(typed_msg); // lstOutput에 typed_msg 추가
            txtInput.Clear(); // TextBox 초기화
            txtInput.Focus(); // TextBox에 포커스
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            txtInput.Clear(); // 여기에 입력하세요. 텍스트 제거
        }

        
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter 키를 누르면 전송 버튼 동작 수행
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                e.SuppressKeyPress = true; // 엔터 입력의 비프음 등 기본 동작 방지
                e.Handled = true;
            }
        }
        
    }
}
