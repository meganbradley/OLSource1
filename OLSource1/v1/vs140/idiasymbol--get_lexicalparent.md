---
title: "IDiaSymbol::get_lexicalParent"
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
  - "IDiaSymbol::get_lexicalParent method"
ms.assetid: 4d119965-33a8-474c-9c64-95c5218c389c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_lexicalParent
Retrieves a reference to the lexical parent of the symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the lexical parent of the symbol.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 The lexical parent of a symbol is the enclosing function or module. For example, the lexical parent of a function parameter or local variable is the function itself while the lexical parent of the function is the module it is defined in.  
  
 The possible symbols that can appear as lexical parents are documented in [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md).  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)