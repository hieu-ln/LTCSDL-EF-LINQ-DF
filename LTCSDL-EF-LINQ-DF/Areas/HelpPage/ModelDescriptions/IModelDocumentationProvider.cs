using System;
using System.Reflection;

namespace LTCSDL_EF_LINQ_DF.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}