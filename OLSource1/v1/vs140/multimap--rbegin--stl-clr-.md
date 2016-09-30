---
title: "multimap::rbegin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::rbegin (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin member [STL/CLR]"
ms.assetid: fd5a2a04-b03d-4920-b8f2-e01985cb91e3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::rbegin (STL-CLR)
Designates the beginning of the reversed controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reverse iterator that designates the last element of the controlled sequence, or just beyond the beginning of an empty sequence. Hence, it designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the reverse sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> beginning of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**\*rbegin() = [c 3]**  
**\*++rbegin() = [b 2]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [begin](../vs140/multimap--begin--stl-clr-.md)   
 [end](../vs140/multimap--end--stl-clr-.md)   
 [rend](../vs140/multimap--rend--stl-clr-.md)