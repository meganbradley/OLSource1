---
title: "IDiaSymbol::get_thisAdjust"
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
  - "IDiaSymbol::get_thisAdjust method"
ms.assetid: 56b9a147-e8c0-4d4b-a42a-398214dd5f86
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_thisAdjust
Retrieves the logical <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> adjustor for the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the logical <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> adjustor for the method.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 In some multiple inheritance cases the method itself must calculate a true <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value by adding an offset to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)