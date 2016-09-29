---
title: "ManagedType"
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
  - "SymTagManagedType symbol"
  - "managed type symbol"
  - "ManagedType symbol"
ms.assetid: 5db99e2a-4f2e-4796-89b7-b401b151826f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ManagedType
A managed type (any symbol defined by metadata, or native to the memory and resource management functionality of languages such as C#) is identified by a `SymTagManagedType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|`BSTR`|Name of the managed symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagManagedType` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)