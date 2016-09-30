---
title: "_mbcjistojms, _mbcjistojms_l, _mbcjmstojis, _mbcjmstojis_l"
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
  - "_mbcjistojms"
  - "_mbcjmstojis"
  - "_mbcjistojms_l"
  - "_mbcjmstojis_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbcjistojms"
  - "_mbcjistojms"
  - "_mbcjistojms_l"
  - "_mbcjmstojis_l"
  - "_mbcjmstojis"
  - "mbcjmstojis_l"
  - "mbcjistojms_l"
  - "mbcjmstojis"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbcjmstojis_l function"
  - "_mbcjistojms function"
  - "mbcjmstojis function"
  - "_mbcjistojms_l function"
  - "_mbcjmstojis function"
  - "mbcjistojms function"
  - "mbcjmstojis_l function"
  - "mbcjistojms_l function"
ms.assetid: dece5127-b337-40a4-aa10-53320a2c9432
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbcjistojms, _mbcjistojms_l, _mbcjmstojis, _mbcjmstojis_l
Converts between Japan Industry Standard (JIS) and Japan Microsoft (JMS) characters.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Character to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 On Japanese locale, these functions return a converted character or return 0 if no conversion is possible. On a non-Japanese locale, these functions return the character passed in.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function converts a Japan Industry Standard (JIS) character to a Microsoft Kanji (Shift JIS) character. The character is converted only if the lead and trail bytes are in the range 0x21 – 0x7E. If the lead or trial byte is outside this range, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>function converts a Shift JIS character to a JIS character. The character is converted only if the lead byte is in the range 0x81 – 0x9F or 0xE0 – 0xFC and the trail byte is in the range 0x40 – 0x7E or 0x80 – 0xFC. Note that some code points in that range do not have a character assigned and so cannot be converted.  
  
 The value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should be a 16-bit value whose upper 8 bits represent the lead byte of the character to convert and whose lower 8 bits represent the trail byte.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In earlier versions, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> were called<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, respectively. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> should be used instead.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)