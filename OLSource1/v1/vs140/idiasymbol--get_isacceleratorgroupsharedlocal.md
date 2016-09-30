---
title: "IDiaSymbol::get_isAcceleratorGroupSharedLocal"
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
ms.assetid: 17a20542-5b45-478f-bb80-0d56031aadb5
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_isAcceleratorGroupSharedLocal
Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods can be used to get the storage location information for the variable.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_baseDataSlot](../vs140/idiasymbol--get_basedataslot.md)   
 [IDiaSymbol::get_baseDataOffset](../vs140/idiasymbol--get_basedataoffset.md)