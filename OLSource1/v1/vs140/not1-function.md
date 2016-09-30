---
title: "not1 Function"
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
  - "std.not1"
  - "std::not1"
  - "not1"
  - "xfunctional/std::not1"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not1 function"
  - "not1"
ms.assetid: 81933163-806a-4c36-938b-4c95c327473f
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not1 Function
Returns the complement of a unary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unary predicate to be negated.  
  
## Return Value  
 A unary predicate that is the negation of the unary predicate modified.  
  
## Remarks  
 If a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is constructed from a unary predicate **Pred**(*x*), then it returns **! Pred**(*x*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector v1 = ( 0 5 10 15 20 25 30 35 )**  
**The number of elements in v1 greater than 10 is: 5.**  
**The number of elements in v1 not greater than 10 is: 3.**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)