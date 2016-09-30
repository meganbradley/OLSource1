---
title: "IDiaSymbol::get_numberOfAcceleratorPointerTags"
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
ms.assetid: 1886e3ec-b227-4187-8d93-c5144b4b77ae
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_numberOfAcceleratorPointerTags
Returns the number of accelerator pointer tags in a C++ AMP stub function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that holds the number of accelerator pointer tags in a C++ AMP stub function.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or an error code.  
  
## Remarks  
 This method is called on an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface that corresponds to a C++ AMP accelerator stub function.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)