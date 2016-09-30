---
title: "operator== (&lt;queue&gt;)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, queue objects"
  - "operator==, queue objects"
  - "== operator, with specific standard C++ objects"
ms.assetid: 53f555c2-73d0-4b88-809b-45475dac7630
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;queue&gt;)
Tests if the queue object on the left side of the operator is equal to queue object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type **queue**.  
  
## Return Value  
 **true** if the queues are not equal; **false** if queues are equal.  
  
## Remarks  
 The comparison between queue objects is based on a pairwise comparison of their elements. Two queues are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The queues q1 and q2 are not equal.**  
**The queues q1 and q3 are equal.**   
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)