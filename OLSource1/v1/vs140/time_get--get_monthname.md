---
title: "time_get::get_monthname"
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
  - "time_get::get_monthname"
  - "time_get.get_monthname"
  - "xloctime/std::time_get::get_monthname"
  - "std.time_get.get_monthname"
  - "std::time_get::get_monthname"
  - "get_monthname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_monthname method"
ms.assetid: 5ba32f1b-1bdc-42b2-81ea-14ef67951af0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::get_monthname
Parses a string as the name of the month.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output parameter that sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to where the month information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_monthname](../vs140/time_get--do_get_monthname.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **time_get(juillet) =**  
**tm_sec: 0**  
**tm_min: 0**  
**tm_hour: 0**  
**tm_mday: 0**  
**tm_mon: 6**  
**tm_year: 0**  
**tm_wday: 0**  
**tm_yday: 0**  
**tm_isdst: 0**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)