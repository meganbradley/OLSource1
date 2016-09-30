---
title: "sync_none::deallocate"
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
  - "stdext::sync_none::deallocate"
  - "sync_none::deallocate"
  - "stdext.sync_none.deallocate"
  - "allocators/stdext::sync_none::deallocate"
  - "sync_none.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 593a21ed-0fb2-4b58-bb9b-79eaacea59bb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sync_none::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
## Remarks  
 The member function calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents the cache object.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [sync_none Class](../vs140/sync_none-class.md)