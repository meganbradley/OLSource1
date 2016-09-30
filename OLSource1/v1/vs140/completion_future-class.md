---
title: "completion_future Class"
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
  - "amprt/Concurrency::completion_future"
dev_langs: 
  - "C++"
ms.assetid: 1303c62e-546d-4b02-a578-251ed3fc0b6b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future Class
Represents a future corresponding to a C++ AMP asynchronous operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[completion_future::completion_future Constructor](../vs140/completion_future--completion_future-constructor.md)|Initializes a new instance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.|  
|[completion_future::~completion_future Destructor](../vs140/completion_future--~completion_future-destructor.md)|Destroys the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[completion_future::get Method](../vs140/completion_future--get-method.md)|Waits until the associated asynchronous operation completes.|  
|[completion_future::then Method](../vs140/completion_future--then-method.md)|Chains a callback function object to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be executed when the associated asynchronous operation finishes execution.|  
|[completion_future::to_task Method](../vs140/completion_future--to_task-method.md)|Returns a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object corresponding to the associated asynchronous operation.|  
|[completion_future::valid Method](../vs140/completion_future--valid-method.md)|Gets a Boolean value that indicates whether the object is associated with an asynchronous operation.|  
|[completion_future::wait Method](../vs140/completion_future--wait-method.md)|Blocks until the associated asynchronous operation completes.|  
|[completion_future::wait_for Method](../vs140/completion_future--wait_for-method.md)|Blocks until the associated asynchronous operation completes or the time specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has elapsed.|  
|[completion_future::wait_until Method](../vs140/completion_future--wait_until-method.md)|Blocks until the associated asynchronous operation completes or until the current time exceeds the value specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[completion_future::operator std::shared_future\<void> Operator](../vs140/completion_future--operator-std--shared_future-void--operator.md)|Implicitly converts the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[completion_future::operator= Operator](../vs140/completion_future--operator=-operator.md)|Copies the contents of the specified <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object into this one.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)