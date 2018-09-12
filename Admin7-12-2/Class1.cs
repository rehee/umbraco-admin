using Examine;
using Examine.SearchCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoExamine;

namespace System
{
  public static class Class1
  {
    public static void a()
    {
     
      var criteria = ExamineManager.Instance.DefaultSearchProvider.CreateSearchCriteria(IndexTypes.Content);
      //var query = criteria.Field("nodeTypeAlias", "home");
      //var query = criteria.Field("title", "home");
      //var query = criteria.Id(1602);
      var query = criteria.Range("ParentId", -2,0);

      //criteria.Field("id")
      //  IExamineValue
      //var test = ExamineManager.Instance.Search("ParentId == -1",true).ToList();
      var test = ExamineManager.Instance.Search(query.Compile()).ToList();
      var a = 1;
    }
  }
}