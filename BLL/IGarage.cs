using System.Collections.Generic;
using System.Data;


namespace BLL
{
    public interface IGarage
    {
        string AddAuto(Automobile au);
        string UpdateAuto(Automobile au);
        int GetIndexAuto(Automobile a1);
        string DeleteAuto(string immatriculation);
        Automobile GetAuto(string immatriculation);
        List<Automobile> AfficherAutomobiles
            (SubType soustype);
    }



}