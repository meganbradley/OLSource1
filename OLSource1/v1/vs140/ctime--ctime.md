---
title: "CTime::CTime"
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
  - "ATL::CTime::CTime"
  - "CTime.CTime"
  - "CTime::CTime"
  - "ATL.CTime.CTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, construction/destruction"
  - "CTime class, constructor"
ms.assetid: 61e1df48-a59f-44cd-a3ad-f2a1308da3da
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::CTime
Creates a new `CTime` object initialized with the specified time.  
  
## Syntax  
  
```  
  
      CTime( ) throw( );  
CTime(  
   __time64_t time   
) throw( );  
CTime(  
   int nYear,  
   int nMonth,  
   int nDay,  
   int nHour,  
   int nMin,  
   int nSec,  
   int nDST = -1   
);  
CTime(  
   WORD wDosDate,  
   WORD wDosTime,  
   int nDST = -1   
);  
CTime(  
   const SYSTEMTIME& st,  
   int nDST = - 1   
) throw( );  
CTime(  
   const FILETIME& ft,  
   int nDST = - 1   
);  
CTime(  
   const DBTIMESTAMP& dbts,  
   int nDST = -1  
) throw( );  
```  
  
#### Parameters  
 `timeSrc`  
 Indicates a `CTime` object that already exists.  
  
 `time`  
 A **__time64_t** time value, which is the number of seconds after January 1, 1970 UTC. Note that this will be adjusted to your local time. For example, if you are in New York and create a `CTime` object by passing a parameter of 0, [CTime::GetMonth](../vs140/ctime--getmonth.md) will return 12.  
  
 In Visual C++ versions 6.0 and earlier, `time` was a value of `time_t`. Visual C++ .NET and later converts a `time_t` parameter to **__time64_t**.  
  
 `nYear`, `nMonth`, `nDay`, `nHour`, `nMin`, `nSec`  
 Indicates the date and time values to be copied into the new `CTime` object.  
  
 `nDST`  
 Indicates whether daylight savings time is in effect. Can have one of three values:  
  
-   `nDST` set to 0   Standard time is in effect.  
  
-   `nDST` set to a value greater than 0   Daylight savings time is in effect.  
  
-   `nDST` set to a value less than 0   The default. Automatically computes whether standard time or daylight savings time is in effect.  
  
 `wDosDate`, `wDosTime`  
 MS-DOS date and time values to be converted to a date/time value and copied into the new `CTime` object.  
  
 `st`  
 A [SYSTEMTIME](../vs140/systemtime-structure.md) structure to be converted to a date/time value and copied into the new `CTime` object.  
  
 `ft`  
 A [FILETIME](../vs140/filetime-structure.md) structure to be converted to a date/time value and copied into the new `CTime` object.  
  
 dbts  
 A reference to a <xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure containing the current local time.  
  
## Remarks  
 Each constructor is described below:  
  
-   **CTime( );** Constructs an uninitialized `CTime` object. This constructor allows you to define `CTime` object arrays. You should initialize such arrays with valid times before using.  
  
-   **CTime( const CTime& );** Constructs a `CTime` object from another `CTime` value.  
  
-   **CTime( __time64_t );** Constructs a `CTime` object from a **__time64_t** type. This constructor expects a UTC time and converts the result to a local time before storing the result.  
  
-   **CTime( int, int, ...);** Constructs a `CTime` object from local time components with each component constrained to the following ranges:  
  
    |Component|Range|  
    |---------------|-----------|  
    |`nYear`|1970–3000|  
    |`nMonth`|1–12|  
    |`nDay`|1–31|  
    |`nHour`|0-23|  
    |`nMin`|0-59|  
    |`nSec`|0-59|  
  
     This constructor makes the appropriate conversion to UTC. The Debug version of the Microsoft Foundation Class Library asserts if one or more of the time components are out of range. You must validate the arguments before calling. This constructor expects a local time.  
  
-   `CTime`( **WORD, WORD** )**;** Constructs a `CTime` object from the specified MS-DOS date and time values. This constructor expects a local time.  
  
-   `CTime`( **const SYSTEMTIME&** )**;** Constructs a `CTime` object from a `SYSTEMTIME` structure. This constructor expects a local time.  
  
-   `CTime`( **const FILETIME&** )**;** Constructs a `CTime` object from a `FILETIME` structure. You most likely will not use `CTime` `FILETIME` initialization directly. If you use a `CFile` object to manipulate a file, `CFile::GetStatus` retrieves the file time stamp for you through a `CTime` object initialized with a `FILETIME` structure. This constructor assumes a time based on UTC and automatically converts the value to local time before storing the result.  
  
    > [!NOTE]
    >  The constructor using **DBTIMESTAMP** parameter is only available when OLEDB.h is included.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Also see the [MS-DOS Date and Time](http://msdn.microsoft.com/library/windows/desktop/ms724503) entry in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
## Example  
 [!CODE [NVC_ATLMFC_Utilities#148](NVC_ATLMFC_Utilities#148)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::GetTime](../vs140/ctime--gettime.md)   
 [CTime::GetCurrentTime](../vs140/ctime--getcurrenttime.md)   
 [CTime::operator =](../vs140/ctime--operator-=.md)