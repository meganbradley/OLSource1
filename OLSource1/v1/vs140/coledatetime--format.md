---
title: "COleDateTime::Format"
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
  - COleDateTime.Format
  - ATL::COleDateTime::Format
  - COleDateTime::Format
  - ATL.COleDateTime.Format
dev_langs: 
  - C++
helpviewer_keywords: 
  - Format method
ms.assetid: 77faab57-e4ce-4662-abb0-611ad6bd68cb
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::Format
Creates a formatted representation of the date/time value.  
  
## Syntax  
  
```  
CString Format(  
   DWORD dwFlags = 0,  
   LCID lcid = LANG_USER_DEFAULT  
) const;  
CString Format(  
   LPCTSTR lpszFormat   
) const;  
CString Format(  
   UINT nFormatID   
) const;  
```  
  
#### Parameters  
 `dwFlags`  
 Indicates one of the following locale flags:  
  
-   `LOCALE_NOUSEROVERRIDE` Use the system default locale settings, instead of custom user settings.  
  
-   `VAR_TIMEVALUEONLY` Ignore the date portion during parsing.  
  
-   `VAR_DATEVALUEONLY` Ignore the time portion during parsing.  
  
 `lcid`  
 Indicates locale ID to use for the conversion. For more information about language identifiers, see [Language Identifiers](http://msdn.microsoft.com/library/windows/desktop/dd318691).  
  
 `lpszFormat`  
 A formatting string similar to the `printf` formatting string. Each formatting code, preceded by a percent (`%`) sign, is replaced by the corresponding `COleDateTime` component. Other characters in the formatting string are copied unchanged to the returned string. See the run-time function [strftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for more information. The value and meaning of the formatting codes for `Format` are:  
  
-   `%H` Hours in the current day  
  
-   `%M` Minutes in the current hour  
  
-   `%S` Seconds in the current minute  
  
-   `%%` Percent sign  
  
 `nFormatID`  
 The resource ID for the format-control string.  
  
## Return Value  
 A `CString` that contains the formatted date/time value.  
  
## Remarks  
 If the status of this `COleDateTime` object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource `ATL_IDS_DATETIME_INVALID`.  
  
 A brief description of the three forms for this function follows:  
  
 `Format`( `dwFlags`, `lcid`)  
 This form formats the value by using the language specifications (locale IDs) for date and time. Using the default parameters, this form will print the date and the time, unless the time portion is 0 (midnight), in which case it will print just the date, or the date portion is 0 (30 December 1899), in which case it will print just the time. If the date/time value is 0 (30 December 1899, midnight), this form with the default parameters will print midnight.  
  
 `Format`( `lpszFormat`)  
 This form formats the value by using the format string which contains special formatting codes that are preceded by a percent sign (%), as in `printf`. The formatting string is passed as a parameter to the function. For more information about the formatting codes, see [strftime, wcsftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) in the Run-Time Library Reference.  
  
 `Format`( `nFormatID`)  
 This form formats the value by using the format string which contains special formatting codes that are preceded by a percent sign (%), as in `printf`. The formatting string is a resource. The ID of this string resource is passed as the parameter. For more information about the formatting codes, see [strftime, wcsftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) in the *Run-Time Library Reference*.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#3](../vs140/codesnippet/CPP/coledatetime--format_1.cpp)]
  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::ParseDateTime](../vs140/coledatetime--parsedatetime.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)