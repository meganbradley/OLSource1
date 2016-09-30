---
title: "_ismbbkana, _ismbbkana_l"
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
  - "_ismbbkana_l"
  - "_ismbbkana"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbkana_l"
  - "ismbbkana_l"
  - "ismbbkana"
  - "_ismbbkana"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbkana_l function"
  - "_ismbbkana function"
  - "ismbbkana function"
  - "ismbbkana_l function"
ms.assetid: 64d4eb4a-205a-40ef-be35-ff9d77fabbaf
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbkana, _ismbbkana_l
Tests for a katakana symbol and is specific to code page 932.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a nonzero value if the integer <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a katakana symbol or 0 if it is not. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses the current locale for locale-dependent character information. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is identical except that it uses the locale object passed in. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<mbctype.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)