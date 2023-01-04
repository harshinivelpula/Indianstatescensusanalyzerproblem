using Indianstatescensusanalyzerproblem;

namespace IndianStateCensusTestProject
{
    public class Tests
    {
        public static string StateCensusCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensusData.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalyse_ShoulReturnNumberOfRecordMatches()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            CSVStateCensus cSVStateCensus= new CSVStateCensus();
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(StateCensusCSVFilePath), stateCodeAnalyser.ReadStateCensusData(StateCensusCSVFilePath));
        }
    }
}