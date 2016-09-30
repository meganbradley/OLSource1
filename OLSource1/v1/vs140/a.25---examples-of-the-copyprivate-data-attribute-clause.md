---
title: "A.25   Examples of the copyprivate Data Attribute Clause"
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
ms.assetid: 7b1cb6a5-5691-4b95-b3ac-d7543ede6405
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.25   Examples of the copyprivate Data Attribute Clause
**Example 1:** The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause ([Section 2.7.2.8](../vs140/2.7.2.8-copyprivate.md) on page 32) can be used to broadcast values acquired by a single thread directly to all instances of the private variables in the other threads.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If routine *init* is called from a serial region, its behavior is not affected by the presence of the directives. After the call to the *get_values* routine has been executed by one thread, no thread leaves the construct until the private objects designated by *a*, *b*, *x*, and *y* in all threads have become defined with the values read.  
  
 **Example 2:** In contrast to the previous example, suppose the read must be performed by a particular thread, say the master thread. In this case, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause cannot be used to do the broadcast directly, but it can be used to provide access to a temporary shared object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Example 3:** Suppose that the number of lock objects required within a parallel region cannot easily be determined prior to entering it. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause can be used to provide access to shared lock objects that are allocated within that parallel region.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>