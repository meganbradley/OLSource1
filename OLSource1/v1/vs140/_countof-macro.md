---
title: "_countof Macro"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_countof"
  - "countof"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "countof macro"
  - "_countof macro"
ms.assetid: 86198767-f7e5-4beb-898d-3cbbf60350a3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _countof Macro
Compute the number of elements in a statically-allocated array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of an array.  
  
## Return Value  
 The number of elements in the array, expressed as a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Ensure that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is actually an array, not a pointer. In C, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will produce erroneous results if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a pointer. In C++, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will fail to compile if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a pointer.  
  
## Requirements  
  
|Macro|Required header|  
|-----------|---------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sizeof(arr) = 40 bytes**  
**_countof(arr) = 20 elements**   
## See Also  
 [sizeof Operator](../vs140/sizeof-operator.md)