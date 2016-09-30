---
title: "unordered_set::begin"
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
  - "unordered_set::begin"
  - "std::tr1::unordered_set::begin"
  - "std.tr1.unordered_set.begin"
  - "unordered_set.begin"
  - "unordered_set/std::tr1::unordered_set::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method [TR1]"
ms.assetid: 76f8a0ad-fb00-495a-a1f5-80911625f6cc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::begin
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
  **[a] [b] [c]**   
 **[a] [b] [c]**   
 **[a] [b]**   
 **[a]**    
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::end](../vs140/unordered_set--end.md)