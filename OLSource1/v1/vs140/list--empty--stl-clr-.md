---
title: "list::empty (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::empty (STL/CLR)"
f1_keywords: 
  - "cliext::list::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty member [STL/CLR]"
ms.assetid: f45edf8a-927d-41ff-9c09-cb0fba4f08b8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::empty (STL-CLR)
Tests whether no elements are present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns true for an empty controlled sequence. It is equivalent to [size](../vs140/list--size--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to test whether the list is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**size() = 3**  
**empty() = False**  
**size() = 0**  
**empty() = True**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [size](../vs140/list--size--stl-clr-.md)