---
title: "wctype"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - wctype
apilocation: 
  - msvcr90.dll
  - msvcrt.dll
  - msvcr110.dll
  - msvcr120.dll
  - msvcr80.dll
  - msvcr110_clr0400.dll
  - msvcr100.dll
apitype: DLLExport
f1_keywords: 
  - wctype
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - wctype function
  - wide characters
ms.assetid: 14aded12-4087-4123-bc48-db4e10999223
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# wctype
Determines a classification rule for wide-character codes.  
  
## Syntax  
  
```  
wctype_t wctype(  
   const char * property   
);  
```  
  
#### Parameters  
 `property`  
 Property string.  
  
## Return Value  
 If the `LC_CTYPE` category of the current locale does not define a classification rule whose name matches the property string `property`, the function returns zero. Otherwise, it returns a nonzero value suitable for use as the second argument to a subsequent call to [towctrans](../vs140/towctrans.md).  
  
## Remarks  
 The function determines a classification rule for wide-character codes. The following pairs of calls have the same behavior in all locales (but an implementation can define additional classification rules even in the "C" locale):  
  
|Function|Same as|  
|--------------|-------------|  
|`iswalnum(`  `c`  `)`|`iswctype(`  `c` `, wctype( "alnum" ) )`|  
|`iswalpha(`  `c`  `)`|`iswctype(`  `c` `, wctype( "alpha" ) )`|  
|`iswcntrl(`  `c`  `)`|`iswctype(`  `c` `, wctype( "cntrl" ) )`|  
|`iswdigit(`  `c`  `)`|`iswctype(`  `c` `, wctype( "digit" ) )`|  
|`iswgraph(`  `c`  `)`|`iswctype(`  `c` `, wctype( "graph" ) )`|  
|`iswlower(`  `c`  `)`|`iswctype(`  `c` `, wctype( "lower" ) )`|  
|`iswprint(`  `c`  `)`|`iswctype(`  `c` `, wctype( "print" ) )`|  
|`iswpunct(`  `c`  `)`|`iswctype(`  `c` `, wctype( "punct" ) )`|  
|`iswspace(`  `c`  `)`|`iswctype(`  `c` `, wctype( "space" ) )`|  
|`iswupper(`  `c`  `)`|`iswctype(`  `c` `, wctype( "upper" ) )`|  
|`iswxdigit(`  `c`  `)`|`iswctype(`  `c` `, wctype( "xdigit" ) )`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`wctype`|<wctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)