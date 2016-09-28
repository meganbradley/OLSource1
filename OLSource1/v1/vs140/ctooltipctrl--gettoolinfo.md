---
title: "CToolTipCtrl::GetToolInfo"
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
  - "TOOLINFO"
  - "GetToolInfo"
  - "CToolTipCtrl.GetToolInfo"
  - "CToolTipCtrl::GetToolInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolInfo method"
  - "TOOLINFO"
ms.assetid: 67ceb05f-7203-49e2-9245-aae6c289ca7f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetToolInfo
Retrieves the information that a tool tip control maintains about a tool.  
  
## Syntax  
  
```  
  
      BOOL GetToolInfo(  
   CToolInfo& ToolInfo,  
   CWnd* pWnd,  
   UINT_PTR nIDTool = 0  
) const;  
```  
  
#### Parameters  
 *ToolInfo*  
 Reference to a `TOOLINFO` object that receives the tool's text.  
  
 `pWnd`  
 Pointer to the window that contains the tool.  
  
 `nIDTool`  
 ID of the tool.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The **hwnd** and **uId** members of the [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure referenced by *CToolInfo* identify the tool. If that tool has been registered with the tool tip control through a previous call to `AddTool`, the `TOOLINFO` structure is filled with information about the tool.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::AddTool](../vs140/ctooltipctrl--addtool.md)