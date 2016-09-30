---
title: "unordered_multiset::rehash"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::tr1::unordered_multiset::rehash"
  - "unordered_multiset.rehash"
  - "unordered_set/std::tr1::unordered_multiset::rehash"
  - "unordered_multiset::rehash"
  - "std.tr1.unordered_multiset.rehash"
  - "rehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rehash method [TR1]"
ms.assetid: 0ade6ee1-c520-41e8-975a-3d77983fdc5e
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::rehash
Rebuilds the hash table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
## Remarks  
 The member function alters the number of buckets to be at least <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_load_factor() == 0.1**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::max_load_factor](../vs140/unordered_multiset--max_load_factor.md)