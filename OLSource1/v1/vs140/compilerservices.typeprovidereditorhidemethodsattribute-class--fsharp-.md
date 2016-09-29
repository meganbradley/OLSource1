---
title: "CompilerServices.TypeProviderEditorHideMethodsAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeProviderEditorHideMethodsAttribute [F#]"
ms.assetid: dea2241e-f83c-465f-aa01-8211b68842a7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.TypeProviderEditorHideMethodsAttribute Class (F#)
Indicates that a code editor should hide all System.Object methods from the Intellisense menus for instances of a provided type  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(5132, AllowMultiple = false)>]  
type TypeProviderEditorHideMethodsAttribute =  
 class  
  new TypeProviderEditorHideMethodsAttribute : unit -> TypeProviderEditorHideMethodsAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `TypeProviderEditorHideMethods`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/compilerservices.typeprovidereditorhidemethodsattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)