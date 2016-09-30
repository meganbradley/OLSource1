---
title: "IDiaSymbol::get_framePointerPresent"
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
  - "IDiaSymbol::get_framePointerPresent method"
ms.assetid: d036090a-1651-454d-9130-b798f58ba053
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_framePointerPresent
Retrieves a flag that specifies whether the frame pointer is present. Use when the [SymTagEnum](../vs140/symtagenum.md) is set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] ] Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the frame pointer is present; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)