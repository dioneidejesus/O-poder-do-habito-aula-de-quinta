using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
            frmPrincipal frm = new frmPrincipal();
            frm.Close(); 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
            this.Close();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Faça a cama todas as manhãs";
            dc1.richTextBox1.Text = "Fazer a cama todas às manhãs ou assim que você sair do banho, trás automaticamente ao seu quarto uma aparência de limpo e organizado.";        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Tome sua medicação sempre no mesmo horário";
            dc1.richTextBox1.Text = "Tomar seus remédios para tratamento ou vitaminas sempre no mesmo horário e preferencialmente juntos (se for possível), evita que você esqueça de ingeri-los. Opte por horário em que você está em casa, como ao se levantar (você pode deixar os medicamentos na cabeceira da cama) ou ao se deitar. Ter um horário fixo reduz o stress ou a dúvida de saber se tomou ou não sua medicação.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Coloque o seu telefone para carregar todas as noites";
            dc1.richTextBox1.Text = "Colocar seu telefone celular para carregar durante a noite garante que você não fique sem bateria durante o dia. O benefício é não entrar em pânico ao perceber que a bateria está no final e você não possui uma tomada ou um carregador.";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Tome café da manhã";
            dc1.richTextBox1.Text = "Tomar café da manhã te prepara para o dia. Muitas vezes reuniões ou imprevistos podem te fazer pular o horário de almoço, portanto, tomar café da manhã pode ser a oportunidade perfeita de ingerir alimentos saudáveis e nutrir seu corpo.";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Esvazie a máquina de lavar louça todas as manhãs";
            dc1.richTextBox1.Text = "Sei que muitos não tem máquina de lavar louça e são resistentes a essa facilidade. Isso porque as máquinas de lavar louça de antigamente não eram tão práticas e eficientes. A vantagem de esvaziar a máquina todas as manhãs é começar o dia com sua cozinha em ordem e com todos os itens limpos, guardados e prontos para uso. Leia aqui sobre as facilidades da lava louças.";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Deixe a casa como você gostaria de encontrá-la";
            dc1.richTextBox1.Text = "Deixar a casa como você gostaria de encontrar quando você chega em casa: Arrumada e limpa. Isso evita stress e aborrecimentos à noite e seu lar lhe dará as boas vindas sempre.";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Acorde e levante todos os dias no mesmo horário";
            dc1.richTextBox1.Text = "Acordar todos os dias no mesmo horário, mesmo no fim de semana é ideal para equilibrar seu relógio biológico. Dormir até mais tarde no fim de semana pode fazer mais mal do que bem. Faz você se sentir fraco e de “ressaca” pelo resto do dia.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Lave a louça antes de se deitar";
            dc1.richTextBox1.Text = "Coloque a louça na máquina ou lave a louça antes de se deitar e encontre sua cozinha limpa na manhã seguinte. Leva menos tempo para limpar as panelas quando elas estão recém sujas, em vez de deixá-las com comida e esperar que a sujeira endureça durante a noite. Encontrar a cozinha limpa todas as manhãs é uma sensação maravilhosa.";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Arrume a casa todas as noites";
            dc1.richTextBox1.Text = "Arrumar sua casa todas as noites andando pelos cômodos e devolvendo objetos em cada local leva menos de 10 minutos. A melhor maneira de começar seu dia ao acordar, é ver sua casa arrumada e sem bagunça acumulada.";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Coloque a mesa do café na noite anterior";
            dc1.richTextBox1.Text = "Colocar a mesa do café da manhã na noite anterior economiza tempo todas as manhãs e evita a correria.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Separe sua roupa na noite anterior";
            dc1.richTextBox1.Text = "Separar a roupa que você usará na noite anterior poupa tempo em suas manhãs e evita atrasos. Além disso, você pode precisar de alguma peça que ainda está na lavanderia. Na dúvida sobre o que vestir? Consulte a previsão do tempo e procure alguma inspiração no Pinterest. Faça um painel com roupas parecidas com as que você tem e monte looks que te agradam.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Tentar ir para a cama no mesmo horário";
            dc1.richTextBox1.Text = "Ir para a cama ao mesmo horário todas as noites, ajuda a regular o sono e você se sentirá muito melhor a cada dia.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Analise o seu dia antes de dormir";
            dc1.richTextBox1.Text = "Analisar como foi seu dia, ajuda a manter a sua mente focada em seu objetivo e ajuda, a saber, o que você precisará trabalhar no próximo dia. Aproveite e faça uma oração de agradecimento.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Lide com a papelada de entrada apenas uma vez";
            dc1.richTextBox1.Text = "Não deixe para lidar com a pilha de papéis e correspondência mais tarde. Crie um sistema de contas para pagar e papéis para arquivar. Isso irá garantir que nada se extravie e que você não perca o prazo para pagamento. Também economiza tempo porque você não precisa ler algo novamente.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Jogue no lixo";
            dc1.richTextBox1.Text = "Ao ler sua correspondência, descarte imediatamente o que precisa ir para o lixo. Isso simplesmente economiza tempo e energia.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Verifique todos os aniversários e eventos da semana de do mês";
            dc1.richTextBox1.Text = "Verifique a lista de aniversários do mês e compre antecipadamente todos os presentes (se você tem o costume de presentear), isso fará você economizar algum dinheiro, sem precisar ir ao shopping às pressas. Se tiver algum evento especial, dará tempo de planejar o que vestir e se precisa fazer alguma aquisição.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Sempre adicione um tempo de contingência";
            dc1.richTextBox1.Text = "Para evitar atrasos em sua agenda, sempre adicione um tempo extra para realização de tarefas, compromissos, tempo de viagem etc. É comum pegar trânsito intenso, o médico atrasar a consulta e alguma reunião se estender mais que o previsto. Adicionando tempo extra você será capaz de ver exatamente como será o seu dia e evita stress e remarcação de compromissos.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Não deixe para fazer as coisas até o último minuto";
            dc1.richTextBox1.Text = "Faça imediatamente ou assim que possível. Deixar para depois só torna as coisas mais difíceis. Fazer imediatamente fará você se sentir muito menos estressado.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Mantenha sua lista de tarefas atualizada";
            dc1.richTextBox1.Text = "Manter sua lista de tarefas atualizada (to do list) irá mantê-lo um passo à frente, e ajudará a organizar o seu dia muito melhor.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Marque o próximo compromisso enquanto ainda estiver no local";
            dc1.richTextBox1.Text = "Aproveite para marcar um compromisso, reunião ou uma consulta médica enquanto você está, por exemplo, saindo do médico e sabe que precisa retornar ou quando você em um compromisso empresarial e precisa agendar a próxima reunião. Agindo assim, você economiza tempo e não precisa adicionar essa tarefa a sua lista de tarefas “to do list”.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dicas1 dc1 = new dicas1();
            dc1.Show();
            dc1.lblTitulo.Text = "Verifique sua agenda para o dia seguinte";
            dc1.richTextBox1.Text = "Verificar sua agenda para o dia seguinte garante que você esteja preparado, seja para uma reunião, ou um exame médico, ou se precisa sair um pouco antes de casa para passar em algum local. Você estará pronto para tudo!";
        }
    }
}
