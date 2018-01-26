using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public static class Mensagens
    {
        public static void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MensagemAtenção(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void MensagemInformacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MensagemQuestao(string mensagem)
        {
            MessageBox.Show(mensagem, "Responda", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
