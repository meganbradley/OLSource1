---
title: "Dimension"
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
  - "Dimension Symbol"
ms.assetid: 94f791da-bfea-454f-8a14-da31e8e1596a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dimension
Each FORTRAN array has a dimension that is identified by a `SymTagDimension` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_lowerBound](../vs140/idiasymbol--get_lowerbound.md)|`IDiaSymbol*`|Lower bound of a FORTRAN array dimension.|  
|[lowerBoundId](../vs140/idiasymbol--get_lowerboundid.md)|`DWORD`|ID of the lower-bound symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagDimension` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_upperBound](../vs140/idiasymbol--get_upperbound.md)|`IDiaSymbol*`|Upper bound of a FORTRAN array dimension.|  
|[upperBoundId](../vs140/idiasymbol--get_upperboundid.md)|`DWORD`|ID of the upper-bound symbol.|  
  
## See Also  
 [ArrayType](../vs140/arraytype.md)   
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)