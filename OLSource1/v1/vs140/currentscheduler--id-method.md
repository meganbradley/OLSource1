---
title: "CurrentScheduler::Id Method"
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
  - "concrt/concurrency::CurrentScheduler::Id"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Id method"
ms.assetid: 9f88a503-7edf-4b97-a83b-031b662df4f0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::Id Method
Returns a unique identifier for the current scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If a scheduler is associated with the calling context, a unique identifier for that scheduler; otherwise, the value <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)