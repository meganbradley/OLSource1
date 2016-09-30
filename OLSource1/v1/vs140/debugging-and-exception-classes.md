---
title: "Debugging and Exception Classes"
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
  - "vc.classes.debug"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "debugging [MFC], exception classes"
  - "debugging [MFC], classes for debugging"
ms.assetid: 0d158efd-2e62-452e-9d2a-d3c30dfee7f9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging and Exception Classes
These classes provide support for debugging dynamic memory allocation and for passing exception information from the function where the exception is thrown to the function where it is caught.  
  
 Use classes [CDumpContext](../vs140/cdumpcontext-class.md) and [CMemoryState](../vs140/cmemorystate-structure.md) during development to assist with debugging, as described in [Debugging MFC Applications](../vs140/mfc-debugging-techniques.md). Use [CRuntimeClass](../vs140/cruntimeclass-structure.md) to determine the class of any object at run time, as described in the article [Accessing Run-Time Class Information](../vs140/accessing-run-time-class-information.md). The framework uses `CRuntimeClass` to create objects of a particular class dynamically.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)