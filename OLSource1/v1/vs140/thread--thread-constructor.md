---
title: "thread::thread Constructor"
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
  - "thread/std::thread::thread"
dev_langs: 
  - "C++"
ms.assetid: 57fab50b-c788-409e-97ad-1ddb64beaf15
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::thread Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An application-defined function to be executed by the thread.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A list of arguments to be passed to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor constructs an object that's not associated with a thread of execution. The value that's returned by a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the constructed object is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object that's associated with a new thread of execution and executes the pseudo-function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that's defined in [\<functional>](../vs140/-functional-.md). If not enough resources are available to start a new thread, the function throws a [system_error](../vs140/system_error-class.md) object that has an error code of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If the call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> terminates with an uncaught exception, [terminate](../vs140/terminate---exception--.md) is called.  
  
 The third constructor constructs an object that's associated with the thread that's associated with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is then set to a default-constructed state.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [\<thread>](../vs140/-thread-.md)   
 [thread::id Class](../vs140/thread--id-class.md)