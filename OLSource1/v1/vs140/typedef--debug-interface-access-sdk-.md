---
title: "Typedef (Debug Interface Access SDK)"
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
  - "Typedef symbol [DIA SDK]"
ms.assetid: 9ab441b9-cc72-47fa-83e2-87b3c2b891b4
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Typedef (Debug Interface Access SDK)
Symbols with `SymTagTypedef` tags introduce names for other types.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[baseType](../vs140/idiasymbol--get_basetype.md)|`DWORD`|One of the [BasicType Enumeration](../vs140/basictype.md) values.|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Class parent of this typedef, if any.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constructor](../vs140/idiasymbol--get_constructor.md)|`BOOL`|`TRUE` if this typedef has a constructor.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if this typedef is marked as constant.|  
|[hasAssignmentOperator](../vs140/idiasymbol--get_hasassignmentoperator.md)|`BOOL`|`TRUE` if this typedef has an assignment operator.|  
|[hasCastOperator](../vs140/idiasymbol--get_hascastoperator.md)|`BOOL`|`TRUE` if this typedef has a cast operator.|  
|[hasNestedTypes](../vs140/idiasymbol--get_hasnestedtypes.md)|`BOOL`|`TRUE` if this typedef has nested types.|  
|[length](../vs140/idiasymbol--get_length.md)|`ULONGLONG`|Length of this typedef in bytes.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the typedef.|  
|[nested](../vs140/idiasymbol--get_nested.md)|`BOOL`|`TRUE` if this typedef is nested in a lexical scope.|  
|[overloadedOperator](../vs140/idiasymbol--get_overloadedoperator.md)|`BOOL`|`TRUE` if this typedef has an overloaded operator.|  
|[packed](../vs140/idiasymbol--get_packed.md)|`BOOL`|`TRUE` if this typedef is packed.|  
|[reference](../vs140/idiasymbol--get_reference.md)|`BOOL`|`TRUE` if this typedef is a reference.|  
|[scoped](../vs140/idiasymbol--get_scoped.md)|`BOOL`|`TRUE` if this typedef is in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagTypedef` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the underlying type.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[udtKind](../vs140/idiasymbol--get_udtkind.md)|`DWORD`|One of the [UdtKind Enumeration](../vs140/udtkind.md) values.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if this typedef is not aligned.|  
|[virtualTableShape](../vs140/idiasymbol--get_virtualtableshape.md)|`IDiaSymbol*`|The symbol that describes the virtual table shape.|  
|[virtualTableShapeId](../vs140/idiasymbol--get_virtualtableshapeid.md)|`DWORD`|ID of the virtual table shape symbol.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if this typedef is marked as volatile.|  
  
## Remarks  
 Since a typedef can represent a class, pointer, or user-defined type (UDT), the symbol for a typedef shares the same properties as one of those other types of symbols.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)