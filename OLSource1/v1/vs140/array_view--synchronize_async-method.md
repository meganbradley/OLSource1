---
title: "array_view::synchronize_async Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::array_view::synchronize_async"
dev_langs: 
  - "C++"
ms.assetid: c9a41b8e-9e71-44e8-b785-e1b7c46279ff
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::synchronize_async Method
Asynchronously synchronizes any modifications made to the [array_view](../vs140/array_view-class.md) object back to its source data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The intended [access_type](../vs140/access_type-enumeration.md) on the target [accelerator_view](../vs140/accelerator_view-class.md). This parameter has a default value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A future upon which to wait for the operation to complete.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)