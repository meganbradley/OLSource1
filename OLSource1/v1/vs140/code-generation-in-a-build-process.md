---
title: "Code Generation in a Build Process"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, build tasks"
  - "text templates, transforming by using msbuild"
ms.assetid: 4da43429-2a11-4d7e-b2e0-9e4af7033b5a
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code Generation in a Build Process
[Text transformation](../vs140/code-generation-and-t4-text-templates.md) can be invoked as part of the [build process](assetId:///a971b0f9-7c28-479d-a37b-8fd7e27ef692) of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution. There are build tasks that are specialized for text transformation. The T4 build tasks run design-time text templates, and they also compile run-time (preprocessed) text templates.  
  
 There are some differences in what the build tasks can do, depending on which build engine you use. When you build the solution in Visual Studio, a text template can access the Visual Studio API (EnvDTE) if the [hostspecific="true"](../vs140/t4-template-directive.md) attribute is set. But that isn’t true when you build the solution from the command line or when you initiate a server build through Visual Studio. In those cases, the build is performed by MSBuild and a different T4 host is used.  
  
 This means that you can’t access things like project file names in the same way when you build a text template in MSBuild. However, you can [pass environment information into text templates and directive processors by using build parameters](#parameters).  
  
##  \<a name="buildserver">\</a> Configure your machines  
 To enable build tasks on your development computer, install [Modeling SDK for Visual Studio](http://www.microsoft.com/download/details.aspx?id=40754).  
  
 If [your build server](assetId:///788443c3-0547-452e-959c-4805573813a9) runs on a computer on which [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is not installed, copy the following files to the build computer from your development machine. Substitute the most recent version numbers for ‘*’.  
  
-   $(ProgramFiles)\MSBuild\Microsoft\VisualStudio\v*.0\TextTemplating  
  
    -   Microsoft.VisualStudio.TextTemplating.Sdk.Host.*.0.dll  
  
    -   Microsoft.TextTemplating.Build.Tasks.dll  
  
    -   Microsoft.TextTemplating.targets  
  
-   $(ProgramFiles)\Microsoft Visual Studio *.0\VSSDK\VisualStudioIntegration\Common\Assemblies\v4.0  
  
    -   Microsoft.VisualStudio.TextTemplating.*.0.dll  
  
    -   Microsoft.VisualStudio.TextTemplating.Interfaces.*.0.dll (several files)  
  
    -   Microsoft.VisualStudio.TextTemplating.VSHost.*.0.dll  
  
-   $(ProgramFiles)\Microsoft Visual Studio *.0\Common7\IDE\PublicAssemblies\  
  
    -   Microsoft.VisualStudio.TextTemplating.Modeling.*.0.dll  
  
## To edit the project file  
 You’ll have to edit your project file to configure some of the features in MSBuild.  
  
 In solution explorer, choose **Unload** from the context menu of your project. That allows you to edit the .csproj or .vbproj file in the XML editor.  
  
 When you’ve finished editing, choose **Reload**.  
  
## Import the Text Transformation Targets  
 In the .vbproj or .csproj file, find a line like this:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 \- or -  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 After that line, insert the Text Templating import:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Transforming templates in a build  
 There are some properties that you can insert into your project file to control the transformation task:  
  
-   Run the Transform task at the start of every build:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Overwrite files that are read-only, for example because they are not checked out:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Transform every template every time:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     By default, the T4 MSBuild task regenerates an output file if it is older than its template file, or any files that are included, or any files that have previously been read by the template or by a directive processor that it uses. Notice that this is a much more powerful dependency test than is used by the Transform All Templates command in Visual Studio, which only compares the dates of the template and output file.  
  
 To perform just the text transformations in your project, invoke the TransformAll task:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 To transform a specific text template:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 You can use wildcards in TransformFile:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Source Control  
 There is no specific built-in integration with a source control system. However, you can add your own extensions, for example to check out and check in a generated file.By default, the text transform task avoids overwriting a file that is marked as read- only, and when such a file is encountered, an error is logged in the Visual Studio error list, and the task fails.  
  
 To specify that read-only files should be overwritten, insert this property:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 Unless you customize the postprocessing step, a warning will be logged in the error list when a file is overwritten.  
  
## Customizing the build process  
 Text transformation happens before other tasks in the build process. You can define tasks that are invoked before and after transformation, by setting the properties <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, you can reference lists of files:  
  
-   GeneratedFiles - a list of files written by the process. For those files that overwrote existing read-only files, %(GeneratedFiles.ReadOnlyFileOverwritten) will be true. These files can be checked out of source control.  
  
-   NonGeneratedFiles - a list of read-only files that were not overwritten.  
  
 For example, you define a task to check out GeneratedFiles.  
  
## OutputFilePath and OutputFileName  
 These properties are used only by MSBuild. They do not affect code generation in Visual Studio. They redirect the generated output file to a different folder or file. The target folder must already exist.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A useful folder to redirect to is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 If you specify and output filename, it will take precedence over the extension specified in the output directive in the templates.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifying an OutputFileName or OutputFilePath isn’t recommended if you are also transforming templates inside VS using Transform All, or running the single file generator. You will end up with different file paths depending on how you triggered the transformation. This can be very confusing.  
  
## Adding reference and include paths  
 The host has a default set of paths where it searches for assemblies referenced in templates. To add to this set:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To set the folders that will be searched for include files, provide a semicolon-separated list. Usually you add to the existing folder list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="parameters">\</a> Pass build context data into the templates  
 You can set parameter values in the project file. For example, you can pass [build properties](../vs140/msbuild-properties.md) and [environment variables](../vs140/how-to--use-environment-variables-in-a-build.md):  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 In a text template, set <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in the template directive. Use the [parameter](../vs140/t4-parameter-directive.md) directive to get values:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 In a directive processor, you can call \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost.ResolveParameterValue*>:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
> [!NOTE]
>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> gets data from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> only when you use MSBuild. When you transform the template using Visual Studio, the parameters will have default values.  
  
##  \<a name="msbuild">\</a> Using project properties in assembly and include directives  
 Visual Studio macros like $(SolutionDir) don’t work in MSBuild. You can use project properties instead.  
  
 Edit your .csproj or .vbproj file to define a project property. This example defines a property named <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Now you can use your project property in assembly and include directives:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 These directives get values from T4parameterValues both in MSBuild and in Visual Studio hosts.  
  
## Q & A  
 **Why would I want to transform templates in the build server? I already transformed templates in Visual Studio before I checked in my code.**  
  
 If you update an included file, or another file read by the template, Visual Studio doesn’t transform the file automatically. Transforming templates as part of the build makes sure that everything’s up to date.  
  
 **What other options are there for transforming text templates?**  
  
-   The [TextTransform utility](../vs140/generating-files-with-the-texttransform-utility.md) can be used in command scripts. In most cases, it’s easier to use MSBuild.  
  
-   [Invoking T4 in a VS Extension](../vs140/invoking-text-transformation-in-a-vs-extension.md)  
  
-   [Design-time text templates](../vs140/design-time-code-generation-by-using-t4-text-templates.md) are transformed by Visual Studio.  
  
-   [Run time text templates](../vs140/run-time-text-generation-with-t4-text-templates.md) are transformed at run time in your application.  
  
## Read more  
 There is good guidance in the T4 MSbuild template, $(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets  
  
 [Writing a text template](../vs140/writing-a-t4-text-template.md)  
  
 [Visual Studio Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=185579)  
  
 [Oleg Sych: Understanding T4:MSBuild Integration](http://www.olegsych.com/2010/04/understanding-t4-msbuild-integration/)