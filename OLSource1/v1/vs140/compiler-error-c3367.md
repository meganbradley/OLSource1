---
title: "Compiler Error C3367"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3367"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3367"
ms.assetid: e675d42b-f5b0-4d43-aab1-1f5024233102
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3367
'static_member_function' : cannot use static function to create an unbound delegate  
  
 When you call an unbound delegate, you must pass an instance of an object. Since a static member function is called through the class name, you can only instantiate an unbound delegate with an instance member function.  
  
 For more information, see [Unbound Delegates](../vs140/unbound-delegates.md).  
  
## Example  
 The following sample generates C3367.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>