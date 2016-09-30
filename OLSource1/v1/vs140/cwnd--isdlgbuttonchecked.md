---
title: "CWnd::IsDlgButtonChecked"
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
  - "IsDlgButtonChecked"
  - "CWnd::IsDlgButtonChecked"
  - "CWnd.IsDlgButtonChecked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDlgButtonChecked method"
ms.assetid: fc050eae-2ca9-4be6-9a49-2f8dd3cbfde0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::IsDlgButtonChecked
Determines whether a button control has a check mark next to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the integer identifier of the button control.  
  
## Return Value  
 Nonzero if the given control is checked, and 0 if it is not checked. Only radio buttons and check boxes can be checked. For three-state buttons, the return value can be 2 if the button is indeterminate. This member function returns 0 for a pushbutton.  
  
## Remarks  
 If the button is a three-state control, the member function determines whether it is dimmed, checked, or neither.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IsDlgButtonChecked](http://msdn.microsoft.com/library/windows/desktop/bb761879)   
 [CButton::GetCheck](../vs140/cbutton--getcheck.md)