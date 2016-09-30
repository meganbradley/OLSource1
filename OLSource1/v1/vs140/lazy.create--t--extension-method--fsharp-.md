---
title: "Lazy.Create&lt;&#39;T&gt; Extension Method (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Lazy.Create<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.LazyExtensions.Create"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Create extension method [F#]"
  - "LazyExtensions.Create extension method [F#]"
ms.assetid: b3ac5a61-f87d-4332-b45c-f56712693b77
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lazy.Create&lt;&#39;T&gt; Extension Method (F#)
Creates a lazy computation that evaluates to the result of the given function when forced.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.LazyExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to provide the value when needed.  
  
## Return Value  
 The created [Lazy](../vs140/control.lazy--t--type-abbreviation--fsharp-.md) object.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [!code[FsCoreLib2#11](../vs140/codesnippet/FSharp/lazy.create--t--extension-method--fsharp-_1.fs)]  
  
 The output is the factorial of 10.  
  
 **3628800**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 \<xref:System.Lazy`1*>   
 [Control.LazyExtensions Module (F#)](../vs140/control.lazyextensions-module--fsharp-.md)   
 [Lazy Computations (F#)](../vs140/lazy-computations--fsharp-.md)