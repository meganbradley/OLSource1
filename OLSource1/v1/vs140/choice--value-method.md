---
title: "choice::value Method"
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
  - "agents/concurrency::choice::value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value method"
ms.assetid: 989d89cc-e3c8-4e57-8318-d5cfda0a9756
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::value Method
Gets the message whose index was selected by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the message payload.  
  
## Return Value  
 The payload of the message.  
  
## Remarks  
 Because a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> messaging block can take inputs with different payload types, you must specify the type of the payload at the point of retrieval. You can determine the type based on the result of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)