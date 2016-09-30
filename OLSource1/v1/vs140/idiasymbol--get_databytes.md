---
title: "IDiaSymbol::get_dataBytes"
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
  - "IDiaSymbol::get_dataBytes method"
ms.assetid: 5eb37179-20d8-44ae-a72a-405c1b0435c4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_dataBytes
Retrieves the data bytes of an OEM symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Size of the buffer to hold the data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes written, or, if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, returns the number of bytes available.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out,] A buffer that is filled in with the data bytes.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> means that the property is not available for the symbol.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)