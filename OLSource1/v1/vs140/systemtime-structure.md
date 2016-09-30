---
title: "SYSTEMTIME Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SYSTEMTIME"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SYSTEMTIME structure"
ms.assetid: 9aaef4d6-de79-4fa1-8158-86b245ef5bff
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SYSTEMTIME Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure represents a date and time using individual members for the month, day, year, weekday, hour, minute, second, and millisecond.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *wYear*  
 The current year.  
  
 *wMonth*  
 The current month; January is 1.  
  
 *wDayOfWeek*  
 The current day of the week; Sunday is 0, Monday is 1, and so on.  
  
 *wDay*  
 The current day of the month.  
  
 *wHour*  
 The current hour.  
  
 *wMinute*  
 The current minute.  
  
 *wSecond*  
 The current second.  
  
 *wMilliseconds*  
 The current millisecond.  
  
## Example  
 [!code[NVC_MFC_Utilities#39](../vs140/codesnippet/CPP/systemtime-structure_1.cpp)]  
  
## Requirements  
 **Header:** winbase.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CTime::CTime](../vs140/ctime--ctime.md)