---
title: "Locale Categories"
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
  - "LC_MAX"
  - "LC_MIN"
  - "LC_MONETARY"
  - "LC_TIME"
  - "LC_NUMERIC"
  - "LC_COLLATE"
  - "LC_CTYPE"
  - "LC_ALL"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "LC_MIN constant"
  - "LC_MONETARY constant"
  - "LC_CTYPE constant"
  - "locale constants"
  - "LC_MAX constant"
  - "LC_ALL constant"
  - "LC_TIME constant"
  - "LC_NUMERIC constant"
  - "LC_COLLATE constant"
ms.assetid: 868f1493-fe5d-4722-acab-bfcd374a063a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Locale Categories
## Syntax  
  
```  
  
#include <locale.h>  
  
```  
  
## Remarks  
 Locale categories are manifest constants used by the localization routines to specify which portion of a program's locale information will be used. The locale refers to the locality (or Country/Region) for which certain aspects of your program can be customized. Locale-dependent areas include, for example, the formatting of dates or the display format for monetary values.  
  
|Locale category|Parts of program affected|  
|---------------------|-------------------------------|  
|`LC_ALL`|All locale-specific behavior (all categories)|  
|`LC_COLLATE`|Behavior of `strcoll` and `strxfrm` functions|  
|`LC_CTYPE`|Behavior of character-handling functions (except **isdigit**, `isxdigit`, `mbstowcs`, and `mbtowc`, which are unaffected)|  
|`LC_MAX`|Same as `LC_TIME`|  
|`LC_MIN`|Same as `LC_ALL`|  
|`LC_MONETARY`|Monetary formatting information returned by the `localeconv` function|  
|`LC_NUMERIC`|Decimal-point character for formatted output routines (for example, `printf`), data conversion routines, and nonmonetary formatting information returned by `localeconv` function|  
|`LC_TIME`|Behavior of `strftime` function|  
  
 See [setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md) for an example.  
  
## See Also  
 [localeconv](../VS_csharp/localeconv.md)   
 [setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md)   
 [strcoll Functions](../VS_csharp/strcoll-functions.md)   
 [strftime, wcsftime, _strftime_l, _wcsftime_l](../VS_csharp/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../VS_csharp/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)   
 [Global Constants](../VS_csharp/global-constants.md)