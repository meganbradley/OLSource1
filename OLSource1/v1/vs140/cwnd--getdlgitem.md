---
title: "CWnd::GetDlgItem"
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
  - "CWnd.GetDlgItem"
  - "CWnd::GetDlgItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgItem method"
ms.assetid: 64aa4c0a-6b25-4175-91a0-9957ca07eeab
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDlgItem
Retrieves a pointer to the specified control or child window in a dialog box or other window.  
  
## Syntax  
  
```  
  
      CWnd* GetDlgItem(  
   int nID   
) const;  
void GetDlgItem(  
   int nID,  
   HWND* phWnd  
) const;  
```  
  
#### Parameters  
 `nID`  
 Specifies the identifier of the control or child window to be retrieved.  
  
 `phWnd`  
 A pointer to a child window.  
  
## Return Value  
 A pointer to the given control or child window. If no control with the integer ID given by the `nID` parameter exists, the value is **NULL**.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The pointer returned is usually cast to the type of control identified by `nID`.  
  
## Example  
 [!code[NVC_MFCWindowing#97](../vs140/codesnippet/CPP/cwnd--getdlgitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetWindow](../vs140/cwnd--getwindow.md)   
 [CWnd::GetDescendantWindow](../vs140/cwnd--getdescendantwindow.md)   
 [CWnd::GetWindow](../vs140/cwnd--getwindow.md)   
 [GetDlgItem](http://msdn.microsoft.com/library/windows/desktop/ms645481)