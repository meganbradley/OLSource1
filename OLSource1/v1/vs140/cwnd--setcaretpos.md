---
title: "CWnd::SetCaretPos"
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
  - "CWnd::SetCaretPos"
  - "SetCaretPos"
  - "CWnd.SetCaretPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCaretPos method"
  - "caret position"
ms.assetid: f85c4213-fa54-49a3-8aaf-6208b96a9765
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetCaretPos
Sets the position of the caret.  
  
## Syntax  
  
```  
  
      static void PASCAL SetCaretPos(  
   POINT point   
);  
```  
  
#### Parameters  
 `point`  
 Specifies the new x and y coordinates (in client coordinates) of the caret.  
  
## Remarks  
 The `SetCaretPos` member function moves the caret only if it is owned by a window in the current task. `SetCaretPos` moves the caret whether or not the caret is hidden.  
  
 The caret is a shared resource. A window should not move the caret if it does not own the caret.  
  
## Example  
 [!code[NVC_MFCWindowing#115](../vs140/codesnippet/CPP/cwnd--setcaretpos_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetCaretPos](../vs140/cwnd--getcaretpos.md)   
 [SetCaretPos](http://msdn.microsoft.com/library/windows/desktop/ms648405)