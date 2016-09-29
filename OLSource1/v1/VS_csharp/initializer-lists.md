---
title: "Initializer Lists"
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
  - "initializer lists"
ms.assetid: b3e53442-9809-4105-9226-ae845bd20cae
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializer Lists
Initializer lists in constructors are now called before the base class constructor.  
  
## Remarks  
 Prior to Visual C++ 2005, the base class constructor was called before the initializer list when compiling with Managed Extensions for C++. Now, when compiling with **/clr**, the initializer list is called first.  
  
## See Also  
 [General Language Changes](../VS_csharp/general-language-changes--c---cli-.md)