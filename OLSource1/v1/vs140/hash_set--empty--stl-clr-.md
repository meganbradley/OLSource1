---
title: "hash_set::empty (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::empty (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty member [STL/CLR]"
ms.assetid: 7843eb9a-067b-4339-8637-5401b637c6d0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::empty (STL-CLR)
Tests whether no elements are present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns true for an empty controlled sequence. It is equivalent to [size](../vs140/hash_set--size--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to test whether the hash_set is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**size() = 3**  
**empty() = False**  
**size() = 0**  
**empty() = True**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [size](../vs140/hash_set--size--stl-clr-.md)