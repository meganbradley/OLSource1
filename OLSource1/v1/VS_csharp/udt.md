---
title: "UDT"
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
  - "SymTagUDT symbol"
  - "user-defined type (UDT) symbol"
  - "unions, as symbols"
  - "UDT symbol"
  - "structs [C++]"
ms.assetid: f12459dd-c64d-4cc9-9ee3-a56e19e9e573
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UDT
Each class, structure, and union is identified by a `SymTagUDT` symbol. Each member, function, data, or nested type, and each base class, appears as a class child of the user-defined type (UDT).  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[classParent](../VS_csharp/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the class parent, if any.|  
|[classParentId](../VS_csharp/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../VS_csharp/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if the UDT has a constructor.|  
|[constType](../VS_csharp/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the UDT is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_csharp/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if the UDT has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../VS_csharp/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if the UDT has any cast operators defined.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_csharp/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if the UDT has nested type definitions.|  
|[IDiaSymbol::get_length](../VS_csharp/idiasymbol--get_length.md)|`LONGLONG`|The size, in bytes, of the UDT.|  
|[lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../VS_csharp/compiland.md).|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../VS_csharp/idiasymbol--get_name.md)|`BSTR`|The name of the UDT.|  
|[IDiaSymbol::get_nested](../VS_csharp/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if the UDT is nested.|  
|[IDiaSymbol::get_overloadedOperator](../VS_csharp/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if overloaded operators are defined for the UDT.|  
|[IDiaSymbol::get_packed](../VS_csharp/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if the UDT is packed.|  
|[IDiaSymbol::get_scoped](../VS_csharp/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if the UDT appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagUDT` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_udtKind](../VS_csharp/idiasymbol--get_udtkind.md)|`DWORD`|Indicates whether this is a structure, class, or union; for details, see [UdtKind Enumeration](../VS_csharp/udtkind.md).|  
|[unalignedType](../VS_csharp/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the UDT is unaligned.|  
|[virtualTableShape](../VS_csharp/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The type of the virtual table.|  
|[virtualTableShapeId](../VS_csharp/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[volatileType](../VS_csharp/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the UDT is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)