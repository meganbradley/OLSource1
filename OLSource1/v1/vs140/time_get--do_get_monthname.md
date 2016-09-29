---
title: "time_get::do_get_monthname"
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
  - "time_get.do_get_monthname"
  - "std.time_get.do_get_monthname"
  - "time_get::do_get_monthname"
  - "xloctime/std::time_get::do_get_monthname"
  - "std::time_get::do_get_monthname"
  - "do_get_monthname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get_monthname method"
ms.assetid: 21434f66-d2ce-42c4-b94a-f30de6bd28ec
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get_monthname
A protected virtual member function that is called to parse a string as the name of the month.  
  
## Syntax  
  
```  
  
      virtual iter  
      _  
      type do  
      _  
      get  
      _  
      monthname(  
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
 An output parameter that sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the month information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [`_First`, `_Last`) until it has recognized a complete, nonempty month input field. If successful, it converts this field to its equivalent value as the component **tm::tm_mon**, and stores the result in _*Pt*->**tm_mon**. It returns an iterator designating the first element beyond the month input field. Otherwise, the function sets `ios_base::failbit` in \_*State*. It returns an iterator designating the first element beyond any prefix of a valid month input field. In either case, if the return value equals `_Last`, the function sets `ios_base::eofbit` in \_*State*.  
  
 The month input field is a sequence that matches the longest of a set of locale-specific sequences, such as Jan, January, Feb, February, and so on. The converted value is the number of months since January.  
  
## Example  
 See the example for [get_monthname](../vs140/time_get--get_monthname.md), which calls `do_get_monthname`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)