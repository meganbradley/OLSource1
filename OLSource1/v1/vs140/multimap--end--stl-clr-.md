---
title: "multimap::end (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::end (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end member [STL/CLR]"
ms.assetid: 8d3f9347-794d-4bd3-9bd1-50534fcf4ffe
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::end (STL-CLR)
Designates the end of the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a bidirectional iterator that points just beyond the end of the controlled sequence. You use it to obtain an iterator that designates the end of the controlled sequence; its status doesn not change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**\*-- --end() = [b 2]**  
**\*--end() = [c 3]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [begin](../vs140/multimap--begin--stl-clr-.md)