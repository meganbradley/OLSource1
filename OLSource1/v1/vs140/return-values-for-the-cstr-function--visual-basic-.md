---
title: "Return Values for the CStr Function (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "times, CStr Function return values"
  - "type conversion"
  - "dates [Visual Basic], CStr Function return values"
  - "CStr function"
  - "strings [Visual Basic], return value"
  - "Date data type, converting"
  - "dates [Visual Basic]"
  - "String data type, converting"
ms.assetid: 3aa744e7-1419-45d5-85e3-e5abc2953673
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return Values for the CStr Function (Visual Basic)
The following table describes the return values for `CStr` for different data types of `expression`.  
  
|If `expression` type is|`CStr` returns|  
|-----------------------------|--------------------|  
|[Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)|A string containing "True" or "False".|  
|[Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md)|A string containing a `Date` value (date and time) in the short date format of your system.|  
|[Numeric Data Types](../vs140/numeric-data-types--visual-basic-.md)|A string representing the number.|  
  
## CStr and Date  
 The `Date` type always contains both date and time information. For purposes of type conversion, Visual Basic considers 1/1/0001 (January 1 of the year 1) to be a *neutral value* for the date, and 00:00:00 (midnight) to be a neutral value for the time. `CStr` does not include neutral values in the resulting string. For example, if you convert `#January 1, 0001 9:30:00#` to a string, the result is "9:30:00 AM"; the date information is suppressed. However, the date information is still present in the original `Date` value and can be recovered with functions such as [DatePart](assetId:///M:Microsoft.VisualBasic.DateAndTime.DatePart(Microsoft.VisualBasic.DateInterval,System.DateTime,Microsoft.VisualBasic.FirstDayOfWeek,Microsoft.VisualBasic.FirstWeekOfYear)?qualifyHint=False&autoUpgrade=True).  
  
> [!NOTE]
>  The `CStr` function performs its conversion based on the current culture settings for the application. To get the string representation of a number in a particular culture, use the number's `ToString(IFormatProvider)` method. For example, use [Double.ToString](assetId:///M:System.Double.ToString(System.IFormatProvider)?qualifyHint=True&autoUpgrade=True) when converting a value of type `Double` to a `String`.  
  
## See Also  
 assetId:///M:Microsoft.VisualBasic.DateAndTime.DatePart(Microsoft.VisualBasic.DateInterval,System.DateTime,Microsoft.VisualBasic.FirstDayOfWeek,Microsoft.VisualBasic.FirstWeekOfYear)?qualifyHint=False&autoUpgrade=True   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)   
 [Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md)