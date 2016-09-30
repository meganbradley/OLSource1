---
title: "single_assignment::accept_message Method"
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
  - "agents/concurrency::single_assignment::accept_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept_message method"
ms.assetid: 65c0032b-13da-4650-89aa-2f99b52e2b79
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::accept_message Method
Accepts a message that was offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block, returning a copy of the message to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the offered <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> messaging block returns copies of the message to its targets, rather than transferring ownership of the currently held message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)