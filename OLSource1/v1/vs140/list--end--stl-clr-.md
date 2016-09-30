---
title: "list::end (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::end (STL/CLR)"
f1_keywords: 
  - "cliext::list::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end member [STL/CLR]"
ms.assetid: c3444164-2c6e-4cbd-8765-1ce7d30fc43e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::end (STL-CLR)
Designates the end of the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a random-access iterator that points just beyond the end of the controlled sequence. You use it to obtain an iterator that designates the end of the controlled sequence; its status doesn not change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*-- --end() = b**  
**\*--end() = c**  
 **a x y**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [back](../vs140/list--back--stl-clr-.md)   
 [back_item](../vs140/list--back_item--stl-clr-.md)   
 [begin](../vs140/list--begin--stl-clr-.md)