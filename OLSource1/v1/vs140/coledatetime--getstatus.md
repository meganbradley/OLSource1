---
title: "COleDateTime::GetStatus"
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
  - "ATL.COleDateTime.GetStatus"
  - "COleDateTime::GetStatus"
  - "COleDateTime.GetStatus"
  - "ATL::COleDateTime::GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DateTimeStatus method"
  - "GetStatus method"
ms.assetid: b9047549-c616-4cbc-9709-8b3ddd6b19d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetStatus
Gets the status (validity) of a given `COleDateTime` object.  
  
## Syntax  
  
```  
  
DateTimeStatus GetStatus( ) const throw( );  
  
```  
  
## Return Value  
 Returns the status of this `COleDateTime` value. If you call **GetStatus** on a `COleDateTime` object constructed with the default, it will return valid. If you call **GetStatus** on a `COleDateTime` object initialized with the constructor set to null, **GetStatus** will return null. See **Remarks** for more information.  
  
## Remarks  
 The return value is defined by the **DateTimeStatus** enumerated type, which is defined within the `COleDateTime` class.  
  
 `enum DateTimeStatus`  
  
 `{`  
  
 `error = -1,`  
  
 `valid = 0,`  
  
 `invalid = 1,    // Invalid date (out of range, etc.)`  
  
 `null = 2,       // Literally has no value`  
  
 `};`  
  
 For a brief description of these status values, see the following list:  
  
-   `COleDateTime::error` Indicates that an error occurred while attempting to obtain part of the date/time value.  
  
-   **COleDateTime::valid** Indicates that this `COleDateTime` object is valid.  
  
-   **COleDateTime::invalid** Indicates that this `COleDateTime` object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTime::null** Indicates that this `COleDateTime` object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a `COleDateTime` object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or `COleVariant` value that could not be converted to a date/time value.  
  
-   If its value is set from a `time_t`, `SYSTEMTIME`, or `FILETIME` value that could not be converted to a valid date/time value.  
  
-   If its value is set by `SetDateTime` with invalid parameter values.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely, `+=` or `-=`.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using `SetStatus`.  
  
 For more information about the operations that may set the status to invalid, see the following member functions:  
  
-   [COleDateTime](../vs140/coledatetime--coledatetime.md)  
  
-   [SetDateTime](../vs140/coledatetime--setdatetime.md)  
  
-   [operator +, -](../vs140/coledatetime--operator-----.md)  
  
-   [operator +=, -=](../vs140/coledatetime--operator--=---=.md)  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#10](../vs140/codesnippet/CPP/coledatetime--getstatus_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::SetStatus](../vs140/coledatetime--setstatus.md)   
 [COleDateTime::m_status](../vs140/coledatetime--m_status.md)