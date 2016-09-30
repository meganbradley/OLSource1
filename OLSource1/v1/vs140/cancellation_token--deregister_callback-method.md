---
title: "cancellation_token::deregister_callback Method"
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
  - "pplcancellation_token/concurrency::cancellation_token::deregister_callback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deregister_callback method"
ms.assetid: 8db2d518-fdf4-47c6-b743-bce70c44f240
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token::deregister_callback Method
Removes a callback previously registered via the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method based on the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object returned at the time of registration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object corresponding to the callback to be deregistered. This token must have been previously returned from a call to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token Class](../vs140/cancellation_token-class.md)