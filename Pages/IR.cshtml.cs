using Contenful_Test.NewFolder;
using Contentful.Core;
using Contentful.Core.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Contenful_Test.Pages
{
    public class IRModel : PageModel
    {
        private readonly IContentfulClient _contentClient;
        public IRModel(IContentfulClient contentClient)
        {
            _contentClient = contentClient;
        }

        public IRMain MainModel { get; set; }




        public async Task OnGetAsync()
        {


            var builder = QueryBuilder<IRMain>.New.ContentTypeIs("ir").Include(3);
            var entries = await _contentClient.GetEntries(builder);
            MainModel = entries.Items.First();
            // entries.items[0].shareinfo.infofields = foreach smallinfo in 
            // entries would be an IEnumerable of Product
            // note that supplying a QueryBuilder infers the generic argument for the GentEntries method and we no longer need to supply the generic type

        }

        /*
         *  public IR.articlesofassociation  NewsuperMethodThatFetchesWhatIWant(){
         *  contentfulContent = Bring everythign from Contentful(irArticlesofassociation)
         * 
         * var result = new {Title = contentfulContent.Title, Pdf = contentfulContent.ArticlesOfassociationPdf}
         * 
         * return result
         * 
         * }
         * 
         * */


        /*
        *  public IR.irFinancialDocs  NewsuperMethodThatFetchesWhatIWant(){
        *  contentfulContent = Bring everythign from Contentful(irFinancialDocs)
        * 
        * var result = new {Title = contentfulContent.Title, Pdf = contentfulContent.ArticlesOfassociationPdf}
        * 
        * return result
        * 
        * }
        * 
        * */


        //I worked with DEPENDENCY INJECTION 

    }
}
