---
title: "IDiaSession::findSymbolsByRVAForAcceleratorPointerTag"
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
ms.assetid: a073cc45-0c7b-417e-b5fc-a3b08beccdbc
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolsByRVAForAcceleratorPointerTag
Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that corresponds to the Accelerator stub function to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The pointer tag value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The relative virtual address.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] A pointer to an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Call this method only on an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface that corresponds to an Accelerator stub function.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)