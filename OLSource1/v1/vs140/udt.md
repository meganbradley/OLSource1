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
Each class, structure, and union is identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol. Each member, function, data, or nested type, and each base class, appears as a class child of the user-defined type (UDT).  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Symbol for the class parent, if any.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|ID of the class parent symbol.|  
|[IDiaSymbol::get_constructor](../vs140/idiasymbol--get_constructor.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the UDT has a constructor.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the UDT is marked as constant.|  
|[IDiaSymbol::get_hasAssignmentOperator](../vs140/idiasymbol--get_hasassignmentoperator.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the UDT has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../vs140/idiasymbol--get_hascastoperator.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the UDT has any cast operators defined.|  
|[IDiaSymbol::get_hasNestedTypes](../vs140/idiasymbol--get_hasnestedtypes.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the UDT has nested type definitions.|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The size, in bytes, of the UDT.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Symbol of the enclosing [Compiland](../vs140/compiland.md).|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The name of the UDT.|  
|[IDiaSymbol::get_nested](../vs140/idiasymbol--get_nested.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the UDT is nested.|  
|[IDiaSymbol::get_overloadedOperator](../vs140/idiasymbol--get_overloadedoperator.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if overloaded operators are defined for the UDT.|  
|[IDiaSymbol::get_packed](../vs140/idiasymbol--get_packed.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if the UDT is packed.|  
|[IDiaSymbol::get_scoped](../vs140/idiasymbol--get_scoped.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the UDT appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_udtKind](../vs140/idiasymbol--get_udtkind.md)|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Indicates whether this is a structure, class, or union; for details, see [UdtKind Enumeration](../vs140/udtkind.md).|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the UDT is unaligned.|  
|[virtualTableShape](../vs140/idiasymbol--get_virtualtableshape.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|The type of the virtual table.|  
|[virtualTableShapeId](../vs140/idiasymbol--get_virtualtableshapeid.md)|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|ID of the virtual table shape symbol.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the UDT is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)