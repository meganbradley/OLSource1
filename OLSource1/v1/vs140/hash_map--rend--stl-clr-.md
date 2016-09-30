---
title: "hash_map::rend (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::rend (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend member [STL/CLR]"
ms.assetid: 87fb2a06-c92b-4d86-855d-22f5c04aabdb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::rend (STL-CLR)
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reverse iterator that points just beyond the beginning of the controlled sequence. Hence, it designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the reverse sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> end of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**\*-- --rend() = [b 2]**  
**\*--rend() = [a 1]**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [begin](../vs140/hash_map--begin--stl-clr-.md)   
 [end](../vs140/hash_map--end--stl-clr-.md)   
 [rbegin](../vs140/hash_map--rbegin--stl-clr-.md)