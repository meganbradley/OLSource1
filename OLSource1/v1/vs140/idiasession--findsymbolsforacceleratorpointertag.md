---
title: "IDiaSession::findSymbolsForAcceleratorPointerTag"
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
ms.assetid: 95fd5e7a-c637-437e-b369-c864eef733c2
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolsForAcceleratorPointerTag
Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An IDiaSymbol that corresponds to the Accelerator stub function to be searched.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The pointer tag value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)