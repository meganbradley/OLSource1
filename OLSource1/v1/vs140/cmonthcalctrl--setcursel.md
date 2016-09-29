---
title: "CMonthCalCtrl::SetCurSel"
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
  - "CMonthCalCtrl.SetCurSel"
  - "CMonthCalCtrl::SetCurSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCurSel method"
  - "CMonthCalCtrl class, operations"
ms.assetid: b26e54ac-cf59-429a-9a14-25d2706ac5df
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetCurSel
Sets the currently selected date for a month calendar control.  
  
## Syntax  
  
```  
  
      BOOL SetCurSel(  
   const COleDateTime& refDateTime   
);  
BOOL SetCurSel(  
   const CTime& refDateTime   
);  
BOOL SetCurSel(  
   const LPSYSTEMTIME pDateTime   
);  
```  
  
#### Parameters  
 `refDateTime`  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object indicating the currently-selected month calendar control.  
  
 `pDateTime`  
 Pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the date to be set as the current selection.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb761002), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of `SetCurSel`, you can specify a `COleDateTime` usage, a `CTime` usage, or a `SYSTEMTIME` structure usage.  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#5](../vs140/codesnippet/CPP/cmonthcalctrl--setcursel_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetCurSel](../vs140/cmonthcalctrl--getcursel.md)