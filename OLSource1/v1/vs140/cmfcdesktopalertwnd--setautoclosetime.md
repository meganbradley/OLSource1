---
title: "CMFCDesktopAlertWnd::SetAutoCloseTime"
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
  - "CMFCDesktopAlertWnd.SetAutoCloseTime"
  - "SetAutoCloseTime"
  - "CMFCDesktopAlertWnd::SetAutoCloseTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoCloseTime method"
ms.assetid: 97a00476-fcda-4f3f-ac06-abbb5d2e844e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertWnd::SetAutoCloseTime
Sets the auto-close time out.  
  
## Syntax  
  
```  
void SetAutoCloseTime(  
    int nTime   
);  
```  
  
#### Parameters  
 [in] `nTime`  
 The time, in milliseconds, that elapses before the alert window automatically closes.  
  
## Remarks  
 The alert window is automatically closed after the specified time if the user does not interact with the window.  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)