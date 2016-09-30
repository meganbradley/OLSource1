---
title: "operator!= (&lt;utility&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "utility/std::operator!="
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, pair objects"
  - "operator !=, pair objects"
ms.assetid: 7bb869b7-8dca-41a5-b4fc-01cbb98ff8f3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;utility&gt;)
Tests if the pair object on the left side of the operator is not equal to the pair object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type **pair.**  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the pairs are not equal; **false** if the pairs are equal.  
  
## Remarks  
 One pair is equal to another pair if each of their respective elements is equal. Two pairs are unequal if either the first or the second element of one is not equal to the corresponding element of the other pair.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The pair p1 is: ( 10, 0.111 ).**  
**The pair p2 is: ( 1000, 0.00111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pairs p1 and p2 are not equal.**  
**The pairs p1 and p3 are equal.**   
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std