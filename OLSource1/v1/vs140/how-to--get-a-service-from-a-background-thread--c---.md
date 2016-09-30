---
title: "How to: Get a Service from a Background Thread (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "multithreading, services"
ms.assetid: 97a56709-66d4-431a-ae63-392ee5898511
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Get a Service from a Background Thread (C++)
Services cannot be obtained by means of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> from a background thread. If you use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to get a service on the main thread, and then try to use the service on a background thread, it also will fail.  
  
 To get a service from a background thread, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to marshal the service provider into a stream on the main thread. You then can unmarshal the service provider on a background thread and use it to get the service. You can unmarshal only once, so cache the interface that you get back.  
  
> [!NOTE]
>  Managed code automatically marshals interfaces between threads, so getting a service from a background thread does not require special code.  
  
## Example  
 The following code marshals a service provider in the main thread and provides a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method to unmarshal the service provider to get a service from a background thread.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Services](../vs140/using-and-providing-services.md)   
 [Service Essentials](../vs140/service-essentials.md)