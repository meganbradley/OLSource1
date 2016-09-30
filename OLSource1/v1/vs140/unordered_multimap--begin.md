---
title: "unordered_multimap::begin"
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
  - "unordered_map/std::tr1::unordered_multimap::begin"
  - "unordered_multimap.begin"
  - "unordered_multimap::begin"
  - "std::tr1::unordered_multimap::begin"
  - "std.tr1.unordered_multimap.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method [TR1]"
ms.assetid: a35f3543-3470-4191-86bb-fa77a46a347b
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::begin
Designates the beginning of the controlled sequence or a bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The bucket number.|  
  
## Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (or just beyond the end of an empty bucket).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2]**  
 **[a, 1]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::end](../vs140/unordered_multimap--end.md)