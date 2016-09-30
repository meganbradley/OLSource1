---
title: "system_clock::is_steady Constant"
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
  - "chrono/std::chrono::system_clock::is_steady"
dev_langs: 
  - "C++"
ms.assetid: 87f8b689-a8e4-4ae0-86ea-01dbd588ef6f
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# system_clock::is_steady Constant
Static value that specifies whether the clock type is *steady*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 In this implementation, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 A clock is *steady* if it is [monotonic](../vs140/system_clock--is_monotonic-constant.md) and if the time between clock ticks is constant.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [system_clock Structure](../vs140/system_clock-structure.md)   
 [\<chrono>](../vs140/-chrono-.md)