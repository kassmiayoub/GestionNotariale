using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class AJOUTER_FICHIERS : UserControl
    {
        public AJOUTER_FICHIERS()
        {
            InitializeComponent();
        }

        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {

            var A = new fichiers_client();
            A.titre = textBoxtitre.Text;
            A.descreption = textBoxdesc.Text;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string file = ofd.FileName;

                    using (FileStream fl = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fl))
                        {
                            byte[] b = br.ReadBytes((int)fl.Length);
                        }
                    }
                }
            }

        }
    }
}
