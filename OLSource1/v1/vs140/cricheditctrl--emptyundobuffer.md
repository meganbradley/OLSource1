---
title: "CRichEditCtrl::EmptyUndoBuffer"
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
  - "CRichEditCtrl.EmptyUndoBuffer"
  - "EmptyUndoBuffer"
  - "CRichEditCtrl::EmptyUndoBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EmptyUndoBuffer method"
ms.assetid: c319bbb3-6606-450a-9d42-11afcf282c2e
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::EmptyUndoBuffer
Resets (clear) the undo flag of this rich edit control.  
  
## Syntax  
  
```  
  
void EmptyUndoBuffer( );  
  
```  
  
## Remarks  
 The control will now be unable to undo the last editing operation. The undo flag is set whenever an operation within the rich edit control can be undone.  
  
 The undo flag is automatically cleared whenever you call the [CWnd](../vs140/cwnd-class.md) member function [SetWindowText](../vs140/cwnd--setwindowtext.md).  
  
 For more information, see [EM_EMPTYUNDOBUFFER](http://msdn.microsoft.com/library/windows/desktop/bb761568) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#8](../vs140/codesnippet/CPP/cricheditctrl--emptyundobuffer_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::CanUndo](../vs140/cricheditctrl--canundo.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md)