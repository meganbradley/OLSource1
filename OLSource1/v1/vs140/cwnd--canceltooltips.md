---
title: "CWnd::CancelToolTips"
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
  - CWnd::CancelToolTips
  - CWnd.CancelToolTips
  - CancelToolTips
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd class, tool tip functions
  - canceling tool tips
  - CancelToolTips method
  - tool tips [C++], canceling
ms.assetid: 55bbf7c6-124d-4f2e-84b6-a183a2897e15
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::CancelToolTips
Call this member function to remove a tool tip from the screen if a tool tip is currently displayed.  
  
## Syntax  
  
```  
  
      static void PASCAL CancelToolTips(  
   BOOL bKeys = FALSE   
);  
```  
  
#### Parameters  
 *bKeys*  
 **TRUE** to cancel tool tips when a key is pressed and set the status bar text to the default; otherwise **FALSE**.  
  
## Remarks  
  
> [!NOTE]
>  Using this member function has no effect on tool tips managed by your code. It only affects the tool tip control managed by [CWnd::EnableToolTips](../vs140/cwnd--enabletooltips.md).  
  
## Example  
 [!code[NVC_MFCWindowing#73](../vs140/codesnippet/CPP/cwnd--canceltooltips_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableToolTips](../vs140/cwnd--enabletooltips.md)   
 [TTM_ACTIVATE](http://msdn.microsoft.com/library/windows/desktop/bb760326)