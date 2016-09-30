---
title: "CWnd::GetDlgCtrlID"
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
  - "CWnd::GetDlgCtrlID"
  - "CWnd.GetDlgCtrlID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgCtrlID method"
ms.assetid: b699f911-9e4b-48f8-816c-4b3ff2d6b022
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDlgCtrlID
Returns the window or control ID value for any child window, not only that of a control in a dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The numeric identifier of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> child window if the function is successful; otherwise 0.  
  
## Remarks  
 Since top-level windows do not have an ID value, the return value of this function is invalid if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a top-level window.  
  
## Example  
 See the example for [CWnd::OnCtlColor](../vs140/cwnd--onctlcolor.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetDlgCtrlID](http://msdn.microsoft.com/library/windows/desktop/ms645478)