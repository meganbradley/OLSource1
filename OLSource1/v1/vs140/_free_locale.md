---
title: "_free_locale"
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
  - "_free_locale"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__free_locale"
  - "free_locale"
  - "_free_locale"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__free_locale function"
  - "free_locale function"
  - "locales, freeing"
  - "_free_locale function"
ms.assetid: 1f08d348-ab32-4028-a145-6cbd51b49af9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _free_locale
Frees a locale object.  
  
## Syntax  
  
```  
void _free_locale(  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `locale`  
 Locale object to free.  
  
## Remarks  
 The `_free_locale` function is used to free the locale object obtained from a call to `_get_current_locale` or `_create_locale`.  
  
 The previous name of this function, `__free_locale` (with two leading underscores) has been deprecated.  
  
## Requirements  
  
|`Routine`|Required header|  
|---------------|---------------------|  
|`_free_locale`|<locale.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 No equivalent.  
  
## See Also  
 [_get_current_locale](../vs140/_get_current_locale.md)   
 [_create_locale](../vs140/_create_locale--_wcreate_locale.md)