﻿using System.Net;
using Newtonsoft.Json.Linq;

class BSAPI
{
    // Input APiKey
    private const string APIKey = "qfURoiLJOu4aZTdTE4wpC755fdg2R9QIbRmSKdbc";
    #region 기본적인 정보
    public struct UserStat
    {
        public int seasonId; //Inputed Season ID
        public int userNum; // Inputed user ID, Check What You Inputed
        public matchMode matchingMode; // MatchingMode, Check Enum
        public teamType matchingTeamMode; // TeamType, Check Enum
        public int mmr; // user MMR
        public string rankTier;
        public string nickname; // Nickname of the user
        public int rank; // User ranking (순위)
        public int rankSize; // Total pool of users in the current rank ( 전체 랭크 유저수)
        public long totalGames; // Total played games
        public long totalWins; // Total games ended in 1st place
        public int totalTeamKills; // Total kills scored by the team. (Regardless of the team mode)
        public int totalDeaths; // Total Death
        public int escapeCount; // Total EscapeCount
        public float rankPercent; // Ranking percentile;
        public float averageRank; // 
        public float averageKills;
        public float averageAssistants;
        public float averageHunts;
        public float top1;
        public float top2;
        public float top3;
        public float top5;
        public float top7;
        public characterStat Most1;
        public characterStat Most2;
        public characterStat Most3;

    }

    public struct characterStat
    {
        public characterCode characterCode;
        public int totalGames;
        public long usages;
        public int maxKillings;
        public int top3;
        public int wins;
        public float top3Rate;
        public float averageRank;
    }

    public enum matchMode
    {
        Normal = 2,
        Ranked = 3
    }

    public enum teamType
    {
        Solo = 1,
        Duo = 2,
        Squad = 3
    }

    public enum characterCode
    {
        None = 0,
        Jackie = 1,
        Aya = 2,
        Fiora = 3,
        Magnus = 4,
        Zahir = 5,
        Nadine = 6,
        Hyunwoo = 7,
        Hart = 8,
        Isol = 9,
        LiDailin = 10,
        Yuki = 11,
        Hyejin = 12,
        Xiukai = 13,
        Chiara = 14,
        Sissela = 15,
        Silvia = 16,
        Adriana = 17,
        Shoichi = 18,
        Emma = 19,
        Lenox = 20,
        Rozzi = 21,
        Luke = 22,
        Cathy = 23,
        Adela = 24,
        Bernice = 25,
        Barbara = 26,
        Alex = 27,
        Sua = 28,
        Leon = 29,
        Eleven = 30,
        Rio = 31,
        William = 32,
        Nicky = 33,
        Nathapon = 34,
        Jan = 35,
        Eva = 36,
        Daniel = 37,
        Jenny = 38,
        Camilo = 39,
        Chloe = 40,
        Johann = 41,
        Bianca = 42,
        Celine = 43,
        Echion = 44,
        Mai = 45,
        Aiden = 46,
        Laura = 47,
        Tia = 48,
        Felix = 49,
        Elena = 50,
        Priya = 51,
        Adina = 52,
        Markus = 53,
        Karla = 54,
        Estelle = 55,
        Piolo = 56,
        Martina = 57,
        Haze = 58,
        Isaac = 59,
        Tazia = 60,
        Irem = 61,
        Theodore = 62,
        Lyanh = 63,
        Vanya = 64,
        DebiMarlene = 65,
        Arda = 66,
        Abigail = 67,
        Alonso = 68,
        Leni = 69,
        Tsubame = 70,
        Kenneth = 71,
        Katja = 72,
        Charlotte = 73,
        Darko = 74,
        Lenore = 75,
    }
    #endregion
    public static Dictionary<characterCode, string> CharacterStringTable = new Dictionary<characterCode, string>();
    public static int Mithril = 0;
    public static int Eternity = 0;

