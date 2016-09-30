---
title: "Data Type Mappings"
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
  - "_TXCHAR"
  - "_TUCHAR"
  - "_TINT"
  - "_TSCHAR"
  - "_TCHAR"
  - "TCHAR::H"
  - "TCHAR"
  - "_T"
  - "_TEXT"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TXCHAR type"
  - "TINT type"
  - "_TCHAR type"
  - "TSCHAR type"
  - "TEXT type"
  - "TCHAR type"
  - "TCHAR.H data types, mappings defined in"
  - "generic-text data types"
  - "_TINT type"
  - "TUCHAR type"
  - "TXCHAR type"
  - "_TSCHAR type"
  - "T type"
  - "_TUCHAR type"
  - "_TEXT type"
  - "_T type"
ms.assetid: 4e573c05-8800-468b-ae5f-76ff7409835e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Type Mappings
These data-type mappings are defined in TCHAR.H and depend on whether the constant `_UNICODE` or `_MBCS` has been defined in your program.  
  
 For related information, see [Using TCHAR.H Data Types with _MBCS Code](../vs140/using-tchar.h-data-types-with-_mbcs-code.md).  
  
### Generic-Text Data Type Mappings  
  
|Generic-text\<br />\<br /> data type name|SBCS (_UNICODE,\<br />\<br /> _MBCS not\<br />\<br /> defined)|_MBCS\<br />\<br /> defined|_UNICODE\<br />\<br /> defined|  
|--------------------------------------|----------------------------------------------------|------------------------|---------------------------|  
|`_TCHAR`|`char`|`char`|`wchar_t`|  
|`_tfinddata_t`|`_finddata_t`|`_finddata_t`|`_wfinddata_t`|  
|`_tfinddata64_t`|`__finddata64_t`|`__finddata64_t`|`__wfinddata64_t`|  
|`_tfinddatai64_t`|`_finddatai64_t`|`_finddatai64_t`|`_wfinddatai64_t`|  
|`_TINT`|`int`|`int`|`wint_t`|  
|`_TSCHAR`|`signed char`|`signed char`|`wchar_t`|  
|`_TUCHAR`|`unsigned char`|`unsigned char`|`wchar_t`|  
|`_TXCHAR`|`char`|`unsigned char`|`wchar_t`|  
|`_T` or `_TEXT`|No effect (removed by preprocessor)|No effect (removed by preprocessor)|`L` (converts following character or string to its Unicode counterpart)|  
  
## See Also  
 [Generic-Text Mappings](../vs140/generic-text-mappings.md)   
 [Constant and Global Variable Mappings](../vs140/constant-and-global-variable-mappings.md)   
 [Routine Mappings](../vs140/routine-mappings.md)   
 [A Sample Generic-Text Program](../vs140/a-sample-generic-text-program.md)   
 [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md)