---
title: "CToolTipCtrl::SetToolRect"
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
  - "CToolTipCtrl::SetToolRect"
  - "SetToolRect"
  - "CToolTipCtrl.SetToolRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetToolRect method"
ms.assetid: f0c038cb-ebc5-4a12-9a04-5a2480d2971f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetToolRect
Sets a new bounding rectangle for a tool.  
  
## Syntax  
  
```  
  
      void SetToolRect(  
   CWnd* pWnd,  
   UINT_PTR nIDTool,  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `pWnd`  
 Pointer to the window that contains the tool.  
  
 `nIDTool`  
 ID of the tool.  
  
 `lpRect`  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the new bounding rectangle.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetToolInfo](../vs140/ctooltipctrl--gettoolinfo.md)