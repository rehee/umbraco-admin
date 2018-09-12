using Examine;
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
      var query = criteria.Range("Id", 0, 9999);
      var test = ExamineManager.Instance.DefaultSearchProvider.Search(query.Compile()).ToList();
      var a = 1;
    }
  }
}