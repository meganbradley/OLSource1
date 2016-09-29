---
title: "CComHeapPtr::CComHeapPtr"
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
  - "ATL::CComHeapPtr::CComHeapPtr"
  - "ATL.CComHeapPtr<T>.CComHeapPtr"
  - "CComHeapPtr::CComHeapPtr"
  - "CComHeapPtr<T>.CComHeapPtr"
  - "CComHeapPtr.CComHeapPtr"
  - "CComHeapPtr"
  - "CComHeapPtr<T>::CComHeapPtr"
  - "ATL.CComHeapPtr.CComHeapPtr"
  - "ATL::CComHeapPtr<T>::CComHeapPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComHeapPtr constructor"
  - "CComHeapPtr class, constructor"
ms.assetid: 7468b740-9a87-4cb6-860a-012428854166
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeapPtr::CComHeapPtr
The constructor.  
  
## Syntax  
  
```  
  
      CComHeapPtr( ) throw( );   
explicit CComHeapPtr(  
   T* pData   
) throw( );  
```  
  
#### Parameters  
 `pData`  
 An existing `CComHeapPtr` object.  
  
## Remarks  
 The heap pointer can optionally be created using an existing `CComHeapPtr` object. If so, the new `CComHeapPtr` object assumes responsibility for managing the new pointer and resources.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComHeapPtr Class](../vs140/ccomheapptr-class.md)