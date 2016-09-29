---
title: "&#39;&lt;typename&gt;&#39; is a delegate type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc32008"
  - "vbc32008"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC32008"
ms.assetid: dc6abba0-a9ad-450f-8899-87265bc84abc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;typename&gt;&#39; is a delegate type
'\<typename>' is a delegate type. Delegate construction permits only a single AddressOf expression as an argument list. Often an AddressOf expression can be used instead of a delegate construction.  
  
 A `New` clause creating an instance of a delegate class supplies an invalid argument list to the delegate constructor.  
  
 You can supply only a single `AddressOf` expression when creating a new delegate instance.  
  
 This error can result if you do not pass any arguments to the delegate constructor, if you pass more than one argument, or if you pass a single argument that is not a valid `AddressOf` expression.  
  
 **Error ID:** BC32008  
  
### To correct this error  
  
-   Use a single `AddressOf` expression in the argument list for the delegate class in the `New` clause.  
  
## See Also  
 [New Operator](../vs140/new-operator--visual-basic-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)   
 [How to: Invoke a Delegate Method](../vs140/how-to--invoke-a-delegate-method--visual-basic-.md)