---
title: "wbuffer_convert Class"
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
  - "stdext::cvt::wbuffer_convert"
  - "wbuffer_convert"
  - "stdext.cvt.wbuffer_convert"
  - "cvt.wbuffer_convert"
  - "cvt::wbuffer_convert"
  - "wbuffer/stdext::cvt::wbuffer_convert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wbuffer_convert class"
ms.assetid: 4a56f9bf-4138-4612-b516-525fea401358
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wbuffer_convert Class
Describes a stream buffer that controls the transmission of elements to and from a byte stream buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The [locale](../vs140/locale-class.md) facet that represents the conversion object.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The wide-character element type.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The traits associated with                                 *Elem*.|  
  
## Remarks  
 This template class describes a stream buffer that controls the transmission of elements of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, whose character traits are described by the class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, to and from a byte stream buffer of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Conversion between a sequence of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> values and multibyte sequences is performed by an object of class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which meets the requirements of the standard code-conversion facet <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 An object of this template class stores:  
  
-   A pointer to its underlying byte stream buffer  
  
-   A pointer to the allocated conversion object (which is freed when the [wbuffer_convert](../vs140/wbuffer_convert-class.md) object is destroyed)  
  
-   A conversion state object of type [state_type](#wbuffer_convert__state_type).  
  
### Constructors  
  
|||  
|-|-|  
|[wbuffer_convert](#wbuffer_convert__wbuffer_convert)|Constructs an object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[state_type](#wbuffer_convert__state_type)|A type that represents the conversion state.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#wbuffer_convert__rdbuf)|Returns the byte stream buffer.|  
|[state](#wbuffer_convert__state)|Returns an object representing the state of the conversion.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="wbuffer_convert__rdbuf">\</a>  wbuffer_convert::rdbuf  
 Returns the byte stream buffer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The byte stream buffer to be stored in the object representing the byte stream buffer.|  
  
### Return Value  
 An object representing the underlying byte stream buffer.  
  
### Remarks  
 The second member function stores <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in the object representing the byte stream buffer.  
  
##  \<a name="wbuffer_convert__state">\</a>  wbuffer_convert::state  
 Returns an object representing the state of the conversion.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An object that represents the state of the conversion.  
  
### Remarks  
  
##  \<a name="wbuffer_convert__state_type">\</a>  wbuffer_convert::state_type  
 A type that represents the conversion state.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
##  \<a name="wbuffer_convert__wbuffer_convert">\</a>  wbuffer_convert::wbuffer_convert  
 Constructs an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The byte-oriented stream buffer to store.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to perform the conversion.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The object of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> representing the conversion state.|  
  
### Remarks  
 This constructor constructs a stream buffer object, initializes the object representing the underlying byte stream buffer to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, initializes                        the conversion object                        to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and initializes the conversion state object to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.