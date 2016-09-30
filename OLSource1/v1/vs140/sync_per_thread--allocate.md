---
title: "sync_per_thread::allocate"
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
  - "sync_per_thread::allocate"
  - "stdext.sync_per_thread.allocate"
  - "sync_per_thread.allocate"
  - "allocators/stdext::sync_per_thread::allocate"
  - "stdext::sync_per_thread::allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: 774f09c4-690b-4dc6-859d-3bdbbf97b144
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_per_thread::allocate
Allocates a block of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
## Remarks  
 The member function returns the result of a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on the cache object belonging to the current thread. If no cache object has been allocated for the current thread, it first allocates one.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_per_thread Class](../vs140/sync_per_thread-class.md)