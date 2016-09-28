---
title: "CMFCToolBarButton::IsVisible"
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
  - "CMFCToolBarButton.IsVisible"
  - "CMFCToolBarButton::IsVisible"
  - "IsVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsVisible method"
ms.assetid: e2cf4c4b-02f6-41bc-aa86-974ea99a229e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsVisible
Determines whether the toolbar button is visible.  
  
## Syntax  
  
```  
BOOL IsVisible() const;  
```  
  
## Return Value  
 Nonzero if the toolbar button is visible; otherwise 0.  
  
## Remarks  
 You can show or hide the toolbar button by using the [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md) method. Call the [CPane::AdjustSizeImmediate](../vs140/cpane--adjustsizeimmediate.md) method on the parent toolbar after you call [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md) to recalculate the layout of a parent toolbar.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md)   
 [CPane::AdjustSizeImmediate](../vs140/cpane--adjustsizeimmediate.md)