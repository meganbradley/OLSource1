---
title: "IDiaSymbol::get_isNaked"
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
  - "IDiaSymbol::get_isNaked method"
ms.assetid: b16629dc-8e17-476b-9c7b-58e7277c61ed
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isNaked
Retrieves a flag that specifies whether the function has the [naked (C++)](../vs140/naked--c---.md) attribute (that is, the function has no prolog or epilog code added by the compiler).  
  
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
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [Naked Function Calls](../vs140/naked-function-calls.md)