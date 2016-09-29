---
title: "CToolTipCtrl::GetText"
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
  - "CToolTipCtrl.GetText"
  - "CToolTipCtrl::GetText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetText method"
ms.assetid: 34562924-3906-43b3-a66f-99ec09b80a2c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetText
Retrieves the text that a tool tip control maintains for a tool.  
  
## Syntax  
  
```  
  
      void GetText(  
   CString& str,  
   CWnd* pWnd,  
   UINT_PTR nIDTool = 0   
) const;  
```  
  
#### Parameters  
 `str`  
 Reference to a `CString` object that receives the tool's text.  
  
 `pWnd`  
 Pointer to the window that contains the tool.  
  
 `nIDTool`  
 ID of the tool.  
  
## Remarks  
 The `pWnd` and `nIDTool` parameters identify the tool. If that tool has been previously registered with the tool tip control through a previous call to **CToolTipCtrl::AddTool**, the object referenced by the `str` parameter is assigned the tool's text.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::AddTool](../vs140/ctooltipctrl--addtool.md)   
 [CToolTipCtrl::DelTool](../vs140/ctooltipctrl--deltool.md)