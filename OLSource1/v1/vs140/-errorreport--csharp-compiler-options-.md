---
title: "-errorreport (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/errorreport (C# Compiler Options)"
f1_keywords: 
  - "/errorreport"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "-errorreport compiler option [C#]"
  - "errorreport compiler option [C#]"
  - "/errorreport compiler option [C#]"
ms.assetid: bd0e7493-b79d-4369-9c3f-ba26ebdfbedf
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -errorreport (C# Compiler Options)
This option provides a convenient way to report a C# internal compiler error to Microsoft.  
  
> [!NOTE]
>  On Windows Vista and Windows Server 2008, the error reporting settings that you make for Visual Studio do not override the settings made through Windows Error Reporting (WER). WER settings always take precedence over Visual Studio error reporting settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 **none**  
 Reports about internal compiler errors will not be collected or sent to Microsoft.  
  
 **prompt**  
 Prompts you to send a report when you receive an internal compiler error. **prompt** is the default when you compile an application in the development environment.  
  
 **queue**  
 Queues the error report. When you log on with administrative credentials, you can report any failures since the last time that you were logged on. You will not be prompted to send reports for failures more than once every three days. **queue** is the default when you compile an application at the command line.  
  
 **send**  
 Automatically sends reports of internal compiler errors to Microsoft. To enable this option, you must first agree to the Microsoft data collection policy. The first time that you specify **/errorreport:send** on a computer, a compiler message will refer you to a Web site that contains the Microsoft data collection policy.  
  
 This option depends on registry settings. For information about how to set the appropriate values in the registry, see [How to Turn on Automatic Error Reporting in Visual Studio 2008 Command-line Tools](http://go.microsoft.com/fwlink/?LinkID=184695) on the MSDN Web site.  
  
## Remarks  
 An internal compiler error (ICE) results when the compiler cannot process a source code file. When an ICE occurs, the compiler does not produce an output file or any useful diagnostic that you can use to fix your code.  
  
 In previous releases, when you received an ICE, you were encouraged to contact Microsoft Product Support Services to report the problem. By using **/errorreport**, you can provide ICE information to the Visual C# team. Your error reports can help improve future compiler releases.  
  
 A user's ability to send reports depends on computer and user policy permissions.  
  
 For more information about error debugger, see [Description of the Dr. Watson for Windows (Drwtsn32.exe) Tool](http://go.microsoft.com/fwlink/?LinkId=147286).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page. For more information, see [Build Page, Project Designer (C#)](../vs140/build-page--project-designer--csharp-.md).  
  
2.  Click the **Build** property page.  
  
3.  Click the **Advanced** button.  
  
4.  Modify the **Internal Compiler Error Reporting** property.  
  
 For information about how to set this compiler option programmatically, see \<xref:VSLangProj80.CSharpProjectConfigurationProperties3.ErrorReport*>.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)