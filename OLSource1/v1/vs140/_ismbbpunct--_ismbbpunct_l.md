---
title: "_ismbbpunct, _ismbbpunct_l"
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
  - "_ismbbpunct"
  - "_ismbbpunct_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbbpunct"
  - "ismbbpunct_l"
  - "_ismbbpunct_l"
  - "_ismbbpunct"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbbpunct function"
  - "_ismbbpunct function"
  - "ismbbpunct_l function"
  - "_ismbbpunct_l function"
ms.assetid: 1976c9d3-7d1a-415f-ac52-2715c7bb56eb
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbpunct, _ismbbpunct_l
Determines whether a particular character is a punctuation character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a nonzero value if the integer <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a non-ASCII punctuation symbol. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses the current locale for any locale-dependent character settings. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is identical except that it uses the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
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