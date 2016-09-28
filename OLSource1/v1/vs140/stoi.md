---
title: "stoi"
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
  - "stoi"
  - "string/std::stoi"
  - "std::stoi"
  - "std.stoi"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stoi function"
  - "stoi"
ms.assetid: 9c895354-bd9f-4d5d-b66f-b287e8f5c4ab
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stoi
Converts a character sequence to an integer.  
  
## Syntax  
  
```  
int stoi(  
    const string& _Str,   
    size_t *_Idx = 0,  
    int _Base = 10  
);  
int stoi(  
    const wstring& _Str,   
    size_t *_Idx = 0,  
    int _Base = 10  
);  
```  
  
## Return Value  
 The integer value.  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Str`|The character sequence to be converted.|  
|`_Idx`|Contains the index of the first unconverted character on return.|  
|`_Base`|The number base to use.|  
  
## Remarks  
 The function `stoi` converts the sequence of characters in `_Str` to a value of type `int` and returns the value. For example, when passed a character sequence "10", the value returned by `stoi` is the integer 10.  
  
 `stoi` behaves similarly to the function `strtol` for single-byte characters when it is called in the manner `strtol(_Str.c_str(), _Eptr, _Base)`, where `_Eptr` is an object internal to the function; or `wcstol` for wide characters, when it is called in similar manner, `wcstol(Str.c_str(), _Eptr, _Base)`. For more information, see [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md).  
  
 If `_Str.c_str() == *_Eptr,``stoi` throws an object of type `invalid_argument`. If such a call would set `errno`, or if the returned valuecannot be represented as an object of type `int`, it throws an object of type `out_of_range`. Otherwise, if `_Idx` is not a null pointer, the function stores `*_Eptr - __Str.c_str()` in `*_Idx`.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [<string\>](../vs140/-string-.md)