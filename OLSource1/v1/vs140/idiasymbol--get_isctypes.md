---
title: "IDiaSymbol::get_isCTypes"
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
  - "IDiaStackWalker2 interface"
ms.assetid: 00c73cf9-2933-472e-bc1d-d041f4d7e412
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isCTypes
Retrieves a flag indicating whether the symbol file contains C types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the symbol file contains C types; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means that the property is not available for the symbol.  
  
## Remarks  
 This property is available from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> symbol type (see [Exe](../vs140/exe.md)).  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [Exe](../vs140/exe.md)