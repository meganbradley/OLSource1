---
title: "to_wstring"
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
  - "string/std::to_wstring"
  - "to_wstring"
  - "std::to_wstring"
  - "std.to_wstring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_wstring"
  - "to_wstring function"
ms.assetid: 2cc50aac-62dc-431c-8a06-d19d6a052403
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# to_wstring
Converts a value to a wide string.  
  
## Syntax  
  
```  
wstring to_wstring(int Val);  
wstring to_wstring(unsigned int Val);  
wstring to_wstring(long Val);  
wstring to_wstring(unsigned long Val);  
wstring to_wstring(long long Val);  
wstring to_wstring(unsigned long long Val);  
wstring to_wstring(float Val);  
wstring to_wstring(double Val);  
wstring to_wstring(long double Val);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Val`|The value to be converted.|  
  
## Return Value  
 The wide string that represents the value.  
  
## Remarks  
 The function converts `Val` to a sequence of elements stored in an array object `Buf` internal to the function as if by calling `swprintf(Buf, Len, Fmt, Val)`, where `Fmt` is  
  
-   `L"%d"` if `Val` has type `int`  
  
-   `L"%u"` if `Val` has type `unsigned int`  
  
-   `L"%ld"` if `Val` has type `long`  
  
-   `L"%lu"` if `Val` has type `unsigned long`  
  
-   `L"%lld"` if `Val` has type `long long`  
  
-   `L"%llu"` if `Val` has type `unsigned long long`  
  
-   `L"%f"` if `Val` has type `float` or `double`  
  
-   `L"%Lf"` if `Val` has type `long double`  
  
 The function returns `wstring(Buf)`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)