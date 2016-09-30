---
title: "Core.CompilerMessageAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerMessageAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilerMessageAttribute class [F#]"
  - "CompilerMessage attribute [F#]"
ms.assetid: 6c7601c0-a58e-458c-bee7-66f6a0de4fb6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilerMessageAttribute Class (F#)
Indicates that a message should be emitted when F# source code uses this construct.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.All, AllowMultiple = false)>]  
[<Sealed>]  
type CompilerMessageAttribute =  
 class  
  new CompilerMessageAttribute : string * int -> CompilerMessageAttribute  
  member this.IsError :  bool with get, set  
  member this.IsHidden :  bool with get, set  
  member this.Message :  string  
  member this.MessageNumber :  int  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `CompilerMessage`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.compilermessageattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[IsError](../vs140/compilermessageattribute.iserror-property--fsharp-.md)|Indicates if the message should indicate a compiler error. Error numbers less than 10000 are considered reserved for use by the F# compiler and libraries.|  
|[IsHidden](../vs140/compilermessageattribute.ishidden-property--fsharp-.md)|Indicates if the construct should always be hidden in an editing environment.|  
|[Message](../vs140/compilermessageattribute.message-property--fsharp-.md)|Indicates the warning message to be emitted when F# source code uses this construct|  
|[MessageNumber](../vs140/compilermessageattribute.messagenumber-property--fsharp-.md)|Indicates the number associated with the message.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)