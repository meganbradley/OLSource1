---
title: "CMFCToolBarDateTimeCtrl::GetTime"
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
  - "CMFCToolBarDateTimeCtrl::GetTime"
  - "CMFCToolBarDateTimeCtrl.GetTime"
  - "GetTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTime method"
ms.assetid: dd79dc90-7089-4230-8f1b-5c7fc6aa7b40
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::GetTime
Gets the selected time from the associated date and time picker control and puts it in a specified [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure  
  
## Syntax  
  
```  
BOOL GetTime(  
   COleDateTime& timeDest   
) const;  
DWORD GetTime(  
   CTime& timeDest   
) const;  
DWORD GetTime(  
   LPSYSTEMTIME pTimeDest   
) const;  
  
```  
  
#### Parameters  
 `[out] timeDest`  
 In the first overload, a [COleDateTime](../vs140/coledatetime-class.md) object that will receive the system time information. In the second overload, a [CTime](../vs140/ctime-class.md) object that will receive the system time information.  
  
 `[out] pTimeDest`  
 A pointer to the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the system time information. Must not be `NULL`.  
  
## Return Value  
 In the first overload, nonzero if the time is successfully written to the [COleDateTime](../vs140/coledatetime-class.md) object; otherwise 0. In the second and third overloads, the return value is a `DWORD` that is equal to the dwFlag member that was set in the [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure.  
  
## Remarks  
 The method sets the [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure member dwFlags to indicate whether the date and time picker is set to a date and time. If the value equals GDT_NONE, the control is set to `no date` status, and uses the DTS_SHOWNONE style. If the value returned equals GDT_VALID, the system time is successfully stored in the destination location.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)