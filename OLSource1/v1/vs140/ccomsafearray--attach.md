---
title: "CComSafeArray::Attach"
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
  - "ATL.CComSafeArray.Attach"
  - "ATL::CComSafeArray::Attach"
  - "CComSafeArray.Attach"
  - "CComSafeArray::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 8396ced8-cf4e-4c0e-9a06-b3351fcfc9b0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::Attach
Attaches a **SAFEARRAY** structure to a `CComSafeArray` object.  
  
## Syntax  
  
```  
  
      HRESULT Attach(  
   const SAFEARRAY * psaSrc   
);  
```  
  
#### Parameters  
 `psaSrc`  
 A pointer to the **SAFEARRAY** structure.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Attaches a **SAFEARRAY** structure to a `CComSafeArray` object, making the existing `CComSafeArray` methods available.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::Detach](../vs140/ccomsafearray--detach.md)