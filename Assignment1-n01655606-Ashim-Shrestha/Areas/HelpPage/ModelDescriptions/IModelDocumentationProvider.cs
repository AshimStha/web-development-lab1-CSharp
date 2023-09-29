using System;
using System.Reflection;

namespace Assignment1_n01655606_Ashim_Shrestha.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}