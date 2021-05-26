using System.Collections.Generic;

interface IHistoric {
    List<Sell> getUserHistoric(uint id);
}