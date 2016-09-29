---
title: "CompilerServices.ITypeProvider Interface (F#)"
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
  - "Microsoft.FSharp.Core.CompilerServices.ITypeProvider"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ITypeProvider interface [F#]"
ms.assetid: 2c2b0571-843d-4a7d-95d4-0a7510ed5e2f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.ITypeProvider Interface (F#)
Type providers implement this interface in order to be recognized by the compiler as an F# type provider. The implementation of this interface determines the public interface and behavior of the type provider. For more information, see [Type Providers](../vs140/type-providers.md).  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type ITypeProvider =  
 interface  
  inherit IDisposable  
  abstract this.ApplyStaticArguments : Type * string [] * obj [] -> Type  abstract this.GetGeneratedAssemblyContents : System.Reflection.Assembly -> byte[]   
  abstract this.GetInvokerExpression : MethodBase * Quotations.Expr [] -> Quotations.Expr  
  abstract this.GetNamespaces : unit -> IProvidedNamespace []  
  abstract this.GetStaticParameters : Type -> ParameterInfo []  
  abstract this.add_Invalidate : EventHandler -> unit  
  abstract this.Invalidate : IEvent<EventHandler,EventArgs>  
  abstract this.remove_Invalidate : EventHandler -> unit  
 end  
```  
  
## Remarks  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[add_Invalidate](../vs140/itypeprovider.add_invalidate-method--fsharp-.md) : <xref:System.EventHandler*> -> unit|Add an event handler for the [Invalidate](../vs140/itypeprovider.invalidate-event--fsharp-.md) event.|  
|[ApplyStaticArguments](../vs140/itypeprovider.applystaticarguments-method--fsharp-.md) : <xref:System.Type*> * [string](../vs140/core.string-type-abbreviation--fsharp-.md) [] \* [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) [] -> <xref:System.Type*>|Apply static arguments to a provided type that accepts static arguments.|  
|[GetInvokerExpression](../vs140/itypeprovider.getinvokerexpression-method--fsharp-.md) : <xref:System.Reflection.MethodBase*> * [Quotations.Expr](../vs140/quotations.expr-class--fsharp-.md) [] -> [Quotations.Expr](../vs140/quotations.expr-class--fsharp-.md)|Called by the compiler to ask for an Expression tree to replace the given <xref:System.Reflection.MethodBase*> with.|  
|[GetGeneratedAssemblyContents](../vs140/itypeprovider.getgeneratedassemblycontents-method--fsharp-.md) : System.Reflection.Assembly -> [byte](../vs140/core.byte-type-abbreviation--fsharp-.md) []|Get the physical contents of the given logical provided assembly.|  
|[GetNamespaces](../vs140/itypeprovider.getnamespaces-method--fsharp-.md) : unit -> [IProvidedNamespace](../vs140/compilerservices.iprovidednamespace-interface--fsharp-.md) []|Namespace name that this type provider injects types into.|  
|[GetStaticParameters](../vs140/itypeprovider.getstaticparameters-method--fsharp-.md) : <xref:System.Type*> -> <xref:System.Reflection.ParameterInfo*> []|Get the static parameters for a provided type.|  
|[Invalidate](../vs140/itypeprovider.invalidate-event--fsharp-.md) : [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md)<<xref:System.EventHandler*>, <xref:System.EventArgs*>>|Triggered when an assumption changes that invalidates the resolutions so far reported by the provider.|  
|[remove_Invalidate](../vs140/itypeprovider.remove_invalidate-method--fsharp-.md) : <xref:System.EventHandler*> -> unit|Remove an event handler for the [Invalidate](../vs140/itypeprovider.invalidate-event--fsharp-.md) event.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)