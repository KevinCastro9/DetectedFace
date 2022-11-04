using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidadorDeFaces.Equipamentos;
using ValidadorDeFaces.Gerenciador;
using ValidadorDeFaces.Pessoas;

namespace ValidadorDeFaces
{
    public partial class Validador : Form
    {
        public Equipamento equipamento = new Equipamento(1, "Equipamento Teste", "Marca Teste", 150, 150, 100, 150);
        public List<Equipamento> equipamentos = new List<Equipamento>();

        public Validador()
        {
            InitializeComponent();
        }

        private void Validador_Load(object sender, EventArgs e)
        {
            try
            {
                equipamentos.Add(equipamento);

                comboBoxEquipamentos.DataSource = equipamentos;
                comboBoxEquipamentos.DisplayMember = "Nome";
                comboBoxEquipamentos.ValueMember = "Id";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogValidador.CheckFileExists = true;
            openFileDialogValidador.CheckPathExists = true;
            openFileDialogValidador.FilterIndex = 2;
            openFileDialogValidador.RestoreDirectory = true;
            openFileDialogValidador.ReadOnlyChecked = true;
            openFileDialogValidador.ShowReadOnly = true;
            //
            openFileDialogValidador.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.gif|*.gif|*.png|*.png|*.jfif|*.jfif";

            if (openFileDialogValidador.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxImagemOriginal.Image = Image.FromFile(openFileDialogValidador.FileName);

                    buttonValidarFoto.Enabled = true;
                    comboBoxEquipamentos.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    // O usuário  não possui permissão para ler arquivos
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    // Não pode carregar a imagem (problemas de permissão)
                    MessageBox.Show("Não é possível exibir a imagem : " + openFileDialogValidador.FileName
                                               + ". Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }

        private void buttonValidarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                GerenciadorDoValidadorDeFaces gerenciadorDoValidadorDeFaces = new GerenciadorDoValidadorDeFaces();
                Bitmap bmp = (Bitmap)pictureBoxImagemOriginal.Image;

                int verificaEquipamento = Convert.ToInt32(comboBoxEquipamentos.SelectedValue);

                Bitmap faceAjustada = null;

                for (int i =0; i < equipamentos.Count;i++)
                {
                    faceAjustada = gerenciadorDoValidadorDeFaces.Gerenciador(bmp, pictureBoxImagemOriginal.Image, equipamentos[0]);
                }
                
                Pessoa pessoa = new Pessoa(1, "João", faceAjustada, equipamentos);

                pictureBoxImagemValidada.Image = pessoa.Face;
            }
            catch
            {

            }
        }
    }
}
