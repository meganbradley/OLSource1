---
title: "IDiaSymbol::get_isSplitted"
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
  - "IDiaSymbol::get_isSplitted method"
ms.assetid: ff160cf6-003b-4ef5-a406-20a7b287b2bf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isSplitted
Retrieves a flag that specifies whether the data symbol has been split into an aggregation or collection of other symbols; the compiler treats the symbols as separate entities, even though they are really part of a larger symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the symbol has been split into an aggregate of symbols; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 The [IDiaSymbol::get_isAggregated](../vs140/idiasymbol--get_isaggregated.md) method returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for all symbols that are part of a split symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_isAggregated](../vs140/idiasymbol--get_isaggregated.md)