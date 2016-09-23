---
title: "_AtlCreateWndData Structure"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ATL::_AtlCreateWndData
  - ATL._AtlCreateWndData
  - _AtlCreateWndData
dev_langs: 
  - C++
helpviewer_keywords: 
  - _AtlCreateWndData structure
  - AtlCreateWndData structure
ms.assetid: 76ed5382-bfbf-4b8b-8a29-912688dfd2ae
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _AtlCreateWndData Structure
This structure contains class instance data in windowing code in ATL.  
  
## Syntax  
  
```  
  
      struct _AtlCreateWndData{  
   void* m_pThis;  
   DWORD m_dwThreadID;  
   _AtlCreateWndData* m_pNext;  
};  
```  
  
## Members  
 **m_pThis**  
 The **this** pointer used to get access to the class instance in window procedures.  
  
 `m_dwThreadID`  
 The thread ID of the current class instance.  
  
 **m_pNext**  
 Pointer to the next `_AtlCreateWndData` object.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Structures](../vs140/atl-structures.md)