---
title: "PointerType"
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
  - "PointerType symbol"
ms.assetid: 67228681-7345-4537-8af3-93806803ee96
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PointerType
Each pointer is identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the pointer is marked as a constant.|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Size, in bytes, of the pointer.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Symbol of the enclosing [Compiland](../vs140/compiland.md).|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_reference](../vs140/idiasymbol--get_reference.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if pointer is a reference type.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Target symbol of the pointer.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|ID of the type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the pointer is unaligned.|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if the pointer is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)