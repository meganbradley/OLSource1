---
title: "run_with_cancellation_token Function"
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
  - "ppl/concurrency::run_with_cancellation_token"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run_with_cancellation_token function"
ms.assetid: 02083191-ebc9-4565-9438-2ca39fcd31f6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# run_with_cancellation_token Function
Executes a function object immediately and synchronously in the context of a given cancellation token.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function object which will be executed. This object must support the function call operator with a signature of void(void).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The cancellation token which will control implicit cancellation of the function object. Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if you want the function execute without any possibility of implicit cancellation from a parent task group being canceled.  
  
## Remarks  
 Any interruption points in the function object will be triggered when the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is canceled. The explicit token <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will isolate this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from parent cancellation if the parent has a different token or no token.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)