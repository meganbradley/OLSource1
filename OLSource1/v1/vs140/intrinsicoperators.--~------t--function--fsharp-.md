---
title: "IntrinsicOperators.( ~&amp;&amp; )&lt;&#39;T&gt; Function (F#)"
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
  - "IntrinsicOperators.( ~&amp;&amp; )<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators.op_IntegerAddressOf``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IntrinsicOperators.( ~&& ) operator [F#]"
  - "IntrinsicOperators.op_IntegerAddressOf operator [F#]"
  - "~&& operator [F#]"
  - "op_IntegerAddressOf operator [F#]"
ms.assetid: 894f4c19-a8ae-4db4-b5b6-6ce2ffe0f1c8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IntrinsicOperators.( ~&amp;&amp; )&lt;&#39;T&gt; Function (F#)
Takes the address of the argument as a native pointer. Uses of this value may result in the generation of unverifiable code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ~&& ) : 'T -> nativeptr<'T> (requires unmanaged)  
  
// Usage:  
&& obj  
```  
  
#### Parameters  
 `obj`  
 Type: `'T`  
  
 The input object.  
  
## Return Value  
 The unmanaged pointer.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicOperators Module (F#)](../vs140/languageprimitives.intrinsicoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)