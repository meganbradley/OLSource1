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
Each base class for a user-defined type (UDT) symbol is identified by a child with a `SymTagBaseClass` tag. The [type](../vs140/idiasymbol--get_type.md) property contains the symbol for the underlying UDT, and all properties of the underlying UDT are available as part of this BaseClass symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[access](../vs140/idiasymbol--get_access.md)|`DWORD`|Access modifier applied to this base class. One of the [CV_access_e Enumeration](../vs140/cv_access_e.md) values.|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol of the enclosing class (if any).|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constructor](../vs140/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if the base class has a constructor.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the base class is marked as const.|  
|[hasAssignmentOperator](../vs140/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if the base class has an assignment operator.|  
|[hasCastOperator](../vs140/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if the base class has a cast operator.|  
|[hasNestedTypes](../vs140/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if the base class has nested types.|  
|[IDiaSymbol::get_indirectVirtualBaseClass](../vs140/idiasymbol--get_indirectvirtualbaseclass.md)|`BOOL`|`TRUE` if the base class is indirect.|  
|[length](../vs140/idiasymbol--get_length.md)|`DWORD`|Length of this base class in bytes.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the base class.|  
|[nested](../vs140/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if the base class is nested.|  
|[IDiaSymbol::get_offset](../vs140/idiasymbol--get_offset.md)|`LONG`|Offset of subobject that represents the base class within the structure.|  
|[overloadedOperator](../vs140/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if the base class has any overloaded operators.|  
|[packed](../vs140/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if the base class is packed.|  
|[scoped](../vs140/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if the base class appears in a nonglobal scope.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagBaseClass` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|The symbol for the base class [UDT](../vs140/udt.md).|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[udtKind](../vs140/idiasymbol--get_udtkind.md)|`DWORD`|A value from the [UdtKind Enumeration](../vs140/udtkind.md).|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the base class is unaligned.|  
|[IDiaSymbol::get_virtualBaseClass](../vs140/idiasymbol--get_virtualbaseclass.md)|`BOOL`|`TRUE` if the base class is virtual.|  
|[IDiaSymbol::get_virtualBaseDispIndex](../vs140/idiasymbol--get_virtualbasedispindex.md)|`DWORD`|Index into the virtual base displacement table.|  
|[IDiaSymbol::get_virtualBasePointerOffset](../vs140/idiasymbol--get_virtualbasepointeroffset.md)|`LONG`|Offset of the virtual base pointer.|  
|[virtualBaseTableType](../vs140/idiasymbol--get_virtualbasetabletype.md)|`IDiaSymbol*`|The type of the virtual base table pointer.|  
|[virtualTableShape](../vs140/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The symbol describing the type of the virtual table for this base class.|  
|[virtualTableShapeId](../vs140/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the base class is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)   
 [UDT](../vs140/udt.md)