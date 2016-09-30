---
title: "hash_multiset::max_load_factor (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::max_load_factor (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::max_load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_load_factor member [STL/CLR]"
ms.assetid: ca0a6e8e-b889-47e4-9edd-c5a321fdeb8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::max_load_factor (STL-CLR)
Gets or sets the maximum elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 new_factor  
 New maximum load factor to store.  
  
## Remarks  
 The first member function returns the current stored maximum load factor. You use it to determine the maximum average bucket size.  
  
 The second member function replaces the store maximum load factor with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. No automatic rehashing occurs until a subsequent insert.  
  
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
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [bucket_count](../vs140/hash_multiset--bucket_count--stl-clr-.md)   
 [load_factor](../vs140/hash_multiset--load_factor--stl-clr-.md)   
 [rehash](../vs140/hash_multiset--rehash--stl-clr-.md)