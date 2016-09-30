---
title: "Core.EqualityConditionalOnAttribute Class (F#)"
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
  - "Core.EqualityConditionalOnAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.EqualityConditionalOnAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EqualityConditionalOnAttribute class [F#]"
  - "EqualityConditionalOn attribute [F#]"
ms.assetid: 26f5c760-97fe-4a6c-8437-652bdc203ee8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.EqualityConditionalOnAttribute Class (F#)
This attribute is used to indicate a generic container type satisfies the F# equality constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on a type definition <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> means that a type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only supports equality if the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> also supports equality and all other conditions for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to support equality are also met. The type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can still be used with other type arguments, but a type such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will not support equality because the type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an F# function type and does not support equality.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This attribute will be ignored if it is used on the generic parameters of functions or methods.  
  
 You can also use the short form of the name, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.equalityconditionalonattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)