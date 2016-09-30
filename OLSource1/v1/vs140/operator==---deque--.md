---
title: "operator== (&lt;deque&gt;)"
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
  - "deque/std::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "== operator, with specific standard C++ objects"
  - "operator==, deque objects"
  - "operator ==, deque objects"
ms.assetid: ac48453b-1d26-4776-8eb8-95de2a1d0a00
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;deque&gt;)
Tests if the deque object on the left side of the operator is equal to the deque object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the deque on the left side of the operator is equal to the deque on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between deque objects is based on a pairwise comparison of their elements. Two deques are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The deques are equal.**  
**The deques are not equal.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque::operator== and deque::operator<](../vs140/deque--operator==-and-deque--operator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)