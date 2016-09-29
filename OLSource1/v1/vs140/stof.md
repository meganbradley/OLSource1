---
title: "stof"
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
  - "string/std::stof"
  - "stof"
  - "std::stof"
  - "std.stof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stof"
  - "stof function"
ms.assetid: d633979b-2347-46d2-9d1d-01c947e76232
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stof
Converts a character sequence to a float.  
  
## Syntax  
  
```  
float stof(  
    const string& _Str,   
    size_t *_Idx = 0  
);  
float stof(  
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
 The float value.  
  
## Remarks  
 The function converts the sequence of elements in `_Str` to a value `_Val` of type `float` as if by calling `strtof(_Str.c_str(), _Eptr)`, where `_Eptr` is an object internal to the function. If `_Str.c_str() == *_Eptr` it throws an object of type `invalid_argument`. If such a call would set `errno`, it throws an object of type `out_of_range`. Otherwise, if `_Idx` is not a null pointer, the function stores `*_Eptr - _Str.c_str()` in `*_Idx` and returns `_Val`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)