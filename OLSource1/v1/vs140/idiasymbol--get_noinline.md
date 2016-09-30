---
title: "IDiaSymbol::get_noInline"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_noInline method"
ms.assetid: 5c610b78-f1a3-494a-acf8-c42b97935be1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_noInline
Retrieves a flag that specifies whether the function has been marked as being not inline (using the [noinline](../vs140/noinline.md) attribute).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the function has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol Interface](../vs140/idiasymbol.md)   
 [noinline](../vs140/noinline.md)