---
title: "CComControlBase::m_spClientSite"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CComControlBase::m_spClientSite
  - CComControlBase.m_spClientSite
  - m_spClientSite
  - ATL.CComControlBase.m_spClientSite
  - CComControlBase::m_spClientSite
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_spClientSite
ms.assetid: 9883c293-8b58-4e18-ba1d-2c8005d61358
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::m_spClientSite
A pointer to the control's client site within the container.  
  
## Syntax  
  
```  
  
CComPtr<IOleClientSite> m_spClientSite;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)   
 [IOleClientSite](http://msdn.microsoft.com/library/windows/desktop/ms693706)