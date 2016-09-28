---
title: "-bugreport (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/bugreport (C# Compiler Options)"
f1_keywords: 
  - "/bugreport"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/bugreport compiler option [C#]"
  - "-bugreport compiler option [C#]"
  - "bugreport compiler option [C#]"
ms.assetid: f39665e3-4f6f-4357-88a2-3274c7bec0c1
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -bugreport (C# Compiler Options)
Specifies that debug information should be placed in a file for later analysis.  
  
## Syntax  
  
```  
/bugreport:file  
```  
  
## Arguments  
 `file`  
 The name of the file that you want to contain your bug report.  
  
## Remarks  
 The **/bugreport** option specifies that the following information should be placed in `file`:  
  
-   A copy of all source code files in the compilation.  
  
-   A listing of the compiler options used in the compilation.  
  
-   Version information about your compiler, run time, and operating system.  
  
-   Referenced assemblies and modules, saved as hexadecimal digits, except assemblies that ship with the .NET Framework and SDK.  
  
-   Compiler output, if any.  
  
-   A description of the problem, which you will be prompted for.  
  
-   A description of how you think the problem should be fixed, which you will be prompted for.  
  
 If this option is used with **/errorreport:prompt** or **/errorreport:send**, the information in the file will be sent to Microsoft Corporation.  
  
 Because a copy of all source code files will be placed in `file`, you might want to reproduce the suspected code defect in the shortest possible program.  
  
 This compiler option is unavailable in Visual Studio and cannot be changed programmatically.  
  
 Notice that contents of the generated file expose source code that could result in inadvertent information disclosure.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [/errorreport (Set Error Reporting Behavior)](../vs140/-errorreport--csharp-compiler-options-.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)