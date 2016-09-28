---
title: "CComPtrBase::SetSite"
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
  - "ATL.CComPtrBase.SetSite"
  - "ATL::CComPtrBase::SetSite"
  - "SetSite"
  - "CComPtrBase<T>.SetSite"
  - "ATL::CComPtrBase<T>::SetSite"
  - "CComPtrBase::SetSite"
  - "CComPtrBase<T>::SetSite"
  - "ATL.CComPtrBase<T>.SetSite"
  - "CComPtrBase.SetSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSite method"
ms.assetid: 232671e7-3608-480e-a346-a51999ced24a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::SetSite
Call this method to set the site of the `CComPtrBase` object to the **IUnknown** of the parent object.  
  
## Syntax  
  
```  
  
      HRESULT SetSite(  
   IUnknown* punkParent  
) throw( );  
```  
  
#### Parameters  
 `punkParent`  
 A pointer to the **IUnknown** interface of the parent.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method calls [AtlSetChildSite](../vs140/atlsetchildsite.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)   
 [CComPtrBase::QueryInterface](../vs140/ccomptrbase--queryinterface.md)