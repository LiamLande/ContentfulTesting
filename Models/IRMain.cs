using Contentful.Core.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Contenful_Test.NewFolder
{
    public class FinanceDocument
    {
        public string? DocumentTitle { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? DocumentYear { get; set; }

        public Asset? Document { get; set; }
    }

    public class SmallInfo
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Value { get; set; }
    }

    public class datelinklink
    {
        public DateTime? Date { get; set; }
        public Asset? Notice { get; set; }
        public Asset? Minutes { get; set; }
    }

    public class IRMain
    {
        public string? Title { get; set; }
        public string? MainTitle { get; set; }
        public string? Subtitle { get; set; }
        public class IntroModel
        {
            public string? Heading { get; set; }
            public string? Body { get; set; }
            public Asset? SideImage { get; set; }
        }

        public IntroModel? Intro { get; set; }
        public class ShareInformationModel
        {
            public string? Header { get; set; }

            public List<SmallInfo>? informationFields { get; set; }
        }
        

        
        public ShareInformationModel? ShareInformation { get; set; }


        public class FinancialCalendarModel
        {
            public string? Title { get; set; }
            public List<SmallInfo>? dates { get; set; }

        }

        public FinancialCalendarModel? FinancialCalendar { get; set; }

        public class FinanceDocsModel 
        {
            public Asset? bgPic { get; set; }
            public string? Title { get; set; }            
            public List<FinanceDocument>? financialDocuments { get; set; }
        }
        public FinanceDocsModel? FinanceDocs { get; set; }
        public class GeneralMeetingsModel 
        {
            public string? Title { get; set; }
            public List<datelinklink>? GeneralMeetings { get; set; }
        }
        public GeneralMeetingsModel? GeneralMeeting { get; set; }
        public class ArticlesOfAssociationModel
        {
            public string? Title { get; set; }
            public Asset? ArticlesOfAssociationPdf { get; set; }
        }
        public ArticlesOfAssociationModel? ArticlesOfAssociation { get; set; }
        public class BoardOfDirectorsModel 
        {
            public string? Header { get; set; }

            public List<SmallInfo>? informationFields { get; set; }
        }
        public BoardOfDirectorsModel? BoardOfDirectors { get; set; }
        public class ContactInfo { }
    }
}
