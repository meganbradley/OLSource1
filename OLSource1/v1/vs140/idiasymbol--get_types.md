---
title: "IDiaSymbol::get_types"
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
  - "IDiaSymbol::get_types method"
ms.assetid: 5f056e0c-e15b-4e00-8f78-aadc8574f7ea
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_types
Retrieves an array of compiler-specific types for this symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Size of the buffer to hold the data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the number of types written, or, if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then the total number of types available.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] An array that is to be filled in with the [IDiaSymbol](../vs140/idiasymbol.md) objects that represent all the types for this symbol.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)