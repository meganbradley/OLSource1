---
title: "Operators.uint32&lt;^T&gt; Function (F#)"
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
  - "Operators.uint32<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.ToUInt32``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.ToUInt32 function [F#]"
  - "Operators.uint32 function [F#]"
  - "uint32 function [F#]"
  - "ToUInt32 function [F#]"
ms.assetid: 65c25d6f-7f26-4d12-96fa-d0120b3b8edd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.uint32&lt;^T&gt; Function (F#)
Converts the argument to unsigned 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt32.Parse*>with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input value.  
  
## Return Value  
 The converted <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)