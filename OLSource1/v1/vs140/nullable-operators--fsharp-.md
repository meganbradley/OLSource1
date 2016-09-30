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
 The nullable operators are included in the [NullableOperators](../vs140/linq.nullableoperators-module--fsharp-.md) module in the namespace [Microsoft.FSharp.Linq](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md). The type for nullable data is <xref:System.Nullable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>float<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>System.Nullable<int><CodeContentPlaceHolder>5\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>System.Nullable<float><CodeContentPlaceHolder>7\</CodeContentPlaceHolder>float<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*> object by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property, and you can determine if a <xref:System.Nullable<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>HasValue<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1.GetValueOrDefault*> method, which allows you to get the value or a default value of the appropriate type. The default value is some form of "zero" value, such as 0, 0.0, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Nullable types may be converted to non-nullable primitive types using the usual conversion operators such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. It is also possible to convert from one nullable type to another nullable type by using the conversion operators for nullable types. The appropriate conversion operators have the same name as the standard ones, but they are in a separate module, the [Nullable](../vs140/linq.nullable-module--fsharp-.md) module in the [Microsoft.FSharp.Linq](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md) namespace. Typically, you open this namespace when working with query expressions. In that case, you can use the nullable conversion operators by adding the prefix <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to the appropriate conversion operator, as shown in the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The output is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Query operators on nullable data fields, such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, also exist for use in query expressions. The query operators for non-nullable types are not type-compatible with nullable types, so you must use the nullable version of the appropriate query operator when you are working with nullable data values. For more information, see [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md).  
  
 The following example shows the use of nullable operators in an F# query expression. The first query shows how you would write a query without a nullable operator; the second query shows an equivalent query that uses a nullable operator. For the full context, including how to set up the database to use this sample code, see [Walkthrough: Accessing a SQL Database by Using Type Providers (F#)](../vs140/walkthrough--accessing-a-sql-database-by-using-type-providers--fsharp-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Nullable`1*>