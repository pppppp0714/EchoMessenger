namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        private bool hasShownLengthWarning = false;

        public Form1()
        {
            InitializeComponent();
            // Enter 키로 전송하도록 KeyDown 이벤트 연결
            txtInput.KeyDown += txtInput_KeyDown;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("[HH:mm:ss] "); // 현재 시간 문자열로 저장
            // 공백 또는 플레이스홀더만 있는 경우 전송하지 않음
            string typed_msg = txtInput.Text?.Trim() ?? string.Empty; // 입력한 메시지 typed_msg에 저장
            if (string.IsNullOrWhiteSpace(typed_msg) || typed_msg == "여기에 입력하세요.")
            {
                // 입력 필드가 비어있으면 포커스만 되돌리고 아무 작업도 하지 않음
                txtInput.Focus();
                return;
            }
            // 길이 제한 재확인: 최종 메시지 길이가 50자를 초과하면 전송 차단
            string result_msg = typed_msg; // typed_msg에서 양쪽 공백 제거하여 result_msg에 저장
            if (result_msg.Length > 50)
            {
                MessageBox.Show("입력 제한: 최대 50자입니다.", "입력 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }
            lstOutput.Items.Add(time + result_msg); // lstOutput에 현재 시간과 정제한 메시지 추가
            lblCount.Text = $"현재대화 : {lstOutput.Items.Count}개"; // 현재 대화 수 라벨에 입력
            txtInput.Clear(); // TextBox 초기화
            txtInput.Focus(); // TextBox에 포커스
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // 사용자가 입력하거나 붙여넣기로 최대 길이에 도달했을 때 경고를 한 번만 표시
            int len = txtInput.Text?.Length ?? 0;
            if (len >= 50)
            {
                if (!hasShownLengthWarning)
                {
                    MessageBox.Show("입력 제한: 최대 50자입니다.", "입력 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasShownLengthWarning = true;
                }
            }
            else
            {
                hasShownLengthWarning = false;
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOutput.SelectedIndex < 0)
                {
                    // 선택한 항목이 없으면 예외 발생시켜 catch로 처리
                    throw new InvalidOperationException("삭제할 항목이 선택되지 않았습니다.");
                }

                lstOutput.Items.RemoveAt(lstOutput.SelectedIndex);
                lblCount.Text = $"현재대화 : {lstOutput.Items.Count}개";
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 항목을 먼저 선택하세요.", "삭제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOutput.Items.Count == 0)
                {
                    throw new InvalidOperationException("삭제할 대화 기록이 없습니다.");
                }

                var result = MessageBox.Show("모든 대화 기록을 삭제하시겠습니까?", "기록 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lstOutput.Items.Clear();
                    lblCount.Text = $"현재대화 : {lstOutput.Items.Count}개";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 대화 기록이 없습니다.", "삭제 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInput.Focus();
            }
        }
        
    }
}
