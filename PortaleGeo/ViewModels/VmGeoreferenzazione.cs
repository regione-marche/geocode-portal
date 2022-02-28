﻿using NuovoPortaleGeo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace NuovoPortaleGeo.ViewModels
{
    public partial class VmGeoreferenzazione
    {

        public VmGeoreferenzazione(CSVdati dati)
        {

        }

        public long Id { get; set; }
        [Required] public string IdUtente { get; set; }
        [Required] public string DescrizioneFile { get; set; }

        [Required] public string Provincia { get; set; }
        [Required] public string Comune { get; set; }
        [Required] public string Indirizzo { get; set; }
        [Required] public string Descrizione { get; set; }
        public Nullable<bool> Here { get; set; }
        public Nullable<bool> OpenStreetMap { get; set; }
        public Nullable<bool> Google { get; set; }


        public DataColumnCollection Columns { get; set; }
        public DataRowCollection Rows { get; set; }




        public VmGeoreferenzazione(CSVdati model, DataTable dataTable)
        {
            Id = model.Id;
            IdUtente = model.IdUtente;
            DescrizioneFile = model.DescrizioneFile;
            Provincia = model.Provincia;
            Comune = model.Comune;
            Indirizzo = model.Indirizzo;
            Descrizione = model.Descrizione;
            Here = model.Here;
            OpenStreetMap = model.OpenStreetMap;
            Google = model.Google;
            Columns = dataTable.Columns;
            Rows = dataTable.Rows;
        }
    }
}