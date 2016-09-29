---
title: "COleDateTime::COleDateTime"
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
  - "COleDateTime::COleDateTime"
  - "ATL::COleDateTime::COleDateTime"
  - "COleDateTime.COleDateTime"
  - "ATL.COleDateTime.COleDateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTime class, constructor"
ms.assetid: 26e27628-0044-49d6-9aca-825d24a4e797
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::COleDateTime
Constructs a `COleDateTime` object.  
  
## Syntax  
  
```  
  
      COleDateTime( ) throw( );   
COleDateTime(  
   const VARIANT& varSrc   
) throw( );  
COleDateTime(  
   DATE dtSrc   
) throw( );  
COleDateTime(  
   time_t timeSrc   
) throw( );  
COleDateTime(  
   __time64_t timeSrc   
) throw( );  
COleDateTime(  
   const SYSTEMTIME& systimeSrc   
) throw( );  
COleDateTime(  
   const FILETIME& filetimeSrc   
) throw( );  
COleDateTime(  
   int nYear,  
   int nMonth,  
   int nDay,  
   int nHour,  
   int nMin,  
   int nSec   
) throw( );  
COleDateTime(  
   WORD wDosDate,  
   WORD wDosTime   
) throw( );  
COleDateTime(  
   const DBTIMESTAMP& dbts  
) throw();  
```  
  
#### Parameters  
 `dateSrc`  
 An existing `COleDateTime` object to be copied into the new `COleDateTime` object.  
  
 *varSrc*  
 An existing **VARIANT** data structure (possibly a `COleVariant` object) to be converted to a date/time value (`VT_DATE`) and copied into the new `COleDateTime` object.  
  
 `dtSrc`  
 A date/time (**DATE**) value to be copied into the new `COleDateTime` object.  
  
 `timeSrc`  
 A `time_t` or **__time64_t** value to be converted to a date/time value and copied into the new `COleDateTime` object.  
  
 *systimeSrc*  
 A `SYSTEMTIME` structure to be converted to a date/time value and copied into the new `COleDateTime` object.  
  
 `filetimeSrc`  
 A `FILETIME` structure to be converted to a date/time value and copied into the new `COleDateTime` object. Note that `FILETIME` uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 `nYear`, `nMonth`, `nDay`, `nHour`, `nMin`, `nSec`  
 Indicate the date and time values to be copied into the new `COleDateTime` object.  
  
 `wDosDate`, `wDosTime`  
 MS-DOS date and time values to be converted to a date/time value and copied into the new `COleDateTime` object.  
  
 `dbts`  
 A reference to a <xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure containing the current local time.  
  
## Remarks  
 All these constructors create new `COleDateTime` objects initialized to the specified value. The following table shows valid ranges for each date and time component:  
  
|Date/time component|Valid range|  
|--------------------------|-----------------|  
|year|100 – 9999|  
|month|0 – 12|  
|day|0 – 31|  
|hour|0 – 23|  
|minute|0 – 59|  
|second|0 – 59|  
  
 Note that the actual upper bound for the day component varies based on the month and year components. For details, see the **SetDate** or `SetDateTime` member functions.  
  
 Following is a brief description of each constructor:  
  
-   `COleDateTime(` **)** Constructs a `COleDateTime` object initialized to 0 (midnight, 30 December 1899).  
  
-   `COleDateTime(` `dateSrc` **)** Constructs a `COleDateTime` object from an existing `COleDateTime` object.  
  
-   `COleDateTime(` *varSrc* **)** Constructs a `COleDateTime` object. Attempts to convert a `VARIANT` structure or [COleVariant](../vs140/colevariant-class.md) object to a date/time (`VT_DATE`) value. If this conversion is successful, the converted value is copied into the new `COleDateTime` object. If it is not, the value of the `COleDateTime` object is set to 0 (midnight, 30 December 1899) and its status to invalid.  
  
-   `COleDateTime(` `dtSrc` **)** Constructs a `COleDateTime` object from a **DATE** value.  
  
-   `COleDateTime(` `timeSrc` **)** Constructs a `COleDateTime` object from a `time_t` value.  
  
-   `COleDateTime(` *systimeSrc* **)** Constructs a `COleDateTime` object from a `SYSTEMTIME` value.  
  
-   `COleDateTime(` `filetimeSrc` **)** Constructs a `COleDateTime` object from a `FILETIME` value. . Note that `FILETIME` uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
-   `COleDateTime(` `nYear`, `nMonth`, `nDay`, `nHour`, `nMin`, `nSec` **)** Constructs a `COleDateTime` object from the specified numerical values.  
  
-   `COleDateTime(` `wDosDate`, `wDosTime` **)** Constructs a `COleDateTime` object from the specified MS-DOS date and time values.  
  
 For more information on the `time_t` data type, see the [time](../vs140/time--_time32--_time64.md) function in the *Run-Time Library Reference*.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
> [!NOTE]
>  The constructor using **DBTIMESTAMP** parameter is only available when OLEDB.h is included.  
  
## Example  
 [!CODE [NVC_ATLMFC_Utilities#2](NVC_ATLMFC_Utilities#2)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::SetDate](../vs140/coledatetime--setdate.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::SetTime](../vs140/coledatetime--settime.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::m_dt](../vs140/coledatetime--m_dt.md)   
 [COleDateTime::m_status](../vs140/coledatetime--m_status.md)