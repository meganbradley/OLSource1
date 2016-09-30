---
title: "Symbols and Symbol Tags"
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
  - "symbols [DIA SDK]"
ms.assetid: 2ee3a262-cda6-48bf-b799-a37edde6c8b8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Symbols and Symbol Tags
Debug information about a compiled program is stored in the program database (.pdb) file as symbols that are accessible using the Debug Interface Access (DIA) SDK APIs. All symbols have a [IDiaSymbol::get_symTag](../vs140/idiasymbol--get_symtag.md) and a [IDiaSymbol::get_symIndexId](../vs140/idiasymbol--get_symindexid.md) property. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property indicates the kind of symbol as defined by the [SymTagEnum Enumeration](../vs140/symtagenum.md) enumeration. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value that contains the unique identifier for every instance of a symbol.  
  
 Symbols also have properties that can specify additional information about the symbol as well as references to other symbols, most often a [IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md) or [IDiaSymbol::get_classParent](../vs140/idiasymbol--get_classparent.md). When you query a property that contains a reference, the reference is returned as an [IDiaSymbol](../vs140/idiasymbol.md) object. Such properties are always paired with another property by the same name but suffixed with "Id", for example, [IDiaSymbol::get_lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md) and [IDiaSymbol::get_classParentId](../vs140/idiasymbol--get_classparentid.md). The tables in [Symbol Locations](../vs140/symbol-locations.md), [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md), and [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md) outline the properties for each of the different kinds of symbols. These properties may have relevant information about or references to other symbols. Because the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> properties are simply numeric ordinal identifiers of their related properties, they are omitted from further discussions. They are referred to only where needed for parameter clarification.  
  
 When trying to access the property, if no error occurs and the symbol property has been assigned a value, the property's "get" method returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> indicates that the property is not valid for the current symbol.  
  
## In This Section  
 [Symbol Locations](../vs140/symbol-locations.md)  
 Describes the different kinds of locations a symbol can have.  
  
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)  
 Describes the symbol types that form lexical hierarchies such as files, modules, and functions.  
  
 [Class Hierarchy of Symbol Types](../vs140/class-hierarchy-of-symbol-types.md)  
 Describes the symbol types that correspond to different language elements such as classes, arrays, and function return types.  
  
## See Also  
 [Debug Interface Access SDK](../vs140/debug-interface-access-sdk.md)