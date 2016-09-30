---
title: "-target:exe (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/target:exe (C# Compiler Options)"
f1_keywords: 
  - "/exe"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "target compiler options [C#], /target:exe"
  - "/target compiler options [C#], /target:exe"
  - "-target compiler options [C#], /target:exe"
ms.assetid: bda5717d-1b91-4848-956b-fcf85c30e432
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -target:exe (C# Compiler Options)
The **/target:exe** option causes the compiler to create an executable (EXE), console application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **/target:exe** option is in effect by default. The executable file will be created with the .exe extension.  
  
 Use [/target:winexe](../vs140/-target-winexe--csharp-compiler-options-.md) to create a Windows program executable.  
  
 Unless otherwise specified with the [/out](../vs140/-out--csharp-compiler-options-.md) option, the output file name takes the name of the input file that contains the [Main](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md) method.  
  
 When specified at the command line, all files up to the next **/out** or **/target:module** option are used to create the .exe file  
  
 One and only one **Main** method is required in the source code files that are compiled into an .exe file. The [/main](../vs140/-main--csharp-compiler-options-.md) compiler option lets you specify which class contains the **Main** method, in cases where your code has more than one class with a **Main** method.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Application** property page.  
  
3.  Modify the **Output type** property.  
  
 For information on how to set this compiler option programmatically, see \<xref:VSLangProj80.ProjectProperties3.OutputType*>.  
  
## Example  
 Each of the following command lines will compile <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, creating <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [/target (C# Compiler Options)](../vs140/-target--csharp-compiler-options-.md)   
 [C# Compiler Options](../vs140/csharp-compiler-options.md)