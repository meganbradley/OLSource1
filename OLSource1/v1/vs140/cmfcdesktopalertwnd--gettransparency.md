---
title: "CMFCDesktopAlertWnd::GetTransparency"
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
  - GetTransparency
  - CMFCDesktopAlertWnd.GetTransparency
  - CMFCDesktopAlertWnd::GetTransparency
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTransparency method
ms.assetid: d3e244fb-1d29-408e-b807-b8b89fb53622
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDesktopAlertWnd::GetTransparency
Returns the transparency level.  
  
## Syntax  
  
```  
BYTE GetTransparency() const;  
```  
  
## Return Value  
 A transparency level between 0 and 255, inclusive. The greater the value, the more opaque the window.  
  
## Remarks  
 Use this method to retrieve the current transparency level of the alert window.  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)