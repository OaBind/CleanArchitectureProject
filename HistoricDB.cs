using System.Collections.Generic;

class HistoricDB {
    public List<Sell> sells { get; set; }

    public HistoricDB() {
        sells = new List<Sell>();
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 2, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 3, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
        sells.Add(new Sell(10, 0, new System.DateTime(2021, 02, 04)));
    }

    public List<Sell> getHistoricByUserId(uint id) {
        return sells.FindAll(s => s.idUser == id);
    }
}