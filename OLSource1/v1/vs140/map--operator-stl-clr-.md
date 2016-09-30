---
title: "map::operator(STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::operator(STL/CLR)"
f1_keywords: 
  - "cliext::map::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operatormember [] [STL/CLR]"
ms.assetid: 50e494c5-62d4-4469-8da3-7432ee4dff97
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::operator(STL-CLR)
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
 **[A 0] [a 1] [b 2] [c 3]**  
 **[A 10] [a 1] [b 2] [c 13]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [find](../vs140/map--find--stl-clr-.md)   
 [insert](../vs140/map--insert--stl-clr-.md)