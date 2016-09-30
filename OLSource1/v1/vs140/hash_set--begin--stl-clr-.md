---
title: "hash_set::begin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::begin (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin member [STL/CLR]"
ms.assetid: 1bd02b6b-0e24-4f42-ad13-fd7776f7f811
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::begin (STL-CLR)
Designates the beginning of the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a bidirectional iterator that designates the first element of the controlled sequence, or just beyond the end of an empty sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> beginning of the controlled sequence, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*begin() = a**  
**\*++begin() = b**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [end](../vs140/hash_set--end--stl-clr-.md)