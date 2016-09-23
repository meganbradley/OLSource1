---
title: "CRectTracker::SetCursor"
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
  - CRectTracker::SetCursor
  - CRectTracker.SetCursor
dev_langs: 
  - C++
helpviewer_keywords: 
  - cursors, position
  - CRectTracker class, operations
  - SetCursor method
  - positioning cursors
ms.assetid: ebe5425a-17dc-4089-870c-79b394cae894
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRectTracker::SetCursor
Call this function to change the cursor shape while it is over the `CRectTracker` object's region.  
  
## Syntax  
  
```  
  
      BOOL SetCursor(  
   CWnd* pWnd,  
   UINT nHitTest   
) const;  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window that currently contains the cursor.  
  
 `nHitTest`  
 Results of the previous hit test, from the `WM_SETCURSOR` message.  
  
## Return Value  
 Nonzero if the previous hit was over the tracker rectangle; otherwise 0.  
  
## Remarks  
 Call this function from inside the function of your window that handles the `WM_SETCURSOR` message (typically `OnSetCursor`).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CRectTracker Class](../vs140/crecttracker-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRectTracker::NormalizeHit](../vs140/crecttracker--normalizehit.md)   
 [CRectTracker::HitTest](../vs140/crecttracker--hittest.md)   
 [CWinApp::LoadCursor](../vs140/cwinapp--loadcursor.md)   
 [CWnd::OnSetCursor](../vs140/cwnd--onsetcursor.md)