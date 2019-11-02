using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIQ_Dashboard
{
    class DAL
    {
        SqlConnection coniiqtest;
        SqlCommand cmdiiq;
        DataSet ds = new DataSet();
        SqlDataAdapter daiiq;

        public DataSet Test()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiqtest = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiqtest"].ConnectionString);
                cmdiiq = new SqlCommand(@"select attributes as details, dateadd(s,convert(integer,LEFT(convert(varchar,completed),10)),'19691231 19:00:00:000') as completed from [identityiq].[identityiq].[spt_task_result] where name IN
  ('Test All Applications')", coniiqtest);
                daiiq = new SqlDataAdapter(cmdiiq);
                daiiq.Fill(ds);
                coniiqtest.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return ds;
        }

        SqlConnection coniiqtestb;
        //SqlCommand cmdiiq;
        DataSet dsub = new DataSet();
        //SqlDataAdapter daiiq;

        public DataSet TestB()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiqtestb = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiqtestb"].ConnectionString);
                cmdiiq = new SqlCommand(@"select attributes as details, dateadd(s,convert(integer,LEFT(convert(varchar,completed),10)),'19691231 19:00:00:000') as completed from [Cloned_identityiq].[identityiq].[spt_task_result] where name IN
  ('Eversource - Test All Applications')", coniiqtestb);
                daiiq = new SqlDataAdapter(cmdiiq);
                daiiq.Fill(dsub);
                coniiqtestb.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dsub;
        }


        SqlConnection coniiqDevA;
        //SqlCommand cmdiiq;
        DataSet dstd = new DataSet();
        //SqlDataAdapter daiiq;

        public DataSet DevA()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiqDevA = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiqDevA"].ConnectionString);
                cmdiiq = new SqlCommand(@"select attributes as details, dateadd(s,convert(integer,LEFT(convert(varchar,completed),10)),'19691231 19:00:00:000') as completed from [identityiq].[identityiq].[spt_task_result] where name IN
  ('Eversource - Test All Applications')", coniiqDevA);
                daiiq = new SqlDataAdapter(cmdiiq);
                daiiq.Fill(dstd);
                coniiqDevA.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dstd;
        }

        SqlConnection coniiqDevB;
        //SqlCommand cmdiiq;
        DataSet dstdb = new DataSet();
        //SqlDataAdapter daiiq;

        public DataSet DevB()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiqDevB = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiqDevA"].ConnectionString);
                cmdiiq = new SqlCommand(@"select attributes as details, dateadd(s,convert(integer,LEFT(convert(varchar,completed),10)),'19691231 19:00:00:000') as completed from [Cloned_IIQ].[identityiq].[spt_task_result] where name IN
  ('Test All Applications')", coniiqDevB);
                daiiq = new SqlDataAdapter(cmdiiq);
                daiiq.Fill(dstdb);
                coniiqDevB.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dstdb;
        }

        SqlConnection coniiq;
        SqlCommand cmdiiqtsk;
        DataSet dstsk = new DataSet();
        SqlDataAdapter daiiqtsk;
        public DataSet GetTasks()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiq = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiq"].ConnectionString);
                cmdiiqtsk = new SqlCommand(@"select name, dateadd(s,convert(integer,LEFT(convert(varchar,created),10)),'19691231 19:00:00:000') as created,
  dateadd(s,convert(integer,LEFT(convert(varchar,completed),10)),'19691231 19:00:00:000') as completed, completion_status as status from [identityiq].[spt_task_result] where name IN
  ('Account Aggregation - Corporate Person',
'Account Aggregation - Workday',
'Eversource Refresh Identity Cubes',
'HR Account Aggregations',
'Perform Identity Request Maintenance',
'Perform Maintenance',
'Account Aggregation - Sumtotal',
'Account Aggregation - ACF2',
'Account Aggregation - RACF',
'Account Group Aggregation - RACF',
'Mainframe Account Aggregations',
'CIP Account Aggregations',
'Account Aggregation - Active Directory - NESD',
'Account Group Aggregation - Active Directory - NESD',
'Account Group Aggregation - Lotus Notes',
'Account Aggregation - Lotus Notes',
'Core Account Aggregations',
'Account Group Aggregation - Continuum',
'Account Aggregation - Continuum',
'Account Group Aggregation - Active Directory - NSTAR',
'Account Group Aggregation - Active Directory - NU',
'Account Aggregation - Active Directory - NSTAR',
'Account Aggregation - Active Directory - NU',
'Account Group Aggregation - Adept Transmission',
'Account Aggregation - RIM',
'Account Aggregation - NSTAR EMS ESAT',
'Account Aggregation - McAfee EPO',
'Account Aggregation - NH ESCC EMS',
'Account Aggregation - Firewalls',
'Account Aggregation - ITSM',
'Account Aggregation - ITAM',
'Account Aggregation - ADEPT Transmission',
'Account Aggregation - ADEPT Facilities',
'Account Aggregation - Andover Continuum',
'Account Group Aggregation - Active Directory ESCC',
'Account Group Aggregation - Active Directory - CVX',
'Account Aggregation - Active Directory - ESCC',
'Account Aggregation - Active Directory - CVX',
'Account Aggregation - Windows Servers (NU Domain)',
'Account Group Aggregation - STORMS Database',
'Account Aggregation - STORMS Database',
'Account Aggregation - STORMS',
'Account Group Aggregation - Oracle eBS Database',
'Account Group Aggregation - Oracle eBS',
'Account Aggregation - Oracle eBS Database',
'Account Aggregation - Oracle eBS Server',
'Account Aggregation - Oracle eBS',
'Eversource - SOX Account Aggregations',
'Account Aggregation - ADABAS Admin',
'Account Aggregation - IDMS',
'Account Aggregation - NSTAR CIS',
'Account Aggregation - Large Power Billing',
'Account Aggregation - Large Customer Billing',
'Account Aggregation - Meter Data Management system',
'Account group Aggregation - Meter Data Management system',
'Account Aggregation - PowerPlan',
'Account group Aggregation - PowerPlan',
'Account Aggregation - PowerPlan Database',
'Account group Aggregation - PowerPlan Database',
'Account Aggregation - Transmission Billing',
'Account group Aggregation - Transmission Billing',
'Account Aggregation - Unvouchered Liability System',
'Account group Aggregation - Unvouchered Liability System'
)", coniiq);
                daiiqtsk = new SqlDataAdapter(cmdiiqtsk);
                daiiqtsk.Fill(dstsk);
                coniiq.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dstsk;
        }
        
        SqlCommand cmdiiqfltsk;
        DataSet dsfltsk = new DataSet();
        SqlDataAdapter daiiqfltsk;
        public DataSet GetFailedTasks()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiq = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiq"].ConnectionString);
                cmdiiqfltsk = new SqlCommand(@"select a.name, cast(messages as xml) as error_message,
 dateadd(s,convert(integer,LEFT(convert(varchar,a.created),10)),'19691231 19:00:00:000') as created,
  dateadd(s,convert(integer,LEFT(convert(varchar,a.completed),10)),'19691231 19:00:00:000') as completed
  from [identityiq].[identityiq].[spt_task_result] as a  
  where completion_status='Error' 
  and dateadd(s,convert(integer,LEFT(convert(varchar,a.completed),10)),'19691231 19:00:00:000') > dateadd(day,-1, cast(getdate() as date))
  order by a.name,a.created desc", coniiq);
                daiiqfltsk = new SqlDataAdapter(cmdiiqfltsk);
                daiiqfltsk.Fill(dsfltsk);
                coniiq.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dsfltsk;
        }
        SqlCommand cmdiiqwar;
        DataSet dswar = new DataSet();
        SqlDataAdapter daiiqwar;
        public DataSet GetWarnings()
        {
            try
            {
                //coniiq = GetConnectionString("conIIQ");
                coniiq = new SqlConnection(ConfigurationManager.ConnectionStrings["coniiq"].ConnectionString);
                cmdiiqwar = new SqlCommand(@"select a.name, cast(messages as xml) as error_message,
 dateadd(s,convert(integer,LEFT(convert(varchar,a.created),10)),'19691231 19:00:00:000') as created,
  dateadd(s,convert(integer,LEFT(convert(varchar,a.completed),10)),'19691231 19:00:00:000') as completed
  from [identityiq].[identityiq].[spt_task_result] as a  
  where completion_status='Warning' 
  and dateadd(s,convert(integer,LEFT(convert(varchar,a.completed),10)),'19691231 19:00:00:000') > dateadd(day,-1, cast(getdate() as date))
  order by a.name,a.created desc", coniiq);
                daiiqwar = new SqlDataAdapter(cmdiiqwar);
                daiiqwar.Fill(dswar);
                coniiq.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            return dswar;
        }
    }

}
