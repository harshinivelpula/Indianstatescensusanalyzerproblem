using Indianstatescensusanalyzerproblem;

namespace IndianStateCensusTestProject
{
    public class Tests
    {
        public static string StateCensusCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensusData.csv";
        public static string StateCensusIncorrectCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensus.csv";
        public static string StateCensusIncorrectCSVFileType = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensus.txt";
        [Test]
        public void GivenStateCensusData_WhenAnalyse_ShoulReturnNumberOfRecordMatches()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            CSVStateCensus cSVStateCensus= new CSVStateCensus();
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(StateCensusCSVFilePath), stateCodeAnalyser.ReadStateCensusData(StateCensusCSVFilePath));
        }
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            try
            {
                int record = stateCodeAnalyser.ReadStateCensusData(StateCensusIncorrectCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
        [Test]
        public void GivenStateCensusDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            try
            {
                int record = stateCodeAnalyser.ReadStateCensusData(StateCensusIncorrectCSVFileType);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FileType");
            }
        }
    }
}