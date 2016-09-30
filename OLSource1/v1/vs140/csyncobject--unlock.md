---
title: "CSyncObject::Unlock"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CSyncObject.Unlock"
  - "CSyncObject::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 31afc9bf-3a76-45fa-aac5-7040953a0e6f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSyncObject::Unlock
The declaration of `Unlock` with no parameters is a pure virtual function, and must be overridden by all classes deriving from `CSyncObject`.  
  
## Syntax  
  
```  
  
      virtual BOOL Unlock( ) = 0;   
virtual BOOL Unlock(  
   LONG lCount,  
   LPLONG lpPrevCount = NULL   
);  
```  
  
#### Parameters  
 `lCount`  
 Not used by default implementation.  
  
 `lpPrevCount`  
 Not used by default implementation.  
  
## Return Value  
 Default implementation always returns **TRUE**.  
  
## Remarks  
 The default implementation of the declaration with two parameters always returns **TRUE**. This function is called to release access to the synchronization object owned by the calling thread. The second declaration is provided for synchronization objects such as semaphores that allow more than one access of a controlled resource.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSyncObject Class](../vs140/csyncobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)