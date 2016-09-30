---
title: "CMonthCalCtrl::GetCalendarBorder"
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
  - "GetCalendarBorder method"
  - "CMonthCalCtrl::GetCalendarBorder"
  - "CMonthCalCtrl.GetCalendarBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCalendarBorder method"
ms.assetid: 6d2bdf58-221a-4d88-964e-94d8d52baeec
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetCalendarBorder
Retrieves the width of the border of the current month calendar control.  
  
## Syntax  
  
```  
int GetCalendarBorder() const;  
```  
  
## Return Value  
 The width of the control border, in pixels.  
  
## Remarks  
 This method sends the [MCM_GETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760945) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MCM_GETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760945)   
 [CMonthCalCtrl::SetCalendarBorder](../vs140/cmonthcalctrl--setcalendarborder.md)