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
 Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data type to contain date values, time values, or date and time values.  
  
 The default value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is 0:00:00 (midnight) on January 1, 0001.  
  
 You can get the current date and time from the \<xref:Microsoft.VisualBasic.DateAndTime*> class.  
  
## Format Requirements  
 You must enclose a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> literal within number signs (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). You must specify the date value in the format M/d/yyyy, for example <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or yyyy-MM-dd, for example <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You can use slashes when specifying the year first.  This requirement is independent of your locale and your computer's date and time format settings.  
  
 The reason for this restriction is that the meaning of your code should never change depending on the locale in which your application is running. Suppose you hard-code a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> literal of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and intend it to mean March 4, 1998. In a locale that uses mm/dd/yyyy, 3/4/1998 compiles as you intend. But suppose you deploy your application in many countries. In a locale that uses dd/mm/yyyy, your hard-coded literal would compile to April 3, 1998. In a locale that uses yyyy/mm/dd, the literal would be invalid (April 1998, 0003) and cause a compiler error.  
  
## Workarounds  
 To convert a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> literal to the format of your locale, or to a custom format, supply the literal to the \<xref:Microsoft.VisualBasic.Strings.Format*> function, specifying either a predefined or user-defined date format. The following example demonstrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Alternatively, you can use one of the overloaded constructors of the \<xref:System.DateTime*> structure to assemble a date and time value. The following example creates a value to represent May 31, 1993 at 12:14 in the afternoon.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Hour Format  
 You can specify the time value in either 12-hour or 24-hour format, for example <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. However, if you do not specify either the minutes or the seconds, you must specify AM or PM.  
  
## Date and Time Defaults  
 If you do not include a date in a date/time literal, Visual Basic sets the date part of the value to January 1, 0001. If you do not include a time in a date/time literal, Visual Basic sets the time part of the value to the start of the day, that is, midnight (0:00:00).  
  
## Type Conversions  
 If you convert a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> value to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> type, Visual Basic renders the date according to the short date format specified by the run-time locale, and it renders the time according to the time format (either 12-hour or 24-hour) specified by the run-time locale.  
  
## Programming Tips  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, keep in mind that date/time types in other environments are not compatible with the Visual Basic <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type. If you are passing a date/time argument to such a component, declare it as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in your new Visual Basic code, and use the conversion methods \<xref:System.DateTime.FromOADate*?displayProperty=fullName> and \<xref:System.DateTime.ToOADate*?displayProperty=fullName>.  
  
-   **Type Characters.** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has no literal type character or identifier type character. However, the compiler treats literals enclosed within number signs (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
-   **Framework Type.** The corresponding type in the .NET Framework is the \<xref:System.DateTime*?displayProperty=fullName> structure.  
  
## Example  
 A variable or constant of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data type holds both the date and the time. The following example illustrates this.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.DateTime*?displayProperty=fullName>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Standard Date and Time Format Strings](assetId:///bb79761a-ca08-44ee-b142-b06b3e2fc22b)   
 [Custom Date and Time Format Strings](assetId:///98b374e3-0cc2-4c78-ab44-efb671d71984)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)