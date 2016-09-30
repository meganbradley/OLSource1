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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wstring_convert::to_bytes
Converts a wide string to a byte string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The wide character to be converted.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The C-style, null-terminated sequence, beginning at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to be converted.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The [wide_string](../vs140/wstring_convert--wide_string.md) to be converted.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The first element in a range of elements to be converted.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The last element in a range of elements to be converted.|  
  
## Remarks  
 If the [conversion state](../vs140/wstring_convert-class.md) object was <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> constructed with an explicit value, it is set to its default value (the initial conversion state) before the conversion begins. Otherwise it is left unchanged.  
  
 The number of input elements successfully converted is stored in the conversion count object. If no conversion error occurs, the member function returns the converted byte string. Otherwise, if the object was constructed with an initializer for the byte-string error message, the member function returns the byte-string error message object. Otherwise, the member function throws an object of class [range_error](../vs140/range_error-class.md).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [wstring_convert Class](../vs140/wstring_convert-class.md)