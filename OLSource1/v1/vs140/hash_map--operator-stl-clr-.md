---
title: "hash_map::operator(STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::operator(STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] member [STL/CLR]"
ms.assetid: b0b8c1bd-4250-447d-9c69-3f8c34e9b6af
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::operator(STL-CLR)
Maps a key to its associated mapped value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member functions endeavors to find an element with equivalent ordering to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If it finds one, it returns the associated mapped value; otherwise, it inserts <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and returns the associated (default) mapped value. You use it to look up a mapped value given its associated key, or to ensure that an entry exists for the key if none is found.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**c1[A] = 0**  
**c1[b] = 2**  
 **[a 1] [A 0] [b 2] [c 3]**  
 **[a 1] [A 10] [b 2] [c 13]**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [find](../vs140/hash_map--find--stl-clr-.md)   
 [insert](../vs140/hash_map--insert--stl-clr-.md)