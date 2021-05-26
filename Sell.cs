using System;

class Sell {
    public Sell(uint userId, uint productId, DateTime date)
    {
        this.idUser = userId;
        this.idProduct = productId;
        this.date = date;
    }

    public uint idUser {get; set;}
    public uint idProduct { get; set; }
    public DateTime date { get; set; }

    

}