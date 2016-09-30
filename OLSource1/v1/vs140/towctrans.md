---
title: "towctrans"
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
  - "towctrans"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "towctrans"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "towctrans function"
ms.assetid: 1ed1e70d-7b31-490f-a7d9-42564b5924ca
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# towctrans
Transforms a character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character you want to transform.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An identifier that contains the return value of [wctrans](../vs140/wctrans.md).  
  
## Return Value  
 The character <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, after <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> used the transform rule in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must have been returned by an earlier successful call to [wctrans](../vs140/wctrans.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<wctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for a sample that uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)