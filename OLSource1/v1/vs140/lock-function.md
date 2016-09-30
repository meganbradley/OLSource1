---
title: "lock Function"
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
  - "mutex/std::lock"
dev_langs: 
  - "C++"
ms.assetid: 3fc3b0e5-3c61-4928-a9ca-f9fc57e13d30
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock Function
Attempts to lock all arguments without deadlock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The arguments to the template function must be *mutex types*, except that calls to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> might throw exceptions.  
  
 The function locks all of its arguments without deadlock by calls to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If a call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> throws an exception, the function calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on any of the mutex objects that were successfully locked before rethrowing the exception.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [mutex Class (STL)](../vs140/mutex-class--stl-.md)   
 [recursive_mutex Class (STL)](../vs140/recursive_mutex-class.md)   
 [recursive_timed_mutex Class (STL)](../vs140/recursive_timed_mutex-class.md)   
 [timed_mutex Class (STL)](../vs140/timed_mutex-class.md)