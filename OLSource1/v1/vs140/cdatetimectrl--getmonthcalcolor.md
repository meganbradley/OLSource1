---
title: "CDateTimeCtrl::GetMonthCalColor"
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
  - "CDateTimeCtrl::GetMonthCalColor"
  - "GetMonthCalColor"
  - "CDateTimeCtrl.GetMonthCalColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMonthCalColor method"
ms.assetid: 3ef42768-2400-4e9b-bd58-141be6c3821c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetMonthCalColor
Retrieves the color for a given portion of the month calendar within the date and time picker control.  
  
## Syntax  
  
```  
  
      COLORREF GetMonthCalColor(  
   int iColor   
) const;  
```  
  
#### Parameters  
 `iColor`  
 An `int` value specifying which color area of the month calendar to retrieve. For a list of values, see the `iColor` parameter for [SetMonthCalColor](../vs140/cdatetimectrl--setmonthcalcolor.md).  
  
## Return Value  
 A **COLORREF** value that represents the color setting for the specified portion of the month calendar control if successful. The function returns -1 if unsuccessful.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_GETMCCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb761759), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#2](../vs140/codesnippet/CPP/cdatetimectrl--getmonthcalcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::SetMonthCalColor](../vs140/cdatetimectrl--setmonthcalcolor.md)