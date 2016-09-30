---
title: "structured_task_group::is_canceling Method"
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
  - "ppl/concurrency::structured_task_group::is_canceling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_canceling method"
ms.assetid: 07e4e74d-fe7f-4899-8fbc-3d51cfd878ea
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group::is_canceling Method
Informs the caller whether or not the task group is currently in the midst of a cancellation. This does not necessarily indicate that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method was called on the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object (although such certainly qualifies this method to return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). It may be the case that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is executing inline and a task group further up in the work tree was canceled. In cases such as these where the runtime can determine ahead of time that cancellation will flow through this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will be returned as well.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An indication of whether the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is in the midst of a cancellation (or is guaranteed to be shortly).  
  
## Remarks  
 For more information, see [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [structured_task_group Class](../vs140/structured_task_group-class.md)