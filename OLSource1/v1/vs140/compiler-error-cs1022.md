---
title: "Compiler Error CS1022"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1022"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1022"
ms.assetid: 76b9f32b-2ebf-471d-a635-852daf8877d7
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1022
Type or namespace definition, or end-of-file expected  
  
 A source-code file does not have a matching set of braces.  
  
 The following sample generates CS1022:  
  
```  
// CS1022.cs  
namespace x  
{  
}  
}   // CS1022  
```