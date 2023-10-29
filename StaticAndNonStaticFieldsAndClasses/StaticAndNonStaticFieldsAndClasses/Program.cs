global using static System.Console;
double price = 5;
//Extensions Method
WriteLine(price.IsVaildPrice());
//Static Value Not Changeble
var totalPrice = price * Product.Tax;
WriteLine(totalPrice.ToString());