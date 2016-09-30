---
title: "Quotations.Expr Class (F#)"
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
  - "Quotations.FSharpExpr"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpExpr"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Expr class [F#]"
  - "FSharpExpr class [F#]"
ms.assetid: ed6a2caf-69d4-45c2-ab97-e9b3be9bce65
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Quotations.Expr Class (F#)
Quoted expressions annotated with \<xref:System.Type*> values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This type is named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[CustomAttributes](../vs140/expr.customattributes-property--fsharp-.md)|Returns the custom attributes of an expression.|  
|[GetFreeVars](../vs140/expr.getfreevars-method--fsharp-.md)|Gets the free expression variables of an expression as a list.|  
|[Substitute](../vs140/expr.substitute-method--fsharp-.md)|Substitutes through the given expression using the given functions to map variables to new values. The functions must give consistent results at each application. Variable renaming may occur on the target expression if variable capture occurs.|  
|[ToString](../vs140/expr.tostring-method--fsharp-.md)|Formats the expression as a string.|  
|[Type](../vs140/expr.type-property--fsharp-.md)|Returns type of an expression.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[AddressOf](../vs140/expr.addressof-method--fsharp-.md)|Creates an expression that represents getting the address of a value.|  
|[AddressSet](../vs140/expr.addressset-method--fsharp-.md)|Creates an expression that represents setting the value held at a particular address.|  
|[Application](../vs140/expr.application-method--fsharp-.md)|Creates an expression that represents the application of a first class function value to a single argument.|  
|[Applications](../vs140/expr.applications-method--fsharp-.md)|Creates an expression that represents the application of a first class function value to multiple arguments.|  
|[Call](../vs140/expr.call-method--fsharp-.md)|Creates an expression that represents a call to an instance method associated with an object.|  
|[Cast](../vs140/expr.cast--t--method--fsharp-.md)|Returns a new typed expression given an underlying runtime-typed expression. A type annotation is usually required to use this function, and using an incorrect type annotation may result in a later runtime exception.|  
|[Coerce](../vs140/expr.coerce-method--fsharp-.md)|Creates an expression that represents the coercion of an expression to a type|  
|[DefaultValue](../vs140/expr.defaultvalue-method--fsharp-.md)|Creates an expression that represents the invocation of a default object constructor|  
|[Deserialize](../vs140/expr.deserialize-method--fsharp-.md)|This function is called automatically when quotation syntax (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) and related typed-expression quotations are used. The bytes are a pickled binary representation of an unlinked form of the quoted expression, and the \<xref:System.Type*> argument is any type in the assembly where the quoted expression occurs, that is, it helps scope the interpretation of the cross-assembly references in the bytes.|  
|[FieldGet](../vs140/expr.fieldget-method--fsharp-.md)|Creates an expression that represents the access of a field of an object.|  
|[FieldSet](../vs140/expr.fieldset-method--fsharp-.md)|Creates an expression that represents writing to a field of an object.|  
|[ForIntegerRangeLoop](../vs140/expr.forintegerrangeloop-method--fsharp-.md)|Creates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression that represent loops over integer ranges.|  
|[GlobalVar](../vs140/expr.globalvar--t--method--fsharp-.md)|Fetches or creates a new variable with the given name and type from a global pool of shared variables indexed by name and type. The type is given by the explicit or inferred type parameter.|  
|[IfThenElse](../vs140/expr.ifthenelse-method--fsharp-.md)|Creates an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> expression.|  
|[Lambda](../vs140/expr.lambda-method--fsharp-.md)|Creates an expression that represents the construction of an F# function value.|  
|[Let](../vs140/expr.let-method--fsharp-.md)|Creates expressions associated with let constructs.|  
|[LetRecursive](../vs140/expr.letrecursive-method--fsharp-.md)|Creates recursive expressions associated with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> constructs.|  
|[NewArray](../vs140/expr.newarray-method--fsharp-.md)|Creates an expression that represents the creation of an array value initialized with the given elements.|  
|[NewDelegate](../vs140/expr.newdelegate-method--fsharp-.md)|Creates an expression that represents the creation of a delegate value for the given type.|  
|[NewObject](../vs140/expr.newobject-method--fsharp-.md)|Creates an expression that represents the invocation of an object constructor.|  
|[NewRecord](../vs140/expr.newrecord-method--fsharp-.md)|Creates record-construction expressions.|  
|[NewTuple](../vs140/expr.newtuple-method--fsharp-.md)|Creates an expression that represents the creation of an F# tuple value.|  
|[NewUnionCase](../vs140/expr.newunioncase-method--fsharp-.md)|Creates an expression that represents the creation of a union case value.|  
|[PropertyGet](../vs140/expr.propertyget-method--fsharp-.md)|Creates an expression that represents reading a static property.|  
|[PropertySet](../vs140/expr.propertyset-method--fsharp-.md)|Creates an expression that represents writing to a static property.|  
|[Quote](../vs140/expr.quote-method--fsharp-.md)|Creates an expression that represents a nested quotation literal.|  
|[RegisterReflectedDefinitions](../vs140/expr.registerreflecteddefinitions-method--fsharp-.md)|Permits interactive environments such as F# Interactive to explicitly register new pickled resources that represent persisted top level definitions. The string indicates a unique name for the resources being added. The format for the bytes is the encoding generated by the F# compiler.|  
|[Sequential](../vs140/expr.sequential-method--fsharp-.md)|Creates an expression that represents the sequential execution of one expression followed by another.|  
|[TryFinally](../vs140/expr.tryfinally-method--fsharp-.md)|Creates an expression that represents a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> construct.|  
|[TryGetReflectedDefinition](../vs140/expr.trygetreflecteddefinition-method--fsharp-.md)|Try and find a stored reflection definition for the given method. Stored reflection definitions are added to an F# assembly through the use of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute.|  
|[TryWith](../vs140/expr.trywith-method--fsharp-.md)|Creates an expression that represents a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> construct for exception filtering and catching.|  
|[TupleGet](../vs140/expr.tupleget-method--fsharp-.md)|Creates an expression that represents getting a field of a tuple.|  
|[TypeTest](../vs140/expr.typetest-method--fsharp-.md)|Creates an expression that represents a type test.|  
|[UnionCaseTest](../vs140/expr.unioncasetest-method--fsharp-.md)|Creates an expression that represents a test of a value is of a particular union case.|  
|[Value](../vs140/expr.value--t--method--fsharp-.md)|Creates an expression that represents a constant value.|  
|[Value](../vs140/expr.value-method--fsharp-.md)|Creates an expression that represents a constant value of a particular type.|  
|[Var](../vs140/expr.var-method--fsharp-.md)|Creates an expression that represents a variable.|  
|[VarSet](../vs140/expr.varset-method--fsharp-.md)|Creates an expression that represents setting a mutable variable.|  
|[WhileLoop](../vs140/expr.whileloop-method--fsharp-.md)|Creates an expression that represents a while loop.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)