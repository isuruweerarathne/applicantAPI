using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicantAPI_1._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace ApplicantAPI_1._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountTypeController : ControllerBase
    {
        string connectionString = @"Server=mssql7.websitelive.net;
Database=Anthony_TalentRecognition;
Persist Security Info=False;
User ID = Anthony_Isuru; Password=Tal5nt_1suru;";

        [HttpGet]
        public v_ApplicantForm_FieldPop Get()
        {
            //using (var context = new Anthony_TalentRecognitionContext())
            //{
            //    return context.AccountType.ToList();
            //}


            var con = new SqlConnection(connectionString);
            con.Open();
            var command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select * from [Anthony_TRMaster].[v_ApplicantForm_FieldPop] ";
            var result = command.ExecuteReader();
            v_ApplicantForm_FieldPop model = new v_ApplicantForm_FieldPop();
            if (result.HasRows)
            {
                //Already token exists
                while (result.Read())
                {
                    //model.Link = Convert.ToInt32(result["Link"].ToString());
                    model.Pages = Convert.ToInt32(result["Pages"].ToString());
                    model.Link = result["Link"].ToString();
                    model.Campaign_ID = Convert.ToInt32(result["Campaign_ID"].ToString());
                    model.CompanyAccount = Convert.ToInt32(result["CompanyAccount"].ToString());
                    model.CompanyName = result["CompanyName"].ToString();
                    model.AdvertTitle = result["AdvertTitle"].ToString();
                    model.Para2 = result["Para2"].ToString();
                    model.CampaignQuestion1 = result["CampaignQuestion1"].ToString();
                    model.CampaignQuestion2 = result["CampaignQuestion2"].ToString();
                    model.CampaignQuestion3 = result["CampaignQuestion3"].ToString();
                    model.CampaignQuestion4 = result["CampaignQuestion4"].ToString();
                    model.VacOpen = Convert.ToInt32(result["VacOpen"].ToString());
                }                
            }
            return model;
        }
    }
}
