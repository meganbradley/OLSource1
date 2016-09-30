---
title: "Thunk"
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
  - "thunk properties [DIA SDK]"
  - "thunk symbol"
ms.assetid: 01abb95f-d89a-465c-a4eb-8e8509598c95
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Thunk
Each <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is identified by a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[access](../vs140/idiasymbol--get_access.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Access modifier attribute, one of the [CV_access_e Enumeration](../vs140/cv_access_e.md) values (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSegment::get_addressSection](../vs140/idiasegment--get_addresssection.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[classParent](../vs140/idiasymbol--get_classparent.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Enclosing class parent, if any (only under DIA SDK V8.0 or later).|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|ID of the enclosing class parent symbol (only in DIA SDK V8.0 or later).|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|TRUE if the thunk is marked as constant (only in DIA SDK V8.0 or later).|  
|[intro](../vs140/idiasymbol--get_intro.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|TRUE if the thunk is an introduction to a virtual function (only in DIA SDK V8.0 or later)|  
|[isStatic](../vs140/idiasymbol--get_isstatic.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|TRUE if the thunk is considered static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Number of bytes of code in the thunk.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Symbol for the enclosing compiland, block, or function.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|End points have static location; for details, see [Symbol Locations](../vs140/symbol-locations.md) enumeration.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Name of the thunk.|  
|[pure](../vs140/idiasymbol--get_pure.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|TRUE if the thunk is purely virtual (only in DIA SDK V8.0 or later).|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Relative position of this thunk within its module.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_targetOffset Method](../vs140/idiasymbol--get_targetoffset.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Offset part of location of the thunk target.|  
|[IDiaSymbol::get_targetRelativeVirtualAddress Method](../vs140/idiasymbol--get_targetrelativevirtualaddress.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Relative virtual address of the thunk target in its enclosing block.|  
|[IDiaSymbol::get_targetSection Method](../vs140/idiasymbol--get_targetsection.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Section part of the thunk target.|  
|[IDiaSymbol::get_targetVirtualAddress Method](../vs140/idiasymbol--get_targetvirtualaddress.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Position of the thunk target in the executable image.|  
|[IDiaSymbol::get_thunkOrdinal](../vs140/idiasymbol--get_thunkordinal.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Thunk type, as defined by the [THUNK_ORDINAL Enumeration](../vs140/thunk_ordinal.md).|  
|[type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The type of this thunk (only in DIA SDK V8.0 or later).|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|ID of the type symbol (only in DIA SDK V8.0 or later).|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the thunk is not aligned (only in DIA SDK V8.0 or later),|  
|[virtual](../vs140/idiasymbol--get_virtual.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the thunk is virtual (only in DIA SDK V8.0 or later).|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Position of this thunk within the executable image.|  
|[virtualBaseOffset](../vs140/idiasymbol--get_virtualbaseoffset.md)|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The offset in the virtual table to this thunk (only in DIA SDK V8.0 or later).|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the thunk is marked as volatile (only in DIA SDK V8.0 or later).|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [THUNK_ORDINAL Enumeration](../vs140/thunk_ordinal.md)