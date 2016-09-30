---
title: "wctrans"
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
  - "wctrans"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wctrans"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "character codes, wctrans"
  - "characters, codes"
  - "characters, converting"
  - "wctrans function"
ms.assetid: 215404bf-6d60-489c-9ae9-880e6b586162
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wctrans
Determines a mapping from one set of character codes to another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that specifies one of the valid transformations.  
  
## Return Value  
 If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> category of the current locale does not define a mapping whose name matches the property string <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the function returns zero. Otherwise, it returns a nonzero value suitable for use as the second argument to a subsequent call to [towctrans](../vs140/towctrans.md).  
  
## Remarks  
 This function determines a mapping from one set of character codes to another.  
  
 The following pairs of calls have the same behavior in all locales, but it is possible to define additional mappings even in the "C" locale:  
  
|Function|Same As|  
|--------------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required Header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<wctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **97**  
**1**  
**0**  
**65**   
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)