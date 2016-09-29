---
title: "CMFCDropDownFrame::Create"
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
  - "CMFCDropDownFrame.Create"
  - "Create"
  - "CMFCDropDownFrame::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 9f2b5ed0-9571-47cc-9537-b75ce2c7b92e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownFrame::Create
Creates a `CMFCDropDownFrame` object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   CWnd* pWndParent,  
   int x,  
   int y,  
   CMFCDropDownToolBar* pWndOriginToolbar  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pWndParent`|The parent window of the drop-down frame.|  
|[in] `x`|The horizontal screen coordinate for the location of the down-down frame.|  
|[in] `y`|The vertical screen coordinate for the location of the down-down frame.|  
|[in] `pWndOriginToolbar`|The toolbar that has the drop-down buttons that this method uses to populate the new drop-down frame object.|  
  
## Return Value  
 `TRUE` if the drop-down frame was successfully created; otherwise `FALSE`.  
  
## Remarks  
 This method calls the base [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md) method to create the drop-down frame window with the `WS_POPUP` style. The drop-down frame window appears at the specified screen coordinates. This method fails if the [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md) method returns `FALSE`.  
  
 The `CMFCDropDownFrame` class creates a copy of the provided `CMFCDropDownToolBar` parameter. This method copies the button images and button states from the `pWndOriginToolbar` parameter to the `m_pWndOriginToolbar` data member.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownFrame Class](../vs140/cmfcdropdownframe-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md)   
 [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md)