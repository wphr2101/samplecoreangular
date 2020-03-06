using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("legis")]
    [ApiController]
    public class LegisController : ControllerBase
    {
        [HttpGet]
        public List<LegislativeElection> Get()
        {
            List<LegislativeElection> legislateList = new List<LegislativeElection>();
            legislateList = GetLegislateList();
            return legislateList;
        }
        private List<LegislativeElection> GetLegislateList()
        {
            List<LegislativeElection> legEle;
            legEle = this.getLegislatives.GetRange(0, getLegislatives.Count);
            return legEle;
        }

        private List<LegislativeElection> getLegislatives = new List<LegislativeElection>()
        {
            new LegislativeElection() { CityDistrict = "基隆市選區", CandidateNumber = 1, CandidateName = "蔡適應", Party = "民主進步黨", Votes = 104082, Elect = true },
            new LegislativeElection() { CityDistrict = "基隆市選區", CandidateNumber = 2, CandidateName = "宋瑋莉", Party = "中國國民黨", Votes = 83689, Elect = false },
            new LegislativeElection() { CityDistrict = "基隆市選區", CandidateNumber = 3, CandidateName = "張耿輝", Party = "無黨籍", Votes = 13374, Elect = false },
            new LegislativeElection() { CityDistrict = "基隆市選區", CandidateNumber = 4, CandidateName = "楊石城", Party = "國會政黨聯盟", Votes = 18942, Elect = false },            
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 1, CandidateName = "王郁揚", Party = "無黨籍", Votes = 4004, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 2, CandidateName = "吳思瑤", Party = "民主進步黨", Votes = 107850, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 3, CandidateName = "李婉鈺", Party = "一邊一國行動黨", Votes = 6636, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 4, CandidateName = "孫士堅", Party = "合一行動聯盟", Votes = 795, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 5, CandidateName = "賴宗育", Party = "人民民主黨", Votes = 1870, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 6, CandidateName = "方儉", Party = "綠黨", Votes = 2203, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第一選區", CandidateNumber = 7, CandidateName = "汪志冰", Party = "中國國民黨", Votes = 83566, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 1, CandidateName = "何志偉", Party = "民主進步黨", Votes = 123652, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 2, CandidateName = "郭啟源", Party = "中華統一促進黨", Votes = 418, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 3, CandidateName = "巫超勝", Party = "宗教聯盟", Votes = 394, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 4, CandidateName = "陳民乾", Party = "一邊一國行動黨", Votes = 1192, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 5, CandidateName = "孫大千", Party = "中國國民黨", Votes = 68667, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第二選區", CandidateNumber = 6, CandidateName = "熊嘉玲", Party = "合一行動聯盟", Votes = 2360, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第三選區", CandidateNumber = 1, CandidateName = "何景榮", Party = "台灣民眾黨", Votes = 5730, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第三選區", CandidateNumber = 2, CandidateName = "吳怡農", Party = "民主進步黨", Votes = 99539, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第三選區", CandidateNumber = 3, CandidateName = "田方宇", Party = "安定力量", Votes = 1209, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第三選區", CandidateNumber = 4, CandidateName = "蔣萬安", Party = "中國國民黨", Votes = 112784, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 1, CandidateName = "郭正典", Party = "一邊一國行動黨", Votes = 1062, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 2, CandidateName = "李彥秀", Party = "中國國民黨", Votes = 118432, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 3, CandidateName = "文祥志", Party = "宗教聯盟", Votes = 246, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 4, CandidateName = "錢一凡", Party = "安定力量", Votes = 1596, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 5, CandidateName = "高嘉瑜", Party = "民主進步黨", Votes = 125138, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 6, CandidateName = "蕭蒼澤", Party = "喜樂島聯盟", Votes = 338, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第四選區", CandidateNumber = 7, CandidateName = "郭佩雯", Party = "綠黨", Votes = 2846, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 1, CandidateName = "楊烱煌", Party = "聾國黨", Votes = 352, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 2, CandidateName = "徐立信", Party = "無黨籍", Votes = 22208, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 3, CandidateName = "林郁方", Party = "中國國民黨", Votes = 76437, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 4, CandidateName = "盧憲孚", Party = "無黨籍", Votes = 385, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 5, CandidateName = "邱一峰", Party = "一邊一國行動黨", Votes = 511, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 6, CandidateName = "林昶佐", Party = "無黨籍", Votes = 81853, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 7, CandidateName = "黃義豐", Party = "無黨籍", Votes = 325, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第五選區", CandidateNumber = 8, CandidateName = "周慶峻", Party = "中華愛國同心黨", Votes = 134, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 1, CandidateName = "沈宜璇", Party = "台灣維新", Votes = 1267, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 2, CandidateName = "楊攸凱", Party = "無黨籍", Votes = 964, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 3, CandidateName = "林奕華", Party = "中國國民黨", Votes = 93785, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 4, CandidateName = "蕭瑞麟", Party = "無黨籍", Votes = 739, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 5, CandidateName = "羅世晧", Party = "勞動黨", Votes = 677, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 6, CandidateName = "謝佩芬", Party = "民主進步黨", Votes = 75718, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 7, CandidateName = "黃典本", Party = "無黨籍", Votes = 177, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 8, CandidateName = "孟藹倫", Party = "中華婦女黨", Votes = 3507, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 9, CandidateName = "張余健", Party = "喜樂島聯盟", Votes = 589, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第六選區", CandidateNumber = 10, CandidateName = "葉日勤", Party = "台灣基進", Votes = 1508, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第七選區", CandidateNumber = 1, CandidateName = "王映心", Party = "台灣基進", Votes = 1979, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第七選區", CandidateNumber = 2, CandidateName = "蔡宜芳", Party = "台灣民眾黨", Votes = 17435, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第七選區", CandidateNumber = 3, CandidateName = "費鴻泰", Party = "中國國民黨", Votes = 85082, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第七選區", CandidateNumber = 4, CandidateName = "許淑華", Party = "民主進步黨", Votes = 79057, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第七選區", CandidateNumber = 5, CandidateName = "蘇伊文", Party = "言論自由聯盟", Votes = 290, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 1, CandidateName = "蕭曉玲", Party = "喜樂島聯盟", Votes = 474, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 2, CandidateName = "華珮君", Party = "台灣動物保護黨", Votes = 7660, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 3, CandidateName = "彭子軒", Party = "無黨籍", Votes = 1324, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 4, CandidateName = "柯士翎", Party = "綠黨", Votes = 2024, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 5, CandidateName = "阮昭雄", Party = "民主進步黨", Votes = 67470, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 6, CandidateName = "賴士葆", Party = "中國國民黨", Votes = 96377, Elect = true },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 7, CandidateName = "顏銘緯", Party = "台灣基進", Votes = 4330, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 8, CandidateName = "李文", Party = "無黨籍", Votes = 1064, Elect = false },
            new LegislativeElection() { CityDistrict = "台北市第八選區", CandidateNumber = 9, CandidateName = "張幸松", Party = "台灣民眾黨", Votes = 12111, Elect = false },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 1, CandidateName = "黃定和", Party = "無黨籍", Votes = 33026, Elect = false },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 2, CandidateName = "陳歐珀", Party = "民主進步黨", Votes = 121526, Elect = true },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 3, CandidateName = "許育嘉", Party = "勞動黨", Votes = 1730, Elect = false },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 4, CandidateName = "林獻山", Party = "台灣維新", Votes = 1618, Elect = false },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 5, CandidateName = "呂國華", Party = "中國國民黨", Votes = 89380, Elect = false },
            new LegislativeElection() { CityDistrict = "宜蘭縣選區", CandidateNumber = 6, CandidateName = "孫博萮", Party = "無黨籍", Votes = 15570, Elect = false },
        };
        
    }
}