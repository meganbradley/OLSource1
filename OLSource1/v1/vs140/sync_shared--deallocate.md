---
title: "sync_shared::deallocate"
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
  - "stdext::sync_shared::deallocate"
  - "stdext.sync_shared.deallocate"
  - "allocators/stdext::sync_shared::deallocate"
  - "sync_shared.deallocate"
  - "sync_shared::deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: b95147c1-f247-4ad5-95a0-3b29724101a5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_shared::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
## Remarks  
 This member function locks the mutex, calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents the cache object, and then unlocks the mutex.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_shared Class](../vs140/sync_shared-class.md)