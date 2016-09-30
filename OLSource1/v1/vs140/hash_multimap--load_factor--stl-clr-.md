---
title: "hash_multimap::load_factor (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::load_factor (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor member [STL/CLR]"
ms.assetid: c4b34387-fe76-405d-bead-a092b4571631
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::load_factor (STL-CLR)
Counts the average elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[size](../vs140/hash_multimap--size--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [bucket_count](../vs140/hash_multimap--bucket_count--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the average bucket size.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 4**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 0.25**  
**bucket_count() = 128**  
**load_factor() = 0.0234375**  
**max_load_factor() = 0.25**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [bucket_count](../vs140/hash_multimap--bucket_count--stl-clr-.md)   
 [max_load_factor](../vs140/hash_multimap--max_load_factor--stl-clr-.md)