---
title: "BaseType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - BaseType symbol [DIA SDK]
ms.assetid: 2f9e22e6-8360-496a-ac6b-17a5a56b0c46
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BaseType
Base types are identified by `SymTagBaseType` symbols.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_baseType](../vs140/idiasymbol--get_basetype.md)|`DWORD`|One of the values of the [BasicType Enumeration](../vs140/basictype.md).|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the base type is marked as const.|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|`LONGLONG`|Size, in bytes, of the base type.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../vs140/compiland.md).|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagBaseType` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the base type is unaligned.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the base type is marked as volatile.|  
  
## See Also  
 [BasicType Enumeration](../vs140/basictype.md)   
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)