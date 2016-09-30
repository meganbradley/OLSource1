---
title: "CMonthCalCtrl::GetMonthRange"
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
  - "GMR_VISIBLE"
  - "GMR_DAYSTATE"
  - "CMonthCalCtrl.GetMonthRange"
  - "GetMonthRange"
  - "CMonthCalCtrl::GetMonthRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GMR_VISIBLE"
  - "CMonthCalCtrl class, operations"
  - "GMR_DAYSTATE"
  - "GetMonthRange method"
ms.assetid: 3ef66af0-5c21-4665-888d-ec9494190097
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetMonthRange
Retrieves date information representing the high and low limits of a month calendar control's display.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object containing the minimum date allowed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object containing the maximum date allowed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Value specifying the scope of the range limits to be retrieved. This value must be one of the following.  
  
|Value|Meaning|  
|-----------|-------------|  
|GMR_DAYSTATE|Include preceding and trailing months of visible range that are only partially displayed.|  
|GMR_VISIBLE|Include only those months that are entirely displayed.|  
  
## Return Value  
 An integer that represents the range, in months, spanned by the two limits indicated by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the first and second versions, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the third version.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETMONTHRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760981), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure usage.  
  
## Example  
 See the example for [CMonthCalCtrl::SetDayState](../vs140/cmonthcalctrl--setdaystate.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetRange](../vs140/cmonthcalctrl--getrange.md)