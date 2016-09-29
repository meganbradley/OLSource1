---
title: "COleDateTime::operator ="
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
  - "COleDateTime::operator="
  - "COleDateTime.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, date time"
  - "operator=, date time"
  - "COleDateTime class, operators"
  - "= operator, with specific MFC objects"
ms.assetid: f2d544bf-85ad-4da7-9cea-7d7e35925a83
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::operator =
Copies a `COleDateTime` value.  
  
## Syntax  
  
```  
  
      COleDateTime& operator =(  
   const VARIANT& varSrc   
) throw( );  
COleDateTime& operator =(  
   DATE dtSrc   
) throw( );  
COleDateTime& operator =(  
   const time_t& timeSrc   
) throw( );  
COleDateTime& operator =(  
   const __time64_t& timeSrc   
) throw( );  
COleDateTime& operator =(  
   const SYSTEMTIME& systimeSrc   
) throw( );  
COleDateTime& operator =(  
   const FILETIME& filetimeSrc   
) throw( );  
COleDateTime& operator =(  
   const UDATE& udate   
) throw( );  
```  
  
## Remarks  
 These overloaded assignment operators copy the source date/time value into this `COleDateTime` object. A brief description of each these overloaded assignment operators follows:  
  
-   **operator =(**  `dateSrc`  **)** The value and status of the operand are copied into this `COleDateTime` object.  
  
-   **operator =(**  *varSrc*  **)** If the conversion of the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) value (or [COleVariant](../vs140/colevariant-class.md) object) to a date/time (`VT_DATE`) is successful, the converted value is copied into this `COleDateTime` object and its status is set to valid. If the conversion is not successful, the value of this object is set to zero (30 December 1899, midnight) and its status to invalid.  
  
-   **operator =(** `dtSrc` **)** The **DATE** value is copied into this `COleDateTime` object and its status is set to valid.  
  
-   **operator =(** `timeSrc` **)** The `time_t` or **__time64_t** value is converted and copied into this `COleDateTime` object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** *systimeSrc* **)** The [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) value is converted and copied into this `COleDateTime` object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** `udate` **)** The **UDATE** value is converted and copied into this `COleDateTime` object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid. A **UDATE** structure represents an "unpacked" date. See the function [VarDateFromUdate](assetId:///1c924ac5-b896-49e1-9ccf-825ac7a030c8) for more details.  
  
-   **operator =(** `filetimeSrc` **)** The [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) value is converted and copied into this `COleDateTime` object. If the conversion is successful, the status of this object is set to valid; otherwise it is set to invalid. `FILETIME` uses Universal Coordinated Time (UTC), so if you pass a UTC time in the structure, your results will be converted from UTC time to local time, and will be stored as variant time. This behavior is the same as in Visual C++ 6.0 and Visual C++.NET 2003 SP2. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on the `time_t` data type, see the [time](../vs140/time--_time32--_time64.md) function in the *Run-Time Library Reference*.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)