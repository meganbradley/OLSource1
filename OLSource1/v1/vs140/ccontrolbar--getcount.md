---
title: "CControlBar::GetCount"
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
  - "CControlBar::GetCount"
  - "CControlBar.GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, attributes"
  - "GetCount method [MFC]"
ms.assetid: fe108afb-19a8-497b-9bbe-cfabff454830
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::GetCount
Returns the number of non-`HWND` items on the `CControlBar` object.  
  
## Syntax  
  
```  
  
int GetCount( ) const;  
```  
  
## Return Value  
 The number of non-`HWND` items on the `CControlBar` object. This function returns 0 for a [CDialogBar](../vs140/cdialogbar-class.md) object.  
  
## Remarks  
 The type of the item depends on the derived object: panes for [CStatusBar](../vs140/cstatusbar-class.md) objects, and buttons and separators for [CToolBar](../vs140/ctoolbar-class.md) objects.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::SetButtons](../vs140/ctoolbar--setbuttons.md)   
 [CStatusBar::SetIndicators](../vs140/cstatusbar--setindicators.md)   
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [CDialogBar Class](../vs140/cdialogbar-class.md)