---
title: "Label (Debug Interface Access SDK)"
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
  - "locations, in program code"
  - "Label symbol"
ms.assetid: 8cef7620-5bc8-4500-8bd0-e9e638bccb24
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Label (Debug Interface Access SDK)
A location in program code is identified by a `SymTagLabel` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../vs140/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../vs140/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../vs140/locationtype.md).|  
|[customCallingConvention](../vs140/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the label uses a custom calling convention.|  
|[farReturn](../vs140/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if label performs a far return.|  
|[interruptReturn](../vs140/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if label contains a return from interrupt.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)|`DWORD`|Labels have static locations; for details, see the [Symbol Locations](../vs140/symbol-locations.md) enumeration.|  
|[name](../vs140/idiasymbol--get_name.md)|`BSTR`|The label's name.|  
|[noInline](../vs140/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the label was specified with the [noinline](../vs140/noinline.md) attribute.|  
|[noReturn](../vs140/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the label was specified with the [noreturn](../vs140/noreturn.md) attribute.|  
|[notReached](../vs140/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the label is never called.|  
|[offset](../vs140/idiasymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../vs140/locationtype.md), `LocIsRegRel`.|  
|[optimizedCodeDebugInfo](../vs140/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code.|  
|[relativeVirtualAddress](../vs140/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of this label within its module.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFuncDebugLabel` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[virtualAddress](../vs140/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this label within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../vs140/locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)