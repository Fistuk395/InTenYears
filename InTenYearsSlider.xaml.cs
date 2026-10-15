namespace InTenYears;

public partial class InTenYearsSlider : ContentPage
{
    public int age;
	public InTenYearsSlider()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (EntName.Text != null && EntAge.Text != null)
            lblResult.Text = "In 10 years from now " + EntName.Text + " will be " + (int.Parse(EntAge.Text.ToString()) + 10);
        else
        {
            lblResult.Text = "Please fill all the following information";
        }
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