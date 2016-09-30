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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Typedef (Debug Interface Access SDK)
Symbols with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tags introduce names for other types.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[baseType](../vs140/idiasymbol--get_basetype.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|One of the [BasicType Enumeration](../vs140/basictype.md) values.|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Class parent of this typedef, if any.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|ID of the class parent symbol.|  
|[constructor](../vs140/idiasymbol--get_constructor.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this typedef has a constructor.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if this typedef is marked as constant.|  
|[hasAssignmentOperator](../vs140/idiasymbol--get_hasassignmentoperator.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if this typedef has an assignment operator.|  
|[hasCastOperator](../vs140/idiasymbol--get_hascastoperator.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if this typedef has a cast operator.|  
|[hasNestedTypes](../vs140/idiasymbol--get_hasnestedtypes.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if this typedef has nested types.|  
|[length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Length of this typedef in bytes.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Name of the typedef.|  
|[nested](../vs140/idiasymbol--get_nested.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if this typedef is nested in a lexical scope.|  
|[overloadedOperator](../vs140/idiasymbol--get_overloadedoperator.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if this typedef has an overloaded operator.|  
|[packed](../vs140/idiasymbol--get_packed.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if this typedef is packed.|  
|[reference](../vs140/idiasymbol--get_reference.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if this typedef is a reference.|  
|[scoped](../vs140/idiasymbol--get_scoped.md)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if this typedef is in a nonglobal lexical scope.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Symbol for the underlying type.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|ID of the type symbol.|  
|[udtKind](../vs140/idiasymbol--get_udtkind.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|One of the [UdtKind Enumeration](../vs140/udtkind.md) values.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if this typedef is not aligned.|  
|[virtualTableShape](../vs140/idiasymbol--get_virtualtableshape.md)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The symbol that describes the virtual table shape.|  
|[virtualTableShapeId](../vs140/idiasymbol--get_virtualtableshapeid.md)|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|ID of the virtual table shape symbol.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if this typedef is marked as volatile.|  
  
## Remarks  
 Since a typedef can represent a class, pointer, or user-defined type (UDT), the symbol for a typedef shares the same properties as one of those other types of symbols.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)