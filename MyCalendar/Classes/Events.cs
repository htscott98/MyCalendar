using System.Data;

namespace MyCalendar
{

    public class Events
    {

        #region " Declarations "

        private int _ID;
        private string _Name;
        private string _Description;
        private DateTime _StartTime;
        private DateTime _StopTime;
        private bool _PastEvent;

        #endregion

        #region " Properties "

        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public DateTime StartTime { get { return _StartTime; } set { _StartTime = value; } }
        public DateTime StopTime { get { return _StopTime; } set { _StopTime = value; } }
        public bool PastEvent { get { return _PastEvent; } set { _PastEvent = value; } }

        #endregion

        #region " Constructors "

        public Events()
        {
            _ID = 0;
            _Name = string.Empty;
            _Description = string.Empty;
            _StartTime = Convert.ToDateTime("1/1/1900");
            _StopTime = Convert.ToDateTime("1/1/1900");
            _PastEvent = false;
        }

        public Events(DataRow row)
        {
            _ID = Convert.ToInt32(row["ID"].ToString());
            _Name = row["Name"].ToString();
            _Description = row["Description"].ToString();
            _StartTime = Convert.ToDateTime(row["StartTime"].ToString());
            _StopTime = Convert.ToDateTime(row["StopTime"].ToString());
            _PastEvent = Convert.ToBoolean(row["PastEvent"].ToString());
        }

        public Events(DataGridViewRow row)
        {
            _ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
            _Name = row.Cells["Name"].Value.ToString();
            _Description = row.Cells["Description"].Value.ToString();
            _StartTime = Convert.ToDateTime(row.Cells["StartTime"].Value.ToString());
            _StopTime = Convert.ToDateTime(row.Cells["StopTime"].Value.ToString());
            _PastEvent = Convert.ToBoolean(row.Cells["PastEvent"].Value.ToString());
        }

        #endregion

        #region " Overrides "

        public override string ToString()
        {
            return "";
        }

        #endregion

        #region " Private Methods "

        private static string GetSQLSelect()
        {
            string strReturnValue;
            strReturnValue = " SELECT ID, Name, Description, StartTime, StopTime, PastEvent ";
            return strReturnValue;
        }

        #endregion

        #region " Public Methods "

        public static DataTable GetDataTable()
        {
            string strSQL = "";
            DataTable dt = null;

            try
            {
                strSQL = GetSQLSelect() +
                "FROM MyCalendar_Events";

                dt = MasterCode.Execute.ExecuteSelectReturnDT(MasterCode.Connection.InitPRDConnection(), strSQL);

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }

            return dt;
        }

        public static List<Events> GetListOfObjects()
        {
            List<Events> objList = new List<Events>();
            string strSQL = "";
            try
            {
                strSQL = GetSQLSelect() +
                "FROM MyCalendar_Events";

                DataTable dt = MasterCode.Execute.ExecuteSelectReturnDT(MasterCode.Connection.InitPRDConnection(), strSQL);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Events obj = new Events(r);

                        if (obj != null)
                            objList.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }

            return objList;
        }

        public static Events GetObjectByID(string id)
        {
            Events obj = new Events();
            string strSQL = "";
            try
            {
                strSQL = GetSQLSelect() +
                "FROM MyCalendar_Events " +
                "WHERE ID = '" + id + "'";

                DataTable dt = MasterCode.Execute.ExecuteSelectReturnDT(MasterCode.Connection.InitPRDConnection(), strSQL);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        obj = new Events(r);

                        if (obj != null)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }

            return obj;
        }

        public static List<Events> GetListOfObjectsByDate(string date, bool pastEvents)
        {
            List<Events> objList = new List<Events>();
            string strSQL = "";
            try
            {
                strSQL = GetSQLSelect() +
                "FROM MyCalendar_Events " +
                "WHERE CONVERT(date, StartTime) = '" + date + "' AND PastEvent = '" + pastEvents + "'" +
                "ORDER BY StartTime ASC";

                DataTable dt = MasterCode.Execute.ExecuteSelectReturnDT(MasterCode.Connection.InitPRDConnection(), strSQL);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Events obj = new Events(r);

                        if (obj != null)
                            objList.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }

            return objList;
        }

        public bool InsertRecord()
        {
            string strSQL = "";
            bool b = false;
            try
            {
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                keyValuePairs.Add("@Name", _Name);
                keyValuePairs.Add("@Description", _Description);
                keyValuePairs.Add("@StartTime", _StartTime.ToString());
                keyValuePairs.Add("@StopTime", _StopTime.ToString());
                keyValuePairs.Add("@PastEvent", _PastEvent.ToString());
                strSQL = "INSERT INTO MyCalendar_Events (" +
                "Name,Description,StartTime,StopTime,PastEvent)" +
                " VALUES (@Name,@Description,@StartTime,@StopTime,@PastEvent)";
                b = MasterCode.Execute.ExecuteStatementReturnBool(MasterCode.Connection.InitPRDConnection(), strSQL, keyValuePairs);
            }


            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);

                b = false;
            }

            return b;
        }

        public bool UpdateRecord()
        {
            string strSQL = "";
            bool b = false;
            try
            {
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                keyValuePairs.Add("@ID", _ID.ToString());
                keyValuePairs.Add("@Name", _Name);
                keyValuePairs.Add("@Description", _Description);
                keyValuePairs.Add("@StartTime", _StartTime.ToString());
                keyValuePairs.Add("@StopTime", _StopTime.ToString());
                keyValuePairs.Add("@PastEvent", _PastEvent.ToString());
                strSQL = "UPDATE MyCalendar_Events " +
                "SET Name=@Name, Description=@Description, StartTime=@StartTime, StopTime=@StopTime, " +
                "PastEvent=@PastEvent " +
                "WHERE ID = @ID ";

                b = MasterCode.Execute.ExecuteStatementReturnBool(MasterCode.Connection.InitPRDConnection(), strSQL, keyValuePairs);

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);

                b = false;
            }

            return b;
        }

        public bool DisablePastEvents()
        {
            string strSQL = "";
            bool b = false;
            try
            {
                strSQL = "UPDATE MyCalendar_Events " +
                "SET PastEvent = 1 WHERE StopTime < GetDate()";

                b = MasterCode.Execute.ExecuteStatementReturnBool(MasterCode.Connection.InitPRDConnection(), strSQL);

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);

                b = false;
            }

            return b;
        }

        public bool DeleteRecord()
        {
            string strSQL = "";
            bool b = false;

            try
            {
                strSQL = "DELETE FROM MyCalendar_Events " +
                 "WHERE ID = " + _ID;

                b = MasterCode.Execute.ExecuteStatementReturnBool(MasterCode.Connection.InitPRDConnection(), strSQL);

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }

            return b;
        }
        #endregion

    }
}
