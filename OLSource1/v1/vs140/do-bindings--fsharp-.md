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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do Bindings (F#)
A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> binding is used to execute code without defining a function or value. Also, do bindings can be used in classes, see [do Bindings in Classes (F#)](../vs140/do-bindings-in-classes--fsharp-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> binding when you want to execute code independently of a function or value definition. The expression in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> binding must return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Code in a top-level <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> binding is executed when the module is initialized. The keyword <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is optional.  
  
 Attributes can be applied to a top-level <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> binding. For example, if your program uses COM interop, you might want to apply the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute to your program. You can do this by using an attribute on a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> binding, as shown in the following code.  
  
 [!code[FsLangRef1#201](../vs140/codesnippet/FSharp/do-bindings--fsharp-_1.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Functions (F#)](../vs140/functions--fsharp-.md)