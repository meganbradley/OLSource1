---
title: "IDiaSymbol::get_rank"
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
  - "IDiaSymbol::get_rank method"
ms.assetid: 14cc9c4b-a5ec-414a-b01f-4a142c17b7cc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_rank
Retrieves the rank (number of dimensions) of a FORTRAN multi-dimensional array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns the number of dimensions in a FORTRAN multi-dimensional array.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 Rank refers to the number of dimensions in an array where the array is declared as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This example has a rank of 3 and 3 dimensions. Rank does not apply to C++ which uses the concept of an array of arrays for each dimension (that is, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)