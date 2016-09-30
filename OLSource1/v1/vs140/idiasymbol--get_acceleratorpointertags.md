---
title: "IDiaSymbol::get_acceleratorPointerTags"
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
ms.assetid: 30e13cee-e511-49ec-affd-99b0097071b2
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_acceleratorPointerTags
Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The size of the output array <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The count of accelerator pointer tags in the C++ AMP accelerator stub function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array pointer that is filled with the accelerator pointer tag values in the C++ AMP accelerator stub function.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an error code.  
  
## Remarks  
 This method is called on an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface that corresponds to a C++ AMP accelerator stub function.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)