---
title: "Core.FSharpInterfaceDataVersionAttribute Class (F#)"
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
  - "Core.FSharpInterfaceDataVersionAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpInterfaceDataVersion attribute [F#]"
  - "FSharpInterfaceDataVersionAttribute class [F#]"
ms.assetid: 900505db-8d27-432e-a216-07ec17dc179d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.FSharpInterfaceDataVersionAttribute Class (F#)
This attribute is added to generated assemblies to indicate the version of the data schema used to encode additional F# specific information in the resource attached to compiled F# libraries.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)>]  
[<Sealed>]  
type FSharpInterfaceDataVersionAttribute =  
 class  
  new FSharpInterfaceDataVersionAttribute : int * int * int -> FSharpInterfaceDataVersionAttribute  
  member this.Major :  int  
  member this.Minor :  int  
  member this.Release :  int  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `FSharpInterfaceDataVersion`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/core.fsharpinterfacedataversionattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Major](../VS_csharp/fsharpinterfacedataversionattribute.major-property--fsharp-.md)|The major version number of the F# version associated with the attribute|  
|[Minor](../VS_csharp/fsharpinterfacedataversionattribute.minor-property--fsharp-.md)|The minor version number of the F# version associated with the attribute|  
|[Release](../VS_csharp/fsharpinterfacedataversionattribute.release-property--fsharp-.md)|The release number of the F# version associated with the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)