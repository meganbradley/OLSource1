---
title: "CMonthCalCtrl::GetCurSel"
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
  - "CMonthCalCtrl::GetCurSel"
  - "CMonthCalCtrl.GetCurSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "GetCurSel method"
ms.assetid: 2d1b1530-3919-45c1-a904-87a978b69dd5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetCurSel
Retrieves the system time as indicated by the currently-selected date.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) object or a [CTime](../vs140/ctime-class.md) object. Receives the current time.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that will receive the currently-selected date information. This parameter must be a valid address and cannot be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwize 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb760957), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function fails if the style **MCS_MULTISELECT** is set.  
  
 In MFC's implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure usage.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetCurSel](../vs140/cmonthcalctrl--setcursel.md)