---
title: "IDiaSymbol::get_type"
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
  - "IDiaSymbol::get_type method"
ms.assetid: 1c6a4176-dd4e-4c22-8b8f-0e559fc078ba
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_type
Retrieves the symbol that represents the type for this symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the type of this symbol.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 To determine the type a symbol has, you must call this method and examine the resulting [IDiaSymbol](../vs140/idiasymbol.md) object. Note that it is possible for a symbol to not have a type. For example, the name of a structure has no type but it might have children symbols (use the [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md) method to examine those children).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_baseType](../vs140/idiasymbol--get_basetype.md)   
 [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)