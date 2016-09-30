---
title: "Enum (Debug Interface Access SDK)"
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
  - "enumerated types as symbols"
  - "Enum symbol"
ms.assetid: c777e2e6-88be-435b-b632-8d43f42b0b49
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enum (Debug Interface Access SDK)
Enumerations are identified by `SymTagEnum` symbols. Each enumeration value appears as a class child with a `SymTagConstant` tag.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[baseType](../vs140/idiasymbol--get_basetype.md)|`DWORD`|One of the [BasicType Enumeration](../vs140/basictype.md) values.|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Class parent of this enumeration, if any.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constructor](../vs140/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if the enumeration has a constructor.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the enumeration is marked as const.|  
|[hasAssignmentOperator](../vs140/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if the enumeration has an assignment operator.|  
|[hasCastOperator](../vs140/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if the enumeration has a cast operator.|  
|[hasNestedTypes](../vs140/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if the enumeration has nested types.|  
|[length](../vs140/idiasymbol--get_length.md)|`DWORD`|Length of this enumeration in bytes.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../vs140/compiland.md).|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the enumerated type.|  
|[IDiaSymbol::get_nested](../vs140/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if the enumeration is nested.|  
|[overloadedOperator](../vs140/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if the enumeration has any overloaded operators.|  
|[packed](../vs140/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if the enumeration is packed.|  
|[IDiaSymbol::get_scoped](../vs140/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if the enumeration appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagEnum` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the underlying type.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the enumeration is unaligned.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the enumeration is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)