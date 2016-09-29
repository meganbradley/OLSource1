---
title: "CRichEditCtrl::CanRedo"
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
  - "CanRedo"
  - "CRichEditCtrl::CanRedo"
  - "CRichEditCtrl.CanRedo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanRedo method"
ms.assetid: 843b1ba7-1eb2-4b4c-af84-d5843edf9ffe
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::CanRedo
Determines if the redo queue contains any actions.  
  
## Syntax  
  
```  
  
BOOL CanRedo( ) const;  
  
```  
  
## Return Value  
 Nonzero if the redo queue contains actions, otherwise 0.  
  
## Remarks  
 To discover the name of the operation in the redo queue, call [CRichEditCtrl::GetRedoName](../vs140/cricheditctrl--getredoname.md). To redo the most recent Undo operation, call [Redo](../vs140/cricheditctrl--redo.md).  
  
 For more information, see [EM_CANREDO](http://msdn.microsoft.com/library/windows/desktop/bb787995) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::CanUndo](../vs140/cricheditctrl--canundo.md)