---
title: "Microsoft.FSharp.Core Namespace (F#)"
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
  - "Microsoft.FSharp.Core"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Microsoft.FSharp.Core namespace [F#]"
ms.assetid: 58298472-1928-421a-afca-75609ab054da
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft.FSharp.Core Namespace (F#)
This namespace contains functionality that supports core F# functionality, including language primitives, operators, attributes, primitive types, strings, and formatted I/O.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
namespace Microsoft.FSharp.Core  
```  
  
## Remarks  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [ExtraTopLevelOperators](../vs140/core.extratopleveloperators-module--fsharp-.md)|Additional F# operators and types that are available without opening a module or namespace.|  
|module [LanguagePrimitives](../vs140/core.languageprimitives-module--fsharp-.md)|Language primitives associated with the F# language|  
|module [NumericLiterals](../vs140/core.numericliterals-module--fsharp-.md)|Provides a default implementations of F# numeric literal syntax for literals fo the form 'dddI'.|  
|module [Operators](../vs140/core.operators-module--fsharp-.md)|Basic F# Operators. This module is automatically opened in all F# code.|  
|module [OptimizedClosures](../vs140/core.optimizedclosures-module--fsharp-.md)|An implementation module used to hold some private implementations of function value invocation.|  
|module [Option](../vs140/core.option-module--fsharp-.md)|Basic operations on options.|  
|module [Printf](../vs140/core.printf-module--fsharp-.md)|Extensible printf-style formatting for numbers and other datatypes|  
|module [String](../vs140/core.string-module--fsharp-.md)|Functional programming operators for string processing. Further string operations are available via the member functions on strings and other functionality in <xref:System.String*> and <xref:System.Text.RegularExpressions.Regex*> types.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [&#91;,,,&#93;<'T>](../vs140/core.--t--type--fsharp-1.md)|Four dimensional arrays, typically zero-based. Non-zero-based arrays can be created using methods on the System.Array type.|  
|type [&#91;,,&#93;<'T>](../vs140/core.--t--type--fsharp-3.md)|Three dimensional arrays, typically zero-based. Non-zero-based arrays can be created using methods on the System.Array type.|  
|type [&#91;,&#93;<'T>](../vs140/core.--t--type--fsharp-4.md)|Two dimensional arrays, typically zero-based.|  
|type [&#91;&#93;<'T>](../vs140/core.--t--type--fsharp-2.md)|Single dimensional, zero-based arrays, written `int[]`, `string[]` and so on.|  
|type [AbstractClassAttribute](../vs140/core.abstractclassattribute-class--fsharp-.md)|Adding this attribute to class definition makes it abstract, which means it need not implement all its methods. Instances of abstract classes may not be constructed directly.|  
|type [AllowNullLiteralAttribute](../vs140/core.allownullliteralattribute-class--fsharp-.md)|Adding this attribute to a type lets the 'null' literal be used for the type within F# code. This attribute may only be added to F#-defined class or interface types.|  
|type [AutoOpenAttribute](../vs140/core.autoopenattribute-class--fsharp-.md)|This attribute is used for two purposes. When applied to an assembly, it must be given a string argument, and this argument must indicate a valid module or namespace in that assembly. Source code files compiled with a reference to this assembly are processed in an environment where the given path is automatically oepned.|  
|type [AutoSerializableAttribute](../vs140/core.autoserializableattribute-class--fsharp-.md)|Adding this attribute to a type with value 'false' disables the behaviour where F# makes the type Serializable by default.|  
|type [byref<'T>](../vs140/core.byref--t--type--fsharp-.md)|Represents a managed pointer in F# code.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5,'T6,'T7>](../vs140/core.choice--t1--t2--t3--t4--t5--t6--t7--union--fsharp-.md)|Helper types for active patterns with 7 choices.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5,'T6>](../vs140/core.choice--t1--t2--t3--t4--t5--t6--union--fsharp-.md)|Helper types for active patterns with 6 choices.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5>](../vs140/core.choice--t1--t2--t3--t4--t5--union--fsharp-.md)|Helper types for active patterns with 5 choices.|  
|type [Choice<'T1,'T2,'T3,'T4>](../vs140/core.choice--t1--t2--t3--t4--union--fsharp-.md)|Helper types for active patterns with 4 choices.|  
|type [Choice<'T1,'T2,'T3>](../vs140/core.choice--t1--t2--t3--union--fsharp-.md)|Helper types for active patterns with 3 choices.|  
|type [Choice<'T1,'T2>](../vs140/core.choice--t1--t2--union--fsharp-.md)|Helper types for active patterns with 2 choices.|  
|type [ClassAttribute](../vs140/core.classattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI class.|  
|type [CLIEventAttribute](../vs140/core.clieventattribute-class--fsharp-.md)|Adding this attribute to a property with event type causes it to be compiled with as a CLI metadata event, through a syntactic translation to a pair of 'add_EventName' and 'remove_EventName' methods.|  
|type [CLIMutableAttribute](../vs140/core.climutableattribute-class--fsharp-.md)|Adding this attribute to a record type causes it to be compiled to a CLI representation with a default constructor with property getters and setters.|  
|type [ComparisonConditionalOnAttribute](../vs140/core.comparisonconditionalonattribute-class--fsharp-.md)|This attribute is used to indicate a generic container type satisfies the F# 'comparison' constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter 'T on a type definition C<'T> means that a type C<X\> only supports comparison if the type X also supports comparison and all other conditions for C<X\> to support comparison are also met. The type C<'T> can still be used with other type arguments, but a type such as C<(int -> int)> will not support comparison because the type (int -> int) is an F# function type and does not support comparison.|  
|type [CompilationArgumentCountsAttribute](../vs140/core.compilationargumentcountsattribute-class--fsharp-.md)|This attribute is generated automatically by the F# compiler to tag functions and members that accept a partial application of some of their arguments and return a residual function|  
|type [CompilationMappingAttribute](../vs140/core.compilationmappingattribute-class--fsharp-.md)|This attribute is inserted automatically by the F# compiler to tag types and methods in the generated CLI code with flags indicating the correspondence with original source constructs. It is used by the functions in the Microsoft.FSharp.Reflection namespace to reverse-map compiled constructs to their original forms. It is not intended for use from user code.|  
|type [CompilationRepresentationAttribute](../vs140/core.compilationrepresentationattribute-class--fsharp-.md)|This attribute is used to adjust the runtime representation for a type. For example, it may be used to note that the `null` representation may be used for a type. This affects how some constructs are compiled.|  
|type [CompilationRepresentationFlags](../vs140/core.compilationrepresentationflags-enumeration--fsharp-.md)|Indicates one or more adjustments to the compiled representation of an F# type or member.|  
|type [CompilationSourceNameAttribute](../vs140/core.compilationsourcenameattribute-class--fsharp-.md)|This attribute is inserted automatically by the F# compiler to tag methods which are given the 'CompiledName' attribute. It is not intended for use from user code.|  
|type [CompiledNameAttribute](../vs140/core.compilednameattribute-class--fsharp-.md)|Adding this attribute to a value or function definition in an F# module changes the name used for the value in compiled CLI code.|  
|type [CompilerMessageAttribute](../vs140/core.compilermessageattribute-class--fsharp-.md)|Indicates that a message should be emitted when F# source code uses this construct.|  
|type [CustomComparisonAttribute](../vs140/core.customcomparisonattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type with a user-defined implementation of comparison.|  
|type [CustomEqualityAttribute](../vs140/core.customequalityattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type with a user-defined implementation of equality.|  
|type [CustomOperationAttribute](../vs140/core.customoperationattribute-class--fsharp-.md)|Indicates that a member on a computation builder type is a custom query operator, and indicates the name of that operator.|  
|type [decimal<'Measure>](../vs140/core.decimal--measure--type--fsharp-.md)|The type of decimal numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Decimal`.|  
|type [DefaultAugmentationAttribute](../vs140/core.defaultaugmentationattribute-class--fsharp-.md)|Adding this attribute to a discriminated union with value false turns off the generation of standard helper member tester, constructor and accessor members for the generated CLI class for that type.|  
|type [DefaultValueAttribute](../vs140/core.defaultvalueattribute-class--fsharp-.md)|Adding this attribute to a field declaration means that the field is not initialized. During type checking a constraint is asserted that the field type supports 'null'. If the 'check' value is false then the constraint is not asserted.|  
|type [EntryPointAttribute](../vs140/core.entrypointattribute-class--fsharp-.md)|Adding this attribute to a function indicates it is the entrypoint for an application. If this absent is not speficied for an EXE then the initialization implicit in the module bindings in the last file in the compilation sequence are used as the entrypoint.|  
|type [EqualityConditionalOnAttribute](../vs140/core.equalityconditionalonattribute-class--fsharp-.md)|This attribute is used to indicate a generic container type satisfies the F# 'equality' constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter 'T on a type definition C<'T> means that a type C<X\> only supports equality if the type X also supports equality and all other conditions for C<X\> to support equality are also met. The type C<'T> can still be used with other type arguments, but a type such as C<(int -> int)> will not support equality because the type (int -> int) is an F# function type and does not support equality.|  
|type [ExperimentalAttribute](../vs140/core.experimentalattribute-class--fsharp-.md)|This attribute is used to tag values that are part of an experimental library feature.|  
|type [float<'Measure>](../vs140/core.float--measure--type--fsharp-.md)|The type of floating point numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Double`.|  
|type [float32<'Measure>](../vs140/core.float32--measure--type--fsharp-.md)|The type of floating point numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Single`.|  
|type [FSharpFunc<'T,'U>](../vs140/core.fsharpfunc--t--u--class--fsharp-.md)|The CLI type used to represent F# function values. This type is not typically used directly, though may be used from other CLI languages.|  
|type [FSharpInterfaceDataVersionAttribute](../vs140/core.fsharpinterfacedataversionattribute-class--fsharp-.md)|This attribute is added to generated assemblies to indicate the version of the data schema used to encode additional F# specific information in the resource attached to compiled F# libraries.|  
|type [FSharpTypeFunc](../vs140/core.fsharptypefunc-class--fsharp-.md)|The CLI type used to represent F# first-class type function values. This type is for use by compiled F# code.|  
|type [FuncConvert](../vs140/core.funcconvert-class--fsharp-.md)|Helper functions for converting F# first class function values to and from CLI representaions of functions using delegates.|  
|type [GeneralizableValueAttribute](../vs140/core.generalizablevalueattribute-class--fsharp-.md)|Adding this attribute to a non-function value with generic parameters indicates that uses of the construct can give rise to generic code through type inference.|  
|type [ilsigptr<'T>](../vs140/core.ilsigptr--t--type--fsharp-.md)|This type is for internal use by the F# code generator.|  
|type [int<'Measure>](../vs140/core.int--measure--type--fsharp-.md)|The type of 32-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int32`.|  
|type [int16<'Measure>](../vs140/core.int16--measure--type--fsharp-.md)|The type of 16-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int16`.|  
|type [int64<'Measure>](../vs140/core.int64--measure--type--fsharp-.md)|The type of 64-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int64`.|  
|type [InterfaceAttribute](../vs140/core.interfaceattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI interface.|  
|type [LiteralAttribute](../vs140/core.literalattribute-class--fsharp-.md)|Adding this attribute to a value causes it to be compiled as a CLI constant literal.|  
|type [MeasureAnnotatedAbbreviationAttribute](../vs140/core.measureannotatedabbreviationattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be interpreted as a refined type, currently limited to measure-parameterized types. This may only be used under very limited conditions.|  
|type [MeasureAttribute](../vs140/core.measureattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be interpreted as a unit of measure. This may only be used under very limited conditions.|  
|type [nativeptr<'T>](../vs140/core.nativeptr--t--type--fsharp-.md)|Represents an unmanaged pointer in F# code.|  
|type [NoComparisonAttribute](../vs140/core.nocomparisonattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type where comparison is an abnormal operation. This means that the type does not satisfy the F# 'comparison' constraint. Within the bounds of the F# type system, this helps ensure that the F# generic comparison function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.|  
|type [NoDynamicInvocationAttribute](../vs140/core.nodynamicinvocationattribute-class--fsharp-.md)|This attribute is used to tag values that may not be dynamically invoked at runtime. This is typically added to inlined functions whose implementations include unverifiable code. It causes the method body emitted for the inlined function to raise an exception if dynamically invoked, rather than including the unverifiable code in the generated assembly.|  
|type [NoEqualityAttribute](../vs140/core.noequalityattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type where equality is an abnormal operation. This means that the type does not satisfy the F# 'equality' constraint. Within the bounds of the F# type system, this helps ensure that the F# generic equality function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.|  
|type [Option<'T>](../vs140/core.option--t--union--fsharp-.md)|The type of optional values. When used from other CLI languages the empty option is the `null` value.|  
|type [OptionalArgumentAttribute](../vs140/core.optionalargumentattribute-class--fsharp-.md)|This attribute is added automatically for all optional arguments.|  
|type [PrintfFormat<'Printer,'State,'Residue,'Result,'Tuple>](../vs140/core.printfformat--printer--state--residue--result--tuple--class--fsharp-.md)|Type of a formatting expression.|  
|type [PrintfFormat<'Printer,'State,'Residue,'Result>](../vs140/core.printfformat--printer--state--residue--result--class--fsharp-.md)|Type of a formatting expression.|  
|type [ProjectionParameterAttribute](../vs140/core.projectionparameterattribute-class--fsharp-.md)|Indicates that, when a custom operator is used in a computation expression, a parameter is automatically parameterized by the variable space of the computation expression.|  
|type [Ref<'T>](../vs140/core.ref--t--record--fsharp-.md)|The type of mutable references. Use the functions [:=] and [!] to get and set values of this type.|  
|type [ReferenceEqualityAttribute](../vs140/core.referenceequalityattribute-class--fsharp-.md)|Adding this attribute to a record or union type disables the automatic generation of overrides for 'System.Object.Equals(obj)', 'System.Object.GetHashCode()' and 'System.IComparable' for the type. The type will by default use reference equality.|  
|type [ReflectedDefinitionAttribute](../vs140/core.reflecteddefinitionattribute-class--fsharp-.md)|Adding this attribute to the let-binding for the definition of a top-level value makes the quotation expression that implements the value available for use at runtime.|  
|type [RequireQualifiedAccessAttribute](../vs140/core.requirequalifiedaccessattribute-class--fsharp-.md)|This attribute is used to indicate that references to a the elements of a module, record or union type require explicit qualified access.|  
|type [RequiresExplicitTypeArgumentsAttribute](../vs140/core.requiresexplicittypeargumentsattribute-class--fsharp-.md)|Adding this attribute to a type, value or member requires that uses of the construct must explicitly instantiate any generic type parameters.|  
|type [sbyte<'Measure>](../vs140/core.sbyte--measure--type--fsharp-.md)|The type of 8-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.SByte`.|  
|type [SealedAttribute](../vs140/core.sealedattribute-class--fsharp-.md)|Adding this attribute to class definition makes it sealed, which means it may not be extended or implemented.|  
|type [SourceConstructFlags](../vs140/core.sourceconstructflags-enumeration--fsharp-.md)|Indicates the relationship between a compiled entity in a CLI binary and an element in F# source code.|  
|type [StructAttribute](../vs140/core.structattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI struct.|  
|type [StructuralComparisonAttribute](../vs140/core.structuralcomparisonattribute-class--fsharp-.md)|Adding this attribute to a record, union, exception, or struct type confirms the automatic generation of implementations for 'System.IComparable' for the type.|  
|type [StructuralEqualityAttribute](../vs140/core.structuralequalityattribute-class--fsharp-.md)|Adding this attribute to a record, union or struct type confirms the automatic generation of overrides for 'System.Object.Equals(obj)' and 'System.Object.GetHashCode()' for the type.|  
|type [StructuredFormatDisplayAttribute](../vs140/core.structuredformatdisplayattribute-class--fsharp-.md)|This attribute is used to mark how a type is displayed by default when using '%A' printf formatting patterns and other two-dimensional text-based display layouts. In this version of F# the only valid values are of the form `PreText {PropertyName} PostText`. The property name indicates a property to evaluate and to display instead of the object itself.|  
|type [Unit](../vs140/core.unit-type--fsharp-.md)|The type 'unit', which has only one value "()". This value is special and always uses the representation 'null'.|  
|type [UnverifiableAttribute](../vs140/core.unverifiableattribute-class--fsharp-.md)|This attribute is used to tag values whose use will result in the generation of unverifiable code. These values are inevitably marked 'inline' to ensure that the unverifiable constructs are not present in the actual code for the F# library, but are rather copied to the source code of the caller.|  
|type [VolatileFieldAttribute](../vs140/core.volatilefieldattribute-class--fsharp-.md)|Adding this attribute to an F# mutable binding causes the "volatile" prefix to be used for all accesses to the field.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [array<'T>](../vs140/core.array--t--type-abbreviation--fsharp-.md)|Single dimensional, zero-based arrays, written `int[]`, `string[]` etc.|  
|type [bigint](../vs140/core.bigint-type-abbreviation--fsharp-.md)|Arbitrarily large integers. An abbreviation for the type <xref:System.Numerics.BigInteger*>.|  
|type [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Boolean*>.|  
|type [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Byte*>.|  
|type [char](../vs140/core.char-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Char*>.|  
|type [decimal](../vs140/core.decimal-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Decimal*>.|  
|type [double](../vs140/core.double-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Double*>.|  
|type [exn](../vs140/core.exn-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Exception*>.|  
|type [float](../vs140/core.float-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Double*>.|  
|type [float32](../vs140/core.float32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Single*>.|  
|type [Format<'Printer,'State,'Residue,'Result,'Tuple>](../vs140/core.format--printer--state--residue--result--tuple--type-abbreviation--fsharp-.md)|Type of a formatting expression.|  
|type [Format<'Printer,'State,'Residue,'Result>](../vs140/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md)|Type of a formatting expression.|  
|type [int](../vs140/core.int-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int32*>.|  
|type [int16](../vs140/core.int16-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int16*>.|  
|type [int32](../vs140/core.int32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int32*>.|  
|type [int64](../vs140/core.int64-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int64*>.|  
|type [int8](../vs140/core.int8-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.SByte*>.|  
|type [nativeint](../vs140/core.nativeint-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.IntPtr*>.|  
|type [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Object*>.|  
|type [option<'T>](../vs140/core.option--t--type-abbreviation--fsharp-.md)|The type of optional values. When used from other CLI languages the empty option is the `null` value.|  
|type [ref<'T>](../vs140/core.ref--t--type-abbreviation--fsharp-.md)|The type of mutable references. Use the functions [:=] and [!] to get and set values of this type.|  
|type [sbyte](../vs140/core.sbyte-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.SByte*>.|  
|type [single](../vs140/core.single-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Single*>.|  
|type [string](../vs140/core.string-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.String*>.|  
|type [uint16](../vs140/core.uint16-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt16*>.|  
|type [uint32](../vs140/core.uint32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt32*>.|  
|type [uint64](../vs140/core.uint64-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt64*>.|  
|type [uint8](../vs140/core.uint8-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Byte*>.|  
|type [unativeint](../vs140/core.unativeint-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UIntPtr*>.|  
|type [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)|The type 'unit', which has only one value "()". This value is special and always uses the representation 'null'.|  
  
## Exceptions  
  
|Exception|Description|  
|---------------|-----------------|  
|exception [MatchFailureException](../vs140/core.matchfailureexception-exception--fsharp-.md)|Non-exhaustive match failures will raise the MatchFailureException exception|  
  
## See Also  
 [F# Library Reference](../vs140/fsharp-core-library-reference.md)