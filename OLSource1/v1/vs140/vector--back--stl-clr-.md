---
title: "vector::back (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::back (STL/CLR)"
f1_keywords: 
  - "cliext::vector::back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back member [STL/CLR]"
ms.assetid: 5edb3fcc-74c5-4f04-b8dd-edab49ba45a0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::back (STL-CLR)
Accesses the last element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reference to the last element of the controlled sequence, which must be non-empty. You use it to access the last element, when you know it exists.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**back() = c**  
 **a b x**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [back_item](../vs140/vector--back_item--stl-clr-.md)   
 [front](../vs140/vector--front--stl-clr-.md)   
 [front_item](../vs140/vector--front_item--stl-clr-.md)