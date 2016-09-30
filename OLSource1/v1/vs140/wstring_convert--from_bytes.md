---
title: "wstring_convert::from_bytes"
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
  - "cvt.wstring_convert.from_bytes"
  - "wstring/stdext::cvt::wstring_convert::from_bytes"
  - "wstring_convert::from_bytes"
  - "stdext.cvt.wstring_convert.from_bytes"
  - "cvt::wstring_convert::from_bytes"
  - "wstring_convert.from_bytes"
  - "stdext::cvt::wstring_convert::from_bytes"
  - "from_bytes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "from_bytes method"
ms.assetid: e150d7fd-5328-467f-b44b-dcf2fbdb4960
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wstring_convert::from_bytes
Converts a byte string to a wide string.  
  
## Syntax  
  
```  
wide_string from_bytes(char _Byte);  
wide_string from_bytes(const char* _Ptr);  
wide_string from_bytes(const byte_string& _Bstr);  
wide_string from_bytes(const char* _First, const char* _Last);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Byte`|The single-element byte sequence to be converted.|  
|`_Ptr`|The C-style, null-terminated sequence of characters to be converted.|  
|`_Bstr`|The [byte_string](../vs140/wstring_convert--byte_string.md) to be converted.|  
|`_First`|The first character in a range of characters to be converted.|  
|`_Last`|The last character in a range of characters to be converted.|  
  
## Return Value  
 A wide string object resulting from the conversion.  
  
## Remarks  
 If the [conversion state](../vs140/wstring_convert-class.md) object was `not` constructed with an explicit value, it is set to its default value (the initial conversion state) before the conversion begins. Otherwise it is left unchanged.  
  
 The number of input elements successfully converted is stored in the conversion count object. If no conversion error occurs, the member function returns the converted wide string. Otherwise, if the object was constructed with an initializer for the wide-string error message, the member function returns the wide-string error message object. Otherwise, the member function throws an object of class [range_error](../vs140/range_error-class.md).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [wstring_convert Class](../vs140/wstring_convert-class.md)