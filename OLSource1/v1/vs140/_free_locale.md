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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _free_locale
Frees a locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Locale object to free.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is used to free the locale object obtained from a call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The previous name of this function, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (with two leading underscores) has been deprecated.  
  
## Requirements  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required header|  
|---------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<locale.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 No equivalent.  
  
## See Also  
 [_get_current_locale](../vs140/_get_current_locale.md)   
 [_create_locale](../vs140/_create_locale--_wcreate_locale.md)