    /// <summary>
    /// Find User ID, Return Integer Value;
    /// </summary>
    /// <param name="_userName"></param>
    /// <returns></returns>
    public static int GetUserNum(string _userName)
    {
        string url = $"https://open-api.bser.io/v1/user/nickname?query={_userName}";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            Console.WriteLine(ret);

            if ((int)ret["code"] == 200)
            {
                return (int)ret["user"]["userNum"];
            }
            else
            {
                return -1;
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        return 0;
    }

    /// <summary>
    /// Find In-Game Data
    /// </summary>
    /// <param name="_metaType">Meta Type, 'hash' to Find All Type</param>
    public static void GetGameData(string _metaType)
    {
        string url = $"https://open-api.bser.io/v2/data/{_metaType}";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            Console.WriteLine(ret);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

    }

    /// <summary>
    /// Return Current Season ID
    /// </summary>
    /// <returns></returns>
    public static int GetCurSeasonNum()
    {
        string url = $"https://open-api.bser.io/v2/data/Season";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            if ((int)ret["code"] == 200)
            {
                foreach (JObject j in ret["data"])
                {
                    if ((int)j["isCurrent"] == 1)
                    {
                        return (int)j["seasonID"];
                    }
                }
            }
            else
            {
                return -1;
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        return 0;

    }

    /// <summary>
    /// Get User Season Stat, It Return UserStat struct
    /// </summary>
    /// <param name="_seasonId"> Input SeaseonId, Use With GetGameData or GetCurSeasonNum</param>
    /// <param name="_userNum"> Input, User Id, Use With GetUserNum</param>
    /// <returns></returns>
    public static UserStat GetUserStat(int _seasonId, int _userNum)
    {
        string url = $"https://open-api.bser.io/v1/user/stats/{_userNum}/{_seasonId}";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            // ret["userStats"][0]["characterStats"][0]
            // userStats는 0번째 인덱스를 가지고 있는 배열이다. (즉, 1칸짜리 배열이라는 의미)
            // 그 안에는 "characterStats"라는 3칸 짜리 배열을 가지고 있다.
            // 단순한 스텟 조회를 위해서라면 앞에서 3칸을 사용하고 3번째 칸의 정보를 다루어야 하고
            // 세부 캐릭터 정보를 알기 위해서는 맨 마지막 인덱스를 활용해야 하고 그 안의 정보를 조회해야 한다.

            //matchMode temp = (matchMode)(int)ret["userStats"][0]["matchingMode"]; << 예제 enum과 연계한 것.

            UserStat temp = new UserStat();
            characterStat[] charstattemp = new characterStat[3];

            var j = ret["userStats"][0];

            temp.seasonId = (int)j["seasonId"];
            temp.userNum = (int)j["userNum"];
            temp.matchingMode = (matchMode)(int)j["matchingMode"];
            temp.matchingTeamMode = (teamType)(int)j["matchingTeamMode"];
            temp.mmr = (int)j["mmr"];
            temp.rankTier = CalcRankTier(temp.mmr);
            temp.nickname = (string)j["nickname"];
            temp.rank = (int)j["rank"];
            temp.rankSize = (int)j["rankSize"];
            temp.totalGames = (int)j["totalGames"];
            temp.totalWins = (int)j["totalWins"];
            temp.totalTeamKills = (int)j["totalTeamKills"];
            temp.totalDeaths = (int)j["totalDeaths"];
            temp.escapeCount = (int)j["escapeCount"];
            temp.rankPercent = (float)j["rankPercent"];
            temp.averageRank = (float)j["averageRank"];
            temp.averageKills = (float)j["averageKills"];
            temp.averageAssistants = (float)j["averageAssistants"];
            temp.averageHunts = (float)j["averageHunts"];
            temp.top1 = (float)j["top1"] * 100;
            temp.top2 = (float)j["top2"] * 100;
            temp.top3 = (float)j["top3"] * 100;
            temp.top5 = (float)j["top5"] * 100;
            temp.top7 = (float)j["top7"] * 100;


            for (int i = 0; i < 3; ++i)
            {
                var jj = ret["userStats"][0]["characterStats"][i];
                charstattemp[i].characterCode = (characterCode)(int)jj["characterCode"];
                charstattemp[i].totalGames = (int)jj["totalGames"];
                charstattemp[i].usages = (int)jj["usages"];
                charstattemp[i].maxKillings = (int)jj["maxKillings"];
                charstattemp[i].top3 = (int)jj["top3"];
                charstattemp[i].wins = (int)jj["wins"];
                charstattemp[i].top3Rate = (float)jj["top3Rate"] * 100;
                charstattemp[i].averageRank = (float)jj["averageRank"];
            }

            temp.Most1 = charstattemp[0];
            temp.Most2 = charstattemp[1];
            temp.Most3 = charstattemp[2];


            //Console.WriteLine(temp.Most1.characterCode);
            //Console.WriteLine(ret["userStats"][0]["characterStats"]);

            return temp;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            UserStat temp = new UserStat();
            temp.nickname = "닉네임 탐지 오류";
            return temp;
        }

    }

    public static void RunRankRate()
    {
        MithrilMMR();
        EternityMMR();
    }
    private static void MithrilMMR()
    {
        int season = GetCurSeasonNum();
        string url = $"https://open-api.bser.io/v1/rank/top/{season}/3";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            if ((int)ret["code"] == 200)
            {
                foreach (JObject j in ret["topRanks"])
                {
                    if ((int)j["rank"] == 700)
                    {
                        Mithril = (int)j["mmr"];
                    }
                }
            }
            else
            {

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

    }
    private static void EternityMMR()
    {
        int season = GetCurSeasonNum();
        string url = $"https://open-api.bser.io/v1/rank/top/{season}/3";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Headers.Add("x-api-key", APIKey);

        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader respStream = new StreamReader(response.GetResponseStream());
            string resp = respStream.ReadToEnd();
            respStream.Close();

            JObject ret = JObject.Parse(resp);

            if ((int)ret["code"] == 200)
            {
                foreach (JObject j in ret["topRanks"])
                {
                    if ((int)j["rank"] == 200)
                    {
                        Eternity = (int)j["mmr"];
                    }
                }
            }
            else
            {

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    public static void InputCharactorKorString()
    {
        CharacterStringTable.Add(characterCode.None, "없음");
        CharacterStringTable.Add(characterCode.Jackie, "재키");
        CharacterStringTable.Add(characterCode.Aya, "아야");
        CharacterStringTable.Add(characterCode.Fiora, "피오라");
        CharacterStringTable.Add(characterCode.Magnus, "매그너스");
        CharacterStringTable.Add(characterCode.Zahir, "자히르");
        CharacterStringTable.Add(characterCode.Nadine, "나딘");
        CharacterStringTable.Add(characterCode.Hyunwoo, "현우");
        CharacterStringTable.Add(characterCode.Hart, "하트");
        CharacterStringTable.Add(characterCode.Isol, "아이솔");
        CharacterStringTable.Add(characterCode.LiDailin, "리다이린");
        CharacterStringTable.Add(characterCode.Hyejin, "혜진");
        CharacterStringTable.Add(characterCode.Yuki, "유키");
        CharacterStringTable.Add(characterCode.Xiukai, "쇼우");
        CharacterStringTable.Add(characterCode.Chiara, "키아라");
        CharacterStringTable.Add(characterCode.Sissela, "시셀라");
        CharacterStringTable.Add(characterCode.Silvia, "실비아");
        CharacterStringTable.Add(characterCode.Adriana, "아드리아나");
        CharacterStringTable.Add(characterCode.Shoichi, "쇼이치");
        CharacterStringTable.Add(characterCode.Emma, "엠마");
        CharacterStringTable.Add(characterCode.Lenox, "레녹스");
        CharacterStringTable.Add(characterCode.Rozzi, "로지");
        CharacterStringTable.Add(characterCode.Luke, "루크");
        CharacterStringTable.Add(characterCode.Cathy, "캐시");
        CharacterStringTable.Add(characterCode.Adela, "아델라");
        CharacterStringTable.Add(characterCode.Bernice, "버니스");
        CharacterStringTable.Add(characterCode.Barbara, "바바라");
        CharacterStringTable.Add(characterCode.Alex, "알렉스");
        CharacterStringTable.Add(characterCode.Sua, "수아");
        CharacterStringTable.Add(characterCode.Leon, "레온");
        CharacterStringTable.Add(characterCode.Eleven, "일레븐");
        CharacterStringTable.Add(characterCode.Rio, "리오");
        CharacterStringTable.Add(characterCode.William, "윌리엄");
        CharacterStringTable.Add(characterCode.Nicky, "니키");
        CharacterStringTable.Add(characterCode.Nathapon, "나타폰");
        CharacterStringTable.Add(characterCode.Jan, "얀");
        CharacterStringTable.Add(characterCode.Eva, "이바");
        CharacterStringTable.Add(characterCode.Daniel, "다니엘");
        CharacterStringTable.Add(characterCode.Jenny, "제니");
        CharacterStringTable.Add(characterCode.Camilo, "카밀로");
        CharacterStringTable.Add(characterCode.Chloe, "클로에");
        CharacterStringTable.Add(characterCode.Johann, "요한");
        CharacterStringTable.Add(characterCode.Bianca, "비앙카");
        CharacterStringTable.Add(characterCode.Celine, "셀린");
        CharacterStringTable.Add(characterCode.Echion, "에키온");
        CharacterStringTable.Add(characterCode.Mai, "마이");
        CharacterStringTable.Add(characterCode.Aiden, "에이든");
        CharacterStringTable.Add(characterCode.Laura, "라우라");
        CharacterStringTable.Add(characterCode.Tia, "띠아");
        CharacterStringTable.Add(characterCode.Felix, "펠릭스");
        CharacterStringTable.Add(characterCode.Elena, "엘레나");
        CharacterStringTable.Add(characterCode.Priya, "프리야");
        CharacterStringTable.Add(characterCode.Adina, "아디나");
        CharacterStringTable.Add(characterCode.Markus, "마커스");
        CharacterStringTable.Add(characterCode.Karla, "칼라");
        CharacterStringTable.Add(characterCode.Estelle, "에스텔");
        CharacterStringTable.Add(characterCode.Piolo, "피올로");
        CharacterStringTable.Add(characterCode.Martina, "마르티나");
        CharacterStringTable.Add(characterCode.Haze, "헤이즈");
        CharacterStringTable.Add(characterCode.Isaac, "아이작");
        CharacterStringTable.Add(characterCode.Tazia, "타지아");
        CharacterStringTable.Add(characterCode.Irem, "이렘");
        CharacterStringTable.Add(characterCode.Theodore, "테오도르");
        CharacterStringTable.Add(characterCode.Lyanh, "이안");
        CharacterStringTable.Add(characterCode.Vanya, "바냐");
        CharacterStringTable.Add(characterCode.DebiMarlene, "데비&마를렌");
        CharacterStringTable.Add(characterCode.Arda, "아르다");
        CharacterStringTable.Add(characterCode.Abigail, "아비게일");
        CharacterStringTable.Add(characterCode.Alonso, "알론소");
        CharacterStringTable.Add(characterCode.Leni, "레니");
        CharacterStringTable.Add(characterCode.Tsubame, "츠바메");
        CharacterStringTable.Add(characterCode.Kenneth, "케네스");
        CharacterStringTable.Add(characterCode.Katja, "카티야");
        CharacterStringTable.Add(characterCode.Charlotte, "샬럿");
        CharacterStringTable.Add(characterCode.Darko, "다르코");
        CharacterStringTable.Add(characterCode.Lenore, "르노어");
    }

    private static string CalcRankTier(int _mmr)
    {

        if (_mmr >= 0 && _mmr <= 199)
        {
            return "아이언4 - " + _mmr;
        }
        else if (_mmr >= 200 && _mmr <= 399)
        {
            return "아이언3 - " + (_mmr - 200);
        }
        else if (_mmr >= 400 && _mmr <= 599)
        {
            return "아이언2 - " + (_mmr - 400);
        }
        else if (_mmr >= 600 && _mmr <= 799)
        {
            return "아이언1 - " + (_mmr - 600);
        }
        else if (_mmr >= 800 && _mmr <= 999)
        {
            return "브론즈4 - " + (_mmr - 800);
        }
        else if (_mmr >= 1000 && _mmr <= 1199)
        {
            return "브론즈3 - " + (_mmr - 1000);
        }
        else if (_mmr >= 1200 && _mmr <= 1399)
        {
            return "브론즈2 - " + (_mmr - 1200);
        }
        else if (_mmr >= 1400 && _mmr <= 1599)
        {
            return "브론즈1 - " + (_mmr - 1400);
        }
        else if (_mmr >= 1600 && _mmr <= 1849)
        {
            return "실버4 - " + (_mmr - 1600);
        }
        else if (_mmr >= 1850 && _mmr <= 2099)
        {
            return "실버3 - " + (_mmr - 1850);
        }
        else if (_mmr >= 2100 && _mmr <= 2349)
        {
            return "실버2 - " + (_mmr - 2100);
        }
        else if (_mmr >= 2350 && _mmr <= 2599)
        {
            return "실버1 - " + (_mmr - 2350);
        }
        else if (_mmr >= 2600 && _mmr <= 2899)
        {
            return "골드4 - " + (_mmr - 2600);
        }
        else if (_mmr >= 2900 && _mmr <= 3199)
        {
            return "골드3 - " + (_mmr - 2900);
        }
        else if (_mmr >= 3200 && _mmr <= 3499)
        {
            return "골드2 - " + (_mmr - 3200);
        }
        else if (_mmr >= 3500 && _mmr <= 3799)
        {
            return "골드1 - " + (_mmr - 3500);
        }
        else if (_mmr >= 3800 && _mmr <= 4149)
        {
            return "플래티넘4 - " + (_mmr - 3800);
        }
        else if (_mmr >= 4150 && _mmr <= 4499)
        {
            return "플래티넘3 - " + (_mmr - 4150);
        }
        else if (_mmr >= 4500 && _mmr <= 4849)
        {
            return "플래티넘2 - " + (_mmr - 4500);
        }
        else if (_mmr >= 4850 && _mmr <= 5199)
        {
            return "플래티넘1 - " + (_mmr - 4850);
        }
        else if (_mmr >= 5200 && _mmr <= 5599)
        {
            return "다이아몬드4 - " + (_mmr - 5200);
        }
        else if (_mmr >= 5600 && _mmr <= 5999)
        {
            return "다이아몬드3 - " + (_mmr - 5600);
        }
        else if (_mmr >= 6000 && _mmr <= 6399)
        {
            return "다이아몬드2 - " + (_mmr - 6000);
        }
        else if (_mmr >= 6400 && _mmr <= 6799)
        {
            return "다이아몬드1 - " + (_mmr - 6400);
        }
        else if (_mmr >= 6800 && _mmr <= Mithril)
        {
            return "미스릴 - " + (_mmr - 6800);
        }
        else if (_mmr >= Mithril && _mmr <= Eternity)
        {
            return "데미갓 - " + (_mmr - 7000);
        }
        else if (_mmr >= Eternity)
        {
            return "이터니티 - " + (_mmr - 7000);
        }
        else
        {
            return "Unknown tier - " + _mmr;
        }
    }
}