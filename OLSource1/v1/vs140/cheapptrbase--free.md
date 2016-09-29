---
title: "CHeapPtrBase::Free"
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
  - "CHeapPtrBase.Free"
  - "ATL::CHeapPtrBase::Free"
  - "CHeapPtrBase::Free"
  - "ATL.CHeapPtrBase.Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: c8055123-2239-47c7-a408-dda1ae8809fa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrBase::Free
Call this method to delete an object pointed to by a `CHeapPtrBase`.  
  
## Syntax  
  
```  
  
void Free( ) throw( );  
  
```  
  
## Remarks  
 The object pointed to by the `CHeapPtrBase` is freed, and the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CHeapPtrBase Class](../vs140/cheapptrbase-class.md)   
 [CHeapPtrBase::AllocateBytes](../vs140/cheapptrbase--allocatebytes.md)   
 [CHeapPtrBase::ReallocateBytes](../vs140/cheapptrbase--reallocatebytes.md)