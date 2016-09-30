---
title: "packaged_task::get_future Method"
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
  - "future/std::packaged_task::get_future"
dev_langs: 
  - "C++"
ms.assetid: c9e7fdfb-0008-45d0-acc0-701c197fbd7f
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# packaged_task::get_future Method
Returns an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that has the same *associated asynchronous state*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object does not have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If this method has already been called for a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [\<future>](../vs140/-future-.md)   
 [future Class](../vs140/future-class.md)