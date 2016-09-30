---
title: "_ultoa, _ultow"
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
  - "_ultoa"
  - "_ultow"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ultot"
  - "ultow"
  - "_ultoa"
  - "_ultow"
  - "_ultot"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ultot function"
  - "converting integers"
  - "_ultot function"
  - "ultow function"
  - "integers, converting"
  - "_ultow function"
  - "_ultoa function"
  - "converting numbers, to strings"
ms.assetid: 7a472dc4-5652-4513-93c3-3358522c23be
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ultoa, _ultow
Convert an unsigned long integer to a string. More secure versions of these functions are available; see [_ultoa_s, _ultow_s](../vs140/_ultoa_s--_ultow_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String result.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Base of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>*.*  
  
## Return Value  
 Each of these functions returns a pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to a null-terminated character string and stores the result (up to 33 bytes) in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. No overflow checking is performed. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifies the base of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must be in the range 2 – 36. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  To prevent buffer overruns, ensure that the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> buffer is large enough to hold the converted digits plus the trailing null-character.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_itoa](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md).  
  
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_itoa, _i64toa, _ui64toa, _itow, _i64tow, _ui64tow](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md)