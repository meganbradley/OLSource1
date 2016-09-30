---
title: "ITypeProvider.GetInvokerExpression Method (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.ITypeProvider.GetInvokerExpression"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GetInvokerExpression method [F#]"
  - "ITypeProvider.GetInvokerExpression method [F#]"
ms.assetid: 5706a4fc-ac14-4d5f-9c28-bb62896e705a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITypeProvider.GetInvokerExpression Method (F#)
Called by the compiler to ask for an Expression tree to replace the given MethodBase with.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.Reflection.MethodBase*>  
  
 MethodBase that was given to the compiler by a type returned by a GetType(s) call.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Quotations.Expr](../vs140/quotations.expr-class--fsharp-.md) []  
  
 Expressions that represent the parameters to this call.  
  
## Return Value  
 An Expression tree that the compiler will use in place of the given method base.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [CompilerServices.ITypeProvider Interface (F#)](../vs140/compilerservices.itypeprovider-interface--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)