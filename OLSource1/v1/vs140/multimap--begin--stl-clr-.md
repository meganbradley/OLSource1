---
title: "multimap::begin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::begin (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin member [STL/CLR]"
ms.assetid: 2e1e48f5-31e5-4ead-abae-bb5220925226
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::begin (STL-CLR)
Designates the beginning of the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a bidirectional iterator that designates the first element of the controlled sequence, or just beyond the end of an empty sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> beginning of the controlled sequence, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**\*begin() = [a 1]**  
**\*++begin() = [b 2]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [end](../vs140/multimap--end--stl-clr-.md)