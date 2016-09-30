---
title: "isleadbyte, _isleadbyte_l"
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
  - "_isleadbyte_l"
  - "isleadbyte"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_istleadbyte"
  - "_isleadbyte_l"
  - "isleadbyte"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "lead bytes"
  - "_isleadbyte_l function"
  - "_istleadbyte function"
  - "istleadbyte function"
  - "isleadbyte function"
ms.assetid: 3b2bcf09-d82b-4803-9e80-59d04942802a
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# isleadbyte, _isleadbyte_l
Determines whether a character is the lead byte of a multibyte character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see                  [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a nonzero value if the argument satisfies the test condition or 0 if it does not. In the "C" locale and in single-byte character set (SBCS) locales, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> always returns 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro returns a nonzero value if its argument is the first byte of a multibyte character. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> produces a meaningful result for any integer argument from –1 (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (0xFF), inclusive.  
  
 The expected argument type of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; if a signed character is passed, the compiler may convert it to an integer by sign extension, yielding unpredictable results.  
  
 The version of this function with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix is identical except that it uses the locale passed in instead of the current locale for its locale-dependent behavior.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Always returns false|**_** <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Always returns false|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<ctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable, but see [System::Globalization::CultureInfo](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [Locale](../vs140/locale.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)