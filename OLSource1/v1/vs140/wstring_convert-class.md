---
title: "wstring_convert Class"
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
  - "cvt.wstring_convert"
  - "wstring_convert"
  - "stdext::cvt::wstring_convert"
  - "cvt::wstring_convert"
  - "wstring/stdext::cvt::wstring_convert"
  - "stdext.cvt.wstring_convert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wstring_convert class"
ms.assetid: e34f5b65-d572-4bdc-ac69-20778712e376
caps.latest.revision: 27
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# wstring_convert Class
The template class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> performs conversions between a wide string and a byte string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Codecvt  
 The [locale](../vs140/locale-class.md) facet that represents the conversion object.  
  
 Elem  
 The wide-character element type.  
  
## Remarks  
 The template class describes an object that controls conversions between wide string objects of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and byte string objects of class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (also known as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). The template class defines the types <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> as synonyms for these two types. Conversion between a sequence of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> values (stored in a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object) and multibyte sequences (stored in a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object) is performed by an object of class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, which meets the requirements of the standard code-conversion facet <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 An object of this template class stores:  
  
-   A byte string to display on errors  
  
-   A wide string to display on errors  
  
-   A pointer to the allocated conversion object (which is freed when the wbuffer_convert object is destroyed)  
  
-   A conversion state object of type [state_type](#wstring_convert__state_type)  
  
-   A conversion count  
  
### Constructors  
  
|||  
|-|-|  
|[wstring_convert](#wstring_convert__wstring_convert)|Constructs an object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[byte_string](#wstring_convert__byte_string)|A type that represents a byte string.|  
|[wide_string](#wstring_convert__wide_string)|A type that represents a wide string.|  
|[state_type](#wstring_convert__state_type)|A type that represents the conversion state.|  
|[int_type](#wstring_convert__int_type)|A type that represents an integer.|  
  
### Member Functions  
  
|||  
|-|-|  
|[from_bytes](#wstring_convert__from_bytes)|Converts a byte string to a wide string.|  
|[to_bytes](#wstring_convert__to_bytes)|Converts a wide string to a byte string.|  
|[converted](#wstring_convert__converted)|Returns the number of successful conversions.|  
|[state](#wstring_convert__state)|Returns an object representing the state of the conversion.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="wstring_convert__byte_string">\</a>  wstring_convert::byte_string  
 A type that represents a byte string.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
##  \<a name="wstring_convert__converted">\</a>  wstring_convert::converted  
 Returns the number of successful conversions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The number of successful conversions.  
  
### Remarks  
 The number of successful conversions is stored in the conversion count object.  
  
##  \<a name="wstring_convert__from_bytes">\</a>  wstring_convert::from_bytes  
 Converts a byte string to a wide string.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The single-element byte sequence to be converted.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|The C-style, null-terminated sequence of characters to be converted.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The [byte_string](#wstring_convert__byte_string) to be converted.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|The first character in a range of characters to be converted.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The last character in a range of characters to be converted.|  
  
### Return Value  
 A wide string object resulting from the conversion.  
  
### Remarks  
 If the [conversion state](../vs140/wstring_convert-class.md) object was <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> constructed with an explicit value, it is set to its default value (the initial conversion state) before the conversion begins. Otherwise it is left unchanged.  
  
 The number of input elements successfully converted is stored in the conversion count object. If no conversion error occurs, the member function returns the converted wide string. Otherwise, if the object was constructed with an initializer for the wide-string error message, the member function returns the wide-string error message object. Otherwise, the member function throws an object of class [range_error](../vs140/range_error-class.md).  
  
##  \<a name="wstring_convert__int_type">\</a>  wstring_convert::int_type  
 A type that represents an integer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="wstring_convert__state">\</a>  wstring_convert::state  
 Returns an object representing the state of the conversion.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The [conversion state](../vs140/wstring_convert-class.md) object that represents the state of the conversion.  
  
### Remarks  
  
##  \<a name="wstring_convert__state_type">\</a>  wstring_convert::state_type  
 A type that represents the conversion state.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can represent a conversion state. The type is a synonym for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="wstring_convert__to_bytes">\</a>  wstring_convert::to_bytes  
 Converts a wide string to a byte string.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|The wide character to be converted.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The C-style, null-terminated sequence, beginning at <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, to be converted.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The [wide_string](#wstring_convert__wide_string) to be converted.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|The first element in a range of elements to be converted.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The last element in a range of elements to be converted.|  
  
### Remarks  
 If the [conversion state](../vs140/wstring_convert-class.md) object was <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> constructed with an explicit value, it is set to its default value (the initial conversion state) before the conversion begins. Otherwise it is left unchanged.  
  
 The number of input elements successfully converted is stored in the conversion count object. If no conversion error occurs, the member function returns the converted byte string. Otherwise, if the object was constructed with an initializer for the byte-string error message, the member function returns the byte-string error message object. Otherwise, the member function throws an object of class [range_error](../vs140/range_error-class.md).  
  
##  \<a name="wstring_convert__wide_string">\</a>  wstring_convert::wide_string  
 A type that represents a wide string.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="wstring_convert__wstring_convert">\</a>  wstring_convert::wstring_convert  
 Constructs an object of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to perform the conversion.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|The object of type [state_type](#wstring_convert__state_type) representing the conversion state.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|The [byte_string](#wstring_convert__byte_string) to display on errors.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The [wide_string](#wstring_convert__wide_string) to display on errors.|  
  
### Remarks  
 The first constructor stores                         *_Pcvt_arg* in the [conversion object](../vs140/wstring_convert-class.md) and default values in the conversion state object, the byte-string error message object, and the wide-string error message object.  
  
 The second constructor stores <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> in the conversion object, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> in the conversion state object. It stores default values in the byte-string error message object and the wide-string error message object. The stored state is retained between calls to [from_bytes](#wstring_convert__from_bytes) and [to_bytes](#wstring_convert__to_bytes).  
  
 The third constructor stores the conversion object in the conversion object, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> in the conversion state object,                         *_Berr* in the byte-string error message object, and                         *_Werr* in the wide-string error message object.