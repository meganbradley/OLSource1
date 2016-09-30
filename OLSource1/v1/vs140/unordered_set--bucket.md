---
title: "unordered_set::bucket"
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
  - "bucket"
  - "unordered_set.bucket"
  - "unordered_set/std::tr1::unordered_set::bucket"
  - "std.tr1.unordered_set.bucket"
  - "unordered_set::bucket"
  - "std::tr1::unordered_set::bucket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket method [TR1]"
ms.assetid: d7680cc8-c009-4384-a922-7370be65a1ce
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::bucket
Gets the bucket number for a key value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value to map.  
  
## Remarks  
 The member function returns the bucket number currently corresponding to the key value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
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
 [unordered_set::bucket_count](../vs140/unordered_set--bucket_count.md)   
 [unordered_set::bucket_size](../vs140/unordered_set--bucket_size.md)