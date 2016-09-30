---
title: "sync_per_thread::deallocate"
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
  - "stdext::sync_per_thread::deallocate"
  - "allocators/stdext::sync_per_thread::deallocate"
  - "stdext.sync_per_thread.deallocate"
  - "sync_per_thread::deallocate"
  - "sync_per_thread.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 86c5cf8d-ff8f-444a-8603-a19a6a16a5d0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_per_thread::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
## Remarks  
 The member function calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on the cache object belonging to the current thread. If no cache object has been allocated for the current thread, it first allocates one.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_per_thread Class](../vs140/sync_per_thread-class.md)