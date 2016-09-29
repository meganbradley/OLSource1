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
|[IDiaSymbol::get_addressOffset](../VS_csharp/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_csharp/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../VS_csharp/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_csharp/locationtype.md).|  
|[customCallingConvention](../VS_csharp/idiasymbol--get_customcallingconvention.md)|`BOOL`|`TRUE` if the label uses a custom calling convention.|  
|[farReturn](../VS_csharp/idiasymbol--get_farreturn.md)|`BOOL`|`TRUE` if label performs a far return.|  
|[interruptReturn](../VS_csharp/idiasymbol--get_interruptreturn.md)|`BOOL`|`TRUE` if label contains a return from interrupt.|  
|[IDiaSymbol::get_lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the enclosing compiland, block, or function.|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_csharp/idiasymbol--get_locationtype.md)|`DWORD`|Labels have static locations; for details, see the [Symbol Locations](../VS_csharp/symbol-locations.md) enumeration.|  
|[name](../VS_csharp/idiasymbol--get_name.md)|`BSTR`|The label's name.|  
|[noInline](../VS_csharp/idiasymbol--get_noinline.md)|`BOOL`|`TRUE` if the label was specified with the [noinline](../VS_csharp/noinline.md) attribute.|  
|[noReturn](../VS_csharp/idiasymbol--get_noreturn.md)|`BOOL`|`TRUE` if the label was specified with the [noreturn](../VS_csharp/noreturn.md) attribute.|  
|[notReached](../VS_csharp/idiasymbol--get_notreached.md)|`BOOL`|`TRUE` if the label is never called.|  
|[offset](../VS_csharp/idiasymbol--get_offset.md)|`LONG`|Offset of symbol in memory; for details, see the [LocationType Enumeration](../VS_csharp/locationtype.md), `LocIsRegRel`.|  
|[optimizedCodeDebugInfo](../VS_csharp/idiasymbol--get_optimizedcodedebuginfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code.|  
|[relativeVirtualAddress](../VS_csharp/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Relative position of this label within its module.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFuncDebugLabel` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[virtualAddress](../VS_csharp/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Position of this label within the executable image.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_csharp/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../VS_csharp/locationtype.md)   
 [Symbol Locations](../VS_csharp/symbol-locations.md)