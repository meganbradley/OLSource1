---
title: "unordered_multiset::max_bucket_count"
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
  - "unordered_multiset.max_bucket_count"
  - "std.tr1.unordered_multiset.max_bucket_count"
  - "unordered_multiset::max_bucket_count"
  - "unordered_set/std::tr1::unordered_multiset::max_bucket_count"
  - "std::tr1::unordered_multiset::max_bucket_count"
  - "max_bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_bucket_count method [TR1]"
ms.assetid: 0abbed1c-9708-4d98-9e22-e483ee1944b4
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::max_bucket_count
Gets the maximum number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
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
 [unordered_multiset::bucket_count](../vs140/unordered_multiset--bucket_count.md)