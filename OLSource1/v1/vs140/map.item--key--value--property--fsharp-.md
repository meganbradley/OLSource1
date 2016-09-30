---
title: "Map.Item&lt;&#39;Key,&#39;Value&gt; Property (F#)"
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
  - "Map.Item<'Key,'Value>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpMap`2.Item"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Item property [F#]"
  - "Map.Item property [F#]"
ms.assetid: 3b7fee5c-edb6-437e-8810-8304d8048adc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.Item&lt;&#39;Key,&#39;Value&gt; Property (F#)
Lookup an element in the map. Raise \<xref:System.Collections.Generic.KeyNotFoundException*> if no binding exists in the map.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input key.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown when the key is not found.|  
  
## Return Value  
 The value mapped to the key.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map\<'Key,'Value> Class (F#)](../vs140/collections.map--key--value--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)