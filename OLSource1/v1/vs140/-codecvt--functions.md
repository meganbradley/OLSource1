---
title: "&lt;codecvt&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f974f410-c99b-4f96-ab29-15716205f4dd
caps.latest.revision: 13
---
# &lt;codecvt&gt; functions
||||  
|-|-|-|  
|[codecvt_mode](#codecvt_mode)|[codecvt_utf16](#codecvt_utf16)|[codecvt_utf8](#codecvt_utf8)|  
|[codecvt_utf8_utf16](#codecvt_utf8_utf16)|  
  
##  \<a name="codecvt_mode">\</a>  codecvt_mode  
 Specifies configuration information for [locale](../vs140/locale-class.md) facets.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The enumeration defines three constants that supply configuration information to the locale facets declared in [\<codecvt>](../vs140/-codecvt-.md). The distinct values are:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, to consume an initial header sequence when reading a multibyte sequence and determine the endianness of the subsequent multibyte sequence to be read  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, to generate an initial header sequence when writing a multibyte sequence to advertise the endianness of the subsequent multibyte sequence to be written  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, to generate a multibyte sequence in little-endian order, as opposed to the default big-endian order  
  
 These constants can be ORed together in arbitrary combinations.  
  
##  \<a name="codecvt_utf8">\</a>  codecvt_utf8  
 Represents a [locale](../vs140/locale-class.md) facet that converts between wide characters encoded as UCS-2 or UCS-4, and a byte stream encoded as UTF-8.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The wide-character element type.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The maximum number of characters for the locale facet.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Configuration information for the locale facet.|  
  
### Remarks  
 The byte stream can be written to either a binary file or a text file.  
  
##  \<a name="codecvt_utf8_utf16">\</a>  codecvt_utf8_utf16  
 Represents a [locale](../vs140/locale-class.md) facet that converts between wide characters encoded as UTF-16 and a byte stream encoded as UTF-8.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The wide-character element type.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The maximum number of characters for the locale facet.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Configuration information for the locale facet.|  
  
### Remarks  
 The byte stream can be written to either a binary file or a text file.  
  
##  \<a name="codecvt_utf16">\</a>  codecvt_utf16  
 Represents a [locale](../vs140/locale-class.md) facet that converts between wide characters encoded as UCS-2 or UCS-4 and a byte stream encoded as UTF-16LE or UTF-16BE.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The wide-character element type.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The maximum number of characters for the locale facet.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Configuration information for the locale facet.|  
  
### Remarks  
 This template class converts between wide characters encoded as UCS-2 or UCS-4 and a byte stream encoded as UTF-16LE, if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or UTF-16BE otherwise.  
  
 The byte stream should be written to a binary file; it can be corrupted if written to a text file.  
  
## See Also  
 [&lt;codecvt&gt;](../vs140/-codecvt-.md)