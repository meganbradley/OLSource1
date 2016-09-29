---
title: "CMonthCalCtrl::SetToday"
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
  - "CMonthCalCtrl.SetToday"
  - "CMonthCalCtrl::SetToday"
  - "SetToday"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMonthCalCtrl class, operations"
  - "SetToday method"
ms.assetid: 92fca090-9869-407b-b5e5-739f8d59b9f5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::SetToday
Sets the calendar control for the current day.  
  
## Syntax  
  
```  
  
      void SetToday(  
   const COleDateTime& refDateTime   
);  
void SetToday(  
   const CTime* pDateTime   
);  
void SetToday(  
   const LPSYSTEMTIME pDateTime   
);  
```  
  
#### Parameters  
 `refDateTime`  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) object that contains the current date.  
  
 `pDateTime`  
 In the second version, a pointer to a [CTime](../vs140/ctime-class.md) object containing the current date information. In the third version, a pointer to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the current date information.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_SETTODAY](http://msdn.microsoft.com/library/windows/desktop/bb761016), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CMonthCalCtrl::GetToday](../vs140/cmonthcalctrl--gettoday.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetToday](../vs140/cmonthcalctrl--gettoday.md)