---
title: "CRichEditCtrl::Redo"
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
  - "CRichEditCtrl.Redo"
  - "Redo"
  - "CRichEditCtrl::Redo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Redo method"
ms.assetid: 77005eab-1f42-4f1d-a240-56319b805df4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::Redo
Redoes the next action in the control's redo queue.  
  
## Syntax  
  
```  
  
BOOL Redo( );  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 For more information, see [EM_REDO](http://msdn.microsoft.com/library/windows/desktop/bb774218) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::CanRedo](../vs140/cricheditctrl--canredo.md)   
 [CRichEditCtrl::GetRedoName](../vs140/cricheditctrl--getredoname.md)