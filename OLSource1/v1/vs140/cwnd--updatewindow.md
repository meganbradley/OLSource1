---
title: "CWnd::UpdateWindow"
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
  - "CWnd.UpdateWindow"
  - "CWnd::UpdateWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "client areas, updating"
  - "UpdateWindow method"
  - "updating client areas"
ms.assetid: 8c15f847-c9ca-4cd0-8a89-5ece5eae80e6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::UpdateWindow
Updates the client area by sending a [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message if the update region is not empty.  
  
## Syntax  
  
```  
  
void UpdateWindow( );  
```  
  
## Remarks  
 The `UpdateWindow` member function sends a `WM_PAINT` message directly, bypassing the application queue. If the update region is empty, `WM_PAINT` is not sent.  
  
## Example  
 [!code[NVC_MFCWindowing#124](../vs140/codesnippet/CPP/cwnd--updatewindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [UpdateWindow](http://msdn.microsoft.com/library/windows/desktop/dd145167)   
 [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md)