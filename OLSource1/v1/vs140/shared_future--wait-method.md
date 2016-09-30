---
title: "shared_future::wait Method"
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
  - "future/std::shared_future::wait"
dev_langs: 
  - "C++"
ms.assetid: 28159543-b093-46c1-b5b9-5666ca1becef
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_future::wait Method
Blocks the current thread until the *associated asynchronous state* is *ready*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [shared_future Class](../vs140/shared_future-class.md)   
 [\<future>](../vs140/-future-.md)