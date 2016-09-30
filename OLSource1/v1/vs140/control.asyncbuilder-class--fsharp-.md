---
title: "Control.AsyncBuilder Class (F#)"
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
  - "Control.AsyncBuilder"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncBuilder"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncBuilder class [F#]"
  - "FSharpAsyncBuilder class [F#]"
ms.assetid: 7f593fcf-bc6e-42fc-bd26-fb9e18951016
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.AsyncBuilder Class (F#)
The type of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator, used to build workflows for asynchronous computations.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For general information on computation expressions and builder types, see [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
 This type is named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in compiled assemblies. If accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/control.asyncbuilder-constructor--fsharp-.md)|Generates an object used to build asynchronous computations using F# computation expressions. The value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a pre-defined instance of this type. A cancellation check is performed when the computation is executed.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Bind](../vs140/asyncbuilder.bind--t--u--method--fsharp-.md)|Implements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in asynchronous computations.|  
|[Combine](../vs140/asyncbuilder.combine--t--method--fsharp-.md)|Creates an asynchronous computation that first runs <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and then runs <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, returning the result of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[Delay](../vs140/asyncbuilder.delay--t--method--fsharp-.md)|Creates an asynchronous computation that runs a function.|  
|[For](../vs140/asyncbuilder.for--t--method--fsharp-.md)|Implements the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression in asynchronous computations.|  
|[Return](../vs140/asyncbuilder.return--t--method--fsharp-.md)|Implements the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression in asynchronous computations. Creates an asynchronous computation that returns the specified result.|  
|[ReturnFrom](../vs140/asyncbuilder.returnfrom--t--method--fsharp-.md)|Implements the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword for asynchronous computations. This function delegates to the input computation.|  
|[TryFinally](../vs140/asyncbuilder.tryfinally--t--method--fsharp-.md)|Implements <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in asynchronous computations.|  
|[TryWith](../vs140/asyncbuilder.trywith--t--method--fsharp-.md)|Implements <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in asynchronous computations.|  
|[Using](../vs140/asyncbuilder.using--t--u--method--fsharp-.md)|Implements the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keywords in asynchronous computation expressions.|  
|[While](../vs140/asyncbuilder.while-method--fsharp-.md)|Implements the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword in asynchronous computation expressions.|  
|[Zero](../vs140/asyncbuilder.zero-method--fsharp-.md)|Creates an asynchronous computation that does nothing and returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)