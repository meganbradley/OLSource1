---
title: "hash_multimap::rbegin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::rbegin (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin member [STL/CLR]"
ms.assetid: f5ce0614-3c73-4cec-9fa2-efadf0fd36c7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::rbegin (STL-CLR)
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
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [begin](../vs140/hash_multimap--begin--stl-clr-.md)   
 [end](../vs140/hash_multimap--end--stl-clr-.md)   
 [rend](../vs140/hash_multimap--rend--stl-clr-.md)