---
title: "atomic::is_lock_free Method"
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
  - "atomic/std::atomic::is_lock_free"
dev_langs: 
  - "C++"
ms.assetid: b99d5130-cdda-40a2-b14c-152b13a8ba45
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::is_lock_free Method
Specifies whether atomic operations on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are *lock free*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if atomic operations on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are lock free; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 An atomic type is *lock free* if no atomic operations on that type use locks.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_is_lock_free](../vs140/atomic_is_lock_free-function.md)