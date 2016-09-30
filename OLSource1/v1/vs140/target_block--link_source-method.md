---
title: "target_block::link_source Method"
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
  - "agents/concurrency::target_block::link_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_source method"
ms.assetid: 331118ba-e255-430b-a848-b62213f62b8d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::link_source Method
Links a specified source block to this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block that is to be linked.  
  
## Remarks  
 This function should not be called directly on a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. Blocks should be connected together using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> blocks, which will invoke the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method on the corresponding target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)