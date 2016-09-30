---
title: "unordered_multiset::bucket_count"
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
  - "std::tr1::unordered_multiset::bucket_count"
  - "unordered_multiset.bucket_count"
  - "unordered_set/std::tr1::unordered_multiset::bucket_count"
  - "std.tr1.unordered_multiset.bucket_count"
  - "bucket_count"
  - "unordered_multiset::bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_count method [TR1]"
ms.assetid: 6097faa8-676f-44cf-a5d5-de9f7214f368
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::bucket_count
Gets the number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the current number of buckets.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_bucket_count() == 128**  
**max_load_factor() == 0.1**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::bucket](../vs140/unordered_multiset--bucket.md)   
 [unordered_multiset::bucket_size](../vs140/unordered_multiset--bucket_size.md)   
 [unordered_multiset::load_factor](../vs140/unordered_multiset--load_factor.md)   
 [unordered_multiset::max_load_factor](../vs140/unordered_multiset--max_load_factor.md)