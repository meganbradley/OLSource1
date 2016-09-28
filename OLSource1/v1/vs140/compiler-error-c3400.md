---
title: "Compiler Error C3400"
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
  - "C3400"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3400"
ms.assetid: d44169a8-73b6-4766-b406-b3a6c93f2a4d
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3400
circular constraint dependency involving 'constraint_1' and 'constraint_2'  
  
 The compiler detected circular constraints.  
  
 For more information, see [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md).  
  
## Example  
 The following sample generates C3400.  
  
```  
// C3400.cpp  
// compile with: /clr /c  
generic<class T, class U>  
where T : U  
where U : T   // C3400  
public ref struct R {};  
```