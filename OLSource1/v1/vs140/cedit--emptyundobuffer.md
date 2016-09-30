---
title: "CEdit::EmptyUndoBuffer"
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
  - "EmptyUndoBuffer"
  - "CEdit::EmptyUndoBuffer"
  - "CEdit.EmptyUndoBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EmptyUndoBuffer method"
  - "CEdit class, general operations"
ms.assetid: 950ef09e-7253-40e3-b534-46bed631b747
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::EmptyUndoBuffer
Call this function to reset (clear) the undo flag of an edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The edit control will now be unable to undo the last operation. The undo flag is set whenever an operation within the edit control can be undone.  
  
 The undo flag is automatically cleared whenever the [SetWindowText](../vs140/cwnd--setwindowtext.md) or [SetHandle](../vs140/cedit--sethandle.md) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member functions are called.  
  
 For more information, see [EM_EMPTYUNDOBUFFER](http://msdn.microsoft.com/library/windows/desktop/bb761568) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#7](../vs140/codesnippet/CPP/cedit--emptyundobuffer_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::CanUndo](../vs140/cedit--canundo.md)   
 [CEdit::SetHandle](../vs140/cedit--sethandle.md)   
 [CEdit::Undo](../vs140/cedit--undo.md)   
 [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md)