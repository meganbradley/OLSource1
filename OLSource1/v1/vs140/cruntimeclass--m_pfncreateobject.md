---
title: "CRuntimeClass::m_pfnCreateObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CRuntimeClass::m_pfnCreateObject"
  - "CRuntimeClass.m_pfnCreateObject"
  - "m_pfnCreateObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pfnCreateObject"
ms.assetid: 9b04a990-7693-4c7d-bf4d-a5ec89af59cf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRuntimeClass::m_pfnCreateObject
A function pointer to the default constructor that creates an object of your class.  
  
## Remarks  
 This pointer is only valid if the class supports dynamic creation; otherwise, the function returns **NULL**.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)