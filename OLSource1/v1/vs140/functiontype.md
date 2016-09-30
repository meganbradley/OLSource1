---
title: "FunctionType"
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
  - "function signature"
  - "FunctionType symbol"
ms.assetid: 646a07e7-9d4f-4e21-95e3-3e403cdd4843
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FunctionType
Each unique function signature is identified by a `SymTagFunctionType` symbol. Each parameter is identified as a class child symbol with a `SymTagFunctionArgType` tag.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_callingConvention](../vs140/idiasymbol--get_callingconvention.md)|`DWORD`|One of the values of the [CV_call_e Enumeration](../vs140/cv_call_e.md).|  
|[IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md)|`IDiaSymbol*`|Class that this function (or method) is a member of.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|`DWORD`|ID of the class parent symbol.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|`BOOL`|`TRUE` if the function is marked as constant.|  
|[IDiaSymbol::get_count](../vs140/idiasymbol--get_count.md)|`DWORD`|Number of function parameters.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_objectPointerType](../vs140/idiasymbol--get_objectpointertype.md)|`IDiaSymbol*`|Type of the method's object pointer ("this").|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagFunctionType` (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_thisAdjust](../vs140/idiasymbol--get_thisadjust.md)|`LONG`|Logical "this" adjustor for the method.|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|`IDiaSymbol*`|Symbol for the return value type.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|`DWORD`|ID of the type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|`BOOL`|`TRUE` if the function is unaligned.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|`BOOL`|`TRUE` if the function is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)   
 [CV_access_e Enumeration](../vs140/cv_access_e.md)   
 [FunctionArgType](../vs140/functionargtype.md)