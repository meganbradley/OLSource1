---
title: "unordered_multimap::bucket_size"
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
  - "std::tr1::unordered_multimap::bucket_size"
  - "bucket_size"
  - "unordered_multimap.bucket_size"
  - "unordered_multimap::bucket_size"
  - "unordered_map/std::tr1::unordered_multimap::bucket_size"
  - "std.tr1.unordered_multimap.bucket_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_size method [TR1]"
ms.assetid: d048f746-9d42-4f6b-a84e-36fb9bb42e53
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::bucket_size
Gets the size of a bucket  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bucket number.  
  
## Remarks  
 The member functions returns the size of bucket number <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::bucket](../vs140/unordered_multimap--bucket.md)   
 [unordered_multimap::bucket_count](../vs140/unordered_multimap--bucket_count.md)