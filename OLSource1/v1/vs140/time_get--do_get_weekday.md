---
title: "time_get::do_get_weekday"
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
  - "do_get_weekday"
  - "time_get.do_get_weekday"
  - "xloctime/std::time_get::do_get_weekday"
  - "time_get::do_get_weekday"
  - "std.time_get.do_get_weekday"
  - "std::time_get::do_get_weekday"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get_weekday method"
ms.assetid: a9e22d32-a47a-4705-9cd4-14a90b752b50
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get_weekday
A protected virtual member function that is called to parse a string as the name of the day of the week.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to where the weekday information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The virtual protected member function tries to match sequential elements beginning at <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the sequence [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty weekday input field. If successful, it converts this field to its equivalent value as the component **tm::tm_wday**, and stores the result in _*Pt*->**tm_wday**. It returns an iterator designating the first element beyond the weekday input field. Otherwise, the function sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in \_*State*. It returns an iterator designating the first element beyond any prefix of a valid weekday input field. In either case, if the return value equals <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in \_*State*.  
  
 The weekday input field is a sequence that matches the longest of a set of locale-specific sequences, such as Sun, Sunday, Mon, Monday, and so on. The converted value is the number of days since Sunday.  
  
## Example  
 See the example for [get_weekday](../vs140/time_get--get_weekday.md), which calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)