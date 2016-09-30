---
title: "Core.ComparisonConditionalOnAttribute Class (F#)"
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
  - "Core.ComparisonConditionalOnAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ComparisonConditionalOnAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ComparisonConditionalOn attribute [F#]"
  - "ComparisonConditionalOnAttribute class [F#]"
ms.assetid: 30f6b489-e03d-4864-bd84-7e88708f569c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.ComparisonConditionalOnAttribute Class (F#)
Indicates that a generic type satisfies the comparison constraint if and only if the type argument satisfies this constraint.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This attribute is used to indicate a generic container type satisfies the F# comparison constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on a type definition <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> means that a type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only supports comparison if the type X also supports comparison and all other conditions for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to support comparison are also met. The type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can still be used with other type arguments, but a type such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will not support comparison because the type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an F# function type and does not support comparison.  
  
 This attribute will be ignored if it is used on the generic parameters of functions or methods.  
  
 You can also use the short form of the name, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.comparisonconditionalonattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)