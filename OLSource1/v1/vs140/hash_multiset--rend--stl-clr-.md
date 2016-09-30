---
title: "hash_multiset::rend (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::rend (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend member [STL/CLR]"
ms.assetid: 6d007ac9-18cc-4b51-8384-a4ff65d23e97
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::rend (STL-CLR)
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reverse iterator that points just beyond the beginning of the controlled sequence. Hence, it designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the reverse sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> end of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*-- --rend() = b**  
**\*--rend() = a**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [begin](../vs140/hash_multiset--begin--stl-clr-.md)   
 [end](../vs140/hash_multiset--end--stl-clr-.md)   
 [rbegin](../vs140/hash_multiset--rbegin--stl-clr-.md)