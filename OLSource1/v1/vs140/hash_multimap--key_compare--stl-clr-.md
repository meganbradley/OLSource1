---
title: "hash_multimap::key_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::key_compare (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare member [STL/CLR]"
ms.assetid: 011f5bc3-0e40-48fe-9d6f-f6960210a27a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::key_compare (STL-CLR)
The ordering delegate for two keys.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its key arguments.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = True**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**  
**compare(L'a', L'a') = False**  
**compare(L'a', L'b') = False**  
**compare(L'b', L'a') = True**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [key_comp](../vs140/hash_multimap--key_comp--stl-clr-.md)   
 [key_type](../vs140/hash_multimap--key_type--stl-clr-.md)   
 [value_compare](../vs140/hash_multimap--value_compare--stl-clr-.md)