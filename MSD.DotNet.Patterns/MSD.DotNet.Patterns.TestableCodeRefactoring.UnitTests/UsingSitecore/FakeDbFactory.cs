using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingSitecore;
using Sitecore.Data;
using Sitecore.FakeDb;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.UsingSitecore
{
    public static class FakeDbFactory
    {
        public static Db CreateDbWithoutNewsRoot()
        {
            return new Db { new DbItem("Home") };
        }

        public static Db CreateDbWithNewsRoot()
        {
            return new Db
            {
                new DbTemplate("NewsItemRoot", Templates.NewsItemRoot.TemplateId),
                new DbItem("Home")
                {
                    new DbItem("News", ID.NewID, Templates.NewsItemRoot.TemplateId)
                }
            };
        }
    }
}
