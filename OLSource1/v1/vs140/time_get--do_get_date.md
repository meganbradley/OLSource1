---
title: "time_get::do_get_date"
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
  - "time_get::do_get_date"
  - "std.time_get.do_get_date"
  - "std::time_get::do_get_date"
  - "time_get.do_get_date"
  - "do_get_date"
  - "xloctime/std::time_get::do_get_date"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get_date method"
ms.assetid: f70c7377-48c0-4bfd-b206-ba15b33faade
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get_date
A protected virtual member function that is called to parse a string as the date produced by the *x* specifier for `strftime`.  
  
## Syntax  
  
```  
  
      virtual iter  
      _  
      type do  
      _  
      get  
      _  
      date(  
   iter_type _First,   
   iter_type _Last,  
   ios_base& _Iosbase,   
   ios_base::iostate& _State,   
   tm* _Pt  
) const;  
```  
  
#### Parameters  
 `_First`  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 `_Last`  
 Input iterator addressing the end of the sequence to be converted.  
  
 `_Iosbase`  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 `_State`  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the date information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [`_First`, `_Last`) until it has recognized a complete, nonempty date input field. If successful, it converts this field to its equivalent value as the components **tm::tm_mon**, **tm::tm_day**, and **tm::tm_year**, and stores the results in _*Pt*->**tm_mon**, \_*Pt*->**tm_day** and \_*Pt*->**tm_year**, respectively. It returns an iterator designating the first element beyond the date input field. Otherwise, the function sets `_Iosbase`**::failbit** in `_State`. It returns an iterator designating the first element beyond any prefix of a valid date input field. In either case, if the return value equals `_Last`, the function sets `ios_base::eofbit` in `_State`.  
  
 The format for the date input field is locale dependent. For the default locale, the date input field has the form MMM DD, YYYY, where:  
  
-   MMM is matched by calling [get_monthname](../vs140/time_get--get_monthname.md), giving the month.  
  
-   DD is a sequence of decimal digits whose corresponding numeric value must be in the range [1, 31], giving the day of the month.  
  
-   YYYY is matched by calling [get_year](../vs140/time_get--get_year.md), giving the year.  
  
 The literal spaces and commas must match corresponding elements in the input sequence.  
  
## Example  
 See the example for [get_date](../vs140/time_get--get_date.md), which calls `do_get_date`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)