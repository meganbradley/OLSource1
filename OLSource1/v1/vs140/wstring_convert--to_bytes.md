---
title: "wstring_convert::to_bytes"
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
  - "cvt::wstring_convert::to_bytes"
  - "wstring/stdext::cvt::wstring_convert::to_bytes"
  - "to_bytes"
  - "wstring_convert::to_bytes"
  - "stdext.cvt.wstring_convert.to_bytes"
  - "wstring_convert.to_bytes"
  - "stdext::cvt::wstring_convert::to_bytes"
  - "cvt.wstring_convert.to_bytes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_bytes method"
ms.assetid: 80c523af-a220-44d0-a1fe-273c19f84d43
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wstring_convert::to_bytes
Converts a wide string to a byte string.  
  
## Syntax  
  
```  
byte_string to_bytes(_Elem _Char);  
byte_string to_bytes(const _Elem* _Wptr);  
byte_string to_bytes(const wide_string& _Wstr);  
byte_string to_bytes(const _Elem* _First, const _Elem* _Last);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Char`|The wide character to be converted.|  
|`_Wptr`|The C-style, null-terminated sequence, beginning at `wptr`, to be converted.|  
|`_Wstr`|The [wide_string](../vs140/wstring_convert--wide_string.md) to be converted.|  
|`_First`|The first element in a range of elements to be converted.|  
|`_Last`|The last element in a range of elements to be converted.|  
  
## Remarks  
 If the [conversion state](../vs140/wstring_convert-class.md) object was `not` constructed with an explicit value, it is set to its default value (the initial conversion state) before the conversion begins. Otherwise it is left unchanged.  
  
 The number of input elements successfully converted is stored in the conversion count object. If no conversion error occurs, the member function returns the converted byte string. Otherwise, if the object was constructed with an initializer for the byte-string error message, the member function returns the byte-string error message object. Otherwise, the member function throws an object of class [range_error](../vs140/range_error-class.md).  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [wstring_convert Class](../vs140/wstring_convert-class.md)