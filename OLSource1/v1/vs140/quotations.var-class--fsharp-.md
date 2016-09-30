---
title: "Quotations.Var Class (F#)"
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
  - "Quotations.FSharpVar"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpVar"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Var class [F#]"
  - "FSharpVar class [F#]"
ms.assetid: 2b1237f9-d897-4bcf-872a-4a297db3f7b5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Quotations.Var Class (F#)
Represents information at the binding site of a variable.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This type is named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/quotations.var-constructor--fsharp-.md)|Creates a new variable with the given name, type and mutability|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[IsMutable](../vs140/var.ismutable-property--fsharp-.md)|Indicates if the variable represents a mutable storage location|  
|[Name](../vs140/var.name-property--fsharp-.md)|The declared name of the variable|  
|[Type](../vs140/var.type-property--fsharp-.md)|The type associated with the variable|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[Global](../vs140/var.global-method--fsharp-.md)|Fetches or creates a new variable with the given name and type from a global pool of shared variables indexed by name and type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)