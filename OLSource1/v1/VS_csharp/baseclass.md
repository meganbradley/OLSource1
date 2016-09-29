---
title: "BaseClass"
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
  - "user-defined types, base classes"
  - "BaseClass symbol"
  - "base classes, user-defined types"
ms.assetid: 9375ca35-cb91-45f5-8903-7344ee4528e8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BaseClass
Each base class for a user-defined type (UDT) symbol is identified by a child with a `SymTagBaseClass` tag. The [type](../VS_csharp/idiasymbol--get_type.md) property contains the symbol for the underlying UDT, and all properties of the underlying UDT are available as part of this BaseClass symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[access](../VS_csharp/idiasymbol--get_access.md)|`DWORD`|Access modifier applied to this base class. One of the [CV_access_e Enumeration](../VS_csharp/cv_access_e.md) values.|  
|[classParent](../VS_csharp/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol of the enclosing class (if any).|  
|[classParentId](../VS_csharp/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constructor](../VS_csharp/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if the base class has a constructor.|  
|[constType](../VS_csharp/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the base class is marked as const.|  
|[hasAssignmentOperator](../VS_csharp/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if the base class has an assignment operator.|  
|[hasCastOperator](../VS_csharp/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if the base class has a cast operator.|  
|[hasNestedTypes](../VS_csharp/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if the base class has nested types.|  
|[IDiaSymbol::get_indirectVirtualBaseClass](../VS_csharp/idiasymbol--get_indirectvirtualbaseclass.md)|`BOOL`|`TRUE` if the base class is indirect.|  
|[length](../VS_csharp/idiasymbol--get_length.md)|`DWORD`|Length of this base class in bytes.|  
|[lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[name](../VS_csharp/idiasymbol--get_name.md)|`BSTR`|Name of the base class.|  
|[nested](../VS_csharp/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if the base class is nested.|  
|[IDiaSymbol::get_offset](../VS_csharp/idiasymbol--get_offset.md)|`LONG`|Offset of subobject that represents the base class within the structure.|  
|[overloadedOperator](../VS_csharp/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if the base class has any overloaded operators.|  
|[packed](../VS_csharp/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if the base class is packed.|  
|[scoped](../VS_csharp/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if the base class appears in a nonglobal scope.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagBaseClass` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../VS_csharp/idiasymbol--get_type.md)|`IDiaSymbol*`|The symbol for the base class [UDT](../VS_csharp/udt.md).|  
|[typeId](../VS_csharp/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[udtKind](../VS_csharp/idiasymbol--get_udtkind.md)|`DWORD`|A value from the [UdtKind Enumeration](../VS_csharp/udtkind.md).|  
|[unalignedType](../VS_csharp/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the base class is unaligned.|  
|[IDiaSymbol::get_virtualBaseClass](../VS_csharp/idiasymbol--get_virtualbaseclass.md)|`BOOL`|`TRUE` if the base class is virtual.|  
|[IDiaSymbol::get_virtualBaseDispIndex](../VS_csharp/idiasymbol--get_virtualbasedispindex.md)|`DWORD`|Index into the virtual base displacement table.|  
|[IDiaSymbol::get_virtualBasePointerOffset](../VS_csharp/idiasymbol--get_virtualbasepointeroffset.md)|`LONG`|Offset of the virtual base pointer.|  
|[virtualBaseTableType](../VS_csharp/idiasymbol--get_virtualbasetabletype.md)|`IDiaSymbol*`|The type of the virtual base table pointer.|  
|[virtualTableShape](../VS_csharp/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The symbol describing the type of the virtual table for this base class.|  
|[virtualTableShapeId](../VS_csharp/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[volatileType](../VS_csharp/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the base class is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)   
 [UDT](../VS_csharp/udt.md)