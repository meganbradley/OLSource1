---
title: "IDiaSymbol::get_hasSetJump"
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
  - "IDiaSymbol::get_hasSetJump method"
ms.assetid: 22656206-dccf-40ed-b179-fc016d1b262a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_hasSetJump
Retrieves a flag that specifies whether the function contains a use of the [setjmp](../vs140/setjmp.md) command (paired with the [longjmp](../vs140/longjmp.md) command, these form the C-style method of exception handling).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the function contains a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> command; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_hasLongJump](../vs140/idiasymbol--get_haslongjump.md)   
 [longjmp](../vs140/longjmp.md)   
 [setjmp](../vs140/setjmp.md)