---
title: "CEdit::SetLimitText"
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
  - "CEdit::SetLimitText"
  - "SetLimitText"
  - "CEdit.SetLimitText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLimitText method"
ms.assetid: 71a587f2-075a-4bba-b500-7ce4e72246f2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetLimitText
Call this member function to set the text limit for this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new text limit, in characters.  
  
## Remarks  
 The text limit is the maximum amount of text, in characters, that the edit control can accept.  
  
 Changing the text limit restricts only the text the user can enter. It has no effect on any text already in the edit control, nor does it affect the length of the text copied to the edit control by the [SetWindowText](../vs140/cwnd--setwindowtext.md) member function in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If an application uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function to place more text into an edit control than is specified in the call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the user can delete any of the text within the edit control. However, the text limit will prevent the user from replacing the existing text with new text, unless deleting the current selection causes the text to fall below the text limit.  
  
 This function replaces [LimitText](../vs140/cedit--limittext.md) in Win32.  
  
 For more information, see [EM_SETLIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761647) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEditView::GetEditCtrl](../vs140/ceditview--geteditctrl.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::GetLimitText](../vs140/cedit--getlimittext.md)   
 [CEdit::LimitText](../vs140/cedit--limittext.md)