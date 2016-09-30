---
title: "choice::release_ref Method"
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
  - "agents/concurrency::choice::release_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release_ref method"
ms.assetid: aad975a5-408f-4448-a886-37354e049d38
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::release_ref Method
Releases a reference count on this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling this method.  
  
## Remarks  
 This method is called by an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that is being unlinked from this source. The source block is allowed to release any resources reserved for the target block.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)