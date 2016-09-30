---
title: "-unsafe (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/unsafe (C# Compiler Options)"
f1_keywords: 
  - "/unsafe"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "-unsafe compiler option [C#]"
  - "unsafe compiler option [C#]"
  - "/unsafe compiler option [C#]"
ms.assetid: fdb77ed9-da03-45bd-bb7f-250704da1bcc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -unsafe (C# Compiler Options)
The **/unsafe** compiler option allows code that uses the [unsafe](../vs140/unsafe--csharp-reference-.md) keyword to compile.  
  
## Syntax  
  
```  
/unsafe  
```  
  
## Remarks  
 For more information about unsafe code, see [Unsafe Code and Pointers (C# Programmer's Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Build** property page.  
  
3.  Select the **Allow Unsafe Code** check box.  
  
 For information about how to set this compiler option programmatically, see \<xref:VSLangProj80.CSharpProjectConfigurationProperties3.AllowUnsafeBlocks*>.  
  
## Example  
 Compile `in.cs` for unsafe mode:  
  
```  
csc /unsafe in.cs  
```  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)