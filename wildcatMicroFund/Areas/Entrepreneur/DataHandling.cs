using Microsoft.CodeAnalysis.Operations;
using System.Data;  // List type
using wildcatMicroFund.Data;
using wildcatMicroFund.Models;
using System.Reflection; // to throw/display exceptions
namespace wildcatMicroFund.Areas.Entrepreneur
{
    public class DataHandling
    {
        public static List<Question> GetQuestions()
        {
            try
            {
                int iRet = 0;               // number of returned rows
                clsDataAccess clsData;      // instance of clsDataAccess, gives access to functions
                DataSet ds = new DataSet(); // Data type contains table returned from query

                List<Question> questions = new List<Question>();    // List of object type to be returned

                /* SQL Query to be run */
                string sql = "select Q.Id, Q.QuestionSummary, Q.QuestIsActive from QuestionUse\n" +
                "LEFT JOIN Question Q on QuestionUse.QuestID = Q.Id\n" +
                "LEFT JOIN QCategory QC on QC.QCategoryID = QuestionUse.QCategoryID\n" +
                "WHERE QC.QCategoryID = 1;\n";

                clsData = new clsDataAccess();  // Defining clsData, sets up connection to database

                ds = clsData.ExecuteSQLStatement(sql, ref iRet);    // setting DataSet ds to the return from the clsDataAccess.ExecuteSQLStatement function
                                                                    // passes sql string and reference to integer iRet (num of returned rows)
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Question temp = new Question(int.Parse(ds.Tables[0].Rows[i][0].ToString()),                 // Calls constructor for object, creates temp with parsed data from ds
                        ds.Tables[0].Rows[i][1].ToString(), bool.Parse(ds.Tables[0].Rows[i][2].ToString()));    
                    questions.Add(temp);        // adds temp row to the list
                }
                Console.WriteLine("Executed SQL: " + sql);  // Test to make sure SQL executed
                return questions;       // Returns list
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
