---
title: "Nullable Operators (F#)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "?=?_FS"
  - "?<_FS"
  - "?/_FS"
  - "?*?_FS"
  - "-?_FS"
  - "?-_FS"
  - "?/?_FS"
  - "+?_FS"
  - ">?_FS"
  - "?<=_FS"
  - "?>?_FS"
  - "<=?_FS"
  - "*?_FS"
  - "?%?_FS"
  - "?>=?_FS"
  - "<>?_FS"
  - "<?_FS"
  - "?+_FS"
  - "/?_FS"
  - "?<>_FS"
  - "?<=?_FS"
  - ">=?_FS"
  - "?-?_FS"
  - "?<?_FS"
  - "?<>?_FS"
  - "=?_FS"
  - "?>_FS"
  - "?+?_FS"
  - "?=_FS"
  - "?>=_FS"
  - "?%_FS"
  - "%?_FS"
  - "?*_FS"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "/? operator [F#]"
  - "?<=? operator [F#]"
  - "?%? operator [F#]"
  - "?= operator [F#]"
  - ">=? operator [F#]"
  - "operators [F#], nullable"
  - "?< operator [F#]"
  - "?/? operator [F#]"
  - "<=? operator [F#]"
  - "?/ operator [F#]"
  - "?>? operator [F#]"
  - ">? operator [F#]"
  - "-? operator [F#]"
  - "?<>? operator [F#]"
  - "?<> operator [F#]"
  - "%? operator [F#]"
  - "?>=? operator [F#]"
  - "=? operator [F#]"
  - "?*? operator [F#]"
  - "?* operator [F#]"
  - "?% operator [F#]"
  - "?> operator [F#]"
  - "?>= operator [F#]"
  - "?<= operator [F#]"
  - "nullable operators [F#]"
  - "?- operator [F#]"
  - "?-? operator [F#]"
  - "<? operator [F#]"
  - "+? operator [F#]"
  - "?+ operator [F#]"
  - "?+? operator [F#]"
  - "?=? operator [F#]"
  - "<>? operator [F#]"
  - "*? operator [F#]"
