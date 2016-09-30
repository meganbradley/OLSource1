---
title: "IDiaSymbol::get_timeStamp"
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
  - "IDiaSymbol::get_timeStamp method"
ms.assetid: 5d707b76-dbaa-4d88-86c3-6f3672cc6d4c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_timeStamp
Retrieves the timestamp of the underlying executable file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns the timestamp of the underlying executable file.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)