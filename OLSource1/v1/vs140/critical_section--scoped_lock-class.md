---
title: "critical_section::scoped_lock Class"
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
  - "concrt/concurrency::critical_section::scoped_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scoped_lock class"
ms.assetid: 9564437e-8df7-4eb7-b60c-842c27ac4bb6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# critical_section::scoped_lock Class
An exception safe RAII wrapper for a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[critical_section::scoped_lock::scoped_lock Constructor](../vs140/critical_section--scoped_lock--scoped_lock-constructor.md)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object and acquires the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object passed in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. If the critical section is held by another thread, this call will block.|  
|[critical_section::scoped_lock::~scoped_lock Destructor](../vs140/critical_section--scoped_lock--~scoped_lock-destructor.md)|Destroys a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object and releases the critical section supplied in its constructor.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [critical_section Class](../vs140/critical_section-class.md)