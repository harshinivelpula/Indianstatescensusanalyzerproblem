using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indianstatescensusanalyzerproblem
{
    public class StateCodeAnalyser
    {
        public int ReadStateCensusData(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.FILE_INCORRECT, "Incorrect FilePath");

            }
            if (!filepath.EndsWith(".csv"))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.TYPE_INCORRECT, "Incorrect FileType");
            }
            var read = File.ReadAllLines(filepath);
            string header = read[0];
            if (header.Contains("-"))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.DELIMITER_INCORRECT, "Delimiter Incorrect");
            }
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCensusData>().ToList();
                foreach (var data in records)
                {
                    // Console.WriteLine(data.State + " " + data.Population + " " + data.DensityPerSqKm + " " + data.AreaInSqKm);
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
        public bool ReadStateCensusData(string filepath, string header)
        {
            var read = File.ReadAllLines(filepath);
            string headers = read[0];
            if (headers.Equals(header))
                return true;
            else
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.HEADER_INCORRECT, "Header is Incorrect");

        }
        // for indianstatecodetestprojct
        public int ReadStateCodeData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.FILE_INCORRECT, "Incorrect FilePath");

            }
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    // Console.WriteLine(data.SrNo+" " +data.StateName+" "+data.TIN+" "+data.StateCode+" ");
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
    }
}