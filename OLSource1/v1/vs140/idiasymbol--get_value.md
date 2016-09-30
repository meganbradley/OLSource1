---
title: "IDiaSymbol::get_value"
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
  - "IDiaSymbol::get_value method"
ms.assetid: 2e40174a-2a61-4e5f-bb32-9e0ceec2178a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_value
Retrieves the value of a constant.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in, out] A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that is filled in with the value of a constant.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
 The supplied VARIANT must be initialized before it is passed to this method. For more information, see the example.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)