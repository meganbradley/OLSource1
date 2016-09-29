---
title: "CMonthCalCtrl::SetColor"
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
  - "SetColor"
  - "CMonthCalCtrl.SetColor"
  - "MCSC_MONTHBK"
  - "MCSC_TRAILINGTEXT"
  - "MCSC_BACKGROUND"
  - "CMonthCalCtrl::SetColor"
  - "MCSC_TEXT"
  - "MCSC_TITLEBK"
  - "MCSC_TITLETEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MCSC_TRAILINGTEXT"
  - "MCSC_TITLETEXT"
  - "CMonthCalCtrl class, operations"
  - "MCSC_TEXT"
  - "MCSC_BACKGROUND"
  - "MCSC_MONTHBK"
  - "SetColor method"
  - "MCSC_TITLEBK"
ms.assetid: 3dae79c3-148f-49c9-acba-81a3b3aa5e01
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetColor
Sets the color of a specified area of a month calendar control.  
  
## Syntax  
  
```  
  
      COLORREF SetColor(  
   int nRegion,  
   COLORREF ref   
);  
```  
  
#### Parameters  
 `nRegion`  
 An integer value specifying which month calendar color to set. This value can be one of the following.  
  
|Value|Meaning|  
|-----------|-------------|  
|MCSC_BACKGROUND|The background color displayed between months.|  
|MCSC_MONTHBK|The background color displayed within the month.|  
|MCSC_TEXT|The color used to display text within a month.|  
|MCSC_TITLEBK|The background color displayed in the calendar's title.|  
|MCSC_TITLETEXT|The color used to display text within the calendar's title.|  
|MCSC_TRAILINGTEXT|The color used to display header and trailing-day text. Header and trailing days are the days from the previous and following months that appear on the current calendar.|  
  
 `ref`  
 A **COLORREF** value for the new color setting for the specified portion of the month calendar control.  
  
## Return Value  
 A **COLORREF** value that represents the previous color setting for the specified portion of the month calendar control, if successful. Otherwise this message returns -1.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760997), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#4](../vs140/codesnippet/CPP/cmonthcalctrl--setcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetColor](../vs140/cmonthcalctrl--getcolor.md)