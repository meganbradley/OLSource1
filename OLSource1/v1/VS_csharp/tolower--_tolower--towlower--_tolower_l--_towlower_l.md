---
title: "tolower, _tolower, towlower, _tolower_l, _towlower_l"
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
  - "_tolower_l"
  - "towlower"
  - "tolower"
  - "_tolower"
  - "_towlower_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_totlower"
  - "tolower"
  - "_tolower"
  - "towlower"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tolower_l function"
  - "_tolower_l function"
  - "totlower function"
  - "string conversion, to different characters"
  - "lowercase, converting to"
  - "tolower function"
  - "string conversion, case"
  - "towlower function"
  - "_tolower function"
  - "_totlower function"
  - "towlower_l function"
  - "case, converting"
  - "characters, converting"
  - "_towlower_l function"
ms.assetid: 86e0fc02-94ae-4472-9631-bf8e96f67b92
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tolower, _tolower, towlower, _tolower_l, _towlower_l
Converts a character to lowercase.  
  
## Syntax  
  
```  
int tolower(  
   int c   
);  
int _tolower(  
   int c   
);  
int towlower(  
   wint_t c   
);  
int _tolower_l(  
   int c,  
   _locale_t locale   
);  
int _towlower_l(  
   wint_t c,  
   _locale_t locale   
);  
```  
  
#### Parameters  
 [in] `c`  
 Character to convert.  
  
 [in] `locale`  
 Locale to use for locale-specific translation.  
  
## Return Value  
 Each of these routines converts a copy of `c` to lower case if the conversion is possible, and returns the result. There is no return value reserved to indicate an error.  
  
## Remarks  
 Each of these routines converts a given uppercase letter to a lowercase letter if it is possible and relevant. The case conversion of `towlower` is locale-specific. Only the characters relevant to the current locale are changed in case. The functions without the `_l` suffix use the currently set locale. The versions of these functions that have the `_l` suffix take the locale as a parameter and use that instead of the currently set locale. For more information, see [Locale](../VS_csharp/locale.md).  
  
 In order for `_tolower` to give the expected results, [__isascii](../VS_csharp/isascii--__isascii--iswascii.md) and [isupper](../VS_csharp/isupper--_isupper_l--iswupper--_iswupper_l.md) must both return nonzero.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_totlower`|`tolower`|`_mbctolower`|`towlower`|  
|`_totlower_l`|`_tolower_l`|`_mbctolower_l`|`_towlower_l`|  
  
> [!NOTE]
>  `_tolower_l` and `_towlower_l` have no locale dependence and are not meant to be called directly. They are provided for internal use by `_totlower_l`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`tolower`|<ctype.h>|  
|`_tolower`|<ctype.h>|  
|`towlower`|<ctype.h> or <wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
 See the example in [to Functions](../VS_csharp/to-functions.md).  
  
## .NET Framework Equivalent  
 [System::Char::ToLower](https://msdn.microsoft.com/en-us/library/system.char.tolower.aspx)  
  
## See Also  
 [Data Conversion](../VS_csharp/data-conversion.md)   
 [is, isw Routines](../VS_csharp/is--isw-routines.md)   
 [to Functions](../VS_csharp/to-functions.md)   
 [Locale](../VS_csharp/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../VS_csharp/interpretation-of-multibyte-character-sequences.md)