---
title: "IDiaSymbol::get_isMSILNetmodule"
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
  - "IDiaSymbol::get_isMSILNetmodule method"
ms.assetid: 593827f3-8437-4a12-ada4-ff715ec95fb2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isMSILNetmodule
Retrieves a flag indicating whether the module is a .netmodule (a Microsoft Intermediate Language (MSIL) module that contains only metadata and no native symbols).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the module is MSIL; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means that the property is not available for the symbol.  
  
## Remarks  
 This property is available from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> symbol type (see [CompilandDetails](../vs140/compilanddetails.md)).  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [CompilandDetails](../vs140/compilanddetails.md)