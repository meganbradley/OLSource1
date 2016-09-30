---
title: "cancellation_token::register_callback Method"
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
  - "pplcancellation_token/concurrency::cancellation_token::register_callback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "register_callback method"
ms.assetid: 2e80b834-9cd3-4ef1-a39e-89f57da59ced
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cancellation_token::register_callback Method
Registers a callback function with the token. If and when the token is canceled, the callback will be made. Note that if the token is already canceled at the point where this method is called, the callback will be made immediately and synchronously.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the function object that will be called back when this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is canceled.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The function object that will be called back when this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is canceled.  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object which can be utilized in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method to deregister a previously registered callback and prevent it from being made. The method will throw an [invalid_operation](../vs140/invalid_operation-class.md) exception if it is called on a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that was created using the [cancellation_token::none](../vs140/cancellation_token--none-method.md) method.  
  
## Requirements  
 **Header:** pplcancellation_token.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [cancellation_token Class](../vs140/cancellation_token-class.md)