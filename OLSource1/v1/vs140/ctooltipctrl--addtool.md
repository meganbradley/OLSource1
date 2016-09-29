---
title: "CToolTipCtrl::AddTool"
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
  - "CToolTipCtrl::AddTool"
  - "AddTool"
  - "CToolTipCtrl.AddTool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTool method"
ms.assetid: 7480c36a-9471-4cd0-aeb5-c8d791e90670
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::AddTool
Registers a tool with the tool tip control.  
  
## Syntax  
  
```  
  
      BOOL AddTool(  
   CWnd* pWnd,  
   UINT nIDText,  
   LPCRECT lpRectTool = NULL,  
   UINT_PTR nIDTool = 0   
);  
BOOL AddTool(  
   CWnd* pWnd,  
   LPCTSTR lpszText = LPSTR_TEXTCALLBACK,  
   LPCRECT lpRectTool = NULL,  
   UINT_PTR nIDTool = 0   
);  
```  
  
#### Parameters  
 `pWnd`  
 Pointer to the window that contains the tool.  
  
 `nIDText`  
 ID of the string resource that contains the text for the tool.  
  
 *lpRectTool*  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure containing coordinates of the tool's bounding rectangle. The coordinates are relative to the upper-left corner of the client area of the window identified by `pWnd`.  
  
 `nIDTool`  
 ID of the tool.  
  
 `lpszText`  
 Pointer to the text for the tool. If this parameter contains the value **LPSTR_TEXTCALLBACK**, **TTN_NEEDTEXT** notification messages go to the parent of the window that `pWnd` points to.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The **lpRectTool** and **nIDTool** parameters must both be valid, or if **lpRectTool** is NULL, **nIDTool** must be 0.  
  
 A tool tip control can be associated with more than one tool. Call this function to register a tool with the tool tip control, so that the information stored in the tool tip is displayed when the cursor is on the tool.  
  
> [!NOTE]
>  You cannot set a tool tip to a static control using `AddTool`.  
  
## Example  
 See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet--gettabcontrol.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::DelTool](../vs140/ctooltipctrl--deltool.md)