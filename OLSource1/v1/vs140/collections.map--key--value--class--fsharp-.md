---
title: "Collections.Map&lt;&#39;Key,&#39;Value&gt; Class (F#)"
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
  - "Collections.Map<'Key,'Value>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpMap`2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpMap class [F#]"
  - "Map class [F#]"
ms.assetid: 975316ea-55e3-4987-9994-90897ad45664
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Map&lt;&#39;Key,&#39;Value&gt; Class (F#)
Immutable maps. Keys are ordered by F# generic comparison.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Maps based on generic comparison are efficient for small keys. They are not a suitable choice if keys are recursive data structures or if keys require bespoke comparison semantics. All members of this class are thread-safe and may be used concurrently from multiple threads.  
  
 This type is named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/collections.map--key--value--constructor--fsharp-.md)|Builds a map that contains the bindings of the given <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Some<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>None` if not.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)