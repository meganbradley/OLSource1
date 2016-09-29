---
title: "CMonthCalCtrl::GetSelRange"
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
  - "GetSelRange"
  - "CMonthCalCtrl::GetSelRange"
  - "CMonthCalCtrl.GetSelRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "GetSelRange method"
ms.assetid: 447014fd-16ed-4274-b54a-6d2d285cd0ed
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetSelRange
Retrieves date information representing the upper and lower limits of the date range currently selected by the user.  
  
## Syntax  
  
```  
  
      BOOL GetSelRange(  
   COleDateTime& refMinRange,  
   COleDateTime& refMaxRange   
) const;  
BOOL GetSelRange(  
   CTime& refMinRange,  
   CTime& refMaxRange   
) const;  
BOOL GetSelRange(  
   LPSYSTEMTIME pMinRange,  
   LPSYSTEMTIME pMaxRange   
) const;  
```  
  
#### Parameters  
 `refMinRange`  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object containing the minimum date allowed.  
  
 `refMaxRange`  
 A reference to a `COleDateTime` or `CTime` object containing the maximum date allowed.  
  
 `pMinRange`  
 A pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 `pMaxRange`  
 A pointer to a `SYSTEMTIME` structure containing the date at the highest end of the range.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETSELRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760985), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. `GetSelRange` will fail if applied to a month calendar control that does not use the **MCS_MULTISELECT** style.  
  
 In MFC's implementation of `GetSelRange`, you can specify `COleDateTime` usage, a `CTime` usage, or a `SYSTEMTIME` structure usage.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetSelRange](../vs140/cmonthcalctrl--setselrange.md)