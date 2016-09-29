---
title: "Compiler Error CS0405"
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
  - "CS0405"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0405"
ms.assetid: 0bf51e24-dc6c-438f-a928-b5bfbf35f81a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0405
Duplicate constraint 'constraint' for type parameter 'type parameter'  
  
 Two of the constraints on the generic declaration are identical. To get rid of the error, remove the duplicate.  
  
 The following sample generates CS0405:  
  
```  
// CS0405.cs  
interface I  
{  
}  
  
class C<T> where T : I, I  // CS0405.cs  
{  
}  
```