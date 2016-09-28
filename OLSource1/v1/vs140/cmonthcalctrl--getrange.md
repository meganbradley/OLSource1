---
title: "CMonthCalCtrl::GetRange"
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
  - "GDTR_MAX"
  - "CMonthCalCtrl.GetRange"
  - "GDTR_MIN"
  - "CMonthCalCtrl::GetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "GetRange method"
  - "GDTR_MAX"
  - "GDTR_MIN"
ms.assetid: 040e1d86-1a33-4805-97fc-e7d563c6674b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetRange
Retrieves the current minimum and maximum dates set in a month calendar control.  
  
## Syntax  
  
```  
  
      DWORD GetRange(  
   COleDateTime* pMinRange,  
   COleDateTime* pMaxRange   
) const;  
DWORD GetRange(  
   CTime* pMinRange,  
   CTime* pMaxRange   
) const;  
DWORD GetRange(  
   LPSYSTEMTIME pMinRange,  
   LPSYSTEMTIME pMaxRange   
) const;  
```  
  
#### Parameters  
 `pMinRange`  
 A pointer to a `COleDateTime` object, a `CTime` object, or [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 `pMaxRange`  
 A pointer to a `COleDateTime` object, a `CTime` object, or [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the highest end of the range.  
  
## Return Value  
 A `DWORD` that can be zero (no limits are set) or a combination of the following values that specify limit information.  
  
|Value|Meaning|  
|-----------|-------------|  
|GDTR_MAX|A maximum limit is set for the control; `pMaxRange` is valid and contains the applicable date information.|  
|GDTR_MIN|A minimum limit is set for the control; `pMinRange` is valid and contains the applicable date information.|  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760983), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of `GetRange`, you can specify a `COleDateTime` usage, a `CTime` usage, or a `SYSTEMTIME` structure usage.  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#2](../vs140/codesnippet/CPP/cmonthcalctrl--getrange_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SetRange](../vs140/cmonthcalctrl--setrange.md)