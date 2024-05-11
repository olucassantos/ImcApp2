using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImcApp
{
    public partial class frmResultado : Form
    {
        decimal imc;

        // Método Construtor
        public frmResultado(decimal _imc)
        {
            InitializeComponent();
            // Guarda o valor recebido como paramentro na variável de classe
            imc = _imc; 
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            // Usa o valor da variável de classe dentro da legenda
            lblResultado.Text = imc.ToString();
        }
    }
}
