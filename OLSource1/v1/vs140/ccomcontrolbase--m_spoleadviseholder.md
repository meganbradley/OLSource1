---
title: "CComControlBase::m_spOleAdviseHolder"
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
  - ATL.CComControlBase.m_spOleAdviseHolder
  - CComControlBase.m_spOleAdviseHolder
  - ATL::CComControlBase::m_spOleAdviseHolder
  - CComControlBase::m_spOleAdviseHolder
  - m_spOleAdviseHolder
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_spOleAdviseHolder
ms.assetid: 018580c0-1836-4d4c-ab42-0086ad6caa5f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::m_spOleAdviseHolder
Provides a standard implementation of a way to hold advisory connections.  
  
## Syntax  
  
```  
  
CComPtr<IOleAdviseHolder> m_spOleAdviseHolder;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 The interface `m_spOleAdviseHolder` implements the [IOleObject::Advise](http://msdn.microsoft.com/library/windows/desktop/ms686573) and [IOleObject::Unadvise](http://msdn.microsoft.com/library/windows/desktop/ms693749) methods to establish and delete advisory connections to the container. The control's container must implement an advise sink by supporting the [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513) interface.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)