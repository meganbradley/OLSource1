---
title: "IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag"
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
ms.assetid: 024ccd78-5867-4ca7-bc26-548758e9ac53
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag
Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The pointer tag value for which the pointee symbol records are found.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The rva that is used to filter the symbols that correspond to the pointee variable with the specified tag value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface pointer which is initialized with the result.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or an error code.  
  
## Remarks  
 Call this method only on an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface that corresponds to an Accelerator stub function.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)