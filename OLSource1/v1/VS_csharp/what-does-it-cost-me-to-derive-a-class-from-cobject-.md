---
title: "What Does it Cost me to Derive a Class from CObject?"
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
  - "CObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObject class, overhead of derived classes"
ms.assetid: 9b92c98b-b3dd-48a7-9d24-c3b8554edf90
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Does it Cost me to Derive a Class from CObject?
The overhead in deriving from class [CObject](../VS_csharp/cobject-class.md) is minimal. Your derived class inherits only four virtual functions and a single [CRuntimeClass](../VS_csharp/cruntimeclass-structure.md) object.  
  
## See Also  
 [CObject Class: Frequently Asked Questions](../VS_csharp/cobject-class--frequently-asked-questions.md)