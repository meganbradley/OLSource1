---
title: "CMonthCalCtrl::SetRange"
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
  - "CMonthCalCtrl.SetRange"
  - "CMonthCalCtrl::SetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "SetRange method"
ms.assetid: f29ffd13-2862-4386-a3f2-0edd865c7029
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetRange
Sets the minimum and maximum allowable dates for a month calendar control.  
  
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
 This member function implements the behavior of the Win32 message [MCM_SETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761012), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure usage.  
  
## Example  
 See the example for [CMonthCalCtrl::GetRange](../vs140/cmonthcalctrl--getrange.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetRange](../vs140/cmonthcalctrl--getrange.md)