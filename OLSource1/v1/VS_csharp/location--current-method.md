---
title: "location::current Method"
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
  - "concrt/concurrency::location::current"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "current method"
ms.assetid: 422b6c59-d6cb-4d00-aad9-6285713b6e5a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# location::current Method
Returns a `location` object representing the most specific place the calling thread is executing.  
  
## Syntax  
  
```  
static location __cdecl current();  
```  
  
## Return Value  
 A location representing the most specific place the calling thread is executing.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [location Class](../VS_csharp/location-class.md)