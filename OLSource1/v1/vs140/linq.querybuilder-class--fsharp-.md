---
title: "Linq.QueryBuilder Class (F#)"
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
  - "Microsoft.FSharp.Linq.QueryBuilder"
dev_langs: 
  - "FSharp"
ms.assetid: 1fb66a8e-b815-4aa3-9fab-82f671337fbc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linq.QueryBuilder Class (F#)
The type used to support the F# query syntax.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type QueryBuilder =  
 class  
  new QueryBuilder : unit -> QueryBuilder  
  member this.All : QuerySource<'T,'Q> * ('T -> bool) -> bool  
  member this.AverageBy : QuerySource<'T,'Q> * ('T -> ^Value) -> ^Value  
  member this.AverageByNullable : QuerySource<'T,'Q> * ('T -> Nullable<^Value>) -> Nullable<^Value>  
  member this.Contains : QuerySource<'T,'Q> * 'T -> bool  
  member this.Count : QuerySource<'T,'Q> -> int  
  member this.Distinct : QuerySource<'T,'Q> -> QuerySource<'T,'Q>  
  member this.ExactlyOne : QuerySource<'T,'Q> -> 'T  
  member this.ExactlyOneOrDefault : QuerySource<'T,'Q> -> 'T  
  member this.Exists : QuerySource<'T,'Q> * ('T -> bool) -> bool  
  member this.Find : QuerySource<'T,'Q> * ('T -> bool) -> 'T  
  member this.For : QuerySource<'T,'Q> * ('T -> QuerySource<'Result,'Q2>) -> QuerySource<'Result,'Q>  
  member this.GroupBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<IGrouping<'Key,'T>,'Q>  
  member this.GroupJoin : QuerySource<'Outer,'Q> * QuerySource<'Inner,'Q> * ('Outer -> 'Key) * ('Inner -> 'Key) * ('Outer -> seq<'Inner> -> 'Result) -> QuerySource<'Result,'Q>  
  member this.GroupValBy : QuerySource<'T,'Q> * ('T -> 'Value) * ('T -> 'Key) -> QuerySource<IGrouping<'Key,'Value>,'Q>  
  member this.Head : QuerySource<'T,'Q> -> 'T  
  member this.HeadOrDefault : QuerySource<'T,'Q> -> 'T  
  member this.Join : QuerySource<'Outer,'Q> * QuerySource<'Inner,'Q> * ('Outer -> 'Key) * ('Inner -> 'Key) * ('Outer -> 'Inner -> 'Result) -> QuerySource<'Result,'Q>  
  member this.Last : QuerySource<'T,'Q> -> 'T  
  member this.LastOrDefault : QuerySource<'T,'Q> -> 'T  
  member this.LeftOuterJoin : QuerySource<'Outer,'Q> * QuerySource<'Inner,'Q> * ('Outer -> 'Key) * ('Inner -> 'Key) * ('Outer -> seq<'Inner> -> 'Result) -> QuerySource<'Result,'Q>  
  member this.MaxBy : QuerySource<'T,'Q> * ('T -> 'Value) -> 'Value  
  member this.MaxByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Value>) -> Nullable<'Value>  
  member this.MinBy : QuerySource<'T,'Q> * ('T -> 'Value) -> 'Value  
  member this.MinByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Value>) -> Nullable<'Value>  
  member this.Nth : QuerySource<'T,'Q> * int -> 'T  
  member this.Quote : Expr<'T> -> Expr<'T>  
  member this.Run : Expr<QuerySource<'T,IQueryable>> -> IQueryable<'T>  
  member this.Select : QuerySource<'T,'Q> * ('T -> 'Result) -> QuerySource<'Result,'Q>  
  member this.Skip : QuerySource<'T,'Q> * int -> QuerySource<'T,'Q>  
  member this.SkipWhile : QuerySource<'T,'Q> * ('T -> bool) -> QuerySource<'T,'Q>  
  member this.SortBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q>  
  member this.SortByDescending : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q>  
  member this.SortByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q>  
  member this.SortByNullableDescending : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q>  
  member this.Source : IEnumerable<'T> -> QuerySource<'T,IEnumerable>  
  member this.Source : IQueryable<'T> -> QuerySource<'T,'Q>  
  member this.SumBy : QuerySource<'T,'Q> * ('T -> ^Value) -> ^Value  
  member this.SumByNullable : QuerySource<'T,'Q> * ('T -> Nullable<^Value>) -> Nullable<^Value>  
  member this.Take : QuerySource<'T,'Q> * int -> QuerySource<'T,'Q>  
  member this.TakeWhile : QuerySource<'T,'Q> * ('T -> bool) -> QuerySource<'T,'Q>  
  member this.ThenBy : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q>  
  member this.ThenByDescending : QuerySource<'T,'Q> * ('T -> 'Key) -> QuerySource<'T,'Q>  
  member this.ThenByNullable : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q>  
  member this.ThenByNullableDescending : QuerySource<'T,'Q> * ('T -> Nullable<'Key>) -> QuerySource<'T,'Q>  
  member this.Where : QuerySource<'T,'Q> * ('T -> bool) -> QuerySource<'T,'Q>  
  member this.Yield : 'T -> QuerySource<'T,'Q>  
  member this.YieldFrom : QuerySource<'T,'Q> -> QuerySource<'T,'Q>  
  member this.Zero : unit -> QuerySource<'T,'Q>  
 end  
```  
  
## Remarks  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/linq.querybuilder-constructor--fsharp-.md)|Create an instance of this builder.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[All](../vs140/querybuilder.all--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether all elements selected so far satisfy a condition.|  
|[AverageBy](../vs140/querybuilder.averageby--t--q-^value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> ^Value) -> ^Value|A query operator that selects a value for each element selected so far and returns the average of these values.|  
|[AverageByNullable](../vs140/querybuilder.averagebynullable--t--q-^value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><^Value>) -> <xref:System.Nullable`1*><^Value>|A query operator that selects a nullable value for each element selected so far and returns the average of these values. If any nullable does not have a value, it is ignored.|  
|[Contains](../vs140/querybuilder.contains--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * 'T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether the selected elements contain a specified element.|  
|[Count](../vs140/querybuilder.count--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [int](../vs140/core.int-type-abbreviation--fsharp-.md)|A query operator that returns the number of selected elements.|  
|[Distinct](../vs140/querybuilder.distinct--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects distinct elements from the elements selected so far.|  
|[ExactlyOne](../vs140/querybuilder.exactlyone--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the single, specific element selected so far.|  
|[ExactlyOneOrDefault](../vs140/querybuilder.exactlyoneordefault--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the single, specific element of those selected so far, or a default value if that element is not found.|  
|[Exists](../vs140/querybuilder.exists--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether any element selected so far satisfies a condition.|  
|[Find](../vs140/querybuilder.find--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)QuerySource<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> 'T|A query operator that selects the first element selected so far that satisfies a specified condition.|  
|[For](../vs140/querybuilder.for--t--q--result--q2--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q2>) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A method used to support the F# query syntax. Projects each element of a sequence to another sequence and combines the resulting sequences into one sequence.|  
|[GroupBy](../vs140/querybuilder.groupby--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<<xref:System.Linq.IGrouping`2*><'Key,'T>,'Q>|A query operator that groups the elements selected so far according to a specified key selector.|  
|[GroupJoin](../vs140/querybuilder.groupjoin--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> seq<'Inner> -> 'Result) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys and groups the results. Normal usage is `groupJoin (for y in elements2 -> key1 = key2) into group`.|  
|[GroupValBy](../vs140/querybuilder.groupvalby--t--key--value--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) \* ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<<xref:System.Linq.IGrouping`2*><'Key,'Value>,'Q>|A query operator that selects a value for each element selected so far and groups the elements by the given key.|  
|[Head](../vs140/querybuilder.head--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the first element from those selected so far.|  
|[HeadOrDefault](../vs140/querybuilder.headordefault--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the first element of those selected so far, or a default value if the sequence contains no elements.|  
|[Join](../vs140/querybuilder.join--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> 'Inner -> 'Result) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys. Normal usage is `join (for y in elements2 -> key1 = key2)`.|  
|[Last](../vs140/querybuilder.last--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the last element of those selected so far.|  
|[LastOrDefault](../vs140/querybuilder.lastordefault--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the last element of those selected so far, or a default value if no element is found.|  
|[LeftOuterJoin](../vs140/querybuilder.leftouterjoin--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> seq<'Inner> -> 'Result) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys and groups the results. If any group is empty, a group with a single default value is used instead. Normal usage is `leftOuterJoin (for y in elements2 -> key1 = key2) into group`.|  
|[MaxBy](../vs140/querybuilder.maxby--t--q--value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) -> 'Value|A query operator that selects a value for each element selected so far and returns the maximum resulting value.|  
|[MaxByNullable](../vs140/querybuilder.maxbynullable--t--q--value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Value>) -> <xref:System.Nullable`1*><'Value>|A query operator that selects a nullable value for each element selected so far and returns the maximum of these values. If any nullable does not have a value, it is ignored.|  
|[MinBy](../vs140/querybuilder.minby--t--q--value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) -> 'Value|A query operator that selects a value for each element selected so far and returns the minimum resulting value.|  
|[MinByNullable](../vs140/querybuilder.minbynullable--t--q--value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Value>) -> <xref:System.Nullable`1*><'Value>|A query operator that selects a nullable value for each element selected so far and returns the minimum of these values. If any nullable does not have a value, it is ignored.|  
|[Nth](../vs140/querybuilder.nth--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../vs140/core.int-type-abbreviation--fsharp-.md) -> 'T|A query operator that selects the element at a specified index among those selected so far.|  
|[Quote](../vs140/querybuilder.quote--t--method--fsharp-.md): Expr<'T> -> Expr<'T>|A method used to support the F# query syntax. Indicates that the query should be passed as a quotation to the Run method.|  
|[Run](../vs140/querybuilder.run--t--method--fsharp-.md): Expr<[QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,IQueryable>> -><xref:System.Linq.IQueryable`1*><'T>|A method used to support the F# query syntax. Runs the given quotation as a query using LINQ IQueryable rules.|  
|[Select](../vs140/querybuilder.select--t--q--result--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Result) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that projects each of the elements selected so far.|  
|[Skip](../vs140/querybuilder.skip--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../vs140/core.int-type-abbreviation--fsharp-.md) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that bypasses a specified number of the elements selected so far and selects the remaining elements.|  
|[SkipWhile](../vs140/querybuilder.skipwhile--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that bypasses elements in a sequence as long as a specified condition is true and then selects the remaining elements.|  
|[SortBy](../vs140/querybuilder.sortby--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in ascending order by the given sorting key.|  
|[SortByDescending](../vs140/querybuilder.sortbydescending--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in descending order by the given sorting key.|  
|[SortByNullable](../vs140/querybuilder.sortbynullable--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in ascending order by the given nullable sorting key.|  
|[SortByNullableDescending](../vs140/querybuilder.sortbynullabledescending--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in descending order by the given nullable sorting key.|  
|[Source](../vs140/querybuilder.source--t--method--fsharp-.md): <xref:System.Collections.Generic.IEnumerable`1*><'T> -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,IEnumerable>|A method used to support the F# query syntax. Inputs to queries are implicitly wrapped by a call to one of the overloads of this method.|  
|[Source](../vs140/querybuilder.source--t--q--method--fsharp-.md): <xref:System.Linq.IQueryable`1*><'T> -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Inputs to queries are implicitly wrapped by a call to one of the overloads of this method.|  
|[SumBy](../vs140/querybuilder.sumby--t--q-^value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> ^Value) -> ^Value|A query operator that selects a value for each element selected so far and returns the sum of these values.|  
|[SumByNullable](../vs140/querybuilder.sumbynullable--t--q-^value--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><^Value>) -> <xref:System.Nullable`1*><^Value>|A query operator that selects a nullable value for each element selected so far and returns the sum of these values. If any nullable does not have a value, it is ignored.|  
|[Take](../vs140/querybuilder.take--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../vs140/core.int-type-abbreviation--fsharp-.md) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects a specified number of contiguous elements from those selected so far.|  
|[TakeWhile](../vs140/querybuilder.takewhile--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects elements from a sequence as long as a specified condition is true, and then skips the remaining elements.|  
|[ThenBy](../vs140/querybuilder.thenby--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByDescending](../vs140/querybuilder.thenbydescending--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in descending order by the given sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByNullable](../vs140/querybuilder.thenbynullable--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given nullable sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByNullableDescending](../vs140/querybuilder.thenbynullabledescending--t--q--key--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in descending order by the given nullable sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[Where](../vs140/querybuilder.where--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects those elements based on a specified predicate.|  
|[Yield](../vs140/querybuilder.yield--t--q--method--fsharp-.md): 'T -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns a sequence of length one that contains the specified value.|  
|[YieldFrom](../vs140/querybuilder.yieldfrom--t--q--method--fsharp-.md): [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns a sequence that contains the specified values.|  
|[Zero](../vs140/querybuilder.zero--t--q--method--fsharp-.md): unit -> [QuerySource](../vs140/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns an empty sequence that has the specified type argument.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)