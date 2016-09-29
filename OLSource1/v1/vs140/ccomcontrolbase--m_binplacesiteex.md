---
title: "CComControlBase::m_bInPlaceSiteEx"
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
  - "ATL::CComControlBase::m_bInPlaceSiteEx"
  - "CComControlBase.m_bInPlaceSiteEx"
  - "m_bInPlaceSiteEx"
  - "CComControlBase::m_bInPlaceSiteEx"
  - "ATL.CComControlBase.m_bInPlaceSiteEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bInPlaceSiteEx"
ms.assetid: d45e3362-5916-4544-a6fc-193a0fb48ab3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bInPlaceSiteEx
Flag indicating the container supports the **IOleInPlaceSiteEx** interface and OCX96 control features, such as windowless and flicker-free controls.  
  
## Syntax  
  
```  
  
unsigned m_bInPlaceSiteEx:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 The data member `m_spInPlaceSite` points to an [IOleInPlaceSite](http://msdn.microsoft.com/library/windows/desktop/ms686586), [IOleInPlaceSiteEx](http://msdn.microsoft.com/library/windows/desktop/ms693461), or [IOleInPlaceSiteWindowless](http://msdn.microsoft.com/library/windows/desktop/ms682300) interface, depending on the value of the `m_bWndLess` and `m_bInPlaceSiteEx` flags. (The data member `m_bNegotiatedWnd` must be **TRUE** for the `m_spInPlaceSite` pointer to be valid.)  
  
 If `m_bWndLess` is **FALSE** and `m_bInPlaceSiteEx` is **TRUE**, `m_spInPlaceSite` is an **IOleInPlaceSiteEx** interface pointer. See [m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md) for a table showing the relationship among these three data members.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_bWndLess](../vs140/ccomcontrolbase--m_bwndless.md)   
 [CComControlBase::m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md)   
 [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md)