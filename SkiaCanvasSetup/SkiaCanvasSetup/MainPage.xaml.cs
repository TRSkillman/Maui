using SkiaSharp;

namespace SkiaCanvasSetup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPaintSurface(object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
	{
		SKCanvas canvas = e.Surface.Canvas;
		SKPaint paint = new SKPaint { Color = SKColors.DarkBlue, Style = SKPaintStyle.Stroke, IsAntialias = true };

		canvas.Clear();
		canvas.DrawOval(new SKRect(200,200,100,100), paint);
	}

	private void OnTouch(object sender, SkiaSharp.Views.Maui.SKTouchEventArgs e)
	{

	}
}

