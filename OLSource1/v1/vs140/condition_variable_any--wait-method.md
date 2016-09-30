---
title: "condition_variable_any::wait Method"
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
  - "condition_variable/std::condition_variable_any::wait"
dev_langs: 
  - "C++"
ms.assetid: 9aef6e28-bb2c-4622-8887-47cfae274654
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable_any::wait Method
Blocks a thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object of any type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first method blocks until the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md). It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable_any Class](../vs140/condition_variable_any-class.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)