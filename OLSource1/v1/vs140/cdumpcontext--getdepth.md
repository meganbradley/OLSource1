---
title: "CDumpContext::GetDepth"
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
  - "CDumpContext::GetDepth"
  - "CDumpContext.GetDepth"
  - "GetDepth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDumpContext class, status"
  - "GetDepth method"
ms.assetid: 1ff63a39-c50f-4668-888b-3deec85e69b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDumpContext::GetDepth
Determines whether a deep or shallow dump is in process.  
  
## Syntax  
  
```  
  
int GetDepth( ) const;  
```  
  
## Return Value  
 The depth of the dump as set by `SetDepth`.  
  
## Example  
 See the example for [SetDepth](../vs140/cdumpcontext--setdepth.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDumpContext::SetDepth](../vs140/cdumpcontext--setdepth.md)