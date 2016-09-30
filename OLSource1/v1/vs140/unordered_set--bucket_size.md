---
title: "unordered_set::bucket_size"
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
  - "bucket_size"
  - "std::tr1::unordered_set::bucket_size"
  - "unordered_set/std::tr1::unordered_set::bucket_size"
  - "std.tr1.unordered_set.bucket_size"
  - "unordered_set.bucket_size"
  - "unordered_set::bucket_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket_size method [TR1]"
ms.assetid: dbbacdba-4ab7-44bd-83ca-c956f2b21f29
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::bucket_size
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
  **[c] [b] [a]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::bucket](../vs140/unordered_set--bucket.md)   
 [unordered_set::bucket_count](../vs140/unordered_set--bucket_count.md)