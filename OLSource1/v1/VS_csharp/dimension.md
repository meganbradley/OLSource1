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
|[IDiaSymbol::get_lowerBound](../VS_csharp/idiasymbol--get_lowerbound.md)|`IDiaSymbol*`|Lower bound of a FORTRAN array dimension.|  
|[lowerBoundId](../VS_csharp/idiasymbol--get_lowerboundid.md)|`DWORD`|ID of the lower-bound symbol.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagDimension` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_upperBound](../VS_csharp/idiasymbol--get_upperbound.md)|`IDiaSymbol*`|Upper bound of a FORTRAN array dimension.|  
|[upperBoundId](../VS_csharp/idiasymbol--get_upperboundid.md)|`DWORD`|ID of the upper-bound symbol.|  
  
## See Also  
 [ArrayType](../VS_csharp/arraytype.md)   
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)