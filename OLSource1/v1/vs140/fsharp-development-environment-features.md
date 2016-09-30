---
title: "F# Development Environment Features"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "development environment [F#]"
  - "Visual Studio, features supported in F#"
  - "IDE [F#]"
  - "Visual F#, features supported"
ms.assetid: e3feeb13-f3ac-49c9-baa9-3292faf3d551
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Development Environment Features
This topic includes information about which features of [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)] are supported in F#.  
  
## Project Features  
 The following table summarizes the templates that are available for use in F# projects. For information about project and item templates, see [NIB Creating Projects from Templates](assetId:///7c36d86a-6b79-4480-8228-0f925f1204b2).  
  
|Template type|Description|Supported templates|  
|-------------------|-----------------|-------------------------|  
|Project templates|Types of projects available in the **New Project** dialog box.|-   F# Application\<br />-   F# Library\<br />-   F# Tutorial\<br />-   F# Portable Library\<br />-   F# Silverlight Library|  
|Item templates|File types available in the **Add New Item** dialog box.|-   F# source file (.fs)\<br />-   F# script (.fsx)\<br />-   F# signature file (.fsi)\<br />-   Configuration file (.config)\<br />-   SQL Database Connection (LINQ-to-SQL type provider)\<br />-   SQL Database Connection (LINQ to Entities type provider)\<br />-   OData Service Connection (LINQ type provider)\<br />-   WSDL Service Connection (type provider)\<br />-   XML file (.xml)\<br />-   Text file|  
  
 To create an application that can run as a standalone executable, choose the F# Application project type. To create a library (that is, a managed assembly or .DLL file) for use on the Windows desktop platform, choose F# Library. To create a portable library that can be used on any supported platform, choose F# Portable Library. F# Portable Library projects reference a version of FSharp.Core.dll (2.3.5.0) that is appropriate to create an F# library that can be used with applications that run on the following platforms: [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps, the .NET Framework 4.5, and Silverlight 5. Older versions of Silverlight aren't supported.  
  
 For more information about the item templates for data access, see [Type Providers](../vs140/type-providers.md).  
  
 The following table summarizes project-properties features supported and not supported in F#. For more information, see [Configuring Projects in F#](../vs140/configuring-projects--fsharp-.md) and [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
|Project setting|Supported in F#?|Notes|  
|---------------------|-----------------------|-----------|  
|Resource files|Yes||  
|Build, debug, and reference settings|Yes||  
|Multitargeting|Yes||  
|Icon and manifest|No|Available through compiler command-line options.|  
|ASP.NET Client Services|No||  
|ClickOnce|No|Use a client project in another .NET Framework language, if applicable.|  
|Strong naming|No|Available through compiler command-line options.|  
|Assembly publishing and versioning|No||  
|Code analysis|No|Code analysis tools can be run manually or as part of a post-build command.|  
|Security (change trust levels)|No||  
  
## Code and Text Editor Features  
 The following features of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] code and text editors are supported in F#. For general information about editing code in Visual Studio, and features of the text editor, see [Code and Text Editor](../vs140/writing-code-in-the-code-and-text-editor.md).  
  
|Feature|Description|Supported in F#?|  
|-------------|-----------------|-----------------------|  
|Automatically comment|Enables you to comment or uncomment sections of code.|Yes|  
|Automatically format|Reformats code with standard indentation and style.|No|  
|Bookmarks|Enables you to save places in the editor.|Yes|  
|Change indentation|Indents or unindents selected lines.|Yes|  
|[Finding and Replacing](../vs140/finding-and-replacing-text.md)|Enables you to search in a file, project, or solution, and potentially change text.|Yes|  
|Go to definition for .NET Framework API|When the cursor is positioned on a .NET Framework API, shows code generated from .NET Framework metadata.|No|  
|Go to definition for user-defined API|When the cursor is on a program entity that you defined, moves the cursor to the location in your code where the entity is defined.|Yes|  
|Go To Line|Enables you to go to a specific line in a file, by line number.|Yes|  
|Navigation bars at top of file|Enables you to jump to locations in code, by, For example, function name.|No|  
|Outlining. See [How to: Outline and Hide Code](../vs140/outlining.md).|Enables you to collapse sections of your code to create a more compact view.|No|  
|Tabify|Converts spaces to tabs.|Yes|  
|Type colorization|Shows defined type names in a special color.|No|  
|Quick Find. See Quick Find, Find and Replace Window.|Enables you to search in a file or project.|Yes, but only to find F# files, not to search within files|  
  
