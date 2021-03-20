using System;
using System.Reflection;

namespace Parcial1_AdanArdayaDominguez.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}