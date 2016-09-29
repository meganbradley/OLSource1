---
title: "CComControlBase::InPlaceActivate"
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
  - "InPlaceActivate"
  - "ATL.CComControlBase.InPlaceActivate"
  - "CComControlBase::InPlaceActivate"
  - "ATL::CComControlBase::InPlaceActivate"
  - "CComControlBase.InPlaceActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InPlaceActivate method"
ms.assetid: acfd1f09-ef2c-40ba-a8fd-7270189d5d72
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::InPlaceActivate
Causes the control to transition from the inactive state to whatever state the verb in `iVerb` indicates.  
  
## Syntax  
  
```  
  
      HRESULT InPlaceActivate(  
   LONG iVerb,  
   const RECT* prcPosRect = NULL   
);  
```  
  
#### Parameters  
 `iVerb`  
 Value indicating the action to be performed by [IOleObjectImpl::DoVerb](../vs140/ioleobjectimpl--doverb.md).  
  
 *prcPosRect*  
 Pointer to the position of the in-place control.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 Before activation, this method checks that the control has a client site, checks how much of the control is visible, and gets the control's location in the parent window. After the control is activated, this method activates the control's user interface and tells the container to make the control visible.  
  
 This method also retrieves an `IOleInPlaceSite`, **IOleInPlaceSiteEx**, or **IOleInPlaceSiteWindowless** interface pointer for the control and stores it in the control class's data member [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md). The control class data members [CComControlBase::m_bInPlaceSiteEx](../vs140/ccomcontrolbase--m_binplacesiteex.md), [CComControlBase::m_bWndLess](../vs140/ccomcontrolbase--m_bwndless.md), [CComControlBase::m_bWasOnceWindowless](../vs140/ccomcontrolbase--m_bwasoncewindowless.md), and [CComControlBase::m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md) are set to true as appropriate.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)