ms.assetid: d7117a93-7c14-407f-b1c5-081b14dd1d8d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable Operators (F#)
Nullable operators are binary arithmetic or comparison operators that work with nullable arithmetic types on one or both sides. Nullable types arise frequently when you work with data from sources such as databases that allow nulls in place of actual values. Nullable operators are used frequently in query expressions. In addition to nullable operators for arithmetic and comparison, conversion operators can be used to convert between nullable types. There are also nullable versions of certain query operators.  
  
## Table of Nullable Operators  
 The following table lists nullable operators supported in the F# language.  
  
||||  
|-|-|-|  
|Nullable on left|Nullable on right|Both sides nullable|  
|[?>=](../vs140/nullableoperators.----=----t--function--fsharp-.md)|[>=?](../vs140/nullableoperators.---=-----t--function--fsharp-.md)|[?>=?](../vs140/nullableoperators.----=-----t--function--fsharp-.md)|  
|[?>](../vs140/nullableoperators.--------t--function--fsharp-.md)|[>?](../vs140/nullableoperators.--------t--function--fsharp-.md)|[?>?](../vs140/nullableoperators.---------t--function--fsharp-.md)|  
|[?<=](../vs140/nullableoperators.----=----t--function--fsharp-.md)|[<=?](../vs140/nullableoperators.---=-----t--function--fsharp-.md)|[?<=?](../vs140/nullableoperators.----=-----t--function--fsharp-.md)|  
|[?<](../vs140/nullableoperators.--------t--function--fsharp-.md)|[<?](../vs140/nullableoperators.--------t--function--fsharp-.md)|[?<?](../vs140/nullableoperators.---------t--function--fsharp-.md)|  
|[?=](../vs140/nullableoperators.---=----t--function--fsharp-.md)|[=?](../vs140/nullableoperators.--=-----t--function--fsharp-.md)|[?=?](../vs140/nullableoperators.---=-----t--function--fsharp-.md)|  
|[?<>](../vs140/nullableoperators.---------t--function--fsharp-.md)|[<>?](../vs140/nullableoperators.---------t--function--fsharp-.md)|[?<>?](../vs140/nullableoperators.----------t--function--fsharp-.md)|  
|[?+](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-.md)|[+?](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-.md)|[?+?](../vs140/nullableoperators.--------^t1-^t2-^t3--function--fsharp-.md)|  
|[?-](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-1.md)|[-?](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-1.md)|[?-?](../vs140/nullableoperators.--------^t1-^t2-^t3--function--fsharp-1.md)|  
|[?*](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-.md)|[*?](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-.md)|[?*?](../vs140/nullableoperators.--------^t1-^t2-^t3--function--fsharp-.md)|  
|[?/](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-2.md)|[/?](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-2.md)|[?/?](../vs140/nullableoperators.--------^t1-^t2-^t3--function--fsharp-2.md)|  
|[?%](../vs140/nullableoperators.------^t1-^t2-^t3--function--fsharp-.md)|[%?](../vs140/nullableoperators.-------^t1-^t2-^t3--function--fsharp-.md)|[?%?](../vs140/nullableoperators.--------^t1-^t2-^t3--function--fsharp-.md)|  
  
## Remarks  
 The nullable operators are included in the [NullableOperators](../vs140/linq.nullableoperators-module--fsharp-.md) module in the namespace [Microsoft.FSharp.Linq](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md). The type for nullable data is <xref:System.Nullable`1*>.  
  
 In query expressions, nullable types arise when selecting data from a data source that allows nulls instead of values. In a SQL Server database, each data column in a table has an attribute that indicates whether nulls are allowed. If nulls are allowed, the data returned from the database can contain nulls that cannot be represented by a primitive data type such as `int`, `float`, and so on. Therefore, the data is returned as a `System.Nullable<int>` instead of `int`, and `System.Nullable<float>` instead of `float`. The actual value can be obtained from a <xref:System.Nullable`1*> object by using the `Value` property, and you can determine if a <xref:System.Nullable`1*> object has a value by calling the `HasValue` method. Another useful method is the <xref:System.Nullable`1.GetValueOrDefault*> method, which allows you to get the value or a default value of the appropriate type. The default value is some form of "zero" value, such as 0, 0.0, or `false`.  
  
 Nullable types may be converted to non-nullable primitive types using the usual conversion operators such as `int` or `float`. It is also possible to convert from one nullable type to another nullable type by using the conversion operators for nullable types. The appropriate conversion operators have the same name as the standard ones, but they are in a separate module, the [Nullable](../vs140/linq.nullable-module--fsharp-.md) module in the [Microsoft.FSharp.Linq](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md) namespace. Typically, you open this namespace when working with query expressions. In that case, you can use the nullable conversion operators by adding the prefix `Nullable.` to the appropriate conversion operator, as shown in the following code.  
  
```f#  
open Microsoft.Fsharp.Linq  
let nullableInt = new System.Nullable<int>(10)  
// Use the Nullable.float conversion operator to convert from one nullable type to another nullable type.  
let nullableFloat = Nullable.float nullableInt  
// Use the regular non-nullable float operator to convert to a non-nullable float.  
printfn "%f" (float nullableFloat)  
```  
  
 The output is `10.000000`.  
  
 Query operators on nullable data fields, such as `sumByNullable`, also exist for use in query expressions. The query operators for non-nullable types are not type-compatible with nullable types, so you must use the nullable version of the appropriate query operator when you are working with nullable data values. For more information, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
 The following example shows the use of nullable operators in an F# query expression. The first query shows how you would write a query without a nullable operator; the second query shows an equivalent query that uses a nullable operator. For the full context, including how to set up the database to use this sample code, see [Walkthrough: Accessing a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md).  
  
```f#  
open System  
open System.Data  
open System.Data.Linq  
open Microsoft.FSharp.Data.TypeProviders  
open Microsoft.FSharp.Linq  
  
[<Generate>]  
type dbSchema = SqlDataConnection<"Data Source=MYSERVER\INSTANCE;Initial Catalog=MyDatabase;Integrated Security=SSPI;">  
let db = dbSchema.GetDataContext()  
  
query {  
        for row in db.Table2 do  
        where (row.TestData1.HasValue && row.TestData1.Value > 2)  
        select row  
      }  
|> Seq.iter (fun row -> printfn "%d %s" row.TestData1.Value row.Name)  
  
query {  
        for row in db.Table2 do  
        // Use a nullable operator ?>  
        where (row.TestData1 ?> 2)  
        select row  
      }  
|> Seq.iter (fun row -> printfn "%d %s" (row.TestData1.GetValueOrDefault()) row.Name)  
  
```  
  
## See Also  
 <xref:System.Nullable`1*>