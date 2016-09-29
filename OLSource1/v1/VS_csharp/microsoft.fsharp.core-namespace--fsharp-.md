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
|module [ExtraTopLevelOperators](../VS_csharp/core.extratopleveloperators-module--fsharp-.md)|Additional F# operators and types that are available without opening a module or namespace.|  
|module [LanguagePrimitives](../VS_csharp/core.languageprimitives-module--fsharp-.md)|Language primitives associated with the F# language|  
|module [NumericLiterals](../VS_csharp/core.numericliterals-module--fsharp-.md)|Provides a default implementations of F# numeric literal syntax for literals fo the form 'dddI'.|  
|module [Operators](../VS_csharp/core.operators-module--fsharp-.md)|Basic F# Operators. This module is automatically opened in all F# code.|  
|module [OptimizedClosures](../VS_csharp/core.optimizedclosures-module--fsharp-.md)|An implementation module used to hold some private implementations of function value invocation.|  
|module [Option](../VS_csharp/core.option-module--fsharp-.md)|Basic operations on options.|  
|module [Printf](../VS_csharp/core.printf-module--fsharp-.md)|Extensible printf-style formatting for numbers and other datatypes|  
|module [String](../VS_csharp/core.string-module--fsharp-.md)|Functional programming operators for string processing. Further string operations are available via the member functions on strings and other functionality in <xref:System.String*> and <xref:System.Text.RegularExpressions.Regex*> types.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [&#91;,,,&#93;<'T>](../VS_csharp/core.--t--type--fsharp-1.md)|Four dimensional arrays, typically zero-based. Non-zero-based arrays can be created using methods on the System.Array type.|  
|type [&#91;,,&#93;<'T>](../VS_csharp/core.--t--type--fsharp-3.md)|Three dimensional arrays, typically zero-based. Non-zero-based arrays can be created using methods on the System.Array type.|  
|type [&#91;,&#93;<'T>](../VS_csharp/core.--t--type--fsharp-4.md)|Two dimensional arrays, typically zero-based.|  
|type [&#91;&#93;<'T>](../VS_csharp/core.--t--type--fsharp-2.md)|Single dimensional, zero-based arrays, written `int[]`, `string[]` and so on.|  
|type [AbstractClassAttribute](../VS_csharp/core.abstractclassattribute-class--fsharp-.md)|Adding this attribute to class definition makes it abstract, which means it need not implement all its methods. Instances of abstract classes may not be constructed directly.|  
|type [AllowNullLiteralAttribute](../VS_csharp/core.allownullliteralattribute-class--fsharp-.md)|Adding this attribute to a type lets the 'null' literal be used for the type within F# code. This attribute may only be added to F#-defined class or interface types.|  
|type [AutoOpenAttribute](../VS_csharp/core.autoopenattribute-class--fsharp-.md)|This attribute is used for two purposes. When applied to an assembly, it must be given a string argument, and this argument must indicate a valid module or namespace in that assembly. Source code files compiled with a reference to this assembly are processed in an environment where the given path is automatically oepned.|  
|type [AutoSerializableAttribute](../VS_csharp/core.autoserializableattribute-class--fsharp-.md)|Adding this attribute to a type with value 'false' disables the behaviour where F# makes the type Serializable by default.|  
|type [byref<'T>](../VS_csharp/core.byref--t--type--fsharp-.md)|Represents a managed pointer in F# code.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5,'T6,'T7>](../VS_csharp/core.choice--t1--t2--t3--t4--t5--t6--t7--union--fsharp-.md)|Helper types for active patterns with 7 choices.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5,'T6>](../VS_csharp/core.choice--t1--t2--t3--t4--t5--t6--union--fsharp-.md)|Helper types for active patterns with 6 choices.|  
|type [Choice<'T1,'T2,'T3,'T4,'T5>](../VS_csharp/core.choice--t1--t2--t3--t4--t5--union--fsharp-.md)|Helper types for active patterns with 5 choices.|  
|type [Choice<'T1,'T2,'T3,'T4>](../VS_csharp/core.choice--t1--t2--t3--t4--union--fsharp-.md)|Helper types for active patterns with 4 choices.|  
|type [Choice<'T1,'T2,'T3>](../VS_csharp/core.choice--t1--t2--t3--union--fsharp-.md)|Helper types for active patterns with 3 choices.|  
|type [Choice<'T1,'T2>](../VS_csharp/core.choice--t1--t2--union--fsharp-.md)|Helper types for active patterns with 2 choices.|  
|type [ClassAttribute](../VS_csharp/core.classattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI class.|  
|type [CLIEventAttribute](../VS_csharp/core.clieventattribute-class--fsharp-.md)|Adding this attribute to a property with event type causes it to be compiled with as a CLI metadata event, through a syntactic translation to a pair of 'add_EventName' and 'remove_EventName' methods.|  
|type [CLIMutableAttribute](../VS_csharp/core.climutableattribute-class--fsharp-.md)|Adding this attribute to a record type causes it to be compiled to a CLI representation with a default constructor with property getters and setters.|  
|type [ComparisonConditionalOnAttribute](../VS_csharp/core.comparisonconditionalonattribute-class--fsharp-.md)|This attribute is used to indicate a generic container type satisfies the F# 'comparison' constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter 'T on a type definition C<'T> means that a type C<X\> only supports comparison if the type X also supports comparison and all other conditions for C<X\> to support comparison are also met. The type C<'T> can still be used with other type arguments, but a type such as C<(int -> int)> will not support comparison because the type (int -> int) is an F# function type and does not support comparison.|  
|type [CompilationArgumentCountsAttribute](../VS_csharp/core.compilationargumentcountsattribute-class--fsharp-.md)|This attribute is generated automatically by the F# compiler to tag functions and members that accept a partial application of some of their arguments and return a residual function|  
|type [CompilationMappingAttribute](../VS_csharp/core.compilationmappingattribute-class--fsharp-.md)|This attribute is inserted automatically by the F# compiler to tag types and methods in the generated CLI code with flags indicating the correspondence with original source constructs. It is used by the functions in the Microsoft.FSharp.Reflection namespace to reverse-map compiled constructs to their original forms. It is not intended for use from user code.|  
|type [CompilationRepresentationAttribute](../VS_csharp/core.compilationrepresentationattribute-class--fsharp-.md)|This attribute is used to adjust the runtime representation for a type. For example, it may be used to note that the `null` representation may be used for a type. This affects how some constructs are compiled.|  
|type [CompilationRepresentationFlags](../VS_csharp/core.compilationrepresentationflags-enumeration--fsharp-.md)|Indicates one or more adjustments to the compiled representation of an F# type or member.|  
|type [CompilationSourceNameAttribute](../VS_csharp/core.compilationsourcenameattribute-class--fsharp-.md)|This attribute is inserted automatically by the F# compiler to tag methods which are given the 'CompiledName' attribute. It is not intended for use from user code.|  
|type [CompiledNameAttribute](../VS_csharp/core.compilednameattribute-class--fsharp-.md)|Adding this attribute to a value or function definition in an F# module changes the name used for the value in compiled CLI code.|  
|type [CompilerMessageAttribute](../VS_csharp/core.compilermessageattribute-class--fsharp-.md)|Indicates that a message should be emitted when F# source code uses this construct.|  
|type [CustomComparisonAttribute](../VS_csharp/core.customcomparisonattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type with a user-defined implementation of comparison.|  
|type [CustomEqualityAttribute](../VS_csharp/core.customequalityattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type with a user-defined implementation of equality.|  
|type [CustomOperationAttribute](../VS_csharp/core.customoperationattribute-class--fsharp-.md)|Indicates that a member on a computation builder type is a custom query operator, and indicates the name of that operator.|  
|type [decimal<'Measure>](../VS_csharp/core.decimal--measure--type--fsharp-.md)|The type of decimal numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Decimal`.|  
|type [DefaultAugmentationAttribute](../VS_csharp/core.defaultaugmentationattribute-class--fsharp-.md)|Adding this attribute to a discriminated union with value false turns off the generation of standard helper member tester, constructor and accessor members for the generated CLI class for that type.|  
|type [DefaultValueAttribute](../VS_csharp/core.defaultvalueattribute-class--fsharp-.md)|Adding this attribute to a field declaration means that the field is not initialized. During type checking a constraint is asserted that the field type supports 'null'. If the 'check' value is false then the constraint is not asserted.|  
|type [EntryPointAttribute](../VS_csharp/core.entrypointattribute-class--fsharp-.md)|Adding this attribute to a function indicates it is the entrypoint for an application. If this absent is not speficied for an EXE then the initialization implicit in the module bindings in the last file in the compilation sequence are used as the entrypoint.|  
|type [EqualityConditionalOnAttribute](../VS_csharp/core.equalityconditionalonattribute-class--fsharp-.md)|This attribute is used to indicate a generic container type satisfies the F# 'equality' constraint only if a generic argument also satisfies this constraint. For example, adding this attribute to parameter 'T on a type definition C<'T> means that a type C<X\> only supports equality if the type X also supports equality and all other conditions for C<X\> to support equality are also met. The type C<'T> can still be used with other type arguments, but a type such as C<(int -> int)> will not support equality because the type (int -> int) is an F# function type and does not support equality.|  
|type [ExperimentalAttribute](../VS_csharp/core.experimentalattribute-class--fsharp-.md)|This attribute is used to tag values that are part of an experimental library feature.|  
|type [float<'Measure>](../VS_csharp/core.float--measure--type--fsharp-.md)|The type of floating point numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Double`.|  
|type [float32<'Measure>](../VS_csharp/core.float32--measure--type--fsharp-.md)|The type of floating point numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Single`.|  
|type [FSharpFunc<'T,'U>](../VS_csharp/core.fsharpfunc--t--u--class--fsharp-.md)|The CLI type used to represent F# function values. This type is not typically used directly, though may be used from other CLI languages.|  
|type [FSharpInterfaceDataVersionAttribute](../VS_csharp/core.fsharpinterfacedataversionattribute-class--fsharp-.md)|This attribute is added to generated assemblies to indicate the version of the data schema used to encode additional F# specific information in the resource attached to compiled F# libraries.|  
|type [FSharpTypeFunc](../VS_csharp/core.fsharptypefunc-class--fsharp-.md)|The CLI type used to represent F# first-class type function values. This type is for use by compiled F# code.|  
|type [FuncConvert](../VS_csharp/core.funcconvert-class--fsharp-.md)|Helper functions for converting F# first class function values to and from CLI representaions of functions using delegates.|  
|type [GeneralizableValueAttribute](../VS_csharp/core.generalizablevalueattribute-class--fsharp-.md)|Adding this attribute to a non-function value with generic parameters indicates that uses of the construct can give rise to generic code through type inference.|  
|type [ilsigptr<'T>](../VS_csharp/core.ilsigptr--t--type--fsharp-.md)|This type is for internal use by the F# code generator.|  
|type [int<'Measure>](../VS_csharp/core.int--measure--type--fsharp-.md)|The type of 32-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int32`.|  
|type [int16<'Measure>](../VS_csharp/core.int16--measure--type--fsharp-.md)|The type of 16-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int16`.|  
|type [int64<'Measure>](../VS_csharp/core.int64--measure--type--fsharp-.md)|The type of 64-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.Int64`.|  
|type [InterfaceAttribute](../VS_csharp/core.interfaceattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI interface.|  
|type [LiteralAttribute](../VS_csharp/core.literalattribute-class--fsharp-.md)|Adding this attribute to a value causes it to be compiled as a CLI constant literal.|  
|type [MeasureAnnotatedAbbreviationAttribute](../VS_csharp/core.measureannotatedabbreviationattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be interpreted as a refined type, currently limited to measure-parameterized types. This may only be used under very limited conditions.|  
|type [MeasureAttribute](../VS_csharp/core.measureattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be interpreted as a unit of measure. This may only be used under very limited conditions.|  
|type [nativeptr<'T>](../VS_csharp/core.nativeptr--t--type--fsharp-.md)|Represents an unmanaged pointer in F# code.|  
|type [NoComparisonAttribute](../VS_csharp/core.nocomparisonattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type where comparison is an abnormal operation. This means that the type does not satisfy the F# 'comparison' constraint. Within the bounds of the F# type system, this helps ensure that the F# generic comparison function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.|  
|type [NoDynamicInvocationAttribute](../VS_csharp/core.nodynamicinvocationattribute-class--fsharp-.md)|This attribute is used to tag values that may not be dynamically invoked at runtime. This is typically added to inlined functions whose implementations include unverifiable code. It causes the method body emitted for the inlined function to raise an exception if dynamically invoked, rather than including the unverifiable code in the generated assembly.|  
|type [NoEqualityAttribute](../VS_csharp/core.noequalityattribute-class--fsharp-.md)|Adding this attribute to a type indicates it is a type where equality is an abnormal operation. This means that the type does not satisfy the F# 'equality' constraint. Within the bounds of the F# type system, this helps ensure that the F# generic equality function is not instantiated directly at this type. The attribute and checking does not constrain the use of comparison with base or child types of this type.|  
|type [Option<'T>](../VS_csharp/core.option--t--union--fsharp-.md)|The type of optional values. When used from other CLI languages the empty option is the `null` value.|  
|type [OptionalArgumentAttribute](../VS_csharp/core.optionalargumentattribute-class--fsharp-.md)|This attribute is added automatically for all optional arguments.|  
|type [PrintfFormat<'Printer,'State,'Residue,'Result,'Tuple>](../VS_csharp/core.printfformat--printer--state--residue--result--tuple--class--fsharp-.md)|Type of a formatting expression.|  
|type [PrintfFormat<'Printer,'State,'Residue,'Result>](../VS_csharp/core.printfformat--printer--state--residue--result--class--fsharp-.md)|Type of a formatting expression.|  
|type [ProjectionParameterAttribute](../VS_csharp/core.projectionparameterattribute-class--fsharp-.md)|Indicates that, when a custom operator is used in a computation expression, a parameter is automatically parameterized by the variable space of the computation expression.|  
|type [Ref<'T>](../VS_csharp/core.ref--t--record--fsharp-.md)|The type of mutable references. Use the functions [:=] and [!] to get and set values of this type.|  
|type [ReferenceEqualityAttribute](../VS_csharp/core.referenceequalityattribute-class--fsharp-.md)|Adding this attribute to a record or union type disables the automatic generation of overrides for 'System.Object.Equals(obj)', 'System.Object.GetHashCode()' and 'System.IComparable' for the type. The type will by default use reference equality.|  
|type [ReflectedDefinitionAttribute](../VS_csharp/core.reflecteddefinitionattribute-class--fsharp-.md)|Adding this attribute to the let-binding for the definition of a top-level value makes the quotation expression that implements the value available for use at runtime.|  
|type [RequireQualifiedAccessAttribute](../VS_csharp/core.requirequalifiedaccessattribute-class--fsharp-.md)|This attribute is used to indicate that references to a the elements of a module, record or union type require explicit qualified access.|  
|type [RequiresExplicitTypeArgumentsAttribute](../VS_csharp/core.requiresexplicittypeargumentsattribute-class--fsharp-.md)|Adding this attribute to a type, value or member requires that uses of the construct must explicitly instantiate any generic type parameters.|  
|type [sbyte<'Measure>](../VS_csharp/core.sbyte--measure--type--fsharp-.md)|The type of 8-bit signed integer numbers, annotated with a unit of measure. The unit of measure is erased in compiled code and when values of this type are analyzed using reflection. The type is representationally equivalent to `System.SByte`.|  
|type [SealedAttribute](../VS_csharp/core.sealedattribute-class--fsharp-.md)|Adding this attribute to class definition makes it sealed, which means it may not be extended or implemented.|  
|type [SourceConstructFlags](../VS_csharp/core.sourceconstructflags-enumeration--fsharp-.md)|Indicates the relationship between a compiled entity in a CLI binary and an element in F# source code.|  
|type [StructAttribute](../VS_csharp/core.structattribute-class--fsharp-.md)|Adding this attribute to a type causes it to be represented using a CLI struct.|  
|type [StructuralComparisonAttribute](../VS_csharp/core.structuralcomparisonattribute-class--fsharp-.md)|Adding this attribute to a record, union, exception, or struct type confirms the automatic generation of implementations for 'System.IComparable' for the type.|  
|type [StructuralEqualityAttribute](../VS_csharp/core.structuralequalityattribute-class--fsharp-.md)|Adding this attribute to a record, union or struct type confirms the automatic generation of overrides for 'System.Object.Equals(obj)' and 'System.Object.GetHashCode()' for the type.|  
|type [StructuredFormatDisplayAttribute](../VS_csharp/core.structuredformatdisplayattribute-class--fsharp-.md)|This attribute is used to mark how a type is displayed by default when using '%A' printf formatting patterns and other two-dimensional text-based display layouts. In this version of F# the only valid values are of the form `PreText {PropertyName} PostText`. The property name indicates a property to evaluate and to display instead of the object itself.|  
|type [Unit](../VS_csharp/core.unit-type--fsharp-.md)|The type 'unit', which has only one value "()". This value is special and always uses the representation 'null'.|  
|type [UnverifiableAttribute](../VS_csharp/core.unverifiableattribute-class--fsharp-.md)|This attribute is used to tag values whose use will result in the generation of unverifiable code. These values are inevitably marked 'inline' to ensure that the unverifiable constructs are not present in the actual code for the F# library, but are rather copied to the source code of the caller.|  
|type [VolatileFieldAttribute](../VS_csharp/core.volatilefieldattribute-class--fsharp-.md)|Adding this attribute to an F# mutable binding causes the "volatile" prefix to be used for all accesses to the field.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [array<'T>](../VS_csharp/core.array--t--type-abbreviation--fsharp-.md)|Single dimensional, zero-based arrays, written `int[]`, `string[]` etc.|  
|type [bigint](../VS_csharp/core.bigint-type-abbreviation--fsharp-.md)|Arbitrarily large integers. An abbreviation for the type <xref:System.Numerics.BigInteger*>.|  
|type [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Boolean*>.|  
|type [byte](../VS_csharp/core.byte-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Byte*>.|  
|type [char](../VS_csharp/core.char-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Char*>.|  
|type [decimal](../VS_csharp/core.decimal-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Decimal*>.|  
|type [double](../VS_csharp/core.double-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Double*>.|  
|type [exn](../VS_csharp/core.exn-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Exception*>.|  
|type [float](../VS_csharp/core.float-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Double*>.|  
|type [float32](../VS_csharp/core.float32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Single*>.|  
|type [Format<'Printer,'State,'Residue,'Result,'Tuple>](../VS_csharp/core.format--printer--state--residue--result--tuple--type-abbreviation--fsharp-.md)|Type of a formatting expression.|  
|type [Format<'Printer,'State,'Residue,'Result>](../VS_csharp/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md)|Type of a formatting expression.|  
|type [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int32*>.|  
|type [int16](../VS_csharp/core.int16-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int16*>.|  
|type [int32](../VS_csharp/core.int32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int32*>.|  
|type [int64](../VS_csharp/core.int64-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Int64*>.|  
|type [int8](../VS_csharp/core.int8-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.SByte*>.|  
|type [nativeint](../VS_csharp/core.nativeint-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.IntPtr*>.|  
|type [obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Object*>.|  
|type [option<'T>](../VS_csharp/core.option--t--type-abbreviation--fsharp-.md)|The type of optional values. When used from other CLI languages the empty option is the `null` value.|  
|type [ref<'T>](../VS_csharp/core.ref--t--type-abbreviation--fsharp-.md)|The type of mutable references. Use the functions [:=] and [!] to get and set values of this type.|  
|type [sbyte](../VS_csharp/core.sbyte-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.SByte*>.|  
|type [single](../VS_csharp/core.single-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Single*>.|  
|type [string](../VS_csharp/core.string-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.String*>.|  
|type [uint16](../VS_csharp/core.uint16-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt16*>.|  
|type [uint32](../VS_csharp/core.uint32-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt32*>.|  
|type [uint64](../VS_csharp/core.uint64-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UInt64*>.|  
|type [uint8](../VS_csharp/core.uint8-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Byte*>.|  
|type [unativeint](../VS_csharp/core.unativeint-type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.UIntPtr*>.|  
|type [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)|The type 'unit', which has only one value "()". This value is special and always uses the representation 'null'.|  
  
## Exceptions  
  
|Exception|Description|  
|---------------|-----------------|  
|exception [MatchFailureException](../VS_csharp/core.matchfailureexception-exception--fsharp-.md)|Non-exhaustive match failures will raise the MatchFailureException exception|  
  
## See Also  
 [F# Library Reference](../VS_csharp/fsharp-core-library-reference.md)