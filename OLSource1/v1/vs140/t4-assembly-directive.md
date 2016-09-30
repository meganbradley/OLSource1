---
title: "T4 Assembly Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 44949749-ce3c-4fb5-8690-a17f1564ac2f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Assembly Directive
In a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] design-time text template, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive loads an assembly so that your template code can use its types. The effect is similar to adding an assembly reference in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project.  
  
 For a general overview of writing text templates, see [Writing a Text Template](../vs140/writing-a-t4-text-template.md).  
  
> [!NOTE]
>  You do not need the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive in a run-time (preprocessed) text template. Instead, add the necessary assemblies to the **References** of your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project.  
  
## Using the Assembly Directive  
 The syntax of the directive is as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The assembly name should be one of the following:  
  
-   The strong name of an assembly in the GAC, such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You can also use the long form, such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For more information, see \<xref:System.Reflection.AssemblyName*>.  
  
-   The absolute path of the assembly  
  
 You can use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> syntax to reference [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] variables such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to reference environment variables. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The assembly directive has no effect in a preprocessed text template. Instead, include the necessary references in the **References** section of your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. For more information, see [Generating Files at Runtime](../vs140/run-time-text-generation-with-t4-text-templates.md).  
  
## Standard Assemblies  
 The following assemblies are loaded automatically, so that you do not need to write assembly directives for them:  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 If you use a custom directive, the directive processor might load additional assemblies. For example, if you write templates for a domain-specific language (DSL), you do not need to write assembly directives for the following assemblies:  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
-   The assembly containing your DSL.  
  
##  \<a name="msbuild">\</a> Using project properties in both MSBuild and Visual Studio  
 Visual Studio macros like $(SolutionDir) don’t work in MSBuild. If you want to transform templates in your build machine, you have to use project properties instead.  
  
 Edit your .csproj or .vbproj file to define a project property. This example defines a property named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Now you can use your project property in text templates, which transform correctly in both Visual Studio and MSBuild:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Include Directive](../vs140/t4-include-directive.md)