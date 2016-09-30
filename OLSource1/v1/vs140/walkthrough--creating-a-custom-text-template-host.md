---
title: "Walkthrough: Creating a Custom Text Template Host"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "walkthroughs [text templates], custom host"
  - "text templates, custom host walkthrough"
ms.assetid: d00bc366-65ed-4229-885a-196ef9625f05
caps.latest.revision: 55
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Custom Text Template Host
A *text template**host* provides an environment that enables the *text template transformation engine* to run. The host is responsible for managing the engine's interaction with the file system. The engine or *directive processor* that needs a file or an assembly can request a resource from the host. The host can then search directories and the global assembly cache to locate the requested resource. For more information, see [The Text Template Transformation Process](../vs140/the-text-template-transformation-process.md).  
  
 You can write a custom host if you want to use the *text template transformation* functionality from outside [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] or if you want to integrate that functionality into custom tools. To create a custom host, you must create a class that inherits from \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost*>. For the documentation of the individual methods, see \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost*>.  
  
> [!WARNING]
>  If you are writing a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extension or package, consider using the text templating service instead of creating your own host. For more information, see [Invoking the Text Templating Service](../vs140/invoking-text-transformation-in-a-vs-extension.md).  
  
 Tasks illustrated in this walkthrough include the following:  
  
-   Creating a custom text template host.  
  
-   Testing the custom host.  
  
## Prerequisites  
 To complete this walkthrough, you must have the following:  
  
-   Visual Studio 2010 or later  
  
-   Visual Studio SDK  
  
## Creating a Custom Text Template Host  
 In this walkthrough, you create a custom host in an executable application that can be called from the command line. The application accepts a text template file as an argument, reads the template, calls the engine to transform the template, and displays any errors that occur in the command prompt window.  
  
#### To create a custom host  
  
1.  In Visual Studio, create a new Visual Basic or a C# console application named CustomHost.  
  
2.  Add references to the following assemblies:  
  
    -   **Microsoft.VisualStudio.TextTemplating.\*.0**  
  
    -   **Microsoft.VisualStudio.TextTemplating.Interfaces.10.0 and later versions**  
  
3.  Replace the code in the Program.cs or Module1.vb file with the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  For [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] only, open the **Project** menu, and click **CustomHost Properties**. In the **Startup object** list, click **CustomHost.Program**.  
  
5.  On the **File** menu, click **Save All**.  
  
6.  On the **Build** menu, click **Build Solution**.  
  
## Testing the Custom Host  
 To test the custom host, you write a text template, then you run the custom host, pass it the name of the text template, and verify that the template is transformed.  
  
#### To create a text template to test the custom host  
  
1.  Create a text file, and name it <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
     You can use any text editor (for example, Notepad) to create the file.  
  
2.  Add the following to the file:  
  
    > [!NOTE]
    >  The programming language of the text template does not have to match that of the custom host.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  Save and close the file.  
  
#### To test the custom host  
  
1.  Open the Command Prompt window.  
  
2.  Type the path of the executable file for the custom host, but do not press ENTER yet.  
  
     For example, type:  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  Instead of typing the address, you can browse to the file CustomHost.exe in **Windows Explorer** and then drag the file into the Command Prompt window.  
  
3.  Type a space.  
  
4.  Type the path of the text template file, and then press ENTER.  
  
     For example, type:  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  Instead of typing the address, you can browse to the file TestTemplate.tt in **Windows Explorer** and then drag the file into the Command Prompt window.  
  
     The custom host application runs and completes the text template transformation process.  
  
5.  In **Windows Explorer**, browse to the folder that contains the file TestTemplate.tt.  
  
     That folder also contains the file TestTemplate1.txt.  
  
6.  Open this file to see the results of the text template transformation.  
  
     The generated text output appears and looks like this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Next Steps  
 In this walkthrough, you created a text template transformation host that supports the basic transformation functionality. You can expand your host to support text templates that call custom or generated directive processors. For more information, see [Walkthrough: Connecting a Host to a Generated Directive Processor](../vs140/walkthrough--connecting-a-host-to-a-generated-directive-processor.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost*>