---
title: "CFontHolder::QueryTextMetrics"
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
  - "QueryTextMetrics"
  - "CFontHolder::QueryTextMetrics"
  - "CFontHolder.QueryTextMetrics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryTextMetrics method"
ms.assetid: ed5a0d10-4722-4cfe-b464-0ea7463ea2e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontHolder::QueryTextMetrics
Retrieves information on the physical font represented by the `CFontHolder` object.  
  
## Syntax  
  
```  
  
      void QueryTextMetrics(  
   LPTEXTMETRIC lptm  
);  
```  
  
#### Parameters  
 `lptm`  
 A pointer to a [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure that will receive the information.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CFontHolder Class](../vs140/cfontholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)