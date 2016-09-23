---
title: "InteractiveSession.PrintWidth Property (F#)"
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
  - Microsoft.FSharp.Compiler.Interactive.InteractiveSession.PrintWidth
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - PrintWidth property [F#]
  - InteractiveSession.PrintWidth property [F#]
ms.assetid: e6c79af4-b6ef-4612-8658-43981632e513
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# InteractiveSession.PrintWidth Property (F#)
Gets or sets the print width, that is, the number of characters to print per line, in an F# interactive session.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive  
  
 **Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.PrintWidth :  int  
member this.PrintWidth : int with set :  int  
  
// Usage:  
interactiveSession.PrintWidth  
interactiveSession.PrintWidth <- printWidth  
```  
  
#### Parameters  
 `printWidth`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The print width to set.  
  
## Return Value  
  
## Remarks  
 The default value is 78.  
  
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