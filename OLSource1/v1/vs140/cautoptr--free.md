---
title: "CAutoPtr::Free"
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
  - "CAutoPtr<T>::Free"
  - "ATL.CAutoPtr<T>.Free"
  - "CAutoPtr<T>.Free"
  - "ATL.CAutoPtr.Free"
  - "ATL::CAutoPtr::Free"
  - "CAutoPtr.Free"
  - "CAutoPtr::Free"
  - "ATL::CAutoPtr<T>::Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: e9bc7840-2df9-454d-9bb6-81cbb1be2361
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr::Free
Call this method to delete an object pointed to by a `CAutoPtr`.  
  
## Syntax  
  
```  
  
void Free( ) throw( );  
  
```  
  
## Remarks  
 The object pointed to by the `CAutoPtr` is freed, and the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member variable is set to NULL.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)