---
title: "CRichEditCtrl::SetUndoLimit"
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
  - "CRichEditCtrl.SetUndoLimit"
  - "SetUndoLimit"
  - "CRichEditCtrl::SetUndoLimit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetUndoLimit method"
ms.assetid: f61f5e5c-b606-46d4-bf61-d55c3e65d733
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetUndoLimit
Sets the maximum number of actions that can stored in the undo queue.  
  
## Syntax  
  
```  
  
      UINT SetUndoLimit(  
   UINT nLimit   
);  
```  
  
#### Parameters  
 *nLimit*  
 Specifies the maximum number of actions that can be stored in the undo queue. Set to zero to disable Undo.  
  
## Return Value  
 The new maximum number of undo actions for the rich edit control.  
  
## Remarks  
 By default, the maximum number of actions in the undo queue is 100. If you increase this number, there must be enough available memory to accommodate the new number. For better performance, set the limit to the smallest possible value.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::EmptyUndoBuffer](../vs140/cricheditctrl--emptyundobuffer.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)