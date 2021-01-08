using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Fantasy
{
     public class Club
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public int GoalsAganist { get; set; }
        public int TotalGoals { get; set; }

        public String StadiumName { get; set; }
        public String ManagerName { get; set; }

        public String FoundationDate { get; set; }
        public List<Footballer> Footballers { get; set; }
        public bool InFpl { set; get; }  

        public Club(DataTable d)
        {
            var row = d.AsEnumerable().FirstOrDefault();
            Name = row.Field<string>("Club_Name");
            Rank = row.Field<int>("Club_Rank");
            Points = row.Field<int>("Club_Points");
            ID = row.Field<int>("Club_ID");
            GoalsAganist = row.Field<int>("Goals_Against");
            TotalGoals = row.Field<int>("Total_Goals");
            StadiumName = row.Field<string>("Stadium_Name");
            ManagerName = row.Field<string>("ManagerName");
            FoundationDate = row.Field<string>("FoundationDate");
            InFpl = row.Field<bool>("inFpl");
        }
        public Club(DataTable d, DataTable p )
        {
            //Club info
            var row = d.AsEnumerable().FirstOrDefault();
            Name = row.Field<string>("Club_Name");
            Rank = row.Field<int>("Club_Rank");
            Points = row.Field<int>("Club_Points");
            ID = row.Field<int>("Club_ID");
            GoalsAganist = row.Field<int>("Goals_Against");
            TotalGoals = row.Field<int>("Total_Goals");
            StadiumName = row.Field<string>("Stadium_Name");
            ManagerName = row.Field<string>("ManagerName");
            FoundationDate = row.Field<string>("FoundationDate");
            //Players Info
            Footballers = new List<Footballer>();
            Footballers = (from DataRow dr in p.Rows
                           select new Footballer()
                           {
                               First_Name = dr["First_Name"].ToString(),
                               Last_Name = dr["Last_Name"].ToString(),
                               Poisition = Convert.ToInt32(dr["Poisition"]),
                           }).ToList();
        public Club() { }

        }
    }

    }

