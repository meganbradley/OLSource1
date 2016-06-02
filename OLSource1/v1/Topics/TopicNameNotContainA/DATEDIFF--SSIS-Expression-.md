---
title: DATEDIFF (SSIS Expression)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 449b327f-47c7-4709-8bc6-4ee9a35cc330
---
# DATEDIFF (SSIS Expression)
  Returns the number of date and time boundaries crossed between two specified dates. The *datepart* parameter identifies which date and time boundaries to compare.  
  
## Syntax  
  
```  
  
DATEDIFF(datepart, startdate, endate)  
```  
  
## Arguments  
 *datepart*  
 Is the parameter that specifies which part of the date to compare and return a value for.  
  
 *startdate*  
 Is the start date of the interval.  
  
 *endate*  
 Is the end date of the interval.  
  
## Result Types  
 DT\_I4  
  
## Remarks  
 The following table lists the dateparts and abbreviations recognized by the expression evaluator.  
  
|Datepart|Abbreviations|  
|--------------|-------------------|  
|Year|yy, yyyy|  
|Quarter|qq, q|  
|Month|mm, m|  
|Dayofyear|dy, y|  
|Day|dd, d|  
|Week|wk, ww|  
|Weekday|dw, w|  
|Hour|Hh|  
|Minute|mi, n|  
|Second|ss, s|  
|Millisecond|Ms|  
  
 DATEDIFF returns a null result if any argument is null.  
  
 A date literal must be explicitly cast to one of the date data types. For more information, see [Integration Services Data Types](../../Topics\TopicNameNotContainA/Integration-Services-Data-Types.md).  
  
 An error occurs if a date is not valid, if the date or time unit is not a string, if the start date is not a date, or if the end date is not a date.  
  
 If the end date is earlier than the start date, the function returns a negative number. If the start and end dates are equal or fall within the same interval, the function returns zero.  
  
## SSIS Expression Examples  
 This example calculates the number of days between two date literals. If the date is in "mm\/dd\/yyyy" format, the function returns 7.  
  
```  
DATEDIFF("dd", (DT_DBTIMESTAMP)"8/1/2003", (DT_DBTIMESTAMP)"8/8/2003")  
```  
  
 This example returns the number of months between a date literal and the current date.  
  
```  
DATEDIFF("mm", (DT_DBTIMESTAMP)"8/1/2003",GETDATE())  
```  
  
 This example returns the number of weeks between the date in the **ModifiedDate** column and the **YearEndDate** variable. If **YearEndDate** has a **date** data type, no explicit casting is required.  
  
```  
DATEDIFF("Week", ModifiedDate,@YearEndDate)  
```  
  
## See Also  
 [DATEADD &#40;SSIS Expression&#41;](../Topic/DATEADD%20\(SSIS%20Expression\).md)   
 [DATEPART &#40;SSIS Expression&#41;](../Topic/DATEPART%20\(SSIS%20Expression\).md)   
 [DAY &#40;SSIS Expression&#41;](../Topic/DAY%20\(SSIS%20Expression\).md)   
 [MONTH &#40;SSIS Expression&#41;](../Topic/MONTH%20\(SSIS%20Expression\).md)   
 [YEAR &#40;SSIS Expression&#41;](../Topic/YEAR%20\(SSIS%20Expression\).md)   
 [Functions &#40;SSIS Expression&#41;](../Topic/Functions%20\(SSIS%20Expression\).md)  
  
  