---
title: "Quotations.Patterns Module (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Quotations.Patterns
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Quotations.PatternsModule
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Patterns module [F#]
  - PatternsModule module [F#]
ms.assetid: 093944a9-c752-403a-8983-5fcd5dbf92a4
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Quotations.Patterns Module (F#)
Contains a set of primitive F# active patterns to analyze F# expression objects.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Patterns  
```  
  
## Remarks  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[AddressOf](../vs140/patterns.addressof-active-pattern--fsharp-.md)  `: Expr -> Expr option`|Recognizes expressions that represent getting the address of a value.|  
|[AddressSet](../vs140/patterns.addressset-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions that represent setting the value held at an address .|  
|[Application](../vs140/patterns.application-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions that represent applications of first class function values.|  
|[Call](../vs140/patterns.call-active-pattern--fsharp-.md)  `: Expr -> (Expr option * MethodInfo * Expr list) option`|Recognizes expressions that represent calls to static and instance methods, and functions defined in modules.|  
|[Coerce](../vs140/patterns.coerce-active-pattern--fsharp-.md)  `: Expr -> (Expr * Type) option`|Recognizes expressions that represent coercions from one type to another.|  
|[DefaultValue](../vs140/patterns.defaultvalue-active-pattern--fsharp-.md)  `: Expr -> Type option`|Recognizes expressions that represent invocations of a default constructor of a structure.|  
|[FieldGet](../vs140/patterns.fieldget-active-pattern--fsharp-.md)  `: Expr -> (Expr option * FieldInfo)`|Recognizes expressions that represent getting a static or instance field.|  
|[FieldSet](../vs140/patterns.fieldset-active-pattern--fsharp-.md)  `: Expr -> (Expr option * FieldInfo * Expr) option`|Recognizes expressions that represent setting a static or instance field.|  
|[ForIntegerRangeLoop](../vs140/patterns.forintegerrangeloop-active-pattern--fsharp-.md)  `: Expr -> (Var * Expr * Expr * Expr) option`|Recognizes expressions that represent loops over integer ranges.|  
|[IfThenElse](../vs140/patterns.ifthenelse-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr * Expr) option`|Recognizes expressions that represent conditionals.|  
|[Lambda](../vs140/patterns.lambda-active-pattern--fsharp-.md)  `: Expr -> (Var * Expr) option`|Recognizes expressions that represent first class function values.|  
|[LetRecursive](../vs140/patterns.letrecursive-active-pattern--fsharp-.md)  `: Expr -> ((Var * Expr) list * Expr) option`|Recognizes expressions that represent recursive let bindings of one or more variables.|  
|[Let](../vs140/patterns.let-active-pattern--fsharp-.md)  `: Expr -> (Var * Expr * Expr) option`|Recognizes expressions that represent let bindings.|  
|[NewArray](../vs140/patterns.newarray-active-pattern--fsharp-.md)  `: Expr -> (Type * Expr list) option`|Recognizes expressions that represent the construction of arrays.|  
|[NewDelegate](../vs140/patterns.newdelegate-active-pattern--fsharp-.md)  `: Expr -> (Type * Var list * Expr) option`|Recognizes expressions that represent construction of delegate values.|  
|[NewObject](../vs140/patterns.newobject-active-pattern--fsharp-.md)  `: Expr -> (ConstructorInfo * Expr list) option`|Recognizes expressions that represent invocation of object constructors.|  
|[NewRecord](../vs140/patterns.newrecord-active-pattern--fsharp-.md)  `: Expr -> (Type * Expr list) option`|Recognizes expressions that represent construction of record values.|  
|[NewTuple](../vs140/patterns.newtuple-active-pattern--fsharp-.md)  `: Expr -> (Expr list) option`|Recognizes expressions that represent construction of tuple values.|  
|[NewUnionCase](../vs140/patterns.newunioncase-active-pattern--fsharp-.md)  `: Expr -> (UnionCaseInfo * Expr list) option`|Recognizes expressions that represent construction of particular union case values.|  
|[PropertyGet](../vs140/patterns.propertyget-active-pattern--fsharp-.md)  `: Expr -> (Expr option * PropertyInfo * Expr list) option`|Recognizes expressions that represent the read of a static or instance property, or a non-function value declared in a module.|  
|[PropertySet](../vs140/patterns.propertyset-active-pattern--fsharp-.md)  `: Expr -> (Expr option * PropertyInfo * Expr list * Expr) option`|Recognizes expressions that represent setting a static or instance property, or a non-function value declared in a module.|  
|[Quote](../vs140/patterns.quote-active-pattern--fsharp-.md)  `: Expr -> Expr option`|Recognizes expressions that represent a nested quotation literal.|  
|[Sequential](../vs140/patterns.sequential-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions that represent sequential execution of one expression followed by another.|  
|[TryFinally](../vs140/patterns.tryfinally-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions that represent a `try...finally` construct.|  
|[TryWith](../vs140/patterns.trywith-active-pattern--fsharp-.md)  `: Expr -> (Expr * Var * Expr * Var * Expr) option`|Recognizes expressions that represent a `try...with` construct for exception filtering and catching.|  
|[TupleGet](../vs140/patterns.tupleget-active-pattern--fsharp-.md)  `: Expr -> (Expr * int) option`|Recognizes expressions that represent getting a tuple field.|  
|[TypeTest](../vs140/patterns.typetest-active-pattern--fsharp-.md)  `: Expr -> (Expr * Type) option`|Recognizes expressions that represent a dynamic type test.|  
|[UnionCaseTest](../vs140/patterns.unioncasetest-active-pattern--fsharp-.md)  `: Expr -> (Expr * UnionCaseInfo) option`|Recognizes expressions that represent a test if a value is of a particular union case.|  
|[Value](../vs140/patterns.value-active-pattern--fsharp-.md)  `: Expr -> (obj * Type) option`|Recognizes expressions that represent a constant value.|  
|[VarSet](../vs140/patterns.varset-active-pattern--fsharp-.md)  `: Expr -> (Var * Expr) option`|Recognizes expressions that represent setting a mutable variable.|  
|[Var](../vs140/patterns.var-active-pattern--fsharp-.md)  `: Expr -> Var option`|Recognizes expressions that represent a variable.|  
|[WhileLoop](../vs140/patterns.whileloop-active-pattern--fsharp-.md)  `: Expr -> (Expr * Expr) option`|Recognizes expressions that represent while loops.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)