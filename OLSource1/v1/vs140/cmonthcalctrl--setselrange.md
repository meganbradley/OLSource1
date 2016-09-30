---
title: "CMonthCalCtrl::SetSelRange"
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
  - "SetSelRange"
  - "CMonthCalCtrl::SetSelRange"
  - "CMonthCalCtrl.SetSelRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "SetSelRange method"
ms.assetid: 1e398c9e-53b1-45be-be4c-e125cc978dc9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetSelRange
Sets the selection for a month calendar control to a given date range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, or [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETSELRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761014), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure usage.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetSelRange](../vs140/cmonthcalctrl--getselrange.md)