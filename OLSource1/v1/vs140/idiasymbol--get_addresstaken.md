---
title: "IDiaSymbol::get_addressTaken"
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
  - "IDiaSymbol::get_addressTaken method"
ms.assetid: 0d366188-f5e1-4226-b392-58c09539d097
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_addressTaken
Retrieves a flag that indicates whether another symbol references this symbol's address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if another symbol references this address; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> means that the property is not available for the symbol.  
  
## Example  
 In the following example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> references <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Therefore, symbol <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)