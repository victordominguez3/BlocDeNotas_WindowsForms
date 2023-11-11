using Notas;
using System;

public class NotasPresentador
{

	private NotasModel model = new NotasModel();

	public NotasPresentador() 
	{ 
		model.presentador = this;
	}

	
	public void rellenarArray(ToolStripMenuItem[] array)
	{
		model.rellenarArray(array);
	}

	public string configurarLineaColumna(RichTextBox textBox)
	{
		return model.configurarLineaColumna(textBox);
	}

	public string configurarZoom(float zoom)
	{
		return model.configurarZoom(zoom);
	}

	public ToolStripMenuItem[] comprobarZoom(float zoom)
	{
		return model.comprobarZoom(zoom);
	}

	public Boolean hayCambios()
	{
		return model.hayCambios();
	}

	public Boolean guardarCambios()
	{
		return model.guardarCambios();
	}

	public void iniciarNuevoFichero()
	{
		model.iniciarNuevoFichero();
	}

	public String? abrirFichero()
	{
		return model.abrirFichero();
	}

	public Boolean guardarComo()
	{
		return model.guardarComo();
	}

	public void setTexto(string texto)
	{
		model.setTexto(texto);
	}

	public void setTextoInicial(string texto)
	{
		model.setTextoInicial(texto);
	}

	public Boolean guardar()
	{
		return model.guardar();
	}

	public ToolStripMenuItem[] ajustarZoomCheck(int numero)
	{
		return model.ajustarZoomCheck(numero);
	}
}
