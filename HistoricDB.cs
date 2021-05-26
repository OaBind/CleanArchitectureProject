using System.Collections.Generic;

class HistoricDB {
    public List<Sell> sells { get; set; }

    public HistoricDB() {
        sells.Add(new Sell());
    }

    public List<Sell> getHistoricByUserId(uint id) {
        return sells.FindAll(s => s.idUser == id);
    }
}