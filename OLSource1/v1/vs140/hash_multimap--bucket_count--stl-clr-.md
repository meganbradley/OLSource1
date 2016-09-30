---
title: "hash_multimap::bucket_count (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::bucket_count (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_count member [STL/CLR]"
ms.assetid: 63b7e08e-16fb-42e5-b592-d1fd29c47637
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::bucket_count (STL-CLR)
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
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [load_factor](../vs140/hash_multimap--load_factor--stl-clr-.md)   
 [max_load_factor](../vs140/hash_multimap--max_load_factor--stl-clr-.md)