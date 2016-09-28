---
title: "CHeapPtrBase::Attach"
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
  - "CHeapPtrBase.Attach"
  - "ATL.CHeapPtrBase.Attach"
  - "ATL::CHeapPtrBase::Attach"
  - "CHeapPtrBase::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 346877e4-4890-4a2f-b283-8ffd92bae5c5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrBase::Attach
Call this method to take ownership of an existing pointer.  
  
## Syntax  
  
```  
  
      void Attach(  
   T* pData   
) throw( );  
```  
  
#### Parameters  
 `pData`  
 The `CHeapPtrBase` object will take ownership of this pointer.  
  
## Remarks  
 When a `CHeapPtrBase` object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope.  
  
 In debug builds, an assertion failure will occur if the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CHeapPtrBase Class](../vs140/cheapptrbase-class.md)   
 [CHeapPtrBase::Detach](../vs140/cheapptrbase--detach.md)