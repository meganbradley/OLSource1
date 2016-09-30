---
title: "vector::end (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::end (STL/CLR)"
f1_keywords: 
  - "cliext::vector::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end member [STL/CLR]"
ms.assetid: 21fcaf1b-7f14-4dc4-a312-fa30e631ea0d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::end (STL-CLR)
Designates the end of the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a random-access iterator that points just beyond the end of the controlled sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> end of the controlled sequence, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*-- --end() = b**  
**\*--end() = c**  
 **a x y**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [back](../vs140/vector--back--stl-clr-.md)   
 [back_item](../vs140/vector--back_item--stl-clr-.md)   
 [begin](../vs140/vector--begin--stl-clr-.md)