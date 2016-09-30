---
title: "IDiaSymbol::get_oemId"
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
  - "IDiaSymbol::get_oemId method"
ms.assetid: c472830f-c3eb-46ab-9498-cd637763d241
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_oemId
Retrieves the symbol's original equipment manufacturer (OEM) ID value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns a unique value that identifies an OEM.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> means that the property is not available for the symbol.  
  
## Remarks  
 This property applies only to symbols with a [SymTagEnum](../vs140/symtagenum.md) type of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum](../vs140/symtagenum.md)