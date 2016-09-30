---
title: "CMonthCalCtrl::GetFirstDayOfWeek"
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
  - "CMonthCalCtrl::GetFirstDayOfWeek"
  - "GetFirstDayOfWeek"
  - "CMonthCalCtrl.GetFirstDayOfWeek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, attributes"
  - "GetFirstDayOfWeek method"
ms.assetid: e5fecbe6-214b-49f6-9a45-60852f890efa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetFirstDayOfWeek
Gets the first day of the week to be displayed in the leftmost column of the calendar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pbLocal*  
 A pointer to a **BOOL** value. If the value is non-zero, the control's setting does not match the setting in the control panel.  
  
## Return Value  
 An integer value that represents the first day of the week. See **Remarks** for more information on what these integers represent.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETFIRSTDAYOFWEEK](http://msdn.microsoft.com/library/windows/desktop/bb760958), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The days of the week are represented as integers, as follows.  
  
|Value|Day of the week|  
|-----------|---------------------|  
|0|Monday|  
|1|Tuesday|  
|2|Wednesday|  
|3|Thursday|  
|4|Friday|  
|5|Saturday|  
|6|Sunday|  
  
## Example  
 See the example for [CMonthCalCtrl::SetFirstDayOfWeek](../vs140/cmonthcalctrl--setfirstdayofweek.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetFirstDayOfWeek](../vs140/cmonthcalctrl--setfirstdayofweek.md)