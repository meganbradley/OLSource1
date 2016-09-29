---
title: "Compiler Warning (level 3) CS1700"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1700"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1700"
ms.assetid: fcd38d68-e34b-4f87-8290-444e66886597
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS1700
Assembly reference Assembly Name is invalid and cannot be resolved  
  
 This warning indicates that an attribute, such as <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*>, was not specified correctly.  
  
 For more information, see [Friend Assemblies (C# Programming Guide)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
## Example  
 The following sample generates CS1700.  
  
```  
// CS1700.cs  
// compile with: /target:library  
using System.Runtime.CompilerServices;  
[assembly:InternalsVisibleTo("app2, Retargetable=f")]   // CS1700  
[assembly:InternalsVisibleTo("app2")]   // OK  
```