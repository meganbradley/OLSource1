---
title: "Block"
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
  - "SymTagBlock symbol"
  - "nested scopes"
  - "Block symbol"
ms.assetid: 95b7b0c1-ecc9-405f-8456-5f9cfb866498
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Block
Each code block is identified by a `SymTagBlock` symbol. Block symbols are used to identify nested scopes within functions.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_addressOffset](../VS_csharp/idiasymbol--get_addressoffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_csharp/locationtype.md).|  
|[IDiaSymbol::get_addressSection](../VS_csharp/idiasymbol--get_addresssection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_csharp/locationtype.md).|  
|[IDiaSymbol::get_length](../VS_csharp/idiasymbol--get_length.md)|`ULONGLONG`|Number of bytes of code in the block.|  
|[IDiaSymbol::get_lexicalParent](../VS_csharp/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing block or function.|  
|[lexicalParentId](../VS_csharp/idiasymbol--get_lexicalparentid.md)|`DWORD`|Returns the ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_csharp/idiasymbol--get_locationtype.md)|`DWORD`|Blocks have static locations; for details, see [Symbol Locations](../VS_csharp/symbol-locations.md).|  
|[name](../VS_csharp/idiasymbol--get_name.md)|`BSTR`|Returns the name of the block (which is usually an empty string).|  
|[relativeVirtualAddress](../VS_csharp/idiasymbol--get_relativevirtualaddress.md)|`DWORD`|Returns the virtual address of this block relative to its lexical parent.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagBlock` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[virtualAddress](../VS_csharp/idiasymbol--get_virtualaddress.md)|`ULONGLONG`|Returns the virtual address of this block within the executable.|  
  
## See Also  
 [Lexical Hierarchy of Symbol Types](../VS_csharp/lexical-hierarchy-of-symbol-types.md)   
 [LocationType Enumeration](../VS_csharp/locationtype.md)   
 [Symbol Locations](../VS_csharp/symbol-locations.md)