---
title: "VTable"
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
  - "VTable symbol"
  - "virtual tables"
ms.assetid: c8be6692-7d2a-4721-99d3-8e2e565bb8a1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VTable
The virtual table is identified by the `SymTagVTable` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[classParent](../VS_csharp/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol of the class that owns this VTable.|  
|[classParentId](../VS_csharp/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constType](../VS_csharp/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the class of the VTable is marked as a constant.|  
|[lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagVTable` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../VS_csharp/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the VTable's [VTableShape](../VS_csharp/vtableshape.md).|  
|[typeId](../VS_csharp/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[unalignedType](../VS_csharp/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the class of the VTable is unaligned.|  
|[volatileType](../VS_csharp/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the class of the VTable is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)   
 [VTableShape](../VS_csharp/vtableshape.md)