## IntelliSense Features  
 The following table summarizes IntelliSense features supported and not supported in F#. For general information about IntelliSense, see [Using IntelliSense](../vs140/using-intellisense.md).  
  
|Feature|Description|Supported in F#?|  
|-------------|-----------------|-----------------------|  
|Automatically implement interfaces|Generates code stubs for interface methods.|No|  
|Code snippets|Injects code from a library of common coding constructs into topics.|No|  
|Complete Word|Saves typing by completing words and names as you type.|Yes|  
|Consume-first completion mode|When enabled, causes the word completion to select the first match as you type, instead of waiting for you to select one or press <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.|No|  
|Generate code elements|Enables you to generate stub code for a variety of constructs.|No|  
|List Members|When you type the member access operator (.), shows members for a type.|Yes|  
|Organize Usings/Open|Organizes namespaces referenced by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements in C# or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives in F#.|No|  
|Parameter Info|Shows helpful information about parameters as you type a function call.|Yes.|  
|Quick Info|Displays the complete declaration for any identifier in your code.|Yes|  
  
 Refactoring of F# code isn't supported in [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)].  
  
## Debugging Features  
 The following table summarizes features that are available when you debug F# code. For general information about the Visual Studio debugger, see [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md).  
  
|Feature|Description|Supported in F#?|  
|-------------|-----------------|-----------------------|  
|Autos window|Shows automatic or temporary variables.|No|  
|Breakpoints|Enables you to pause code execution at specific points during debugging.|Yes|  
|Conditional breakpoints|Enables breakpoints that test a condition that determines whether execution should pause.|Yes|  
|Edit and Continue|Enables code to be modified and compiled as you debug a running program without stopping and restarting the debugger.|No|  
|Expression evaluator|Evaluates and executes code at run time.|No, but the C# expression evaluator can be used, although you must use C# syntax.|  
|Historical debugging|Enables you to step into previously executed code.|Yes|  
|Locals window|Shows locally defined values and variables.|Yes|  
|Run To Cursor|Enables you to execute code until the line that contains the cursor is reached.|Yes|  
|Step Into|Enables you to advance execution and move into any function call.|Yes|  
|Step Over|Enables you to advance execution in the current stack frame and move past any function call.|Yes|  
  
## Additional Tools  
 The following table summarizes the support for F# in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] tools.  
  
|Tool|Description|Supported in F#?|  
|----------|-----------------|-----------------------|  
|Call Hierarchy|Displays the nested structure of function calls in your code.|No|  
|Code Metrics|Gathers information about your code, such as line counts.|No|  
|Class View|Provides a type-based view of the code in a project.|No|  
|[Error List Window](../vs140/error-list-window.md)|Shows a list of errors in code.|Yes|  
|[F# Interactive (fsi.exe) Reference](../vs140/fsharp-interactive--fsi.exe--reference.md)|Enables you to type (or copy and paste) F# code and run it immediately, independently of the building of your project. The F# Interactive window is a Read, Evaluate, Print Loop (REPL).|Yes|  
|Object Browser|Enables you to view the types in an assembly.|F# types as they appear in compiled assemblies do not appear exactly as you author them. You can browse through the compiled representation of F# types, but you cannot view the types as they appear from F#.|  
|[Output Window](../vs140/output-window.md)|Displays build output.|Yes|  
|Performance analysis|Provides tools for measuring the performance of your code.|Yes|  
|Properties Window|Displays and enables editing of properties of the object in the development environment that has focus.|Yes|  
|[Server Explorer/Database Explorer](assetId:///4ea29b3b-bbb2-45e4-9082-eaf635c41c4d)|Provides ways to interact with a variety of server resources.|Yes|  
|Solution Explorer|Enables you to view and manage projects and files.|Yes|  
|Task List|Enables you to manage work items pertaining to your code.|Yes|  
|Test Projects|Provides features that help you test your code.|No|  
|Toolbox|Displays tabs that contain draggable objects such as controls and sections of text or code.|Yes|  
  
## See Also  
 [Writing F# Programs in Visual Studio](../vs140/using-visual-studio-to-write-fsharp-programs.md)   
 [Configuring Projects in F#](../vs140/configuring-projects--fsharp-.md)