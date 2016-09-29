---
title: "Date Data Type (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Date"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Date data type"
  - "dates, Visual Basic data types"
  - "times, Date data type"
  - "Date literals"
  - "data values"
  - "times, Visual Basic data types"
  - "dates, Date data type"
  - "data types [Visual Basic], assigning"
  - "literals, Date"
  - "# specifier for Date literals"
ms.assetid: d9edf5b0-e85e-438b-a1cf-1f321e7c831b
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Date Data Type (Visual Basic)
Holds IEEE 64-bit (8-byte) values that represent dates ranging from January 1 of the year 0001 through December 31 of the year 9999, and times from 12:00:00 AM (midnight) through 11:59:59.9999999 PM. Each increment represents 100 nanoseconds of elapsed time since the beginning of January 1 of the year 1 in the Gregorian calendar. The maximum value represents 100 nanoseconds before the beginning of January 1 of the year 10000.  
  
## Remarks  
 Use the `Date` data type to contain date values, time values, or date and time values.  
  
 The default value of `Date` is 0:00:00 (midnight) on January 1, 0001.  
  
 You can get the current date and time from the <xref:Microsoft.VisualBasic.DateAndTime*> class.  
  
## Format Requirements  
 You must enclose a `Date` literal within number signs (`# #`). You must specify the date value in the format M/d/yyyy, for example `#5/31/1993#`, or yyyy-MM-dd, for example `#1993-5-31#`. You can use slashes when specifying the year first.  This requirement is independent of your locale and your computer's date and time format settings.  
  
 The reason for this restriction is that the meaning of your code should never change depending on the locale in which your application is running. Suppose you hard-code a `Date` literal of `#3/4/1998#` and intend it to mean March 4, 1998. In a locale that uses mm/dd/yyyy, 3/4/1998 compiles as you intend. But suppose you deploy your application in many countries. In a locale that uses dd/mm/yyyy, your hard-coded literal would compile to April 3, 1998. In a locale that uses yyyy/mm/dd, the literal would be invalid (April 1998, 0003) and cause a compiler error.  
  
## Workarounds  
 To convert a `Date` literal to the format of your locale, or to a custom format, supply the literal to the <xref:Microsoft.VisualBasic.Strings.Format*> function, specifying either a predefined or user-defined date format. The following example demonstrates this.  
  
```  
MsgBox("The formatted date is " & Format(#5/31/1993#, "dddd, d MMM yyyy"))  
```  
  
 Alternatively, you can use one of the overloaded constructors of the <xref:System.DateTime*> structure to assemble a date and time value. The following example creates a value to represent May 31, 1993 at 12:14 in the afternoon.  
  
```  
Dim dateInMay As New System.DateTime(1993, 5, 31, 12, 14, 0)  
```  
  
## Hour Format  
 You can specify the time value in either 12-hour or 24-hour format, for example `#1:15:30 PM#` or `#13:15:30#`. However, if you do not specify either the minutes or the seconds, you must specify AM or PM.  
  
## Date and Time Defaults  
 If you do not include a date in a date/time literal, Visual Basic sets the date part of the value to January 1, 0001. If you do not include a time in a date/time literal, Visual Basic sets the time part of the value to the start of the day, that is, midnight (0:00:00).  
  
## Type Conversions  
 If you convert a `Date` value to the `String` type, Visual Basic renders the date according to the short date format specified by the run-time locale, and it renders the time according to the time format (either 12-hour or 24-hour) specified by the run-time locale.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, keep in mind that date/time types in other environments are not compatible with the Visual Basic `Date` type. If you are passing a date/time argument to such a component, declare it as `Double` instead of `Date` in your new Visual Basic code, and use the conversion methods <xref:System.DateTime.FromOADate*?displayProperty=fullName> and <xref:System.DateTime.ToOADate*?displayProperty=fullName>.  
  
-   **Type Characters.** `Date` has no literal type character or identifier type character. However, the compiler treats literals enclosed within number signs (`# #`) as `Date`.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the <xref:System.DateTime*?displayProperty=fullName> structure.  
  
## Example  
 A variable or constant of the `Date` data type holds both the date and the time. The following example illustrates this.  
  
```  
Dim someDateAndTime As Date = #8/13/2002 12:14 PM#  
```  
  
## See Also  
 <xref:System.DateTime*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Standard Date and Time Format Strings](assetId:///bb79761a-ca08-44ee-b142-b06b3e2fc22b)   
 [Custom Date and Time Format Strings](assetId:///98b374e3-0cc2-4c78-ab44-efb671d71984)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)