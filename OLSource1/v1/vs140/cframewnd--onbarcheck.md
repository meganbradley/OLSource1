---
title: "CFrameWnd::OnBarCheck"
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
  - CFrameWnd::OnBarCheck
  - CFrameWnd.OnBarCheck
  - OnBarCheck
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnBarCheck method
ms.assetid: 8f530568-1570-4ac2-8606-3b3fe52e74a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::OnBarCheck
Called whenever an action is performed on the specified control bar.  
  
## Syntax  
  
```  
  
      afx_msg BOOL OnBarCheck(  
   UINT nID  
);  
```  
  
#### Parameters  
 `nID`  
 The ID of the control bar being shown.  
  
## Return Value  
 Nonzero if the control bar existed; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)