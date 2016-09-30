---
title: "sync_per_thread::equals"
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
  - "stdext::sync_per_thread::equals"
  - "sync_per_thread::equals"
  - "allocators/stdext::sync_per_thread::equals"
  - "stdext.sync_per_thread.equals"
  - "sync_per_thread.equals"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equals method"
ms.assetid: 0ab1054b-5a03-4009-a1f9-a87bb2f2e2b3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_per_thread::equals
Compares two caches for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The cache object of the synchronization filter.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The cache object to compare for equality.|  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if no cache object has been allocated for this object or for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the current thread. Otherwise it returns the result of applying <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the two cache objects.  
  
## Remarks  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_per_thread Class](../vs140/sync_per_thread-class.md)