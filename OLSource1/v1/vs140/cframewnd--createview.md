---
title: "CFrameWnd::CreateView"
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
  - "CFrameWnd::CreateView"
  - "CFrameWnd.CreateView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateView method"
ms.assetid: f490fc29-b689-4e24-b266-837192be83f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::CreateView
Call `CreateView` to create a view within a frame.  
  
## Syntax  
  
```  
  
      CWnd* CreateView(  
   CCreateContext* pContext,  
   UINT nID = AFX_IDW_PANE_FIRST   
);  
```  
  
#### Parameters  
 `pContext`  
 Specifies the type of view and document.  
  
 `nID`  
 The ID number of a view.  
  
## Return Value  
 Pointer to a `CWnd` object if successful; otherwise **NULL**.  
  
## Remarks  
 Use this member function to create "views" that are not `CView`-derived within a frame. After calling `CreateView`, you must manually set the view to active and set it to be visible; these tasks are not automatically performed by `CreateView`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)