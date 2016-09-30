---
title: "time_get::do_get"
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
  - "std::time_get::do_get"
  - "time_get::do_get"
  - "time_get.do_get"
  - "std.time_get.do_get"
  - "do_get"
  - "xloctime/std::time_get::do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: abf8b0d4-7d8e-42be-b47f-a8d715cbc280
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get
Reads and converts character data to a time value. Accepts one conversion specifier and modifier.  
  
## Syntax  
  
```  
virtual iter_type  
    do_get(  
        iter_type _First,   
        iter_type _Last,  
        ios_base& _Iosbase,   
        ios_base::iostate& _State,   
        tm *_Pt,  
        char _Fmt,   
        char _Mod  
    ) const;  
```  
  
#### Parameters  
 `_First`  
 An Input iterator that indicates the start of the sequence to convert.  
  
 `_Last`  
 An Input iterator that indicates the end of the sequence.  
  
 `_Iosbase`  
 A stream object.  
  
 `_State`  
 A field in _Iosbase where appropriate bitmask elements are set to indicate errors.  
  
 `_Pt`  
 A pointer to the time structure where the time is to be stored.  
  
 `_Fmt`  
 A conversion specifier character.  
  
 `_Mod`  
 An optional modifier character.  
  
## Return Value  
 Returns an iterator that designates the first unconverted element. A conversion failure sets `ios_base::failbit` in `_State` and returns `_First`.  
  
## Remarks  
 The virtual member function converts and skips one or more input elements in the range `[``_First``,` `_Last``)` to determine the values stored in one or more members of `*pt`. A conversion failure sets `ios_base::failbit` in `_State` and returns `_First`. Otherwise, the function returns an iterator designating the first unconverted element.  
  
 The conversion specifiers are:  
  
 `'a'` or `'A'` -- behaves the same as [get_weekday](../vs140/time_get--get_weekday.md).  
  
 `'b'`, `'B'`, or `'h'` -- behaves the same as [get_monthname](../vs140/time_get--get_monthname.md).  
  
 `'c'` -- behaves the same as `"%b %d %H : %M : %S %Y"`.  
  
 `'C'` -- converts a decimal input field in the range [0, 99] to the value `val` and stores `val * 100 - 1900` in `pt-&tm_year`.  
  
 `'d'` or `'e'` -- converts a decimal input field in the range [1, 31] and stores its value in `pt-&tm_mday`.  
  
 `'D'` -- behaves the same as `"%m / %d / %y"`.  
  
 `'H'` -- converts a decimal input field in the range [0, 23] and stores its value in `pt-&tm_hour`.  
  
 `'I'` -- converts a decimal input field in the range [0, 11] and stores its value in `pt-&tm_hour`.  
  
 `'j'` -- converts a decimal input field in the range [1, 366] and stores its value in `pt-&tm_yday`.  
  
 `'m'` -- converts a decimal input field in the range [1, 12] to the value `val` and stores `val - 1` in and stores its value in `pt-&tm_mon`.  
  
 `'M'` -- converts a decimal input field in the range [0, 59] and stores its value in `pt-&tm_min`.  
  
 `'n'` or `'t'` -- behaves the same as `" "`.  
  
 `'p'` -- converts "AM" or "am" to zero and "PM" or "PM" to 12 and adds this value to `pt-&tm_hour`.  
  
 `'r'` -- behaves the same as `"%I : %M : %S %p"`.  
  
 `'R'` -- behaves the same as `"%H %M"`.  
  
 `'S'` -- converts a decimal input field in the range [0, 59] and stores its value in `pt-&tm_sec`.  
  
 `'T'` or `'X'` -- behaves the same as `"%H : %M : S"`.  
  
 `'U'` -- converts a decimal input field in the range [0, 53] and stores its value in `pt-&tm_yday`.  
  
 `'w'` -- converts a decimal input field in the range [0, 6] and stores its value in `pt-&tm_wday`.  
  
 `'W'` -- converts a decimal input field in the range [0, 53] and stores its value in `pt-&tm_yday`.  
  
 `'x'` -- behaves the same as `"%d / %m / %y"`.  
  
 `'y'` -- converts a decimal input field in the range [0, 99] to the value `val` and stores `val < 69 ? val + 100 : val` in `pt-&tm_year`.  
  
 `'Y'` -- behaves the same as [get_year](../vs140/time_get--get_year.md).  
  
 Any other conversion specifier sets `ios_base::failbit` in `state` and returns. In this implementation, any modifier has no effect.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)   
 [\<locale>](../vs140/-locale-.md)