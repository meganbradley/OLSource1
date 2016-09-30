---
title: "critical_section::~critical_section Destructor"
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
  - "concrt/concurrency::critical_section::~critical_section"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~critical_section, destructor"
ms.assetid: 88e1aabe-ee3a-4e3f-8acf-0c1687df3ba5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# critical_section::~critical_section Destructor
Destroys a critical section.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 It is expected that the lock is no longer held when the destructor runs. Allowing the critical section to destruct with the lock still held results in undefined behavior.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [critical_section Class](../vs140/critical_section-class.md)