---
title: "Compiler Error C3551"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3551"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3551"
ms.assetid: c8ee23da-6568-40db-93a6-3ddb7ac47712
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3551
"expected a late specified return type"  
  
 If you use the `auto` keyword as a placeholder for the return type of a function, you must provide a late-specified return type. In the following example, the late-specified return type of function `myFunction` is a pointer to an array of four elements of type `int`.  
  
```  
auto myFunction()->int(*)[4];   
```  
  
## See Also  
 [auto Keyword (Type Deduction)](../vs140/auto--c---.md)