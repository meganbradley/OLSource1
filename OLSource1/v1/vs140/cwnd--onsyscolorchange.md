---
title: "CWnd::OnSysColorChange"
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
  - "OnSysColorChange"
  - "WM_SYSCOLORCHANGE"
  - "CWnd.OnSysColorChange"
  - "CWnd::OnSysColorChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SYSCOLORCHANGE"
  - "OnSysColorChange method"
ms.assetid: 3f0a2263-e9ac-4a93-a3fc-6405f0bb2696
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSysColorChange
The framework calls this member function for all top-level windows when a change is made in the system color setting.  
  
## Syntax  
  
```  
  
afx_msg void OnSysColorChange( );  
```  
  
## Remarks  
 Windows calls `OnSysColorChange` for any window that is affected by a system color change.  
  
 Applications that have brushes that use the existing system colors should delete those brushes and re-create them with the new system colors.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetSysColors](http://msdn.microsoft.com/library/windows/desktop/ms724940)   
 [WM_SYSCOLORCHANGE](http://msdn.microsoft.com/library/windows/desktop/dd145223)