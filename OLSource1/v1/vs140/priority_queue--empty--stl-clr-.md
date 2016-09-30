---
title: "priority_queue::empty (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::empty (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty member [STL/CLR]"
ms.assetid: bb2bc4cf-395f-4c4f-b432-550b85e1865d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::empty (STL-CLR)
Tests whether no elements are present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns true for an empty controlled sequence. It is equivalent to [size](../vs140/priority_queue--size--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to test whether the priority_queue is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **c a b**  
**size() = 3**  
**empty() = False**  
**size() = 0**  
**empty() = True**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [size](../vs140/priority_queue--size--stl-clr-.md)