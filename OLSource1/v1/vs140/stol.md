---
title: "stol"
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
  - "std.stol"
  - "stol"
  - "string/std::stol"
  - "std::stol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stol"
  - "stol function"
ms.assetid: ecd75b86-2850-4f69-bb1d-8741fb71fc08
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# stol
Converts a character sequence to a `long`.  
  
## Syntax  
  
```  
long stol(  
    const string& _Str,  
    size_t *_Idx = 0,  
    int _Base = 10  
);  
long stol(  
    const wstring& _Str,   
    size_t *_Idx = 0,  
    int _Base = 10  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Str`|The character sequence to be converted.|  
|`_Idx`|The index value of the first unconverted character.|  
|`_Base`|The number base to use.|  
  
## Return Value  
 The long-integer value.  
  
## Remarks  
 The function converts the sequence of elements in `_Str` to a value `_Val` of type `long` as if by calling `strtol(_Str.c_str(), _Eptr, _Base)`, where `_Eptr` is an object internal to the function. If `_Str.c_str() == *_Eptr` it throws an object of type `invalid_argument`. If such a call would set `errno`, it throws an object of type `out_of_range`. Otherwise, if `_Idx` is not a null pointer, the function stores `*_Eptr - _Str.c_str()` in `*_Idx` and returns `_Val`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)