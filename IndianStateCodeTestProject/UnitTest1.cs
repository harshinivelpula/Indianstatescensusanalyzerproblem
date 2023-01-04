using Indianstatescensusanalyzerproblem;

namespace IndianStateCodeTestProject
{
    public class Tests
    {
        public static string stateCodeCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCode.csv";
        public static string stateCodeIncorrectCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCodedata.csv";

        public void GivenStateCodeData_WhenAnalyse_ShoulReturnNumberOfRecordMatches()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            CSVStateCode cSVStateCode = new CSVStateCode();
            Assert.AreEqual(cSVStateCode.ReadStateCodeData(stateCodeCSVFilePath), stateCodeAnalyser.ReadStateCodeData(stateCodeCSVFilePath));
        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            try
            {
                int record = stateCodeAnalyser.ReadStateCensusData(stateCodeIncorrectCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
    }
} 