using System;
using System.Windows.Forms;

namespace OrcamentoFotografico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] info = new string[] {
                "– Sessão com aproximadamente 60 fotos.\n– 20 fotos digitais, tratadas e entregues via link.\n– 2 trocas de roupa ou 1 figurino.\n– 3 fundos (branco, preto e cinza) ou 1 cenário clássico.\n– Maquiagem.\n– Realizado todos os dias, também aos Sábados e Domingos.",
                "- Para bebês de 16 a 30 dias de vida.\n– 20 Fotos em alta resolução.\n– 1 Produção (obrigatoriamente no wrap).\n– Fotos com pais e irmãos",
                "– Sessão da Gestante com aproximadamente 70 fotos.\n– 30 fotos digitais da Gestante.\n– 2 Trocas de roupa e 1 figurino para a Gestante.\n– 3 fundos (branco, preto, cinza) e 1 cenário clássico.\n– Sessão do Recém-nascido no estúdio, 20 fotos, 1 cenários, 2 figurinos.", 
                "- Locação Externa.\n- Até 2 horas de sessão (ideal fim de tarde).\n- 50 Fotos editadas entregues por link (núvem).\n- 50 fotos reveladas 10x15cm.",
                "- Sessão de fotos em locação externa.\n- 1:30h de duração.\n- 40 fotos editadas em alta resolução.\n- Maquiagem profissional.\n- 2 trocas de roupas (looks próprios).",
                "- 2 fotógrafos profissionais.\n- Cobertura do Making Of.\n- Cobertura da Cerimônia.\n- Ensaio Fotográfico logo após cerimônia.\n- Cobertura da Recepção e Jantar.\n- Cobertura da Festa.\n- Tempo aproximado da cobertura: 10 horas.\n- Todas as fotos em alta resolução.\n- 1 Caixinha com Pendrive.\n- 1 porta - retrato de madeira 15 x 21 cm.\n- 2 porta - retratos de madeira 10 x 15 cm.\n- 2 porta - retratos magnéticos 10 x 15 cm.\n- Disponibilização das fotos para acesso online."
            };


            string[] preco = new string[] {
                "549,00",
                "900,00",
                "849,00",
                "650,00",
                "1.100,00",
                "4.800,00",
            };

            if (comboBoxOptions.Text == "Grávida")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\gravida.jpg";
                richTextBoxInfo.Text = info[0];
                textBoxValor.Text = preco[0];
            }
            else if (comboBoxOptions.Text == "New Born")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\newborn.jpg";
                richTextBoxInfo.Text = info[1];
                textBoxValor.Text = preco[1];
            }
            else if (comboBoxOptions.Text == "Duo (Grávida + New Born)")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\duo.jpg";
                richTextBoxInfo.Text = info[2];
                textBoxValor.Text = preco[2];
            }
            else if (comboBoxOptions.Text == "Casal")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\casal.jpg";
                richTextBoxInfo.Text = info[3];
                textBoxValor.Text = preco[3];
            }
            else if (comboBoxOptions.Text == "Pré-wedding")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\prewedding.jpg";
                richTextBoxInfo.Text = info[4];
                textBoxValor.Text = preco[4];
            }
            else if (comboBoxOptions.Text == "Casamento")
            {
                pictureBoxPhoto.ImageLocation = @"C:\Users\Tamires\projetos\img\casamento.jpg";
                richTextBoxInfo.Text = info[5];
                textBoxValor.Text = preco[5];
            }
        }
    }
}
