---
title: "CComControlBase::m_bWndLess"
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
  - "m_bWndLess"
  - "ATL::CComControlBase::m_bWndLess"
  - "ATL.CComControlBase.m_bWndLess"
  - "CComControlBase::m_bWndLess"
  - "CComControlBase.m_bWndLess"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bWndLess"
ms.assetid: a90df669-1463-4537-b8a4-c93c80bf8796
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bWndLess
Flag indicating the control is windowless.  
  
## Syntax  
  
```  
  
unsigned m_bWndLess:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 The data member `m_spInPlaceSite` points to an [IOleInPlaceSite](http://msdn.microsoft.com/library/windows/desktop/ms686586), [IOleInPlaceSiteEx](http://msdn.microsoft.com/library/windows/desktop/ms693461), or [IOleInPlaceSiteWindowless](http://msdn.microsoft.com/library/windows/desktop/ms682300) interface, depending on the value of the `m_bWndLess` and [CComControlBase::m_bInPlaceSiteEx](../vs140/ccomcontrolbase--m_binplacesiteex.md) flags. (The data member [CComControlBase::m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md) must be **TRUE** for the [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md) pointer to be valid.)  
  
 If `m_bWndLess` is **TRUE**, `m_spInPlaceSite` is an **IOleInPlaceSiteWindowless** interface pointer. See [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md) for a table showing the complete relationship between these data members.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)