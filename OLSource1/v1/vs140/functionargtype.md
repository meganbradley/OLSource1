---
title: "FunctionArgType"
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
  - "FunctionArgType symbol"
ms.assetid: 9f072fd3-0b99-405c-af99-fd44cd56fd73
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FunctionArgType
Each parameter of a function is identified by a `SymTagFunctionArgType` symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Symbol for the FunctionType parent.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing [Compiland](../vs140/compiland.md).|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFunctionArgType` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|Type of the parameter.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)   
 [FunctionType](../vs140/functiontype.md)