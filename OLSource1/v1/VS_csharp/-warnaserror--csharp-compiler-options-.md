---
title: "-warnaserror (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/warnaserror (C# Compiler Options)"
f1_keywords: 
  - "/warnaserror"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/warnaserror compiler option [C#]"
  - "-warnaserror compiler option [C#]"
  - "warnaserror compiler option [C#]"
ms.assetid: 04680ec3-08d6-4e2e-a274-38310e10e33c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -warnaserror (C# Compiler Options)
The **/warnaserror+** option treats all warnings as errors  
  
## Syntax  
  
```  
/warnaserror[<U>+</U> | -][:warning-list]  
```  
  
## Remarks  
 Any messages that would ordinarily be reported as warnings are instead reported as errors, and the build process is halted (no output files are built).  
  
 By default, **/warnaserror-** is in effect, which causes warnings to not prevent the generation of an output file. **/warnaserror**, which is the same as **/warnaserror+**, causes warnings to be treated as errors.  
  
 Optionally, if you want only a few specific warnings to be treated as errors, you may specify a comma-separated list of warning numbers to treat as errors.  
  
 Use [/warn](../VS_csharp/-warn--csharp-compiler-options-.md) to specify the level of warnings that you want the compiler to display. Use [/nowarn](../VS_csharp/-nowarn--csharp-compiler-options-.md) to disable certain warnings.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Build** property page.  
  
3.  Modify the **Treat Warnings As Errors** property.  
  
     To set this compiler option programmatically, see <xref:VSLangProj80.CSharpProjectConfigurationProperties3.TreatWarningsAsErrors*>.  
  
## Example  
 Compile `in.cs` and have the compiler display no warnings:  
  
```  
csc /warnaserror in.cs  
csc /warnaserror:642,649,652 in.cs  
```  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)