---
title: "time_get::get"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - time_get.get
  - get
  - std.time_get.get
  - std::time_get::get
  - xloctime/std::time_get::get
  - time_get::get
dev_langs: 
  - C++
helpviewer_keywords: 
  - get method
ms.assetid: 260b29b1-77e0-49f0-aea1-0a6978b02bfb
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# time_get::get
Reads from a source of character data and converts that data to a time that is stored in a time struct. The first function accepts one conversion specifier and modifier, the second accepts several.  
  
## Syntax  
  
```  
iter_type get(  
    iter_type _First,   
    iter_type _Last,  
    ios_base& _Iosbase,   
    ios_base::iostate& _State,   
    tm *_Pt,  
    char _Fmt,   
    char _Mod  
) const;  
iter_type get(  
    iter_type _First,   
    iter_type _Last,  
    ios_base& _Iosbase,   
    ios_base::iostate& _State,   
    tm *_Pt,  
    char_type *_Fmt_first,    
    char_type *_Fmt_last  
) const;  
```  
  
#### Parameters  
 `_First`  
 Input iterator that indicates where the sequence to be converted starts.  
  
 `_Last`  
 Input iterator that indicates the end of the sequence to be converted.  
  
 `_Iosbase`  
 The stream.  
  
 `_State`  
 The appropriate bitmask elements are set for the stream state to indicate errors.  
  
 `_Pt`  
 Pointer to the time structure where the time is to be stored.  
  
 `_Fmt`  
 A conversion specifier character.  
  
 `_Mod`  
 An optional modifier character.  
  
 `_Fmt_first`  
 Points to where the format directives start.  
  
 `_Fmt_last`  
 Points to the end of the format directives.  
  
## Return Value  
 Returns an iterator to the first character after the data that was used to assign the time struct *_Pt.  
  
## Remarks  
 The first member function returns `do_get` `(``_First``,` `_Last``,` `_Iosbase``,` `_State``,` `_Pt``,` `_Fmt``,` `_Mod``)`.  
  
 The second member function calls `do_get` under the control of the format delimited by `[``_Fmt_first``,``_Fmt_last``)`. It treats the format as a sequence of fields, each of which determines the conversion of zero or more input elements delimited by `[first, last)`. It returns an iterator designating the first unconverted element. There are three kinds of fields:  
  
 A per cent (%) in the format, followed by an optional modifier `mod` in the set [EOQ#], followed by a conversion specifier `fmt`, replaces `first` with the value returned by `do_get` `(``_First``,` `_Last``,` `_Iosbase``,` `_State``,` `_Pt``,` `_Fmt``,` `_Mod``)`. A conversion failure sets `ios_base::failbit` in `state` and returns.  
  
 A whitespace element in the format skips past zero or more input whitespace elements.  
  
 Any other element in the format must match the next input element, which is skipped. A match failure sets `ios_base::failbit` in `state` and returns.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [Time_get::do_get](../vs140/time_get--do_get.md)   
 [time_get Class](../vs140/time_get-class.md)   
 [<locale\>](../vs140/-locale-.md)