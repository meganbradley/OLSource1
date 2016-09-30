---
title: "CWnd::GetDlgItemInt"
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
  - "CWnd::GetDlgItemInt"
  - "CWnd.GetDlgItemInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgItemInt method"
ms.assetid: 3903b6c4-efbf-4ca6-a9c9-38bc58a7a460
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDlgItemInt
Retrieves the text of the control identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the integer identifier of the dialog-box control to be translated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the Boolean variable that is to receive the translated flag.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies whether the value to be retrieved is signed.  
  
## Return Value  
 Specifies the translated value of the dialog-box item text. Since 0 is a valid return value, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be used to detect errors. If a signed return value is desired, cast it as an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type.  
  
 The function returns 0 if the translated number is greater than INT_MAX (for signed numbers) or UINT_MAX (for unsigned).  
  
 When errors occur, such as encountering nonnumeric characters and exceeding the above maximum, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> copies 0 to the location pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If there are no errors, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> receives a nonzero value. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **NULL**, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not warn about errors.  
  
## Remarks  
 It translates the text of the specified control in the given dialog box into an integer value by stripping any extra spaces at the beginning of the text and converting decimal digits. It stops the translation when it reaches the end of the text or encounters any nonnumeric character.  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> checks for a minus sign (–) at the beginning of the text and translates the text into a signed number. Otherwise, it creates an unsigned value.  
  
 It sends a [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627) message to the control.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDlgItemText](../vs140/cwnd--getdlgitemtext.md)   
 [GetDlgItemInt](http://msdn.microsoft.com/library/windows/desktop/ms645485)