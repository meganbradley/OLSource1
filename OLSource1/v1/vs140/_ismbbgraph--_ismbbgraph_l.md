---
title: "_ismbbgraph, _ismbbgraph_l"
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
  - "_ismbbgraph_l"
  - "_ismbbgraph"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbgraph"
  - "_ismbbgraph_l"
  - "ismbbgraph"
  - "ismbbgraph_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbgraph_l function"
  - "ismbbgraph_l function"
  - "_ismbbgraph function"
  - "ismbbgraph function"
ms.assetid: b60db718-134f-4796-acc1-592d0b9efbb7
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbgraph, _ismbbgraph_l
Determines whether a particular multibyte character is a graphical character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Integer to be tested.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a nonzero value if the expression:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is nonzero for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or 0 if it is not. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<mbctype.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)