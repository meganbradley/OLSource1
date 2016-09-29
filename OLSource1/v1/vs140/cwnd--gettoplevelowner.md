---
title: "CWnd::GetTopLevelOwner"
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
  - "CWnd.GetTopLevelOwner"
  - "CWnd::GetTopLevelOwner"
  - "GetTopLevelOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTopLevelOwner method"
ms.assetid: 7a8e13aa-db3d-43cc-9065-adb05a0856b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetTopLevelOwner
Call this member function to retrieve the top-level window.  
  
## Syntax  
  
```  
  
CWnd* GetTopLevelOwner( ) const;  
  
```  
  
## Return Value  
 Identifies the top-level window. The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The top-level window is the window that is a child of the desktop. If `CWnd` has no attached window, this function returns **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetTopLevelFrame](../vs140/cwnd--gettoplevelframe.md)   
 [CWnd::GetTopLevelParent](../vs140/cwnd--gettoplevelparent.md)