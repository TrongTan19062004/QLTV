using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLayer; // namespace chứa DataProvier
using TransferObject;       // namespace chứa class Regulation

public class RegulationDL
{
    private DataProvier dataProvider = new DataProvier();

    public List<Regulation> GetAllRegulations()
    {
        List<Regulation> regulations = new List<Regulation>();
        string sql = "SELECT * FROM Regulation";

        DataTable dt = dataProvider.MyExcuteReader(sql, CommandType.Text);

        foreach (DataRow row in dt.Rows)
        {
            Regulation reg = new Regulation
            {
                RegulationID = Convert.ToInt32(row["RegulationID"]),
                Description = row["Description"].ToString(),
                MaxBookDays = Convert.ToInt32(row["MaxBorrowDays"]),
                FinePerDay = Convert.ToInt32(row["FinePerDay"]),
                MaxBooksAllow = Convert.ToInt32(row["MaxBooksAllowed"])
            };

            regulations.Add(reg);
        }

        return regulations;
    }
    // Cập nhật Description
    // Cập nhật Description
    public bool UpdateDescription(int regulationId, string description)
    {
        string sql = "UPDATE Regulation SET Description = @Description WHERE RegulationID = @RegulationID";
        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@Description", description),
        new SqlParameter("@RegulationID", regulationId)
        };
        return dataProvider.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
    }

    // Cập nhật MaxBorrowDays
    public bool UpdateMaxBookDays(int regulationId, int maxBorrowDays)
    {
        string sql = "UPDATE Regulation SET MaxBorrowDays = @MaxBorrowDays WHERE RegulationID = @RegulationID";
        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@MaxBorrowDays", maxBorrowDays),
        new SqlParameter("@RegulationID", regulationId)
        };
        return dataProvider.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
    }

    // Cập nhật FinePerDay
    public bool UpdateFinePerDays(int regulationId, int finePerDay)
    {
        string sql = "UPDATE Regulation SET FinePerDay = @FinePerDay WHERE RegulationID = @RegulationID";
        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@FinePerDay", finePerDay),
        new SqlParameter("@RegulationID", regulationId)
        };
        return dataProvider.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
    }

    // Cập nhật MaxBooksAllowed
    public bool UpdateMaxBookAllow(int regulationId, int maxBooksAllowed)
    {
        string sql = "UPDATE Regulation SET MaxBooksAllowed = @MaxBooksAllowed WHERE RegulationID = @RegulationID";
        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@MaxBooksAllowed", maxBooksAllowed),
        new SqlParameter("@RegulationID", regulationId)
        };
        return dataProvider.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
    }


}
