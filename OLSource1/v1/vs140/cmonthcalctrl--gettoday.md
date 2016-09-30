---
title: "CMonthCalCtrl::GetToday"
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
  - "CMonthCalCtrl.GetToday"
  - "GetToday"
  - "CMonthCalCtrl::GetToday"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "GetToday method"
ms.assetid: 681f42e9-11f5-4bdd-a788-b0e656bc52d7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetToday
Retrieves the date information for the date specified as "today" for a month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object indicating the current day.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that will receive the date information. This parameter must be a valid address and cannot be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETTODAY](http://msdn.microsoft.com/library/windows/desktop/bb760987), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure usage.  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#3](../vs140/codesnippet/CPP/cmonthcalctrl--gettoday_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetToday](../vs140/cmonthcalctrl--settoday.md)