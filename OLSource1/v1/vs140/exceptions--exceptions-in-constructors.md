---
title: "Exceptions: Exceptions in Constructors"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "constructors [C++], exceptions"
  - "throwing exceptions, in constructors"
  - "exceptions, in constructors"
ms.assetid: a78eae5a-5821-4b27-9478-1436320ed1e1
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: Exceptions in Constructors
When throwing an exception in a constructor, clean up whatever objects and memory allocations you have made prior to throwing the exception, as explained in [Exceptions: Throwing Exceptions from Your Own Functions](../vs140/exceptions--throwing-exceptions-from-your-own-functions.md).  
  
 When throwing an exception in a constructor, the memory for the object itself has already been allocated by the time the constructor is called. So, the compiler will automatically deallocate the memory occupied by the object after the exception is thrown.  
  
 For more information, see [Exceptions: Freeing Objects in Exceptions](../vs140/exceptions--freeing-objects-in-exceptions.md).  
  
## See Also  
 [Exception Handling](../vs140/exception-handling-in-mfc.md)