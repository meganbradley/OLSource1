---
title: "unordered_multimap::bucket"
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
  - "std::tr1::unordered_multimap::bucket"
  - "bucket"
  - "unordered_multimap::bucket"
  - "unordered_map/std::tr1::unordered_multimap::bucket"
  - "std.tr1.unordered_multimap.bucket"
  - "unordered_multimap.bucket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bucket method [TR1]"
ms.assetid: 89d3af9a-28f1-4720-a207-b219f163e07b
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::bucket
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
  **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::bucket_count](../vs140/unordered_multimap--bucket_count.md)   
 [unordered_multimap::bucket_size](../vs140/unordered_multimap--bucket_size.md)