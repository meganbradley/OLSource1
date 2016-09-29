---
title: "do Bindings (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "do keyword [F#]"
  - "do bindings [F#]"
ms.assetid: 7219aeda-807c-43a9-a4a9-863b463fe3c0
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do Bindings (F#)
A `do` binding is used to execute code without defining a function or value. Also, do bindings can be used in classes, see [do Bindings in Classes (F#)](../vs140/do-bindings-in-classes--fsharp-.md).  
  
## Syntax  
  
```  
[ attributes ]  
[ do ]expression  
```  
  
## Remarks  
 Use a `do` binding when you want to execute code independently of a function or value definition. The expression in a `do` binding must return `unit`. Code in a top-level `do` binding is executed when the module is initialized. The keyword `do` is optional.  
  
 Attributes can be applied to a top-level `do` binding. For example, if your program uses COM interop, you might want to apply the `STAThread` attribute to your program. You can do this by using an attribute on a `do` binding, as shown in the following code.  
  
 [!code[FsLangRef1#201](../vs140/codesnippet/FSharp/do-bindings--fsharp-_1.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Functions (F#)](../vs140/functions--fsharp-.md)