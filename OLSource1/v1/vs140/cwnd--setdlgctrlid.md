---
title: "CWnd::SetDlgCtrlID"
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
  - "CWnd::SetDlgCtrlID"
  - "CWnd.SetDlgCtrlID"
  - "SetDlgCtrlID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog box functions"
  - "SetDlgCtrlID method"
ms.assetid: 3832a584-e88d-458c-96dc-d95e3a5a5c13
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetDlgCtrlID
Sets the window ID or control ID for the window to a new value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new value to set for the control's identifier.  
  
## Return Value  
 The previous identifier of the window, if successful; otherwise 0.  
  
## Remarks  
 The window can be any child window, not only a control in a dialog box. The window cannot be a top-level window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDlgCtrlID](../vs140/cwnd--getdlgctrlid.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CWnd::CreateEx](../vs140/cwnd--createex.md)   
 [CWnd::GetDlgItem](../vs140/cwnd--getdlgitem.md)