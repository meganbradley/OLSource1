---
title: "list::front (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::front (STL/CLR)"
f1_keywords: 
  - "cliext::list::front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front member [STL/CLR]"
ms.assetid: ead6aaaa-b518-4a9c-af80-7189bf872cad
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::front (STL-CLR)
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
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [back](../vs140/list--back--stl-clr-.md)   
 [back_item](../vs140/list--back_item--stl-clr-.md)   
 [front_item](../vs140/list--front_item--stl-clr-.md)