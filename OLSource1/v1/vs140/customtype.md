---
title: "CustomType"
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
  - "CustomType symbol"
ms.assetid: 1b66bc0a-7979-416f-bf7f-e5df91584c91
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CustomType
Vendor-defined types (compiler-specific types) are identified by a `SymTagCustomType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_oemId](../vs140/idiasymbol--get_oemid.md)|`DWORD`|Identifier of OEM.|  
|[IDiaSymbol::get_oemSymbolId](../vs140/idiasymbol--get_oemsymbolid.md)|`DWORD`|OEM's internal ID.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagCustomType` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|The first type referenced by the custom type symbol.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_types](../vs140/idiasymbol--get_types.md)|`IDiaSymbol**`|Array of all types referenced by the custom type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)