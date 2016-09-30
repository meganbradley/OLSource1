---
title: "accelerator::get_auto_selection_view Method"
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
ms.assetid: 53648239-9818-4573-b8cf-32754440693b
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::get_auto_selection_view Method
Returns the auto selection accelerator_view, which when specified as the parallel_for_each target results in the target accelerator_view for executing the parallel_for_each kernel to be automatically selected by the runtime. For all other purposes, the accelerator_view returned by this method is the same as the default accelerator_view of the default accelerator  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The auto selection accelerator_view.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)