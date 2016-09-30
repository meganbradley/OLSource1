---
title: "vector::size (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::size (STL/CLR)"
f1_keywords: 
  - "cliext::vector::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size member [STL/CLR]"
ms.assetid: 3d2a156e-5871-4441-9307-21a20cd1430f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::size (STL-CLR)
Counts the number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the length of the controlled sequence. You use it to determine the number of elements currently in the controlled sequence. If all you care about is whether the sequence has nonzero size, see [empty](../vs140/vector--empty--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**size() = 3 starting with 3**  
**size() = 0 after clearing**  
**size() = 2 after adding 2**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [empty](../vs140/vector--empty--stl-clr-.md)