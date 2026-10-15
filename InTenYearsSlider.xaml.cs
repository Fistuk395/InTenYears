namespace InTenYears;

public partial class InTenYearsSlider : ContentPage
{
    public int age;
	public InTenYearsSlider()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)sldAge.Value + 10;
        EntAge.Text = age.ToString();
    }

    private void sldAge_DragCompleted(object sender, EventArgs e)
    {
        lblResult.Text = "In 10 years from now " + EntName.Text + " will be " + int.Parse(EntAge.Text.ToString());
    }
}