---
title: "CMonthCalCtrl::SetFirstDayOfWeek"
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
  - CMonthCalCtrl::SetFirstDayOfWeek
  - CMonthCalCtrl.SetFirstDayOfWeek
  - SetFirstDayOfWeek
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMonthCalCtrl class, attributes
  - SetFirstDayOfWeek method
ms.assetid: a92364b9-4ac4-4512-be1d-9ad3dff97619
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::SetFirstDayOfWeek
Sets the day of week to be displayed in the leftmost column of the calendar.  
  
## Syntax  
  
```  
  
      BOOL SetFirstDayOfWeek(  
   int iDay,  
   int* lpnOld = NULL   
);  
```  
  
#### Parameters  
 *iDay*  
 An integer value representing which day is to be set as the first day of the week. This value must be one of the day numbers. See [GetFirstDayOfWeek](../vs140/cmonthcalctrl--getfirstdayofweek.md) for a description of the day numbers.  
  
 *lpnOld*  
 A pointer to an integer indicating the first day of the week previously set.  
  
## Return Value  
 Nonzero if the previous first day of the week is set to a value other than that of **LOCALE_IFIRSTDAYOFWEEK**, which is the day indicated in the control panel setting. Otherwise, this function returns 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETFIRSTDAYOFWEEK](http://msdn.microsoft.com/library/windows/desktop/bb761006), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#7](../vs140/codesnippet/CPP/cmonthcalctrl--setfirstdayofweek_1.cpp)]
  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetFirstDayOfWeek](../vs140/cmonthcalctrl--getfirstdayofweek.md)