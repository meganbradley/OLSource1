---
title: "COleDateTime::ParseDateTime"
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
  - "ATL.COleDateTime.ParseDateTime"
  - "COleDateTime.ParseDateTime"
  - "ATL::COleDateTime::ParseDateTime"
  - "COleDateTime::ParseDateTime"
  - "ParseDateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ParseDateTime method"
ms.assetid: 734ab792-5f5c-47d5-82a0-2396c0f8255c
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::ParseDateTime
Parses a string to read a date/time value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the null-terminated string which is to be parsed. For details, see Remarks.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates flags for locale settings and parsing. One or more of the following flags:  
  
-   **LOCALE_NOUSEROVERRIDE** Use the system default locale settings, rather than custom user settings.  
  
-   **VAR_TIMEVALUEONLY** Ignore the date portion during parsing.  
  
-   **VAR_DATEVALUEONLY** Ignore the time portion during parsing.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
## Return Value  
 Returns **true** if the string was successfully converted to a date/time value, otherwise **false**.  
  
## Remarks  
 If the string was successfully converted to a date/time value, the value of this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is set to that value and its status to valid.  
  
> [!NOTE]
>  Year values must lie between 100 and 9999, inclusively.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter can take a variety of formats. For example, the following strings contain acceptable date/time formats:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 Note that the locale ID will also affect whether the string format is acceptable for conversion to a date/time value.  
  
 In the case of **VAR_DATEVALUEONLY**, the time value is set to time 0, or midnight. In the case of **VAR_TIMEVALUEONLY**, the date value is set to date 0, meaning 30 December 1899.  
  
 If the string could not be converted to a date/time value or if there was a numerical overflow, the status of this <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is invalid.  
  
 For more information about the bounds and implementation for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::Format](../vs140/coledatetime--format.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)