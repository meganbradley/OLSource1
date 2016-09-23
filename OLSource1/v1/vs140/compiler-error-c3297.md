---
title: "Compiler Error C3297"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3297
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3297
ms.assetid: 2a718b4c-6cdb-4418-92c0-fc3a259431c4
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3297
'constraint_2' : cannot use 'constraint_1' as a constraint because 'constraint_1' has the value constraint  
  
 Value classes are sealed. If a constraint is a value class, another constraint can never derive from it.  
  
 For more information, see [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md).  
  
## Example  
 The following sample generates C3297.  
  
```  
// C3297.cpp  
// compile with: /clr /c  
generic<class T, class U>  
where T : value class  
where U : T   // C3297  
public ref struct R {};  
```