---
title: "choice::accept Method"
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
  - "agents/concurrency::choice::accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept method"
ms.assetid: 2a2499b9-3511-450c-b281-731f4ceb8af8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::accept Method
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
 [choice Class](../vs140/choice-class.md)