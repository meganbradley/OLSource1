---
title: "_ltoa, _ltow"
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
  - "_ltoa"
  - "_ltow"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ltow"
  - "_ltot"
  - "_ltoa"
  - "_ltow"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "converting integers"
  - "_ltoa function"
  - "_ltow function"
  - "ltow function"
  - "ltoa function"
  - "long integer conversion to string"
  - "converting numbers, to strings"
ms.assetid: 14036104-2c25-4759-87c0-918ed8521e47
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ltoa, _ltow
Converts a long integer to a string. More secure versions of these functions are available; see [_ltoa_s, _ltow_s](../vs140/_ltoa_s--_ltow_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String result.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Base of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Each of these functions returns a pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts the digits of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to a null-terminated character string and stores the result (up to 33 bytes) in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument specifies the base of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which must be in the range 2 – 36. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> equals 10 and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is negative, the first character of the stored string is the minus sign (–). <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; the second argument and return value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are wide-character strings. Each of these functions is Microsoft-specific.  
  
> [!IMPORTANT]
>  To prevent buffer overruns, ensure that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> buffer is large enough to hold the converted digits plus the trailing null-character and a sign character.  
  
 In C++, these functions have template overloads. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_itoa](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md).  
  
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_itoa, _i64toa, _ui64toa, _itow, _i64tow, _ui64tow](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md)   
 [_ultoa, _ultow](../vs140/_ultoa--_ultow.md)