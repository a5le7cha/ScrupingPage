using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    public class Activity
    {
        public string activityCode { get; set; }
        public string activityName { get; set; }
        public string activityKind { get; set; }
    }

    public class Contact
    {
        public string phone { get; set; }
        public string site { get; set; }
        public string mail { get; set; }
    }

    public class FacialAccount
    {
        public string kindName { get; set; }
        public string kindCode { get; set; }
        public string num { get; set; }
        public string createDate { get; set; }
        public string closeDate { get; set; }
        public string status { get; set; }
        public string openUfkCode { get; set; }
        public string openUfkName { get; set; }
        public string openTofkName { get; set; }
        public string srvUfkCode { get; set; }
        public string srvUfkName { get; set; }
        public string accountorgcode { get; set; }
        public string accountorgfullname { get; set; }
        public string ppocode { get; set; }
        public string pponame { get; set; }
        public string refopenUfkCode { get; set; }
        public string refsrvUfkCode { get; set; }
    }

    public class Head
    {
        public string fio { get; set; }
        public string post { get; set; }
        public string docName { get; set; }
        public string docNum { get; set; }
        public string docDate { get; set; }
        public string headMain { get; set; }
    }

    public class Info
    {
        public string regNum { get; set; }
        public string code { get; set; }
        public string divisionParentName { get; set; }
        public string divisionParentCode { get; set; }
        public string ogrn { get; set; }
        public string fullName { get; set; }
        public string shortName { get; set; }
        public string inn { get; set; }
        public string kpp { get; set; }
        public string regDate { get; set; }
        public string okopfName { get; set; }
        public string okopfCode { get; set; }
        public string okfsName { get; set; }
        public string okfsCode { get; set; }
        public string postIndex { get; set; }
        public string cityType { get; set; }
        public string cityName { get; set; }
        public string streetType { get; set; }
        public string streetName { get; set; }
        public string house { get; set; }
        public string oktmoName { get; set; }
        public string oktmoCode { get; set; }
        public string orfkName { get; set; }
        public string orfkCode { get; set; }
        public string oksmName { get; set; }
        public string oksmCode { get; set; }
        public string location { get; set; }
        public string kbkName { get; set; }
        public string kbkCode { get; set; }
        public string okoguName { get; set; }
        public string okoguCode { get; set; }
        public string okpoCode { get; set; }
        public string orgTypeName { get; set; }
        public string orgTypeCode { get; set; }
        public string establishmentKindName { get; set; }
        public string establishmentKindCode { get; set; }
        public string legalPersonKindName { get; set; }
        public string legalPersonKindCode { get; set; }
        public string ougvName { get; set; }
        public string ougvCode { get; set; }
        public string uoName { get; set; }
        public string uoCode { get; set; }
        public string creatorKindName { get; set; }
        public string creatorKindCode { get; set; }
        public string creatorPlaceName { get; set; }
        public string creatorPlaceCode { get; set; }
        public string founderKindName { get; set; }
        public string founderKindCode { get; set; }
        public string founderPlaceName { get; set; }
        public string founderPlaceCode { get; set; }
        public string budgetLvlName { get; set; }
        public string budgetLvlCode { get; set; }
        public string budgetName { get; set; }
        public string budgetCode { get; set; }
        public string statusCode { get; set; }
        public string statusName { get; set; }
        public string regionType { get; set; }
        public string regionName { get; set; }
        public string isOGV { get; set; }
        public string isObosob { get; set; }
        public string orgStatus { get; set; }
        public string recordNum { get; set; }
        public string parentCode { get; set; }
        public string parentName { get; set; }
        public string okatoCode { get; set; }
        public string okatoName { get; set; }
        public string guid { get; set; }
        public string status { get; set; }
        public string controlNum { get; set; }
        public string bidNum { get; set; }
        public string firstRegDate { get; set; }
        public string firstRegGuid { get; set; }
        public string lastRegGuid { get; set; }
        public string lastRegDate { get; set; }
        public string lastRegNum { get; set; }
        public string updateReason { get; set; }
        public string updateNum { get; set; }
        public string inclusionDate { get; set; }
        public string exclusionDate { get; set; }
        public string pubpCode { get; set; }
        public string rubpCode { get; set; }
        public string nubpCode { get; set; }
        public string cpzCode { get; set; }
        public string pgmyCode { get; set; }
        public string firmName { get; set; }
        public string kofkCode { get; set; }
        public string nameDocs { get; set; }
        public string accMgmt { get; set; }
        public string naibznachuch { get; set; }
        public string regionCode { get; set; }
        public string areaCode { get; set; }
        public string areaType { get; set; }
        public string areaName { get; set; }
        public string cityCode { get; set; }
        public string localCode { get; set; }
        public string localName { get; set; }
        public string localType { get; set; }
        public string streetCode { get; set; }
        public string building { get; set; }
        public string apartment { get; set; }
        public string reformationDocument { get; set; }
        public string reformationDocumentNum { get; set; }
        public string reformationDocumentDate { get; set; }
        public string reformationName { get; set; }
        public string reformationCode { get; set; }
        public string reformationStartDate { get; set; }
        public string reformationEndDate { get; set; }
        public string dateUpdate { get; set; }
        public string isExcluded { get; set; }
        public string isReorg { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string loadDate { get; set; }
        public string regionKladrCode { get; set; }
        public string egrulnotincluded { get; set; }
        public string parentrecordnum { get; set; }
        public string planningstructuretype { get; set; }
        public string planningstructurename { get; set; }
        public string contourTypeCode { get; set; }
        public string specEventCode { get; set; }
        public string speceventcodedop1 { get; set; }
        public string speceventcodedop2 { get; set; }
        public string speceventcodedop3 { get; set; }
        public string dsp { get; set; }
        public string ppotypecode { get; set; }
        public string ppotypename { get; set; }
        public string isUch { get; set; }
        public string reforfkCode { get; set; }
    }

    public class NonParticipantPermission
    {
        public string name { get; set; }
        public string registryNum { get; set; }
        public string code { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string authBudgName { get; set; }
        public string authBudgCode { get; set; }
        public string authPPOName { get; set; }
        public string authPPOCode { get; set; }
        public string authKBKGlavaName { get; set; }
        public string authKBKGlavaCode { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public Info info { get; set; }
        public List<object> authorities { get; set; }
        public List<Activity> activities { get; set; }
        public List<Head> heads { get; set; }
        public List<Succession> successions { get; set; }
        public List<FacialAccount> facialAccounts { get; set; }
        public List<object> foAccounts { get; set; }
        public List<object> participantPermissions { get; set; }
        public List<NonParticipantPermission> nonParticipantPermissions { get; set; }
        public List<object> procurementPermissions { get; set; }
        public List<Contact> contacts { get; set; }
        public List<object> acceptAuths { get; set; }
        public List<object> transfauth { get; set; }
        public List<object> attachment { get; set; }
        public List<object> contracts { get; set; }
        public List<object> ubptransfauthbp { get; set; }
        public List<object> ubptransfauthbu { get; set; }
        public List<object> ubpfin { get; set; }
        public List<object> ksaccounts { get; set; }
    }

    public class Succession
    {
        public string parentName { get; set; }
        public string parentCode { get; set; }
        public string ogrn { get; set; }
        public string docname { get; set; }
        public string numberdoc { get; set; }
        public string documentdate { get; set; }
        public string datasource { get; set; }
    }


}
