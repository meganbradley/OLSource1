---
title: "-nowarn (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/nowarn (C# Compiler Options)"
f1_keywords: 
  - "/nowarn"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "nowarn compiler option [C#]"
  - "/nowarn compiler option [C#]"
  - "-nowarn compiler option [C#]"
ms.assetid: 6dcbc5e8-ae67-4566-9df3-f63cfdd9c4e4
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -nowarn (C# Compiler Options)
The **/nowarn** option lets you suppress the compiler from displaying one or more warnings. Separate multiple warning numbers with a comma.  
  
## Syntax  
  
```  
/nowarn:number1[,number2,...]  
```  
  
## Arguments  
 `number1`, `number2`  
 Warning number(s) that you want the compiler to suppress.  
  
## Remarks  
 You should only specify the numeric part of the warning identifier. For example, if you want to suppress CS0028, you could specify `/nowarn:28`.  
  
 The compiler will silently ignore warning numbers passed to `/nowarn` that were valid in previous releases, but that have been removed from the compiler. For example, CS0679 was valid in the compiler in Visual Studio .NET 2002 but was subsequently removed.  
  
 The following warnings cannot be suppressed by the `/nowarn` option:  
  
-   Compiler Warning (level 1) CS2002  
  
-   Compiler Warning (level 1) CS2023  
  
-   Compiler Warning (level 1) CS2029  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the **Properties** page for the project. For details, see [Build Page, Project Designer (C#)](../VS_csharp/build-page--project-designer--csharp-.md).  
  
2.  Click the **Build** property page.  
  
3.  Modify the **Suppress Warnings** property.  
  
 For information about how to set this compiler option programmatically, see <xref:VSLangProj80.ProjectProperties3.DelaySign*>.  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)   
 [C# Compiler Errors and Warnings](../VS_csharp/csharp-compiler-errors.md)