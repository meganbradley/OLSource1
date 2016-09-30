---
title: "unordered_map::bucket_count"
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
  - "unordered_map.bucket_count"
  - "std::tr1::unordered_map::bucket_count"
  - "unordered_map/std::tr1::unordered_map::bucket_count"
  - "unordered_map::bucket_count"
  - "std.tr1.unordered_map.bucket_count"
  - "bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_count method [TR1]"
ms.assetid: 5b2f8daf-2f41-4e48-bc3d-2e2c0f384ad6
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::bucket_count
Gets the number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the current number of buckets.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
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
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::bucket](../vs140/unordered_map--bucket.md)   
 [unordered_map::bucket_size](../vs140/unordered_map--bucket_size.md)   
 [unordered_map::load_factor](../vs140/unordered_map--load_factor.md)   
 [unordered_map::max_load_factor](../vs140/unordered_map--max_load_factor.md)