---
title: "completion_future::wait_until Method"
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
  - "amprt/Concurrency::completion_future::wait_until"
dev_langs: 
  - "C++"
ms.assetid: cb12f1a2-211f-4c64-85e6-a37585573847
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future::wait_until Method
Blocks until the associated asynchronous operation completes or until the current time exceeds the value specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The clock on which this time point is measured.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The time interval since the start of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>’s epoch, after which the function will time out.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The point in time after which the function will time out.  
  
## Return Value  
 Returns:  
  
1.  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the associated asynchronous operation is not running.  
  
2.  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the associated asynchronous operation is finished.  
  
3.  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the time period specified has elapsed.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)