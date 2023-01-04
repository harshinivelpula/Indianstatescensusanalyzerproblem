namespace Indianstatescensusanalyzerproblem
{
    class Program
    {
        public static string stateCensusCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensusData.csv";
        public static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
        }
    }
}