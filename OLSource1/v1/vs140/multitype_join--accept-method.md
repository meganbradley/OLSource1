---
title: "multitype_join::accept Method"
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
  - "agents/concurrency::multitype_join::accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept method"
ms.assetid: 63e7e8e6-cddb-440a-b94e-afe18cff295a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join::accept Method
Accepts a message that was offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block, transferring ownership to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the offered <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Return Value  
 A pointer to the message that the caller now has ownership of.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)