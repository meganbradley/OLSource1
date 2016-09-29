---
title: "Date and Time"
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
  - "time, MFC programming"
  - "time"
  - "MFC, date and time"
  - "dates, MFC"
ms.assetid: ecf56dc5-d418-4603-ad3e-af7e205a6403
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Date and Time
MFC supports several different ways of working with dates and times. These include:  
  
-   General-purpose time classes. The [CTime](../vs140/ctime-class.md) and [CTimeSpan](../vs140/ctimespan-class.md) classes encapsulate most of the functionality associated with the ANSI-standard time library, which is declared in TIME.H.  
  
-   Support for system clock. With MFC version 3.0, support was added to `CTime` for the Win32 `SYSTEMTIME` and `FILETIME` data types.  
  
-   Support for the Automation [DATE data type](../vs140/date-type.md). **DATE** supports date, time, and date/time values. The [COleDateTime](../vs140/coledatetime-class.md) and [COleDateTimeSpan](../vs140/coledatetimespan-class.md) classes encapsulate this functionality. They work with the [COleVariant](../vs140/colevariant-class.md) class using Automation support.  
  
## What do you want to know more about?  
  
-   [Date and Time: General-Purpose Classes](../vs140/date-and-time--general-purpose-classes.md)  
  
-   [Date and Time: SYSTEMTIME Support](../vs140/date-and-time--systemtime-support.md)  
  
-   [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md)  
  
-   [Date and Time: Database Support](../vs140/date-and-time--database-support.md)  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)