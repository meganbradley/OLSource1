---
title: "CRichEditCtrl::GetRedoName"
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
  - "CRichEditCtrl.GetRedoName"
  - "CRichEditCtrl::GetRedoName"
  - "GetRedoName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRedoName method"
ms.assetid: a8ffb63f-2cd8-404d-8dae-43e092948231
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetRedoName
Retrieves the type of the next available action in the redo queue, if any.  
  
## Syntax  
  
```  
  
UNDONAMEID GetRedoName( ) const;  
  
```  
  
## Return Value  
 If successful, `GetRedoName` returns the [UNDONAMEID](http://msdn.microsoft.com/library/windows/desktop/bb774365) enumeration type indicating the type of the next action in the control's redo queue. If the redo queue is empty, or if the redo action in the queue is of an unknown type, `GetRedoName` returns 0.  
  
## Remarks  
 The types of actions that can be undone or redone include typing, delete, drag-drop, cut, and paste operations. This information can be useful for applications that provide an extended user interface for Undo and Redo operations, such as a drop-down list box of redoable actions.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Redo](../vs140/cricheditctrl--redo.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::GetUndoName](../vs140/cricheditctrl--getundoname.md)