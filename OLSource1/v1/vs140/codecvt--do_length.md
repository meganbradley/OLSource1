---
title: "codecvt::do_length"
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
  - "codecvt::do_length"
  - "codecvt.do_length"
  - "std.codecvt.do_length"
  - "do_length"
  - "xlocale/std::codecvt::do_length"
  - "std::codecvt::do_length"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_length method"
ms.assetid: f4533e3f-2e8c-4dfc-a3c9-5b8c3025ab10
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_length
A virtual function that determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
## Syntax  
  
```  
virtual int do_length(  
    const StateType& _State,  
    const Byte* _First1,   
    const Byte* _Last1,  
    size_t _Len2  
) const;  
```  
  
#### Parameters  
 `_State`  
 The conversion state that is maintained between calls to the member function.  
  
 `_First1`  
 Pointer to the beginning of the external sequence.  
  
 `_Last1`  
 Pointer to the end of the external sequence.  
  
 `_Len2`  
 The maximum number of **Byte**s that can be returned by the member function.  
  
## Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than `_Len2`, defined by the external source sequence at [`_First1`, `_Last1`).  
  
## Remarks  
 The protected virtual member function effectively calls `do_in`(`_State`, `_First1`, `_Last1`, `_Next1`, `_Buf`, `_Buf` + `_Len2`, `_Next2`) for `_State` (a copy of state), some buffer `_Buf`, and pointers `_Next1`and `_Next2`.  
  
 It then returns `_Next2` – **buf**. Thus, it counts the maximum number of conversions, not greater than `_Len2`, defined by the source sequence at [`_First1`, `_Last1`).  
  
 The template version always returns the lesser of `_Last1` – `_First1` and `_Len2`.  
  
## Example  
 See the example for [length](../vs140/codecvt--length.md), which calls **do_length**.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)