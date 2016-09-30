---
title: "source_block::consume_message Method"
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
  - "agents/concurrency::source_block::consume_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume_message method"
ms.assetid: 1d20e951-ef02-40c3-aa61-048723623ca9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::consume_message Method
When overridden in a derived class, consumes a message that was previously reserved.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object being consumed.  
  
## Return Value  
 A pointer to the message that the caller now has ownership of.  
  
## Remarks  
 Similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, but is always preceded by a call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)