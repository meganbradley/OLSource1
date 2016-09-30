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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Locale categories are manifest constants used by the localization routines to specify which portion of a program's locale information will be used. The locale refers to the locality (or Country/Region) for which certain aspects of your program can be customized. Locale-dependent areas include, for example, the formatting of dates or the display format for monetary values.  
  
|Locale category|Parts of program affected|  
|---------------------|-------------------------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|All locale-specific behavior (all categories)|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Behavior of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Behavior of character-handling functions (except **isdigit**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which are unaffected)|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Monetary formatting information returned by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Decimal-point character for formatted output routines (for example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), data conversion routines, and nonmonetary formatting information returned by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Behavior of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function|  
  
 See [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for an example.  
  
## See Also  
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)   
 [Global Constants](../vs140/global-constants.md)