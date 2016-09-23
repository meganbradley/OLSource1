---
title: "CTimeSpan::CTimeSpan"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CTimeSpan::CTimeSpan
  - CTimeSpan::CTimeSpan
  - ATL.CTimeSpan.CTimeSpan
  - CTimeSpan.CTimeSpan
dev_langs: 
  - C++
helpviewer_keywords: 
  - CTimeSpan class, constructor
  - CTimeSpan class, construction/destruction
ms.assetid: 027ca262-bccc-45fe-a0c6-7fe201a99cb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTimeSpan::CTimeSpan
Constructs `CTimeSpan` objects in various ways.  
  
## Syntax  
  
```  
  
      CTimeSpan( ) throw( );  
CTimeSpan(  
   __time64_t time   
) throw( );  
CTimeSpan(  
   LONG lDays,  
   int nHours,  
   int nMins,  
   int nSecs   
) throw( );  
```  
  
#### Parameters  
 *timeSpanSrc*  
 A `CTimeSpan` object that already exists.  
  
 `time`  
 A **__time64_t** time value, which is the number of seconds in the time span. In Visual C++ versions 6.0 and earlier, `time` was a value of `time_t`. Visual C++ .NET or later silently converts a `time_t` parameter to **__time64_t**.  
  
 `lDays`, `nHours`, `nMins`, `nSecs`  
 Days, hours, minutes, and seconds, respectively.  
  
## Remarks  
 All these constructors create a new `CTimeSpan` object initialized with the specified relative time. Each constructor is described below:  
  
-   **CTimeSpan( );** Constructs an uninitialized `CTimeSpan` object.  
  
-   **CTimeSpan( const CTimeSpan& );** Constructs a `CTimeSpan` object from another `CTimeSpan` value.  
  
-   **CTimeSpan( __time64_t );** Constructs a `CTimeSpan` object from a **__time64_t** type.  
  
-   **CTimeSpan( LONG**, **int, int, int );** Constructs a `CTimeSpan` object from components with each component constrained to the following ranges:  
  
    |Component|Range|  
    |---------------|-----------|  
    |`lDays`|0–25,000 (approximately)|  
    |`nHours`|0–23|  
    |`nMins`|0–59|  
    |`nSecs`|0–59|  
  
 Note that the Debug version of the Microsoft Foundation Class Library asserts if one or more of the time-day components is out of range. It is your responsibility to validate the arguments prior to calling.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#162](../vs140/codesnippet/CPP/ctimespan--ctimespan_1.cpp)]
  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)