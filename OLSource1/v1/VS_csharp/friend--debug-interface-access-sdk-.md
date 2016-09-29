---
title: "Friend (Debug Interface Access SDK)"
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
  - "friend functions [DIA SDK]"
  - "friend classes [DIA SDK]"
  - "Friend symbol"
ms.assetid: 5147a170-41ce-4727-8ace-c318e8d11647
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Friend (Debug Interface Access SDK)
Friend classes and friend functions are identified by `SymTagFriend` symbols. They are children of parent user-defined types (UDTs) and have a [classParent](../VS_csharp/idiasymbol--get_classparent.md) property.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../VS_csharp/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the UDT parent.|  
|[classParentId](../VS_csharp/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_name](../VS_csharp/idiasymbol--get_name.md)|`BSTR`|Name of the class or function.|  
|[IDiaSymbol::get_symIndexId Method](../VS_csharp/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../VS_csharp/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFriend` (one of the [SymTagEnum Enumeration](../VS_csharp/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../VS_csharp/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the class or function.|  
|[typeId](../VS_csharp/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_csharp/class-hierarchy-of-symbol-types.md)