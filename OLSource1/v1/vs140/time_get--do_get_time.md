---
title: "time_get::do_get_time"
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
  - "do_get_time"
  - "std.time_get.do_get_time"
  - "std::time_get::do_get_time"
  - "time_get::do_get_time"
  - "xloctime/std::time_get::do_get_time"
  - "time_get.do_get_time"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get_time method"
ms.assetid: f2275815-bbbc-46b4-b596-88f9f21d31a8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get_time
A protected virtual member function that is called to parse a string as the date produced by the *X* specifier for `strftime`.  
  
## Syntax  
  
```  
  
      virtual iter  
      _  
      type do  
      _  
      get  
      _  
      time(  
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
 Unused.  
  
 `_State`  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the date information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [`_First`, `_Last`) until it has recognized a complete, nonempty time input field. If successful, it converts this field to its equivalent value as the components **tm::tm_hour**, **tm::tm_min**, and **tm::tm_sec**, and stores the results in _*Pt*->**tm_hour**, \_*Pt*->**tm_min**, and \_*Pt*->**tm_sec**, respectively. It returns an iterator designating the first element beyond the time input field. Otherwise, the function sets `ios_base::failbit` in \_*State*. It returns an iterator designating the first element beyond any prefix of a valid time input field. In either case, if the return value equals `_Last`, the function sets `ios_base::eofbit` in \_*State*.  
  
 In this implementation, the time input field has the form HH:MM:SS, where:  
  
-   HH is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 24), giving the hour of the day.  
  
-   MM is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 60), giving the minutes past the hour.  
  
-   SS is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 60), giving the seconds past the minute.  
  
 The literal colons must match corresponding elements in the input sequence.  
  
## Example  
 See the example for [get_time](../vs140/time_get--get_time.md), which calls `do_get_time`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)