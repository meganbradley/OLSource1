---
title: "CWnd::CheckDlgButton"
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
  - "CWnd.CheckDlgButton"
  - "CWnd::CheckDlgButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckDlgButton method"
ms.assetid: 9418c960-a7d7-47c0-9090-db4e9c2d92df
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CheckDlgButton
Selects (places a check mark next to) or clears (removes a check mark from) a button, or it changes the state of a three-state button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the button to be modified.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the action to take. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is nonzero, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function places a check mark next to the button; if 0, the check mark is removed. For three-state buttons, if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 2, the button state is indeterminate.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function sends a [BM_SETCHECK](http://msdn.microsoft.com/library/windows/desktop/bb775989) message to the specified button.  
  
## Example  
 [!code[NVC_MFCWindowing#75](../vs140/codesnippet/CPP/cwnd--checkdlgbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::IsDlgButtonChecked](../vs140/cwnd--isdlgbuttonchecked.md)   
 [CButton::SetCheck](../vs140/cbutton--setcheck.md)   
 [CheckDlgButton](http://msdn.microsoft.com/library/windows/desktop/bb761875)