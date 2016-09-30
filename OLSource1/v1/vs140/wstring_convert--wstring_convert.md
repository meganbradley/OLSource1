---
title: "wstring_convert::wstring_convert"
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
  - "stdext::cvt::wstring_convert::wstring_convert"
  - "wstring_convert"
  - "wstring/stdext::cvt::wstring_convert::wstring_convert"
  - "stdext.cvt.wstring_convert.wstring_convert"
  - "wstring_convert::wstring_convert"
  - "cvt.wstring_convert.wstring_convert"
  - "wstring_convert.wstring_convert"
  - "cvt::wstring_convert::wstring_convert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wstring_convert method"
  - "wstring_convert class, constructor"
ms.assetid: 86c05f4e-34b8-4eb9-a95b-d7d10cb9643b
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# wstring_convert::wstring_convert
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to perform the conversion.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The object of type [state_type](../vs140/wstring_convert--state_type.md) representing the conversion state.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The [byte_string](../vs140/wstring_convert--byte_string.md) to display on errors.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The [wide_string](../vs140/wstring_convert--wide_string.md) to display on errors.|  
  
## Remarks  
 The first constructor stores *_Pcvt_arg* in the [conversion object](../vs140/wstring_convert-class.md) and default values in the conversion state object, the byte-string error message object, and the wide-string error message object.  
  
 The second constructor stores <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the conversion object, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the conversion state object. It stores default values in the byte-string error message object and the wide-string error message object. The stored state is retained between calls to [from_bytes](../vs140/wstring_convert--from_bytes.md) and [to_bytes](../vs140/wstring_convert--to_bytes.md).  
  
 The third constructor stores the conversion object in the conversion object, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the conversion state object, *_Berr* in the byte-string error message object, and *_Werr* in the wide-string error message object.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [wstring_convert Class](../vs140/wstring_convert-class.md)