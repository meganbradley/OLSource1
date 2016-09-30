---
title: "hash_set::bucket_count (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::bucket_count (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_count member [STL/CLR]"
ms.assetid: 3ff49f99-b70d-4455-93e8-2bdc983a0e67
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::bucket_count (STL-CLR)
Counts the number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member functions returns the current number of buckets. You use it to determine the size of the hash table.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
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
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [load_factor](../vs140/hash_set--load_factor--stl-clr-.md)   
 [max_load_factor](../vs140/hash_set--max_load_factor--stl-clr-.md)