---
title: "not2 Function"
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
  - "xfunctional/std::not2"
  - "std::not2"
  - "not2"
  - "std.not2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not2 function"
  - "not2"
ms.assetid: 78ed2ed6-67a8-4892-9222-94039fc36763
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not2 Function
Returns the complement of a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary predicate to be negated.  
  
## Return Value  
 A binary predicate that is the negation of the binary predicate modified.  
  
## Remarks  
 If a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is constructed from a binary predicate **BinPred**(*x*, *y*), then it returns ! **BinPred**(*x*, *y*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original vector v1 = ( 6262 6262 41 18467 6334 26500 19169 )**  
**Sorted vector v1 = ( 41 6262 6262 6334 18467 19169 26500 )**  
**Resorted vector v1 = ( 26500 19169 18467 6334 6262 6262 41 )**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)