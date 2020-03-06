using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("pres")]
    [ApiController]
    public class PresController : ControllerBase
    {
        [HttpGet]
        public List<PresidentElection> Get()
        {
            List<PresidentElection> presidentList = new List<PresidentElection>();
            GetPresidentList(presidentList);
            return presidentList;
        }

        private List<PresidentElection> GetPresidentList(List<PresidentElection> presidents)
        {            
            PresidentElection peTaipei = new PresidentElection
            {
                City = "台北市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 70769,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 685830,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 875854,
            };
            presidents.Add(peTaipei);
            PresidentElection peNewTaipei = new PresidentElection
            {
                City = "新北市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 112620,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 959631,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 1393936,
            };
            presidents.Add(peNewTaipei);
            PresidentElection peTaoyuan = new PresidentElection
            {
                City = "桃園市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 63132,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 529749,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 718260,
            };
            presidents.Add(peTaoyuan);
            PresidentElection peTaichung = new PresidentElection
            {
                City = "台中市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 84800,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 646366,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 967304,
            };
            presidents.Add(peTaichung);
            PresidentElection peTainan = new PresidentElection
            {
                City = "台南市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 41075,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 339702,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 786471,
            };
            presidents.Add(peTainan);
            PresidentElection peKaohsung = new PresidentElection
            {
                City = "高雄市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 55309,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 610896,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 1097621,
            };
            presidents.Add(peKaohsung);
            PresidentElection peKeelung = new PresidentElection
            {
                City = "基隆市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 11878,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 99360,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 114966,
            };
            presidents.Add(peKeelung);
            PresidentElection peIlang = new PresidentElection
            {
                City = "宜蘭縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 10739,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 90010,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 173657,
            };
            presidents.Add(peIlang);
            PresidentElection peHsinTzu = new PresidentElection
            {
                City = "新竹縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 18435,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 154224,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 152380,
            };
            presidents.Add(peHsinTzu);
            PresidentElection peHTCity = new PresidentElection
            {
                City = "新竹市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 14103,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 102725,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 144274,
            };
            presidents.Add(peHTCity);
            PresidentElection peMiaoLi = new PresidentElection
            {
                City = "苗栗縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 15222,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 164345,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 147034,
            };
            presidents.Add(peMiaoLi);
            PresidentElection peChanghua = new PresidentElection
            {
                City = "彰化縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 35060,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 291835,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 436336,
            };
            presidents.Add(peChanghua);
            PresidentElection peNantou = new PresidentElection
            {
                City = "南投縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 13315,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 133791,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 152046,
            };
            presidents.Add(peNantou);
            PresidentElection peYunlin = new PresidentElection
            {
                City = "雲林縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 15331,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 138341,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 246116,
            };
            presidents.Add(peYunlin);
            PresidentElection peChiayi = new PresidentElection
            {
                City = "嘉義縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 11138,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 98810,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 197342,
            };
            presidents.Add(peChiayi);
            PresidentElection peCYCity = new PresidentElection
            {
                City = "嘉義市",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 6204,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 56269,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 99265,
            };
            presidents.Add(peCYCity);
            PresidentElection pePingtung = new PresidentElection
            {
                City = "屏東縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 14021,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 179353,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 317676,
            };
            presidents.Add(pePingtung);
            PresidentElection peTaitung = new PresidentElection
            {
                City = "台東縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 4163,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 67413,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 44092,
            };
            presidents.Add(peTaitung);
            PresidentElection peHualien = new PresidentElection
            {
                City = "花蓮縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 6869,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 111834,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 66509,
            };
            presidents.Add(peHualien);
            PresidentElection pePenghu = new PresidentElection
            {
                City = "澎湖縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 2583,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 20911,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 27410,
            };
            presidents.Add(pePenghu);
            PresidentElection peKinmen = new PresidentElection
            {
                City = "金門縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 1636,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 35948,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 10456,
            };
            presidents.Add(peKinmen);
            PresidentElection peLienchiang = new PresidentElection
            {
                City = "連江縣",
                Candidate1Name = "宋楚瑜",
                Candidate1Votes = 188,
                Candidate2Name = "韓國瑜",
                Candidate2Votes = 4776,
                Candidate3Name = "蔡英文",
                Candidate3Votes = 1226,
            };
            presidents.Add(peLienchiang);

            return presidents;
        }
    }
}