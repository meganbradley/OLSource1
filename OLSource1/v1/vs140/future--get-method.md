---
title: "future::get Method"
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
  - "future/std::future::get"
dev_langs: 
  - "C++"
ms.assetid: e8b611b6-9609-409b-a499-8443ec8e6d14
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future::get Method
Retrieves the result that is stored in the associated asynchronous state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the result is an exception, the method rethrows it. Otherwise, the result is returned.  
  
## Remarks  
 Before it retrieves the result, this method blocks the current thread until the associated asynchronous state is ready.  
  
 For the partial specialization <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the stored value is effectively a reference to the object that was passed to the asynchronous provider as the return value.  
  
 Because no stored value exists for the specialization <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 In other specializations, the method moves its return value from the stored value. Therefore, call this method only once.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [future Class](../vs140/future-class.md)   
 [\<future>](../vs140/-future-.md)