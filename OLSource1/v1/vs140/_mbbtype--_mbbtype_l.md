---
title: "_mbbtype, _mbbtype_l"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_mbbtype"
  - "_mbbtype_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbbtype_l"
  - "mbbtype"
  - "mbbtype_l"
  - "_mbbtype"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbbtype function"
  - "_mbbtype_l function"
  - "mbbtype function"
  - "mbbtype_l function"
ms.assetid: b8e34b40-842a-4298-aa39-0bd2d8e51c2a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbbtype, _mbbtype_l
Returns the byte type, based on the previous byte.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of byte to test for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the type of byte in a string. This decision is context-sensitive, as specified by the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which provides the control test condition. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the type of the previous byte in the string. The manifest constants in the following table are defined in Mbctype.h.  
  
|Value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> tests for|Return value|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|---------------------|--------------------------|------------------|---------|  
|Any value except 1|Valid single byte or lead byte|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (0)|Single byte (0x20 – 0x7E, 0xA1 – 0xDF)|  
|Any value except 1|Valid single byte or lead byte|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (1)|Lead byte of multibyte character (0x81 – 0x9F, 0xE0 – 0xFC)|  
|Any value except 1|Valid single-byte or lead byte|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> ( –1)|Invalid character (any value except 0x20 – 0x7E, 0xA1 – 0xDF, 0x81 – 0x9F, 0xE0 – 0xFC|  
|1|Valid trail byte|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (2)|Trailing byte of multibyte character (0x40 – 0x7E, 0x80 – 0xFC)|  
|1|Valid trail byte|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> ( –1)|Invalid character (any value except 0x20 – 0x7E, 0xA1 – 0xDF, 0x81 – 0x9F, 0xE0 – 0xFC|  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function determines the type of a byte in a multibyte character. If the value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is any value except 1, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> tests for a valid single-byte or lead byte of a multibyte character. If the value of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is 1, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> tests for a valid trail byte of a multibyte character.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> version of this function uses the current locale for this locale-dependent behavior; the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> version is identical except that it use the locale parameter that's passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In earlier versions, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> was named <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For new code, use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> instead.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<mbstring.h>|\<mbctype.h>*|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<mbstring.h>|\<mbctype.h>*|  
  
 \* For definitions of manifest constants that are used as return values.  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable, but see [System::Globalization::CultureInfo](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)