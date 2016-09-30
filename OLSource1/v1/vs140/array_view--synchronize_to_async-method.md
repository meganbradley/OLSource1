---
title: "array_view::synchronize_to_async Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 466d1966-cf6c-4f02-a799-57f0e59f1ce6
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::synchronize_to_async Method
Asynchronously synchronizes any modifications made to this array_view to the specified accelerator_view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The target accelerator_view to synchronize to.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The desired access_type on the target accelerator_view. This parameter has a default value of access_type_read.  
  
## Return Value  
 A future upon which to wait for the operation to complete.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)