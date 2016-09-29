---
title: "CWnd::GetTopWindow"
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
  - "CWnd::GetTopWindow"
  - "CWnd.GetTopWindow"
  - "GetTopWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTopWindow method"
ms.assetid: 25da4fe9-a8db-48fc-855e-42f9e52040b4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetTopWindow
Searches for the top-level child window that belongs to `CWnd`.  
  
## Syntax  
  
```  
  
CWnd* GetTopWindow( ) const;  
```  
  
## Return Value  
 Identifies the top-level child window in a `CWnd` linked list of child windows. If no child windows exist, the value is **NULL**.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 If `CWnd` has no children, this function returns **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetTopWindow](http://msdn.microsoft.com/library/windows/desktop/ms633514)