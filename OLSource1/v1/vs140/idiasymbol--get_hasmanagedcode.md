---
title: "IDiaSymbol::get_hasManagedCode"
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
  - "IDiaSymbol::get_hasManagedCode method"
ms.assetid: e40f82f5-88fe-4a9b-b594-3605f42773ec
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_hasManagedCode
Retrieves a flag indicating whether the module contains managed code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the module contains managed code; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the code is unmanaged code.  
  
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