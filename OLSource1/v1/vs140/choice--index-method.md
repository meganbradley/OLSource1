---
title: "choice::index Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - agents/concurrency::choice::index
dev_langs: 
  - C++
helpviewer_keywords: 
  - index method
ms.assetid: 2341a217-df19-42c6-83ac-846075ae0f1d
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# choice::index Method
Returns an index into the `tuple` representing the element selected by the `choice` messaging block.  
  
## Syntax  
  
```  
size_t index();  
```  
  
## Return Value  
 The message index.  
  
## Remarks  
 The message payload can be extracted using the `get` method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)