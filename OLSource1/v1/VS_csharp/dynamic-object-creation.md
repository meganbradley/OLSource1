---
title: "Dynamic Object Creation"
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
helpviewer_keywords: 
  - "object creation, dynamically at run time"
  - "CObject class, dynamic object creation"
  - "objects [C++], creating dynamically at run time"
  - "dynamic object creation"
ms.assetid: 3e0f51cb-3e24-4231-817f-1c0ce9f2d5df
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dynamic Object Creation
This article explains how to create an object dynamically at run time. The procedure uses run-time class information, as discussed in the article [Accessing Run-Time Class Information](../VS_csharp/accessing-run-time-class-information.md).  
  
#### To dynamically create an object given its run-time class  
  
1.  Use the following code to dynamically create an object by using the `CreateObject` function of the `CRuntimeClass`. Note that on failure, `CreateObject` returns **NULL** instead of raising an exception:  
  
     [!code[NVC_MFCCObjectSample#6](../VS_csharp/codesnippet/CPP/dynamic-object-creation_1.cpp)]  
  
## See Also  
 [Using CObject](../VS_csharp/using-cobject.md)