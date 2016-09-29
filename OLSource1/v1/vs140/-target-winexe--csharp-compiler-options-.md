---
title: "-target:winexe (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/target:winexe (C# Compiler Options)"
f1_keywords: 
  - "/target:winexe"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/target compiler options [C#], /target:winexe"
  - "-target compiler options [C#], /target:winexe"
  - "target compiler options [C#], /target:winexe"
ms.assetid: b5a0619c-8caa-46a5-a743-1cf68408ad7a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -target:winexe (C# Compiler Options)
The **/target:winexe** option causes the compiler to create an executable (EXE), Windows program.  
  
## Syntax  
  
```  
/target:winexe  
```  
  
## Remarks  
 The executable file will be created with the .exe extension. A Windows program is one that provides a user interface from either the .NET Framework library or with the Win32 APIs.  
  
 Use [/target:exe](../vs140/-target-exe--csharp-compiler-options-.md) to create a console application.  
  
 Unless otherwise specified with the [/out](../vs140/-out--csharp-compiler-options-.md) option, the output file name takes the name of the input file that contains the [Main](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md) method.  
  
 When specified at the command line, all files until the next **/out** or [/target](../vs140/-target--csharp-compiler-options-.md) option are used to create the Windows program.  
  
 One and only one **Main** method is required in the source code files that are compiled into an .exe file. The [/main](../vs140/-main--csharp-compiler-options-.md) option lets you specify which class contains the **Main** method, in cases where your code has more than one class with a **Main** method.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Application** property page.  
  
3.  Modify the **Output type** property.  
  
 For information on how to set this compiler option programmatically, see <xref:VSLangProj80.ProjectProperties3.OutputType*>.  
  
## Example  
 Compile `in.cs` into a Windows program:  
  
```  
csc /target:winexe in.cs  
```  
  
## See Also  
 [/target (C# Compiler Options)](../vs140/-target--csharp-compiler-options-.md)   
 [C# Compiler Options](../vs140/csharp-compiler-options.md)