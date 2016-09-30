---
title: "sync_shared::allocate"
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
  - "stdext::sync_shared::allocate"
  - "stdext.sync_shared.allocate"
  - "sync_shared::allocate"
  - "sync_shared.allocate"
  - "allocators/stdext::sync_shared::allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: 5573ad54-bdd1-4019-ba13-7e291d5c9f79
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_shared::allocate
Allocates a block of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
 The member function locks the mutex, calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, unlocks the mutex, and returns the result of the earlier call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents the current cache object.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_shared Class](../vs140/sync_shared-class.md)