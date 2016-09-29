---
title: "CMFCRibbonEdit::Redraw"
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
  - "Redraw"
  - "CMFCRibbonEdit::Redraw"
  - "CMFCRibbonEdit.Redraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Redraw method"
ms.assetid: a4aca05c-9355-4a0c-8783-91f7ec6b6132
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::Redraw
Updates the display of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
## Syntax  
  
```  
virtual void Redraw();  
```  
  
## Remarks  
 This method redraws the display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object by indirectly calling [CWnd::RedrawWindow](http://msdn.microsoft.com/library/windows/desktop/dd162911) with the `RDW_INVALIDATE`, `RDW_ERASE`, and `RDW_UPDATENOW` flags set.  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)