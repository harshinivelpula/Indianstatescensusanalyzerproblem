using Indianstatescensusanalyzerproblem;

namespace IndianStateCensusTestProject
{
    public class Tests
    {
        public static string StateCensusCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensusData.csv";
        public static string StateCensusIncorrectCSVFilePath = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensus.csv";
        public static string StateCensusIncorrectCSVFileType = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensus.txt";
        public static string StaticCensusDelimiterCSVFile = @"C:\Users\DELL\source\repos\Indianstatescensusanalyzerproblem\Indianstatescensusanalyzerproblem\files\StateCensusDelimiter.csv";
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
        [Test]
        public void GivenStateCensusDataDelimiterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            try
            {
                int record = stateCodeAnalyser.ReadStateCensusData(StaticCensusDelimiterCSVFile);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter Incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDataFileIncorrectHeader_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyser analyzer = new StateCodeAnalyser();
            try
            {
                bool records = analyzer.ReadStateCensusData(StateCensusCSVFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Header is Incorrect");
            }
        }
    }
}