---
title: "CEdit::ReplaceSel"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CEdit.ReplaceSel
  - CEdit::ReplaceSel
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReplaceSel method
  - CEdit class, general operations
ms.assetid: 352c8d29-0020-4e3f-b633-7a27f5b64139
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEdit::ReplaceSel
Call this function to replace the current selection in an edit control with the text specified by `lpszNewText`.  
  
## Syntax  
  
```  
  
      void ReplaceSel(  
   LPCTSTR lpszNewText,  
   BOOL bCanUndo = FALSE   
);  
```  
  
#### Parameters  
 `lpszNewText`  
 Points to a null-terminated string containing the replacement text.  
  
 `bCanUndo`  
 To specify that this function can be undone, set the value of this parameter to **TRUE** . The default value is **FALSE**.  
  
## Remarks  
 Replaces only a portion of the text in an edit control. If you want to replace all of the text, use the [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md) member function.  
  
 If there is no current selection, the replacement text is inserted at the current cursor location.  
  
 For more information, see [EM_REPLACESEL](http://msdn.microsoft.com/library/windows/desktop/bb761633) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::LineIndex](../vs140/cedit--lineindex.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md)