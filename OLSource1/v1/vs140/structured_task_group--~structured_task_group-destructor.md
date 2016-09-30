---
title: "structured_task_group::~structured_task_group Destructor"
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
  - "ppl/concurrency::structured_task_group::~structured_task_group"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~structured_task_group, destructor"
ms.assetid: 79f4df3d-3bab-4599-b8bd-2530e47a1d09
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group::~structured_task_group Destructor
Destroys a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. You are expected to call either the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method on the object prior to the destructor executing, unless the destructor is executing as a result of stack unwinding due to an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the destructor runs as the result of normal execution (for example, not stack unwinding due to an exception) and neither the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods have been called, the destructor may throw a [missing_wait](../vs140/missing_wait-class.md) exception.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [structured_task_group::wait Method](../vs140/structured_task_group--wait-method.md)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group--run_and_wait-method.md)