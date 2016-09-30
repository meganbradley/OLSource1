---
title: "CWnd::SetDlgItemText"
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
  - "CWnd.SetDlgItemText"
  - "CWnd::SetDlgItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDlgItemText method"
ms.assetid: 219c44dd-2386-4789-8225-dfd5522db4ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetDlgItemText
Sets the caption or text of a control owned by a window or dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the control whose text is to be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [CString](../vs140/cstringt-class.md) object or null-terminated string that contains the text to be copied to the control.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sends a [WM_SETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632644) message to the given control.  
  
## Example  
 [!code[NVC_MFCWindowing#116](../vs140/codesnippet/CPP/cwnd--setdlgitemtext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetDlgItemText](http://msdn.microsoft.com/library/windows/desktop/ms645521)   
 [WM_SETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632644)   
 [CWnd::GetDlgItemText](../vs140/cwnd--getdlgitemtext.md)