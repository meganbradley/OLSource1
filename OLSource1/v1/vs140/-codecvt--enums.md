---
title: "&lt;codecvt&gt; enums"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 46a8b073-01bc-46d3-b3d3-a8540f9422c1
caps.latest.revision: 13
---
# &lt;codecvt&gt; enums
||  
|-|  
|[codecvt_mode Enumeration](#codecvt_mode_enumeration)|  
  
##  \<a name="codecvt_mode_enumeration">\</a>  codecvt_mode Enumeration  
 Specifies configuration information for [locale](../vs140/locale-class.md) facets.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The enumeration defines three constants that supply configuration information to the locale facets declared in [\<codecvt>](../vs140/-codecvt-.md). The distinct values are:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, to consume an initial header sequence when reading a multibyte sequence and determine the endianness of the subsequent multibyte sequence to be read  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to generate an initial header sequence when writing a multibyte sequence to advertise the endianness of the subsequent multibyte sequence to be written  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to generate a multibyte sequence in little-endian order, as opposed to the default big-endian order  
  
 These constants can be ORed together in arbitrary combinations.  
  
## See Also  
 [&lt;codecvt&gt;](../vs140/-codecvt-.md)