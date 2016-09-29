---
title: "-pdb (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/pdb (C# Compiler Options)"
f1_keywords: 
  - "/pdb"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "-pdb compiler option [C#]"
  - "pdb compiler option [C#]"
  - "/pdb compiler option [C#]"
ms.assetid: e9d0f96a-5b75-45d6-9765-92538dd5f823
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -pdb (C# Compiler Options)
The **/pdb** compiler option specifies the name and location of the debug symbols file.  
  
## Syntax  
  
```  
/pdb:filename  
```  
  
## Arguments  
 `filename`  
 The name and location of the debug symbols file.  
  
## Remarks  
 When you specify [/debug (Emit Debugging Information) (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md), the compiler will create a .pdb file in the same directory where the compiler will create the output file (.exe or .dll) with a file name that is the same as the name of the output file.  
  
 **/pdb** allows you to specify a non-default file name and location for the .pdb file.  
  
 This compiler option cannot be set in the Visual Studio development environment, nor can it be changed programmatically.  
  
## Example  
 Compile `t.cs` and create a .pdb file called tt.pdb:  
  
```  
csc /debug /pdb:tt t.cs  
```  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)