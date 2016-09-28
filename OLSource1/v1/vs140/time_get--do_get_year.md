---
title: "time_get::do_get_year"
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
  - "std::time_get::do_get_year"
  - "std.time_get.do_get_year"
  - "do_get_year"
  - "time_get::do_get_year"
  - "time_get.do_get_year"
  - "xloctime/std::time_get::do_get_year"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get_year method"
ms.assetid: f7f61482-882b-4936-95de-a4e192c90de2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get_year
A protected virtual member function that is called to parses a string as the name of the year.  
  
## Syntax  
  
```  
  
      virtual iter  
      _  
      type do  
      _  
      get  
      _  
      year(  
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
 A pointer to where the year information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The virtual protected member function tries to match sequential elements beginning at `_First` in the sequence [`_First`, `_Last`) until it has recognized a complete, nonempty year input field. If successful, it converts this field to its equivalent value as the component **tm::tm_year**, and stores the result in _*Pt*->**tm_year**. It returns an iterator designating the first element beyond the year input field. Otherwise, the function sets `ios_base::failbit` in \_*State*. It returns an iterator designating the first element beyond any prefix of a valid year input field. In either case, if the return value equals `_Last`, the function sets `ios_base::eofbit` in \_*State*.  
  
 The year input field is a sequence of decimal digits whose corresponding numeric value must be in the range [1900, 2036). The stored value is this value minus 1900. In this implementation, values in the range [69, 136) represent the range of years [1969, 2036). Values in the range [0, 69) are also permissible, but may represent either the range of years [1900, 1969) or [2000, 2069), depending on the specific translation environment.  
  
## Example  
 See the example for [get_year](../vs140/time_get--get_year.md), which calls `do_get_year`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)