---
title: "InteractiveSession.PrintSize Property (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Microsoft.FSharp.Compiler.Interactive.InteractiveSession.PrintSize
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - InteractiveSession.PrintSize property [F#]
  - PrintSize property [F#]
ms.assetid: decec1b9-6403-433c-b45f-6e4a03b8db51
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# InteractiveSession.PrintSize Property (F#)
Gets or sets the total print size, the maximum number of characters to print when displaying data, in the interactive session.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive  
  
 **Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.PrintSize :  int  
member this.PrintSize : int with set :  int  
  
// Usage:  
interactiveSession.PrintSize  
interactiveSession.PrintSize <- printSize  
```  
  
#### Parameters  
 `printSize`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The print size to set.  
  
## Return Value  
  
## Remarks  
 The default value is 10000.  
  
## Platforms  
 Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2  
  
## Version Information  
 **F# Runtime**  
  
 Supported in: 2.0, 4  
  
 **Silverlight**  
  
 Supported in: 3  
  
## See Also  
 [Interactive.InteractiveSession Class (F#)](../vs140/interactive.interactivesession-class--fsharp-.md)   
 [Microsoft.FSharp.Compiler.Interactive Namespace (F#)](../vs140/microsoft.fsharp.compiler.interactive-namespace--fsharp-.md)