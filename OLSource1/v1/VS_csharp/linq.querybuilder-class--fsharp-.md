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
|[new](../VS_csharp/linq.querybuilder-constructor--fsharp-.md)|Create an instance of this builder.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[All](../VS_csharp/querybuilder.all--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether all elements selected so far satisfy a condition.|  
|[AverageBy](../VS_csharp/querybuilder.averageby--t--q-^value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> ^Value) -> ^Value|A query operator that selects a value for each element selected so far and returns the average of these values.|  
|[AverageByNullable](../VS_csharp/querybuilder.averagebynullable--t--q-^value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><^Value>) -> <xref:System.Nullable`1*><^Value>|A query operator that selects a nullable value for each element selected so far and returns the average of these values. If any nullable does not have a value, it is ignored.|  
|[Contains](../VS_csharp/querybuilder.contains--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * 'T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether the selected elements contain a specified element.|  
|[Count](../VS_csharp/querybuilder.count--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)|A query operator that returns the number of selected elements.|  
|[Distinct](../VS_csharp/querybuilder.distinct--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects distinct elements from the elements selected so far.|  
|[ExactlyOne](../VS_csharp/querybuilder.exactlyone--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the single, specific element selected so far.|  
|[ExactlyOneOrDefault](../VS_csharp/querybuilder.exactlyoneordefault--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the single, specific element of those selected so far, or a default value if that element is not found.|  
|[Exists](../VS_csharp/querybuilder.exists--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)|A query operator that determines whether any element selected so far satisfies a condition.|  
|[Find](../VS_csharp/querybuilder.find--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)QuerySource<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> 'T|A query operator that selects the first element selected so far that satisfies a specified condition.|  
|[For](../VS_csharp/querybuilder.for--t--q--result--q2--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q2>) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A method used to support the F# query syntax. Projects each element of a sequence to another sequence and combines the resulting sequences into one sequence.|  
|[GroupBy](../VS_csharp/querybuilder.groupby--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<<xref:System.Linq.IGrouping`2*><'Key,'T>,'Q>|A query operator that groups the elements selected so far according to a specified key selector.|  
|[GroupJoin](../VS_csharp/querybuilder.groupjoin--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> seq<'Inner> -> 'Result) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys and groups the results. Normal usage is `groupJoin (for y in elements2 -> key1 = key2) into group`.|  
|[GroupValBy](../VS_csharp/querybuilder.groupvalby--t--key--value--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) \* ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<<xref:System.Linq.IGrouping`2*><'Key,'Value>,'Q>|A query operator that selects a value for each element selected so far and groups the elements by the given key.|  
|[Head](../VS_csharp/querybuilder.head--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the first element from those selected so far.|  
|[HeadOrDefault](../VS_csharp/querybuilder.headordefault--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the first element of those selected so far, or a default value if the sequence contains no elements.|  
|[Join](../VS_csharp/querybuilder.join--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> 'Inner -> 'Result) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys. Normal usage is `join (for y in elements2 -> key1 = key2)`.|  
|[Last](../VS_csharp/querybuilder.last--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the last element of those selected so far.|  
|[LastOrDefault](../VS_csharp/querybuilder.lastordefault--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> 'T|A query operator that selects the last element of those selected so far, or a default value if no element is found.|  
|[LeftOuterJoin](../VS_csharp/querybuilder.leftouterjoin--outer--q--inner--key--result--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Outer,'Q> * [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Inner,'Q> \* ('Outer -> 'Key) \* ('Inner -> 'Key) \* ('Outer -> seq<'Inner> -> 'Result) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that correlates two sets of selected values based on matching keys and groups the results. If any group is empty, a group with a single default value is used instead. Normal usage is `leftOuterJoin (for y in elements2 -> key1 = key2) into group`.|  
|[MaxBy](../VS_csharp/querybuilder.maxby--t--q--value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) -> 'Value|A query operator that selects a value for each element selected so far and returns the maximum resulting value.|  
|[MaxByNullable](../VS_csharp/querybuilder.maxbynullable--t--q--value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Value>) -> <xref:System.Nullable`1*><'Value>|A query operator that selects a nullable value for each element selected so far and returns the maximum of these values. If any nullable does not have a value, it is ignored.|  
|[MinBy](../VS_csharp/querybuilder.minby--t--q--value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Value) -> 'Value|A query operator that selects a value for each element selected so far and returns the minimum resulting value.|  
|[MinByNullable](../VS_csharp/querybuilder.minbynullable--t--q--value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Value>) -> <xref:System.Nullable`1*><'Value>|A query operator that selects a nullable value for each element selected so far and returns the minimum of these values. If any nullable does not have a value, it is ignored.|  
|[Nth](../VS_csharp/querybuilder.nth--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) -> 'T|A query operator that selects the element at a specified index among those selected so far.|  
|[Quote](../VS_csharp/querybuilder.quote--t--method--fsharp-.md): Expr<'T> -> Expr<'T>|A method used to support the F# query syntax. Indicates that the query should be passed as a quotation to the Run method.|  
|[Run](../VS_csharp/querybuilder.run--t--method--fsharp-.md): Expr<[QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,IQueryable>> -><xref:System.Linq.IQueryable`1*><'T>|A method used to support the F# query syntax. Runs the given quotation as a query using LINQ IQueryable rules.|  
|[Select](../VS_csharp/querybuilder.select--t--q--result--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Result) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'Result,'Q>|A query operator that projects each of the elements selected so far.|  
|[Skip](../VS_csharp/querybuilder.skip--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that bypasses a specified number of the elements selected so far and selects the remaining elements.|  
|[SkipWhile](../VS_csharp/querybuilder.skipwhile--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that bypasses elements in a sequence as long as a specified condition is true and then selects the remaining elements.|  
|[SortBy](../VS_csharp/querybuilder.sortby--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in ascending order by the given sorting key.|  
|[SortByDescending](../VS_csharp/querybuilder.sortbydescending--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in descending order by the given sorting key.|  
|[SortByNullable](../VS_csharp/querybuilder.sortbynullable--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in ascending order by the given nullable sorting key.|  
|[SortByNullableDescending](../VS_csharp/querybuilder.sortbynullabledescending--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that sorts the elements selected so far in descending order by the given nullable sorting key.|  
|[Source](../VS_csharp/querybuilder.source--t--method--fsharp-.md): <xref:System.Collections.Generic.IEnumerable`1*><'T> -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,IEnumerable>|A method used to support the F# query syntax. Inputs to queries are implicitly wrapped by a call to one of the overloads of this method.|  
|[Source](../VS_csharp/querybuilder.source--t--q--method--fsharp-.md): <xref:System.Linq.IQueryable`1*><'T> -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Inputs to queries are implicitly wrapped by a call to one of the overloads of this method.|  
|[SumBy](../VS_csharp/querybuilder.sumby--t--q-^value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> ^Value) -> ^Value|A query operator that selects a value for each element selected so far and returns the sum of these values.|  
|[SumByNullable](../VS_csharp/querybuilder.sumbynullable--t--q-^value--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><^Value>) -> <xref:System.Nullable`1*><^Value>|A query operator that selects a nullable value for each element selected so far and returns the sum of these values. If any nullable does not have a value, it is ignored.|  
|[Take](../VS_csharp/querybuilder.take--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects a specified number of contiguous elements from those selected so far.|  
|[TakeWhile](../VS_csharp/querybuilder.takewhile--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects elements from a sequence as long as a specified condition is true, and then skips the remaining elements.|  
|[ThenBy](../VS_csharp/querybuilder.thenby--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByDescending](../VS_csharp/querybuilder.thenbydescending--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> 'Key) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in descending order by the given sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByNullable](../VS_csharp/querybuilder.thenbynullable--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in ascending order by the given nullable sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[ThenByNullableDescending](../VS_csharp/querybuilder.thenbynullabledescending--t--q--key--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> <xref:System.Nullable`1*><'Key>) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that performs a subsequent ordering of the elements selected so far in descending order by the given nullable sorting key. This operator may only be used immediately after a `sortBy`, `sortByDescending`, `thenBy` or `thenByDescending`, or their nullable variants.|  
|[Where](../VS_csharp/querybuilder.where--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> * ('T -> [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)) -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A query operator that selects those elements based on a specified predicate.|  
|[Yield](../VS_csharp/querybuilder.yield--t--q--method--fsharp-.md): 'T -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns a sequence of length one that contains the specified value.|  
|[YieldFrom](../VS_csharp/querybuilder.yieldfrom--t--q--method--fsharp-.md): [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q> -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns a sequence that contains the specified values.|  
|[Zero](../VS_csharp/querybuilder.zero--t--q--method--fsharp-.md): unit -> [QuerySource](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)<'T,'Q>|A method used to support the F# query syntax. Returns an empty sequence that has the specified type argument.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md)