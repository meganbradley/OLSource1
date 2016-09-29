---
title: "IObjectWithSiteImpl::m_spUnkSite"
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
  - "ATL::IObjectWithSiteImpl::m_spUnkSite"
  - "IObjectWithSiteImpl.m_spUnkSite"
  - "ATL::IObjectWithSiteImpl<T>::m_spUnkSite"
  - "IObjectWithSiteImpl::m_spUnkSite"
  - "IObjectWithSiteImpl<T>::m_spUnkSite"
  - "ATL.IObjectWithSiteImpl.m_spUnkSite"
  - "m_spUnkSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spUnkSite"
ms.assetid: 0e779dea-8121-4d44-bafa-b6cd35157e22
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObjectWithSiteImpl::m_spUnkSite
Manages the site's **IUnknown** pointer.  
  
## Syntax  
  
```  
  
CComPtr< IUnknown > m_spUnkSite;  
  
```  
  
## Remarks  
 `m_spUnkSite` initially receives this pointer through a call to [SetSite](../VS_csharp/iobjectwithsiteimpl--setsite.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IObjectWithSiteImpl Class](../VS_csharp/iobjectwithsiteimpl-class.md)   
 [CComPtr Class](../VS_csharp/ccomptr-class.md)