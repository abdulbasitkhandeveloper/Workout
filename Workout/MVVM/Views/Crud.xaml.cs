using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workout.MVVM.Models;
using Workout.MVVM.Models.Utility;

namespace Workout.MVVM.Views;

public partial class Crud : ContentPage
{
    private Repository rp;
    
    public Crud()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
         = new Repository();
        Item item = new Item();
        item.Name = nameText.Text;
        item.ItemPrice = Convert.ToDecimal(priceText.Text);
        item.Description = desText.Text;
        rp.AddItem(item);
        DisplayAlert("item Added", "Item added", "OK");
    }

    private void Button_OnClicked1(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
    
    private void Button_OnClicked2(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}