---
title: "to_string"
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
  - "std::to_string"
  - "string/std::to_string"
  - "to_string"
  - "std.to_string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_string function"
  - "to_string"
ms.assetid: c4e5c11b-ec14-484c-9a6e-995d116c2858
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# to_string
Converts a value to a `string`.  
  
## Syntax  
  
```  
string to_string(int Val);  
string to_string(unsigned int Val);  
string to_string(long Val);  
string to_string(unsigned long Val);  
string to_string(long long Val);  
string to_string(unsigned long long Val);  
string to_string(float Val);  
string to_string(double Val);  
string to_string(long double Val);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Val`|The value to be converted.|  
  
## Return Value  
 The `string` that represents the value.  
  
## Remarks  
 The function converts `Val` to a sequence of elements stored in an array object `Buf` internal to the function as if by calling `sprintf(Buf, Fmt, Val)`, where `Fmt` is  
  
-   `"%d"` if `Val` has type `int`  
  
-   `"%u"` if `Val` has type `unsigned int`  
  
-   `"%ld"` if `Val` has type `long`  
  
-   `"%lu"` if `Val` has type `unsigned long`  
  
-   `"%lld"` if `Val` has type `long long`  
  
-   `"%llu"` if `Val` has type `unsigned long long`  
  
-   `"%f"` if `Val` has type `float` or `double`  
  
-   `"%Lf"` if `Val` has type `long double`  
  
 The function returns `string(Buf)`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)