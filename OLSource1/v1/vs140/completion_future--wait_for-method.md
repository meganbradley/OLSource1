---
title: "completion_future::wait_for Method"
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
  - "amprt/Concurrency::completion_future::wait_for"
dev_langs: 
  - "C++"
ms.assetid: 715e4ac6-6014-48fb-b1a0-ea9d6183fbe1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future::wait_for Method
Blocks until the associated asynchronous operation completes or the time that's specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has elapsed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An arithmetic type that represents the number of ticks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A std::ratio that represents the number of seconds that elapse per tick.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum amount of time to wait for the operation to complete.  
  
## Return Value  
 Returns:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the associated asynchronous operation is not running.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the associated asynchronous operation is finished.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the specified time period has elapsed.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)