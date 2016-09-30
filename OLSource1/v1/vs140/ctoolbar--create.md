---
title: "CToolBar::Create"
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
  - "CToolBar::Create"
  - "CToolBar.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbars [C++], creating"
  - "toolbars [C++], constructing or destroying"
  - "Create method [C++]"
  - "CToolBar class, construction/destruction"
ms.assetid: b2d46cc4-38ab-47bf-b0a2-840e2eb736e2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::Create
This member function creates a Windows toolbar (a child window) and associates it with the `CToolBar` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwStyle = WS_CHILD |  WS_VISIBLE | CBRS_TOP,  
   UINT nID = AFX_IDW_TOOLBAR   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Pointer to the window that is the toolbar's parent.  
  
 `dwStyle`  
 The toolbar style. Additional toolbar styles supported are:  
  
-   `CBRS_TOP` Control bar is at top of the frame window.  
  
-   `CBRS_BOTTOM` Control bar is at bottom of the frame window.  
  
-   `CBRS_NOALIGN` Control bar is not repositioned when the parent is resized.  
  
-   `CBRS_TOOLTIPS` Control bar displays tool tips.  
  
-   **CBRS_SIZE_DYNAMIC** Control bar is dynamic.  
  
-   **CBRS_SIZE_FIXED** Control bar is fixed.  
  
-   **CBRS_FLOATING** Control bar is floating.  
  
-   `CBRS_FLYBY` Status bar displays information about the button.  
  
-   **CBRS_HIDE_INPLACE** Control bar is not displayed to the user.  
  
 `nID`  
 The toolbar's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 It also sets the toolbar height to a default value.  
  
## Example  
 [!code[NVC_MFCDocView#179](../vs140/codesnippet/CPP/ctoolbar--create_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::CToolBar](../vs140/ctoolbar--ctoolbar.md)   
 [CToolBar::LoadBitmap](../vs140/ctoolbar--loadbitmap.md)   
 [CToolBar::SetButtons](../vs140/ctoolbar--setbuttons.md)   
 [CToolBar::LoadToolBar](../vs140/ctoolbar--loadtoolbar.md)   
 [CControlBar::CalcDynamicLayout](../vs140/ccontrolbar--calcdynamiclayout.md)   
 [CControlBar::CalcFixedLayout](../vs140/ccontrolbar--calcfixedlayout.md)