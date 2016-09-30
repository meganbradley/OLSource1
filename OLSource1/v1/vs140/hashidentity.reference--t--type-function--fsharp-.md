---
title: "HashIdentity.Reference&lt;&#39;T&gt; Type Function (F#)"
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
  - "HashIdentity.Reference<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.HashIdentity.Reference``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Reference type function [F#]"
  - "HashIdentity.Reference type function [F#]"
ms.assetid: 5a92cdd8-bf3f-4943-b132-59c0e0463d41
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashIdentity.Reference&lt;&#39;T&gt; Type Function (F#)
Implements physical hashing, which means that it hashes on reference identity of objects, and the contents of value types.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An object that implements \<xref:System.Collections.IEqualityComparer*>.  
  
## Remarks  
 This function hashes using [LanguagePrimitives.PhysicalEquality](../vs140/languageprimitives.physicalequality--t--function--fsharp-.md) and [LanguagePrimitives.PhysicalHash](../vs140/languageprimitives.physicalhash--t--function--fsharp-.md). That is, for value types uses \<xref:System.Object.GetHashCode*> and \<xref:System.Object.Equals*> (if no other optimization available), and for reference types uses \<xref:System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode*> and reference equality.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.HashIdentity Module (F#)](../vs140/collections.hashidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)