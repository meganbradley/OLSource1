---
title: "ArrayType"
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
  - "ArrayType symbol"
ms.assetid: 1d973a3a-2bde-46df-8625-85d519bb3cc9
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ArrayType
An array is identified by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol.  
  
## Properties  
 The following table shows additional valid properties for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_arrayIndexType](../vs140/idiasymbol--get_arrayindextype.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Symbol for the array index type.|  
|[arrayIndexTypeId](../vs140/idiasymbol--get_arrayindextypeid.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|ID of the array index type symbol.|  
|[constType](../vs140/idiasymbol--get_consttype.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the array is marked as const.|  
|[count](../vs140/idiasymbol--get_count.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Number of items in the array.|  
|[IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Size, in bytes, of this array.|  
|[lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Symbol of the enclosing compiland.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_rank](../vs140/idiasymbol--get_rank.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Rank of a FORTRAN multidimensional array.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
|[IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Symbol for the array element type.|  
|[typeId](../vs140/idiasymbol--get_typeid.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|ID of the array element type symbol.|  
|[unalignedType](../vs140/idiasymbol--get_unalignedtype.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if the array is unaligned|  
|[volatileType](../vs140/idiasymbol--get_volatiletype.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the array is marked as volatile.|  
  
## See Also  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)   
 [Dimension](../vs140/dimension.md)