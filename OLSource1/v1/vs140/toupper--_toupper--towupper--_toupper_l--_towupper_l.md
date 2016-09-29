---
title: "toupper, _toupper, towupper, _toupper_l, _towupper_l"
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
  - "_toupper_l"
  - "towupper"
  - "toupper"
  - "_towupper_l"
  - "_toupper"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "towupper"
  - "_toupper"
  - "_totupper"
  - "toupper"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_toupper function"
  - "towupper function"
  - "uppercase, converting strings to"
  - "totupper function"
  - "string conversion, to different characters"
  - "towupper_l function"
  - "toupper_l function"
  - "string conversion, case"
  - "_toupper_l function"
  - "_towupper_l function"
  - "_totupper function"
  - "case, converting"
  - "characters, converting"
  - "toupper function"
ms.assetid: cdef1b0f-b19c-4d11-b7d2-cf6334c9b6cc
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# toupper, _toupper, towupper, _toupper_l, _towupper_l
Convert character to uppercase.  
  
## Syntax  
  
```  
int toupper(  
   int c   
);  
int _toupper(  
   int c   
);  
int towupper(  
   wint_t c   
);  
int _toupper_l(  
   int c ,  
   _locale_t locale  
);  
int _towupper_l(  
   wint_t c ,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Character to convert.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Each of these routines converts a copy of `c`, if possible, and returns the result.  
  
 If `c` is a wide character for which `iswlower` is nonzero and there is a corresponding wide character for which `iswupper` is nonzero, `towupper` returns the corresponding wide character; otherwise, `towupper` returns `c` unchanged.  
  
 There is no return value reserved to indicate an error.  
  
 In order for `toupper` to give the expected results, [__isascii](../vs140/isascii--__isascii--iswascii.md) and [islower](../vs140/islower--iswlower--_islower_l--_iswlower_l.md) must both return nonzero.  
  
## Remarks  
 Each of these routines converts a given lowercase letter to an uppercase letter if possible and appropriate. The case conversion of `towupper` is locale-specific. Only the characters relevant to the current locale are changed in case. The functions without the `_l` suffix use the currently set locale. The versions of these functions with the `_l` suffix take the locale as a parameter and use that instead of the currently set locale. For more information, see [Locale](../vs140/locale.md).  
  
 In order for `toupper` to give the expected results, [__isascii](../vs140/isascii--__isascii--iswascii.md) and [isupper](../vs140/isupper--_isupper_l--iswupper--_iswupper_l.md) must both return nonzero.  
  
 [Data Conversion Routines](../vs140/data-conversion.md)  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_totupper`|`toupper`|`_mbctoupper`|`towupper`|  
|`_totupper_l`|`_toupper_l`|`_mbctoupper_l`|`_towupper_l`|  
  
> [!NOTE]
>  `_toupper_l` and `_towupper_l` have no locale dependence and are not meant to be called directly. They are provided for internal use by `_totupper_l`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`toupper`|<ctype.h>|  
|`_toupper`|<ctype.h>|  
|`towupper`|<ctype.h> or <wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example in [to Functions](../vs140/to-functions.md).  
  
## .NET Framework Equivalent  
 [System::Char::ToUpper](https://msdn.microsoft.com/en-us/library/system.char.toupper.aspx)  
  
## See Also  
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [to Functions](../vs140/to-functions.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)