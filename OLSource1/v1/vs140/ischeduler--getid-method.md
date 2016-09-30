---
title: "IScheduler::GetId Method"
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
  - "concrtrm/concurrency::IScheduler::GetId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetId method"
ms.assetid: 3280bda0-b1a4-4c8f-89e1-8869a0c9ee9d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler::GetId Method
Returns a unique identifier for the scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A unique integer identifier.  
  
## Remarks  
 You should use the [GetSchedulerId](../vs140/getschedulerid-function.md) function to obtain a unique identifier for the object that implements the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface, before you use the interface as a parameter to methods supplied by the Resource Manager. You are expected to return the same identifier when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is invoked.  
  
 An identifier obtained from a different source could result in undefined behavior.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)