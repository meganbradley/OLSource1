---
title: "_ismbbblank, _ismbbblank_l"
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
  - "_ismbbblank_l"
  - "_ismbbblank"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
dev_langs: 
  - "C++"
ms.assetid: d21b2e41-7206-41f5-85bb-9c9ab4f3e21b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbbblank, _ismbbblank_l
Determines whether a specified multibyte character is a blank character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents a space (0x20) character, a horizontal tab (0x09) character, or a locale-specific character that's used to separate words within a line of text for which <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is true; otherwise, returns 0. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is identical except that it instead uses the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<mbctype.h>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)