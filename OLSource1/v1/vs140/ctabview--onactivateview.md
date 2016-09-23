---
title: "CTabView::OnActivateView"
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
  - CTabView::OnActivateView
  - CTabView.OnActivateView
  - OnActivateView
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnActivateView method
ms.assetid: afc7e199-1132-41d0-b436-81bbd7976fb4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTabView::OnActivateView
Called by the framework when the tab view is made active or inactive.  
  
## Syntax  
  
```  
virtual void OnActivateView(  
   CView* view  
);  
```  
  
#### Parameters  
 [in] `view`  
 A pointer to the view.  
  
## Remarks  
 The default implementation does nothing. Override this method in a `CTabView`-derived class to process this notification.  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)