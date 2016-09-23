---
title: "FuncDebugEnd"
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
  - FuncDebugEnd symbol
  - debugging [DIA SDK], end point
ms.assetid: 68f84fff-7cd3-4636-b929-7063a45009f8
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FuncDebugEnd
If a function has a defined point at which debugging is to end, the debug starting point is identified by a symbol with a `SymTagFuncDebugEnd` tag.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[customCallingConvention](../vs140/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[farReturn](../vs140/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if function performs a far return (only in DIA SDK V8.0 or later).|  
|[interruptReturn](../vs140/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if function contains a return from interrupt (only in DIA SDK V8.0 or later).|  
|[isStatic](../vs140/idiasymbol--get_isstatic.md)|`BOOL`|`TRUE` if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing function.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|`DWORD`|End points have static location; for details, see [Symbol Locations](../vs140/symbol-locations.md).|  
|[noInline](../vs140/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the function was specified with the [noinline](../vs140/noinline.md) attribute (only in DIA SDK V8.0 or later).|  
|[noReturn](../vs140/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the function was specified with the [noreturn](../vs140/noreturn.md) attribute (only in DIA SDK V8.0 or later).|  
|[notReached](../vs140/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the function is never called (only in DIA SDK V8.0 or later).|  
|[offset](../vs140/idiasymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../vs140/locationtype.md), `LocIsRegRel`.|  
|[optimizedCodeDebugInfo](../vs140/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the function has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of the end of this function within its module.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFuncDebugEnd` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this function within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)