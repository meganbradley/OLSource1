---
title: "FuncDebugEnd"
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
  - "FuncDebugEnd symbol"
  - "debugging [DIA SDK], end point"
ms.assetid: 68f84fff-7cd3-4636-b929-7063a45009f8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FuncDebugEnd
If a function has a defined point at which debugging is to end, the debug starting point is identified by a symbol with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[customCallingConvention](../vs140/idiasymbol--get_customcallingconvention.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[farReturn](../vs140/idiasymbol--get_farreturn.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if function performs a far return (only in DIA SDK V8.0 or later).|  
|[interruptReturn](../vs140/idiasymbol--get_interruptreturn.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if function contains a return from interrupt (only in DIA SDK V8.0 or later).|  
|[isStatic](../vs140/idiasymbol--get_isstatic.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Symbol for the enclosing function.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|End points have static location; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[noInline](../vs140/idiasymbol--get_noinline.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the function was specified with the [noinline](../vs140/noinline.md) attribute (only in DIA SDK V8.0 or later).|  
|[noReturn](../vs140/idiasymbol--get_noreturn.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if the function was specified with the [noreturn](../vs140/noreturn.md) attribute (only in DIA SDK V8.0 or later).|  
|[notReached](../vs140/idiasymbol--get_notreached.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if the function is never called (only in DIA SDK V8.0 or later).|  
|[offset](../vs140/idiasymbol--get_offset.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Offset of symbol in memory; for details, see the [LocationType Enumeration](../vs140/locationtype.md), <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[optimizedCodeDebugInfo](../vs140/idiasymbol--get_optimizedcodedebuginfo.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if the function has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Relative position of the end of this function within its module.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Position of this function within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)