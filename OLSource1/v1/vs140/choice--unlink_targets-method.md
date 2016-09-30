---
title: "choice::unlink_targets Method"
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
  - "agents/concurrency::choice::unlink_targets"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unlink_targets method"
ms.assetid: a06d4a0e-f932-43d2-b595-e694a17b1b43
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::unlink_targets Method
Unlinks all targets from this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method does not need to be called from the destructor because destructor for the internal <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block will unlink properly.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)