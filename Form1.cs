using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Notas
{
    public partial class NotasView : Form
    {
        private string textoInicial = string.Empty;
        private string texto = string.Empty;
        private string archivoActual = string.Empty;
        ToolStripMenuItem[] zoomItems = new ToolStripMenuItem[6];

        public NotasView()
        {
            InitializeComponent();
            rellenarArray();
            FormClosing += new FormClosingEventHandler(onClose);
        }

        private void onClose(object sender, FormClosingEventArgs e)
        {
            /*
            if (textoInicial == texto)
            {

            }
            else
            {
                if (!guardarCambios())
                {
                    e.Cancel = true;
                }
            }
            */

            if (textoInicial != texto && !guardarCambios())
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Font = new Font("Consolas", 12, FontStyle.Regular);
            textoInicial = textBox.Text;
            guardarToolStripMenuItem.Enabled = false;
            deshacerToolStripMenuItem.Enabled = false;
            rehacerToolStripMenuItem.Enabled = false;
            configurarLineaColumna();
            configurarZoom();
        }

        private void rellenarArray()
        {
            zoomItems[0] = toolStripMenuItem1;
            zoomItems[1] = toolStripMenuItem2;
            zoomItems[2] = toolStripMenuItem3;
            zoomItems[3] = toolStripMenuItem4;
            zoomItems[4] = toolStripMenuItem5;
            zoomItems[5] = toolStripMenuItem6;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            texto = textBox.Text;
            deshacerToolStripMenuItem.Enabled = true;
            rehacerToolStripMenuItem.Enabled = true;
            if (texto != textoInicial)
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
            configurarLineaColumna();
        }

        private void TextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            configurarZoom();
            comprobarZoom();
        }

        private void configurarLineaColumna()
        {
            int posicionCursor = textBox.SelectionStart;
            int linea = textBox.GetLineFromCharIndex(posicionCursor);
            int columna = posicionCursor - textBox.GetFirstCharIndexFromLine(linea);
            toolStripStatusLabel1.Text = "Línea " + linea + 1 + ", Columna " + columna + 1;
        }

        private void configurarZoom()
        {
            toolStripStatusLabel2.Text = ((int)(textBox.ZoomFactor * 100)).ToString() + "%";
        }

        private void comprobarZoom()
        {
            switch (textBox.ZoomFactor)
            {
                case 0.5f:
                    ajustarZoomCheck(0);
                    break;
                case 0.75f:
                    ajustarZoomCheck(1);
                    break;
                case 1f:
                    ajustarZoomCheck(2);
                    break;
                case 1.25f:
                    ajustarZoomCheck(3);
                    break;
                case 1.5f:
                    ajustarZoomCheck(4);
                    break;
                case 2f:
                    ajustarZoomCheck(5);
                    break;
                default:
                    ajustarZoomCheck(6);
                    break;

            }
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guardarCambios())
            {
                iniciarNuevoFichero();
            }
        }

        private Boolean guardarCambios()
        {
            if (textoInicial != texto)
            {
                DialogResult resultado = MessageBox.Show("Tiene cambios en el archivo, ¿desea guardar antes de continuar?", "Alerta", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    return guardarComo();
                }
                return true;
            }
            else return false;
        }

        private void iniciarNuevoFichero()
        {
            textoInicial = string.Empty;
            texto = string.Empty;
            textBox.Text = string.Empty;
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (guardarCambios())
            {
                abrirFichero();
            }
            else
            {
                abrirFichero();
            }
        }

        private void abrirFichero()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de texto (.txt)|*.txt";
            openFileDialog.Title = "Abrir archivo";
            openFileDialog.DefaultExt = "txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    string contenido = File.ReadAllText(filePath);

                    textBox.Text = contenido;
                    textoInicial = contenido;
                    texto = contenido;
                    archivoActual = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivoActual != "")
            {
                try
                {
                    File.WriteAllText(archivoActual, texto);
                    textoInicial = texto;
                    guardarToolStripMenuItem.Enabled = false;
                    MessageBox.Show("El archivo se ha guardado correctamente.", "Guardado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar el archivo: " + ex.Message);
                }
            }
            else
            {
                guardarComo();
            }
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private Boolean guardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos de texto (.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = "Sin titulo";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, texto);

                    MessageBox.Show("El archivo se ha guardado correctamente.", "Guardado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textoInicial = texto;
                    guardarToolStripMenuItem.Enabled = false;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
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
                if (textBox.SelectedText.Length > 0)
                {
                    textBox.SelectionFont = fontDialog.Font;
                    texto = textBox.Text;
                }
                else
                {
                    textBox.Font = fontDialog.Font;
                    texto = textBox.Text;
                }
            }
        }

        private void ColorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (textBox.SelectedText.Length > 0)
                {
                    textBox.SelectionColor = colorDialog.Color;
                    texto = textBox.Text;
                }
                else
                {
                    textBox.ForeColor = colorDialog.Color;
                    texto = textBox.Text;
                }
            }
        }

        private void ColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = colorDialog.Color;
                texto = textBox.Text;
            }
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
            texto = textBox.Text;
        }

        private void RehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
            texto = textBox.Text;
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
            texto = textBox.Text;
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
            texto = textBox.Text;
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
            texto = textBox.Text;
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
            MessageBox.Show("Notas\nVersion 1.0.1\nCreado por Víctor Domínguez Gómez Limón", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("https://learn.microsoft.com/es-mx/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8");

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
            ajustarZoomCheck(0);
            textBox.ZoomFactor = 0.5f;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ajustarZoomCheck(1);
            textBox.ZoomFactor = 0.75f;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ajustarZoomCheck(2);
            textBox.ZoomFactor = 1;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ajustarZoomCheck(3);
            textBox.ZoomFactor = 1.25f;
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ajustarZoomCheck(4);
            textBox.ZoomFactor = 1.5f;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ajustarZoomCheck(5);
            textBox.ZoomFactor = 2;
        }

        private void ajustarZoomCheck(int numero)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i == numero)
                {
                    zoomItems[i].Checked = true;
                }
                else
                {
                    zoomItems[i].Checked = false;
                }
            }
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