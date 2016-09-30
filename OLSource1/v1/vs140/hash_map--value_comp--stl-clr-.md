---
title: "hash_map::value_comp (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::value_comp (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp member [STL/CLR]"
ms.assetid: b11a2dee-07e8-450c-8f85-979c0a15ae64
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::value_comp (STL-CLR)
Copies the ordering delegate for two element values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the ordering delegate used to order the controlled sequence. You use it to compare two element values.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare([L'a', 1], [L'a', 1]) = True**  
**compare([L'a', 1], [L'b', 2]) = True**  
**compare([L'b', 2], [L'a', 1]) = False**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [value_compare](../vs140/hash_map--value_compare--stl-clr-.md)   
 [value_type](../vs140/hash_map--value_type--stl-clr-.md)