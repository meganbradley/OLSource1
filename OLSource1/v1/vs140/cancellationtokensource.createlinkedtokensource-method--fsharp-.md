---
title: "CancellationTokenSource.CreateLinkedTokenSource Method (F#)"
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
  - "CancellationTokenSource.CreateLinkedTokenSource"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationTokenSource.CreateLinkedTokenSource"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CreateLinkedTokenSource method [F#]"
  - "CancellationTokenSource.CreateLinkedTokenSource method [F#]"
ms.assetid: a75ae3f2-9924-4079-aaab-7f8bea64a2e8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CancellationTokenSource.CreateLinkedTokenSource Method (F#)
Creates a cancellation capability linking two tokens.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The first input token.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 The second input token.  
  
## Return Value  
 The created CancellationTokenSource.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, \<xref:System.Threading.CancellationTokenSource.CreateLinkedTokenSource*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Threading.CancellationTokenSource Class (F#)](../vs140/threading.cancellationtokensource-class--fsharp-.md)   
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)