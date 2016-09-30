---
title: "CRichEditCtrl::CanUndo"
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
  - "CRichEditCtrl::CanUndo"
  - "CRichEditCtrl.CanUndo"
  - "CanUndo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanUndo method"
ms.assetid: 809f2f22-2557-4821-aebd-f4d4e7134500
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::CanUndo
Determines if the last editing operation can be undone.  
  
## Syntax  
  
```  
  
BOOL CanUndo( ) const;  
  
```  
  
## Return Value  
 Nonzero if the last edit operation can be undone by a call to the [Undo](../vs140/cricheditctrl--undo.md) member function; 0 if it cannot be undone.  
  
## Remarks  
 For more information, see [EM_CANUNDO](http://msdn.microsoft.com/library/windows/desktop/bb775468) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#2](../vs140/codesnippet/CPP/cricheditctrl--canundo_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::EmptyUndoBuffer](../vs140/cricheditctrl--emptyundobuffer.md)   
 [CRichEditCtrl::CanRedo](../vs140/cricheditctrl--canredo.md)   
 [CRichEditCtrl::GetRedoName](../vs140/cricheditctrl--getredoname.md)