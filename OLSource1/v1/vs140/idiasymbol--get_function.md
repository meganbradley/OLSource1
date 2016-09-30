---
title: "IDiaSymbol::get_function"
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
  - "IDiaSymbol::get_function method"
ms.assetid: 48b3a318-3211-410f-8570-c02ee210f0a5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_function
Retrieves a flag that specifies whether the public symbol refers to a function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the symbol refers to a function; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)