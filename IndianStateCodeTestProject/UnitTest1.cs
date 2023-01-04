using Indianstatescensusanalyzerproblem;

namespace IndianStateCodeTestProject
{
    public class Tests
    {
        public static string stateCodeCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCode.csv";
        public static string stateCodeIncorrectCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCodedata.csv";
        public static string stateCodeIncorrectCSVFileType = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCodeType.txt";
        public static string stateCodeDelimiterCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCodeDelimiter.csv";

        [Test]
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
        [Test]
        public void GivenStateCodeDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
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
        [Test]
        public void GivenStateCodeDataDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            try
            {
                int record = stateCodeAnalyser.ReadStateCensusData(stateCodeDelimiterCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter Incorrect");
            }
        }
        [Test]
        public void GivenStateCodeDataFileIncorrectHeader_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser analyzer = new StateCodeAnalyser();
            try
            {
                bool records = analyzer.ReadStateCensusData(stateCodeCSVFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Header is Incorrect");
            }
        }
    }
}