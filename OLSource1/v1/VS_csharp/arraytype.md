---
title: "ArrayType"
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
  - "ArrayType symbol"
ms.assetid: 1d973a3a-2bde-46df-8625-85d519bb3cc9
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ArrayType
An array is identified by a `SymTagArray` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_arrayIndexType](../VS_csharp/idiasymbol--get_arrayindextype.md)|`IDiaSymbol*`|Symbol for the array index type.|  
|[arrayIndexTypeId](../VS_csharp/idiasymbol--get_arrayindextypeid.md)|`DWORD`|ID of the array index type symbol.|  
|[constType](../VS_csharp/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the array is marked as const.|  
|[count](../VS_csharp/idiasymbol--get_count.md)|`DWORD`|Number of items in the array.|  
|[IDiaSymbol::get_length](../VS_csharp/idiasymbol--get_length.md)|`LONGLONG`|Size, in bytes, of this array.|  
|[lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_rank](../VS_csharp/idiasymbol--get_rank.md)|`DWORD`|Rank of a FORTRAN multidimensional array.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagArray` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../VS_csharp/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the array element type.|  
|[typeId](../VS_csharp/idiasymbol--get_typeid.md)|`DWORD`|ID of the array element type symbol.|  
|[unalignedType](../VS_csharp/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the array is unaligned|  
|[volatileType](../VS_csharp/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the array is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)   
 [Dimension](../VS_csharp/dimension.md)