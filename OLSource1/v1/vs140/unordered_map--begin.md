---
title: "unordered_map::begin"
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
  - "std::tr1::unordered_map::begin"
  - "unordered_map.begin"
  - "unordered_map::begin"
  - "unordered_map/std::tr1::unordered_map::begin"
  - "std.tr1.unordered_map.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method [TR1]"
ms.assetid: 1d421596-13ca-4ffb-ade6-d543346acdac
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::begin
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
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::end](../vs140/unordered_map--end.md)