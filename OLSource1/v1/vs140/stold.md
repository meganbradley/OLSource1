---
title: "stold"
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
  - stold
  - std.stold
  - std::stold
  - string/std::stold
dev_langs: 
  - C++
helpviewer_keywords: 
  - stold function
  - stold
ms.assetid: e88f2a56-3720-4e11-a3b9-258c75c3f1ef
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# stold
Converts a character sequence to a `long double`.  
  
## Syntax  
  
```  
double stold(  
    const string& _Str,   
    size_t *_Idx = 0  
);  
double stold(  
    const wstring& _Str,   
    size_t *_Idx = 0  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Str`|The character sequence to be converted.|  
|`_Idx`|The index value of the first unconverted character.|  
  
## Return Value  
 The `long double` value.  
  
## Remarks  
 The function converts the sequence of elements in `_Str` to a value `_Val` of type `long double` as if by calling `strtold(_Str.c_str(), _Eptr)`, where `_Eptr` is an object internal to the function. If `_Str.c_str() == *_Eptr` it throws an object of type `invalid_argument`. If such a call would set `errno`, it throws an object of type `out_of_range`. Otherwise, if `_Idx` is not a null pointer, the function stores `*_Eptr - _Str.c_str()` in `*_Idx` and returns `_Val`.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [<string\>](../vs140/-string-.md)