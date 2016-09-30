---
title: "unordered_map::max_bucket_count"
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
  - "unordered_map/std::tr1::unordered_map::max_bucket_count"
  - "unordered_map.max_bucket_count"
  - "unordered_map::max_bucket_count"
  - "max_bucket_count"
  - "std.tr1.unordered_map.max_bucket_count"
  - "std::tr1::unordered_map::max_bucket_count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_bucket_count method [TR1]"
ms.assetid: 7711ba5c-065d-45e8-a9f5-0750e649e90f
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::max_bucket_count
Gets the maximum number of buckets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
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
 [unordered_map::bucket_count](../vs140/unordered_map--bucket_count.md)