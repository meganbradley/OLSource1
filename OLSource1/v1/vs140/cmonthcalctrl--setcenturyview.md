---
title: "CMonthCalCtrl::SetCenturyView"
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
  - "CMonthCalCtrl::SetCenturyView"
  - "CMonthCalCtrl.SetCenturyView"
  - "SetCenturyView method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCenturyView method"
ms.assetid: 27ea8d0c-013a-43db-9a2a-dd0f90b0de04
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetCenturyView
Sets the current month calendar control to display the century view.  
  
## Syntax  
  
```  
BOOL SetCenturyView();  
```  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method uses the [CMonthCalCtrl::SetCurrentView](../vs140/cmonthcalctrl--setcurrentview.md) method to set the view to `MCMV_CENTURY`, which represents the century view.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_SETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760998)   
 [CMonthCalCtrl::SetCurrentView](../vs140/cmonthcalctrl--setcurrentview.md)