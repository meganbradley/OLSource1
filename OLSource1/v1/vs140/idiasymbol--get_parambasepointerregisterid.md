---
title: "IDiaSymbol::get_paramBasePointerRegisterId"
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
  - "IDiaSymbol::get_paramBasePointerRegisterId method"
ms.assetid: 9f5caeb4-5c88-4054-bf8b-50d34bbbf8c5
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_paramBasePointerRegisterId
Retrieves the ID of the register that holds a base pointer to the parameters. Use when the [SymTagEnum](../vs140/symtagenum.md) is set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the ID of the register that holds a base pointer to the parameters.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)