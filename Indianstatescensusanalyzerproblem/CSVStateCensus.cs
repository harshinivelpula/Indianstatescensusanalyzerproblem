using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indianstatescensusanalyzerproblem
{
    public class CSVStateCensus
    {
        public void ReadStateCensusData(string filepath)
        {
            using var reader = new StreamReader(filepath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<StateCensusData>().ToList();
            foreach (var data in records)
            {
                Console.WriteLine(data.State + " " + data.Population + " " + data.AreaInSqKm + " " + data.DensityPerSqKm + " ");
            }
        }
    }
}