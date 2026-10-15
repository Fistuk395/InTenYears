namespace InTenYears;

public partial class InTenYears1 : ContentPage
{
	public InTenYears1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(EntName.Text != null && EntAge.Text != null)
			lblResult.Text = "In 10 years from now " + EntName.Text + " will be " + (int.Parse(EntAge.Text.ToString()) + 10);
		else
		{
			lblResult.Text = "Please enter the following information";
        }
    }
}