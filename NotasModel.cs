using System;

namespace Notas
{

    public partial class NotasModel
    {

        private string textoInicial = string.Empty;
        private string texto = string.Empty;
        private string archivoActual = string.Empty;
        ToolStripMenuItem[] zoomItems = new ToolStripMenuItem[6];
        public NotasPresentador? presentador;

        public NotasModel() 
        {
            
        }

        public void rellenarArray(ToolStripMenuItem[] array)
        {
            zoomItems[0] = array[0];
            zoomItems[1] = array[1];
            zoomItems[2] = array[2];
            zoomItems[3] = array[3];
            zoomItems[4] = array[4];
            zoomItems[5] = array[5];
        }

        public void setTexto(string texto)
        {
            this.texto = texto;
        }

        public void setTextoInicial(string texto)
        {
            textoInicial = texto;
        }

        public string configurarLineaColumna(RichTextBox textBox)
        {
            int posicionCursor = textBox.SelectionStart;
            int linea = textBox.GetLineFromCharIndex(posicionCursor);
            int columna = posicionCursor - textBox.GetFirstCharIndexFromLine(linea);
            return "Línea " + (linea + 1) + ", Columna " + (columna + 1);
        }

        public string configurarZoom(float zoom)
        {
            return ((int)(zoom * 100)).ToString() + "%";
        }

        public ToolStripMenuItem[] comprobarZoom(float zoom)
        {
            switch (zoom)
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
            return zoomItems;
        }

        public Boolean guardar()
        {
            if (archivoActual != "")
            {
                try
                {
                    File.WriteAllText(archivoActual, texto);
                    textoInicial = texto;
                    MessageBox.Show("El archivo se ha guardado correctamente.", "Guardado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar el archivo: " + ex.Message);
                }
            }
            else
            {
                return !guardarComo();
            }
            return true;
        }

        public Boolean guardarCambios()
        {
            if (hayCambios())
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

        public Boolean hayCambios()
        {
            return textoInicial != texto;
        }

        public void iniciarNuevoFichero()
        {
            textoInicial = string.Empty;
            texto = string.Empty;
        }

        public string? abrirFichero()
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

                    textoInicial = contenido;
                    texto = contenido;
                    archivoActual = filePath;
                    return contenido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return texto;
        }

        public Boolean guardarComo()
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
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public ToolStripMenuItem[] ajustarZoomCheck(int numero)
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
            return zoomItems;
        }
    }
}
