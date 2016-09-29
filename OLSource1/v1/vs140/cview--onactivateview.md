---
title: "CView::OnActivateView"
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
  - "CView.OnActivateView"
  - "OnActivateView"
  - "CView::OnActivateView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views, activating"
  - "OnActivateView method"
  - "CView class, overridables"
ms.assetid: e7966b13-44c3-439a-accb-eb3fd79cab99
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnActivateView
Called by the framework when a view is activated or deactivated.  
  
## Syntax  
  
```  
  
      virtual void OnActivateView(  
   BOOL bActivate,  
   CView* pActivateView,  
   CView* pDeactiveView   
);  
```  
  
#### Parameters  
 `bActivate`  
 Indicates whether the view is being activated or deactivated.  
  
 `pActivateView`  
 Points to the view object that is being activated.  
  
 `pDeactiveView`  
 Points to the view object that is being deactivated.  
  
## Remarks  
 The default implementation of this function sets the focus to the view being activated. Override this function if you want to perform special processing when a view is activated or deactivated. For example, if you want to provide special visual cues that distinguish the active view from the inactive views, you would examine the `bActivate` parameter and update the view's appearance accordingly.  
  
 The `pActivateView` and `pDeactiveView` parameters point to the same view if the application's main frame window is activated with no change in the active view — for example, if the focus is being transferred from another application to this one, rather than from one view to another within the application or when switching amongst MDI child windows. This allows a view to re-realize its palette, if needed.  
  
 These parameters differ when [CFrameWnd::SetActiveView](../vs140/cframewnd--setactiveview.md) is called with a view that is different from what [CFrameWnd::GetActiveView](../vs140/cframewnd--getactiveview.md) would return. This happens most often with splitter windows.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnActivate](../vs140/cwnd--onactivate.md)   
 [CFrameWnd::SetActiveView](../vs140/cframewnd--setactiveview.md)   
 [CFrameWnd::GetActiveView](../vs140/cframewnd--getactiveview.md)