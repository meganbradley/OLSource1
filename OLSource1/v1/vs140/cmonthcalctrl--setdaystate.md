---
title: "CMonthCalCtrl::SetDayState"
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
  - "CMonthCalCtrl.SetDayState"
  - "CMonthCalCtrl::SetDayState"
  - "SetDayState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDayState method"
  - "CMonthCalCtrl class, operations"
ms.assetid: 74de8d66-1edf-4c44-ac4e-9bb93ca4668a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetDayState
Sets the display for days in a month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nMonths*  
 Value indicating how many elements are in the array that <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> points to.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [MONTHDAYSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760915) array of values that define how the month calendar control will draw each day in its display. The **MONTHDAYSTATE** data type is a bit field, where each bit (1 through 31) represents the state of a day in a month. If a bit is on, the corresponding day will be displayed in bold; otherwise it will be displayed with no emphasis.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETDAYSTATE](http://msdn.microsoft.com/library/windows/desktop/bb761004), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#6](../vs140/codesnippet/CPP/cmonthcalctrl--setdaystate_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)