---
title: "CReBar::Create"
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
  - "CReBar::Create"
  - "AFX_IDW_TOOLBAR"
  - "CReBar.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_IDW_TOOLBAR"
  - "Create method [C++]"
  - "CReBar class, initialization"
ms.assetid: 3cc756ae-db6c-4aa7-a5da-c66c6571382e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBar::Create
Call this member function to create a rebar.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwCtrlStyle = RBS_BANDBORDERS,  
   DWORD dwStyle = WS_CHILD | WS_VISIBLE | WS_CLIPSIBLINGS | WS_CLIPCHILDREN | CBRS_TOP,  
   UINT nID = AFX_IDW_REBAR   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Pointer to the `CWnd` object whose Windows window is the parent of the status bar. Normally your frame window.  
  
 `dwCtrlStyle`  
 The rebar control style. By default, **RBS_BANDBORDERS**, which displays narrow lines to separate adjacent bands within the rebar control. See [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of styles.  
  
 `dwStyle`  
 The rebar window styles.  
  
 `nID`  
 The rebar's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CReBar::AddBar](../vs140/crebar--addbar.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CReBar Class](../vs140/crebar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)