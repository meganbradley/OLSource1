---
title: "vector::rbegin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::rbegin (STL/CLR)"
f1_keywords: 
  - "cliext::vector::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin member [STL/CLR]"
ms.assetid: fad410b9-fe79-4820-9be5-6b7e0219a1af
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::rbegin (STL-CLR)
Designates the beginning of the reversed controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reverse iterator that designates the last element of the controlled sequence, or just beyond the beginning of an empty sequence. Hence, it designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the reverse sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> beginning of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*rbegin() = c**  
**\*++rbegin() = b**  
 **a y x**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [begin](../vs140/vector--begin--stl-clr-.md)   
 [end](../vs140/vector--end--stl-clr-.md)   
 [rend](../vs140/vector--rend--stl-clr-.md)