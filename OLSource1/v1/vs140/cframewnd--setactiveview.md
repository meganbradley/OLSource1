---
title: "CFrameWnd::SetActiveView"
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
  - "SetActiveView"
  - "CFrameWnd::SetActiveView"
  - "CFrameWnd.SetActiveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFrameWnd class, operations"
  - "SetActiveView method"
ms.assetid: fec424f1-2bbd-4ed1-be9e-88ff1e2b092d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetActiveView
Call this member function to set the active view.  
  
## Syntax  
  
```  
  
      void SetActiveView(  
   CView* pViewNew,  
   BOOL bNotify = TRUE   
);  
```  
  
#### Parameters  
 *pViewNew*  
 Specifies a pointer to a [CView](../vs140/cview-class.md) object, or **NULL** for no active view.  
  
 `bNotify`  
 Specifies whether the view is to be notified of activation. If **TRUE**, `OnActivateView` is called for the new view; if **FALSE**, it is not.  
  
## Remarks  
 The framework will call this function automatically as the user changes the focus to a view within the frame window. You can explicitly call `SetActiveView` to change the focus to the specified view.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::GetActiveView](../vs140/cframewnd--getactiveview.md)   
 [CView::OnActivateView](../vs140/cview--onactivateview.md)   
 [CFrameWnd::GetActiveDocument](../vs140/cframewnd--getactivedocument.md)