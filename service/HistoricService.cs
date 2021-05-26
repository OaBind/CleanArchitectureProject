
using System.Collections.Generic;

class HistoricService : IHistoric
{
    public List<Sell> getUserHistoric(uint id)
    {
        return new HistoricDB().getHistoricByUserId(id);
    }
}