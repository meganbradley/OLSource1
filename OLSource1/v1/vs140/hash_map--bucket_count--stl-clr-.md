---
title: "hash_map::bucket_count (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::bucket_count (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_count member [STL/CLR]"
ms.assetid: 67cbcb76-1edd-44a0-8779-fa61410c3aff
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::bucket_count (STL-CLR)
Counts the number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member functions returns the current number of buckets. You use it to determine the size of the hash table.  
  
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
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [load_factor](../vs140/hash_map--load_factor--stl-clr-.md)   
 [max_load_factor](../vs140/hash_map--max_load_factor--stl-clr-.md)