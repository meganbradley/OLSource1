---
title: "vector::front (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::front (STL/CLR)"
f1_keywords: 
  - "cliext::vector::front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front member [STL/CLR]"
ms.assetid: 37a36157-8220-4d5b-85b5-c6a63211a322
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::front (STL-CLR)
Accesses the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reference to the first element of the controlled sequence, which must be non-empty. You use it to read or write the first element, when you know it exists.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**front() = a**  
 **x b c**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [back](../vs140/vector--back--stl-clr-.md)   
 [back_item](../vs140/vector--back_item--stl-clr-.md)   
 [front_item](../vs140/vector--front_item--stl-clr-.md)