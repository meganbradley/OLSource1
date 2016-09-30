---
title: "IDiaSymbol::get_symTag"
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
  - "IDiaSymbol::get_symTag method"
ms.assetid: 139a35bd-faeb-4878-be72-394dedfbb18f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_symTag
Retrieves the symbol type classifier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns A value from the [SymTagEnum](../vs140/symtagenum.md) enumeration that specifies the symbol type classifier.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)