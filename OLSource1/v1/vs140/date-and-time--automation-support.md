---
title: "Date and Time: Automation Support"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "adding dates"
  - "calculating dates and times"
  - "formatting [Visual Studio], dates"
  - "dates, Automation support"
  - "elapsed time, calculating in Automation"
  - "COleDateTime class, Automation date/time support"
  - "COleDateTimeSpan class, Automation date/time support"
  - "Automation, date and time support"
  - "formatting [Visual Studio], time"
  - "calculations, date and time"
  - "time [Visual Studio], Automation support"
ms.assetid: 6eee94c4-943d-4ffc-bf7c-bdda89337ab0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Date and Time: Automation Support
This article describes how to take advantage of the class library services related to date and time management. Procedures described include:  
  
-   [Getting the current time](../vs140/current-time--automation-classes.md)  
  
-   [Calculating elapsed time](../vs140/elapsed-time--automation-classes.md)  
  
-   [Formatting a string representation of a date/time](../vs140/formatting-time--automation-classes.md)  
  
 The [COleDateTime](../vs140/coledatetime-class.md) class provides a way to represent date and time information. It provides finer granularity and a greater range than the [CTime](../vs140/ctime-class.md) class. The [COleDateTimeSpan](../vs140/coledatetimespan-class.md) class represents elapsed time, such as the difference between two <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> classes are designed to be used with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class used in Automation. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are also useful in MFC database programming, but they can be used whenever you want to manipulate date and time values. Although the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class has a greater range of values and finer granularity than the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class, it requires more storage per object than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. There are also some special considerations when working with the underlying **DATE** type. See [The DATE Type](../vs140/date-type.md) for more details on the implementation of **DATE**.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects can be used to represent dates between January 1, 100, and December 31, 9999. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects are floating point values, with an approximate resolution of 1 millisecond. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is based on the **DATE** data type, defined in the MFC documentation under [COleDateTime::operator DATE](../vs140/coledatetime--operator-date.md). The actual implementation of **DATE** extends beyond these bounds. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implementation imposes these bounds to facilitate working with the class.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not support Julian dates. The Gregorian calendar is assumed to extend back in time to January 1, 100.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> ignores Daylight Saving Time (DST). The following code example compares two methods of calculating a time span that crosses the DST switchover date: one using the CRT, and the other using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. DST switches over, in most locales, in the second week in April and the third in October.  
  
 The first method sets two <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects, *time1* and *time2*, to April 5 and April 6 respectively, using the standard C type structures **tm** and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The code displays *time1* and *time2* and the time span between them.  
  
 The second method creates two <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and sets them to the same dates as *time1* and *time2*. It displays <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and the time span between them.  
  
 The CRT correctly calculates a difference of 23 hours. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> calculates a difference of 24 hours.  
  
 Note that a workaround is used near the end of the example to display the date properly using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. See the Knowledge Base article "BUG: Format("%D") Fails for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>" (Q167338).  
  
 [!code[NVC_ATLMFC_Utilities#176](../vs140/codesnippet/CPP/date-and-time--automation-support_1.cpp)]  
  
## See Also  
 [Date and Time](../vs140/date-and-time.md)