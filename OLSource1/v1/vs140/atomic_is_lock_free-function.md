---
title: "atomic_is_lock_free Function"
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
  - "atomic/std::atomic_is_lock_free"
dev_langs: 
  - "C++"
ms.assetid: 6e8cbc6b-bfcf-483b-9e18-c45a03139d2b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_is_lock_free Function
Specifies whether atomic operations on an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object are *lock-free*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if atomic operations on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are lock-free; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 An atomic type is lock-free if no atomic operations on that type use locks. If this function returns true, the type is safe to use in signal-handlers.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)