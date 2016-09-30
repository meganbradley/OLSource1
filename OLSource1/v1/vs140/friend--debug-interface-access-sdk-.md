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
Friend classes and friend functions are identified by <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbols. They are children of parent user-defined types (UDTs) and have a [classParent](../vs140/idiasymbol--get_classparent.md) property.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Symbol for the UDT parent.|  
|[classParentId](../vs140/idiasymbol--get_classparentid.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|ID of the class parent symbol.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Name of the class or function.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Symbol for the class or function.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|ID of the type symbol.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)