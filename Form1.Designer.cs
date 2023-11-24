using System.Windows.Forms;

namespace Notas
{
    partial class NotasView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            edicionToolStripMenuItem = new ToolStripMenuItem();
            deshacerToolStripMenuItem = new ToolStripMenuItem();
            rehacerToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDelFondoToolStripMenuItem = new ToolStripMenuItem();
            ajusteDeLineaToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            barraDeEstadoToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            textBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deshacerToolStripMenuItem1 = new ToolStripMenuItem();
            rehacerToolStripMenuItem1 = new ToolStripMenuItem();
            copiarToolStripMenuItem1 = new ToolStripMenuItem();
            cortarToolStripMenuItem1 = new ToolStripMenuItem();
            pegarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, edicionToolStripMenuItem, formatoToolStripMenuItem, verToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(696, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, imprimirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = Properties.Resources.agregar;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(246, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += NuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = Properties.Resources.abrir;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            abrirToolStripMenuItem.Size = new Size(246, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += AbrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = Properties.Resources.guardar;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            guardarToolStripMenuItem.Size = new Size(246, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += GuardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Image = Properties.Resources.guardarComo;
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarComoToolStripMenuItem.Size = new Size(246, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como...";
            guardarComoToolStripMenuItem.Click += GuardarComoToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = Properties.Resources.imprimir;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(246, 26);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += ImprimirToolStripMenuItem_Click;
            // 
            // edicionToolStripMenuItem
            // 
            edicionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deshacerToolStripMenuItem, rehacerToolStripMenuItem, copiarToolStripMenuItem, cortarToolStripMenuItem, pegarToolStripMenuItem, eliminarToolStripMenuItem });
            edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            edicionToolStripMenuItem.Size = new Size(72, 24);
            edicionToolStripMenuItem.Text = "Edición";
            // 
            // deshacerToolStripMenuItem
            // 
            deshacerToolStripMenuItem.Image = Properties.Resources.deshacer;
            deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            deshacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            deshacerToolStripMenuItem.Size = new Size(211, 26);
            deshacerToolStripMenuItem.Text = "Deshacer";
            deshacerToolStripMenuItem.Click += DeshacerToolStripMenuItem_Click;
            // 
            // rehacerToolStripMenuItem
            // 
            rehacerToolStripMenuItem.Image = Properties.Resources.rehacer;
            rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            rehacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            rehacerToolStripMenuItem.Size = new Size(211, 26);
            rehacerToolStripMenuItem.Text = "Rehacer";
            rehacerToolStripMenuItem.Click += RehacerToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = Properties.Resources.copiar;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(211, 26);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += CopiarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Image = Properties.Resources.tijeras;
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cortarToolStripMenuItem.Size = new Size(211, 26);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += CortarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Image = Properties.Resources.pegar;
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem.Size = new Size(211, 26);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += PegarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Image = Properties.Resources.basura;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.ShortcutKeys = Keys.Delete;
            eliminarToolStripMenuItem.Size = new Size(211, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorDeFuenteToolStripMenuItem, colorDelFondoToolStripMenuItem, ajusteDeLineaToolStripMenuItem });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(79, 24);
            formatoToolStripMenuItem.Text = "Formato";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Image = Properties.Resources.texto;
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fuenteToolStripMenuItem.Size = new Size(239, 26);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += FuenteToolStripMenuItem_Click;
            // 
            // colorDeFuenteToolStripMenuItem
            // 
            colorDeFuenteToolStripMenuItem.Image = Properties.Resources.paleta;
            colorDeFuenteToolStripMenuItem.Name = "colorDeFuenteToolStripMenuItem";
            colorDeFuenteToolStripMenuItem.Size = new Size(239, 26);
            colorDeFuenteToolStripMenuItem.Text = "Color de fuente";
            colorDeFuenteToolStripMenuItem.Click += ColorDeFuenteToolStripMenuItem_Click;
            // 
            // colorDelFondoToolStripMenuItem
            // 
            colorDelFondoToolStripMenuItem.Image = Properties.Resources.llenar;
            colorDelFondoToolStripMenuItem.Name = "colorDelFondoToolStripMenuItem";
            colorDelFondoToolStripMenuItem.Size = new Size(239, 26);
            colorDelFondoToolStripMenuItem.Text = "Color del fondo";
            colorDelFondoToolStripMenuItem.Click += ColorDelFondoToolStripMenuItem_Click;
            // 
            // ajusteDeLineaToolStripMenuItem
            // 
            ajusteDeLineaToolStripMenuItem.Name = "ajusteDeLineaToolStripMenuItem";
            ajusteDeLineaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            ajusteDeLineaToolStripMenuItem.Size = new Size(239, 26);
            ajusteDeLineaToolStripMenuItem.Text = "Ajuste de línea";
            ajusteDeLineaToolStripMenuItem.Click += AjusteDeLineaToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { barraDeEstadoToolStripMenuItem, zoomToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // barraDeEstadoToolStripMenuItem
            // 
            barraDeEstadoToolStripMenuItem.Checked = true;
            barraDeEstadoToolStripMenuItem.CheckState = CheckState.Checked;
            barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem";
            barraDeEstadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            barraDeEstadoToolStripMenuItem.Size = new Size(247, 26);
            barraDeEstadoToolStripMenuItem.Text = "Barra de estado";
            barraDeEstadoToolStripMenuItem.Click += BarraDeEstadoToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            zoomToolStripMenuItem.Image = Properties.Resources.acercarse;
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(247, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 26);
            toolStripMenuItem1.Text = "50%";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(128, 26);
            toolStripMenuItem2.Text = "75%";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem3.CheckState = CheckState.Checked;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(128, 26);
            toolStripMenuItem3.Text = "100%";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(128, 26);
            toolStripMenuItem4.Text = "125%";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(128, 26);
            toolStripMenuItem5.Text = "150%";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(128, 26);
            toolStripMenuItem6.Text = "200%";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, ayudaToolStripMenuItem1 });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Image = Properties.Resources.informacion;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(213, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += AcercaDeToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Image = Properties.Resources.interrogatorio;
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(213, 26);
            ayudaToolStripMenuItem1.Text = "¿Necesitas ayuda?";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // textBox
            // 
            textBox.AllowDrop = true;
            textBox.ContextMenuStrip = contextMenuStrip1;
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 28);
            textBox.Name = "textBox";
            textBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            textBox.Size = new Size(696, 378);
            textBox.TabIndex = 1;
            textBox.Text = "";
            textBox.WordWrap = false;
            textBox.ContentsResized += TextBox_ContentsResized;
            textBox.SelectionChanged += TextBox_SelectionChanged;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deshacerToolStripMenuItem1, rehacerToolStripMenuItem1, copiarToolStripMenuItem1, cortarToolStripMenuItem1, pegarToolStripMenuItem1, eliminarToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(202, 160);
            // 
            // deshacerToolStripMenuItem1
            // 
            deshacerToolStripMenuItem1.Image = Properties.Resources.deshacer;
            deshacerToolStripMenuItem1.Name = "deshacerToolStripMenuItem1";
            deshacerToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Z;
            deshacerToolStripMenuItem1.Size = new Size(201, 26);
            deshacerToolStripMenuItem1.Text = "Deshacer";
            deshacerToolStripMenuItem1.Click += DeshacerToolStripMenuItem_Click;
            // 
            // rehacerToolStripMenuItem1
            // 
            rehacerToolStripMenuItem1.Image = Properties.Resources.rehacer;
            rehacerToolStripMenuItem1.Name = "rehacerToolStripMenuItem1";
            rehacerToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Y;
            rehacerToolStripMenuItem1.Size = new Size(201, 26);
            rehacerToolStripMenuItem1.Text = "Rehacer";
            rehacerToolStripMenuItem1.Click += RehacerToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem1
            // 
            copiarToolStripMenuItem1.Image = Properties.Resources.copiar;
            copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            copiarToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem1.Size = new Size(201, 26);
            copiarToolStripMenuItem1.Text = "Copiar";
            copiarToolStripMenuItem1.Click += CopiarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem1
            // 
            cortarToolStripMenuItem1.Image = Properties.Resources.tijeras;
            cortarToolStripMenuItem1.Name = "cortarToolStripMenuItem1";
            cortarToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.X;
            cortarToolStripMenuItem1.Size = new Size(201, 26);
            cortarToolStripMenuItem1.Text = "Cortar";
            cortarToolStripMenuItem1.Click += CortarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem1
            // 
            pegarToolStripMenuItem1.Image = Properties.Resources.pegar;
            pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            pegarToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem1.Size = new Size(201, 26);
            pegarToolStripMenuItem1.Text = "Pegar";
            pegarToolStripMenuItem1.Click += PegarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Image = Properties.Resources.basura;
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.ShortcutKeys = Keys.Delete;
            eliminarToolStripMenuItem1.Size = new Size(201, 26);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            eliminarToolStripMenuItem1.Click += EliminarToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(696, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Padding = new Padding(50, 0, 40, 0);
            toolStripStatusLabel1.Size = new Size(241, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Padding = new Padding(0, 0, 40, 0);
            toolStripStatusLabel2.Size = new Size(191, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Padding = new Padding(0, 0, 40, 0);
            toolStripStatusLabel3.Size = new Size(152, 20);
            toolStripStatusLabel3.Text = "Windows(CRLF)";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(48, 20);
            toolStripStatusLabel4.Text = "UTF-8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 432);
            Controls.Add(textBox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = Properties.Resources.notas_adhesivas;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bloc de notas";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem edicionToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private RichTextBox textBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDelFondoToolStripMenuItem;
        private ToolStripMenuItem barraDeEstadoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem ajusteDeLineaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copiarToolStripMenuItem1;
        private ToolStripMenuItem cortarToolStripMenuItem1;
        private ToolStripMenuItem pegarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        private ToolStripMenuItem rehacerToolStripMenuItem1;
        private ToolStripMenuItem deshacerToolStripMenuItem1;
    }
}