---
title: "ITarget::unlink_source Method"
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
  - "agents/concurrency::ITarget::unlink_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unlink_source method"
ms.assetid: f3841a19-f009-4749-9270-e51834d60589
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITarget::unlink_source Method
When overridden in a derived class, unlinks a specified source block from this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block being unlinked from this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block.  
  
## Remarks  
 This function should not be called directly on an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block. Blocks should be disconnected using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> blocks, which will invoke the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method on the corresponding target.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITarget Class](../vs140/itarget-class.md)