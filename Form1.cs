using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Notas
{
    public partial class NotasView : Form
    {

        public NotasPresentador presentador = new NotasPresentador();

        public NotasView()
        {
            InitializeComponent();
            presentador.rellenarArray( new ToolStripMenuItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            FormClosing += new FormClosingEventHandler(onClose);
        }

        private void onClose(object? sender, FormClosingEventArgs e)
        {
            if (presentador.hayCambios() && !presentador.guardarCambios())
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Font = new Font("Consolas", 12, FontStyle.Regular);
            presentador.setTextoInicial(textBox.Text);
            guardarToolStripMenuItem.Enabled = false;
            deshacerToolStripMenuItem.Enabled = false;
            rehacerToolStripMenuItem.Enabled = false;
            toolStripStatusLabel1.Text = presentador.configurarLineaColumna(textBox);
            toolStripStatusLabel2.Text = presentador.configurarZoom(textBox.ZoomFactor);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            presentador.setTexto(textBox.Text);
            deshacerToolStripMenuItem.Enabled = true;
            rehacerToolStripMenuItem.Enabled = true;
            if (presentador.hayCambios())
            {
                guardarToolStripMenuItem.Enabled = true;
            }
            else
            {
                guardarToolStripMenuItem.Enabled = false;
            }
        }

        private void TextBox_SelectionChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = presentador.configurarLineaColumna(textBox);
        }

        private void TextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            toolStripStatusLabel2.Text = presentador.configurarZoom(textBox.ZoomFactor);
            actualizarZoomItems(presentador.comprobarZoom(textBox.ZoomFactor));
        }

        private void actualizarZoomItems(ToolStripMenuItem[] items)
        {
            toolStripMenuItem1 = items[0];
            toolStripMenuItem2 = items[1];
            toolStripMenuItem3 = items[2];
            toolStripMenuItem4 = items[3];
            toolStripMenuItem5 = items[4];
            toolStripMenuItem6 = items[5];
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (presentador.guardarCambios())
            {
                presentador.iniciarNuevoFichero();
                textBox.Text = string.Empty;
            }
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presentador.guardarCambios();
            textBox.Text = presentador.abrirFichero();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = presentador.guardar();
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = !presentador.guardarComo();
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.SelectionFont = fontDialog.Font;
                presentador.setTexto(textBox.Text);
            }
        }

        private void ColorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.SelectionColor = colorDialog.Color;
                presentador.setTexto(textBox.Text);
            }
        }

        private void ColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = colorDialog.Color;
                presentador.setTexto(textBox.Text);
            }
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
            presentador.setTexto(textBox.Text);
        }

        private void RehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
            presentador.setTexto(textBox.Text);
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
            presentador.setTexto(textBox.Text);
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
            presentador.setTexto(textBox.Text);
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
            presentador.setTexto(textBox.Text);
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText.Length > 0)
            {
                textBox.SelectedText = "";
            }
            else
            {
                int posicion = textBox.SelectionStart;
                textBox.Text = textBox.Text.Remove(posicion, 1);
                textBox.SelectionStart = posicion;
            }

        }

        private void BarraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeEstadoToolStripMenuItem.Checked)
            {
                barraDeEstadoToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
                textBox.Height += statusStrip1.Height;
            }
            else
            {
                barraDeEstadoToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                textBox.Height -= statusStrip1.Height;
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notas\nVersion 1.0\nCreado por Víctor Domínguez Gómez Limón", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("https://learn.microsoft.com/es-mx/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8"); no funciona :(

                ProcessStartInfo process = new ProcessStartInfo("https://learn.microsoft.com/es-mx/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8") { UseShellExecute = true };
                Process.Start(process);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1 = presentador.ajustarZoomCheck(0)[0];
            textBox.ZoomFactor = 0.5f;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2 = presentador.ajustarZoomCheck(1)[1];
            textBox.ZoomFactor = 0.75f;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3 = presentador.ajustarZoomCheck(2)[2];
            textBox.ZoomFactor = 1;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem4 = presentador.ajustarZoomCheck(3)[3];
            textBox.ZoomFactor = 1.25f;
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripMenuItem5 = presentador.ajustarZoomCheck(4)[4];
            textBox.ZoomFactor = 1.5f;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem6 = presentador.ajustarZoomCheck(5)[5];
            textBox.ZoomFactor = 2;
        }

        private void AjusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.WordWrap == true)
            {
                ajusteDeLíneaToolStripMenuItem.Checked = false;
                textBox.WordWrap = false;
            }
            else
            {
                ajusteDeLíneaToolStripMenuItem.Checked = true;
                textBox.WordWrap = true;
            }
        }
    }
}