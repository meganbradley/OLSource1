---
title: "Computation Expressions (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - use!_FS
  - return!_FS
  - yield!_FS
  - let!_FS
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - do! keyword [F#]
  - yield! keyword [F#]
  - workflows [F#]
  - monads [F#]
  - let! keyword [F#]
  - computation expressions [F#]
  - return keyword [F#]
ms.assetid: 1a629b0f-f961-4064-8b64-69cf8877eae4
caps.latest.revision: 46
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Computation Expressions (F#)
Computation expressions in F# provide a convenient syntax for writing computations that can be sequenced and combined using control flow constructs and bindings. They can be used to provide a convenient syntax for *monads*, a functional programming feature that can be used to manage data, control, and side effects in functional programs.  
  
## Built-in Workflows  
 Sequence expressions are an example of a computation expression, as are asynchronous workflows and query expressions. For more information, see [Sequences](../vs140/sequences--fsharp-.md), [Asynchronous Workflows](../vs140/asynchronous-workflows--fsharp-.md), and [Query Expressions](../vs140/query-expressions--fsharp-.md).  
  
 Certain features are common to both sequence expressions and asynchronous workflows and illustrate the basic syntax for a computation expression:  
  
 `builder-name` { `expression` }  
  
 The previous syntax specifies that the given expression is a computation expression of a type specified by `builder-name`. The computation expression can be a built-in workflow, such as `seq` or `async`, or it can be something you define. The `builder-name` is the identifier for an instance of a special type known as the *builder type*. The builder type is a class type that defines special methods that govern the way the fragments of the computation expression are combined, that is, code that controls how the expression executes. Another way to describe a builder class is to say that it enables you to customize the operation of many F# constructs, such as loops and bindings.  
  
 In computation expressions, two forms are available for some common language constructs. You can invoke the variant constructs by using a ! (bang) suffix on certain keywords, such as `let!`, `do!`, and so on. These special forms cause certain functions defined in the builder class to replace the ordinary built-in behavior of these operations. These forms resemble the `yield!` form of the `yield` keyword that is used in sequence expressions. For more information, see [Sequences](../vs140/sequences--fsharp-.md).  
  
## Creating a New Type of Computation Expression  
 You can define the characteristics of your own computation expressions by creating a builder class and defining certain special methods on the class. The builder class can optionally define the methods as listed in the following table.  
  
 The following table describes methods that can be used in a workflow builder class.  
  
||||  
|-|-|-|  
|**Method**|**Typical signature(s)**|**Description**|  
|`Bind`|`M<'T> * ('T -> M<'U>) -> M<'U>`|Called for `let!` and `do!` in computation expressions.|  
|`Delay`|`(unit -> M<'T>) -> M<'T>`|Wraps a computation expression as a function.|  
|`Return`|`'T -> M<'T>`|Called for `return` in computation expressions.|  
|`ReturnFrom`|`M<'T> -> M<'T>`|Called for `return!` in computation expressions.|  
|`Run`|`M<'T> -> M<'T>` or<br /><br /> `M<'T> -> 'T`|Executes a computation expression.|  
|`Combine`|`M<'T> * M<'T> -> M<'T>` or<br /><br /> `M<unit> * M<'T> -> M<'T>`|Called for sequencing in computation expressions.|  
|`For`|`seq<'T> * ('T -> M<'U>) -> M<'U>` or<br /><br /> `seq<'T> * ('T -> M<'U>) -> seq<M<'U>>`|Called for `for...do` expressions in computation expressions.|  
|`TryFinally`|`M<'T> * (unit -> unit) -> M<'T>`|Called for `try...finally` expressions in computation expressions.|  
|`TryWith`|`M<'T> * (exn -> M<'T>) -> M<'T>`|Called for `try...with` expressions in computation expressions.|  
|`Using`|`'T * ('T -> M<'U>) -> M<'U> when 'U :> IDisposable`|Called for `use` bindings in computation expressions.|  
|`While`|`(unit -> bool) * M<'T> -> M<'T>`|Called for `while...do` expressions in computation expressions.|  
|`Yield`|`'T -> M<'T>`|Called for `yield` expressions in computation expressions.|  
|`YieldFrom`|`M<'T> -> M<'T>`|Called for `yield!` expressions in computation expressions.|  
|`Zero`|`unit -> M<'T>`|Called for empty `else` branches of `if...then` expressions in computation expressions.|  
  
 Many of the methods in a builder class use and return an `M<'T>` construct, which is typically a separately defined type that characterizes the kind of computations being combined, for example, `Async<'T>` for asynchronous workflows and `Seq<'T>` for sequence workflows. The signatures of these methods enable them to be combined and nested with each other, so that the workflow object returned from one construct can be passed to the next. The compiler, when it parses a computation expression, converts the expression into a series of nested function calls by using the methods in the preceding table and the code in the computation expression.  
  
 The nested expression is of the following form:  
  
```  
builder.Run(builder.Delay(fun () -> {| cexpr |}))  
```  
  
 In the above code, the calls to `Run` and `Delay` are omitted if they are not defined in the computation expression builder class. The body of the computation expression, here denoted as `{| cexpr |}`, is translated into calls involving the methods of the builder class by the translations described in the following table. The computation expression `{| cexpr |}` is defined recursively according to these translations where `expr` is an F# expression and `cexpr` is a computation expression.  
  
|Expression|Translation|  
|----------------|-----------------|  
|`{&#124; let binding in cexpr &#124;}`|`let binding in {&#124; cexpr &#124;}`|  
|`{&#124; let! pattern = expr in cexpr &#124;}`|`builder.Bind(expr, (fun pattern -> {&#124; cexpr &#124;}))`|  
|`{&#124; do! expr in cexpr &#124;}`|`builder.Bind(expr1, (fun () -> {&#124; cexpr &#124;}))`|  
|`{&#124; yield expr &#124;}`|`builder.Yield(expr)`|  
|`{&#124; yield! expr &#124;}`|`builder.YieldFrom(expr)`|  
|`{&#124; return expr &#124;}`|`builder.Return(expr)`|  
|`{&#124; return! expr &#124;}`|`builder.ReturnFrom(expr)`|  
|`{&#124; use pattern = expr in cexpr &#124;}`|`builder.Using(expr, (fun pattern -> {&#124; cexpr &#124;}))`|  
|`{&#124; use! value = expr in cexpr &#124;}`|`builder.Bind(expr, (fun value -> builder.Using(value, (fun value -> {&#124; cexpr &#124;}))))`|  
|`{&#124; if expr then cexpr0 &#124;}`|`if expr then {&#124; cexpr0 &#124;} else binder.Zero()`|  
|`{&#124; if expr then cexpr0 else cexpr1 &#124;}`|`if expr then {&#124; cexpr0 &#124;} else {&#124; cexpr1 &#124;}`|  
|`{&#124; match expr with &#124; pattern_i -> cexpr_i &#124;}`|`match expr with &#124; pattern_i -> {&#124; cexpr_i &#124;}`|  
|`{&#124; for pattern in expr do cexpr &#124;}`|`builder.For(enumeration, (fun pattern -> {&#124; cexpr }&#124;))`|  
|`{&#124; for identifier = expr1 to expr2 do cexpr &#124;}`|`builder.For(enumeration, (fun identifier -> {&#124; cexpr }&#124;))`|  
|`{&#124; while expr do cexpr &#124;}`|`builder.While(fun () -> expr), builder.Delay({&#124;cexpr &#124;})`|  
|`{&#124; try cexpr with &#124; pattern_i -> expr_i &#124;}`|`builder.TryWith(builder.Delay({&#124; cexpr &#124;}), (fun value -> match value with &#124; pattern_i -> expr_i &#124; exn -> reraise exn)))`|  
|`{&#124; try cexpr finally expr &#124;}`|`builder.TryFinally(builder.Delay( {&#124; cexpr &#124;}), (fun () -> expr))`|  
|`{&#124; cexpr1; cexpr2 &#124;}`|`builder.Combine({&#124;cexpr1 &#124;}, {&#124; cexpr2 &#124;})`|  
|`{&#124; other-expr; cexpr &#124;}`|`expr; {&#124; cexpr &#124;}`|  
|`{&#124; other-expr &#124;}`|`expr; builder.Zero()`|  
  
 In the previous table, `other-expr` describes an expression that is not otherwise listed in the table. A builder class does not need to implement all of the methods and support all of the translations listed in the previous table. Those constructs that are not implemented are not available in computation expressions of that type. For example, if you do not want to support the `use` keyword in your computation expressions, you can omit the definition of `Use` in your builder class.  
  
 The following code example shows a computation expression that encapsulates a computation as a series of steps that can be evaluated one step at a time. A discriminated union type, `OkOrException`, encodes the error state of the expression as evaluated so far. This code demonstrates several typical patterns that you can use in your computation expressions, such as boilerplate implementations of some of the builder methods.  
  
```  
// Computations that can be run step by step  
type Eventually<'T> =  
    | Done of 'T  
    | NotYetDone of (unit -> Eventually<'T>)  
  
module Eventually =  
    // The bind for the computations. Append 'func' to the  
    // computation.  
    let rec bind func expr =  
        match expr with  
        | Done value -> NotYetDone (fun () -> func value)  
        | NotYetDone work -> NotYetDone (fun () -> bind func (work()))  
  
    // Return the final value wrapped in the Eventually type.  
    let result value = Done value  
  
    type OkOrException<'T> =  
    | Ok of 'T  
    | Exception of System.Exception  
  
    // The catch for the computations. Stitch try/with throughout  
    // the computation, and return the overall result as an OkOrException.  
    let rec catch expr =  
        match expr with  
        | Done value -> result (Ok value)  
        | NotYetDone work ->  
            NotYetDone (fun () ->  
            let res = try Ok(work()) with | exn -> Exception exn  
            match res with  
            | Ok cont -> catch cont // note, a tailcall  
            | Exception exn -> result (Exception exn))  
  
    // The delay operator.  
    let delay func = NotYetDone (fun () -> func())  
  
    // The stepping action for the computations.  
    let step expr =  
        match expr with  
        | Done _ -> expr  
        | NotYetDone func -> func ()  
  
    // The rest of the operations are boilerplate.  
    // The tryFinally operator.  
    // This is boilerplate in terms of "result", "catch", and "bind".  
    let tryFinally expr compensation =  
        catch (expr)  
        |> bind (fun res -> compensation();  
                            match res with  
                            | Ok value -> result value  
                            | Exception exn -> raise exn)  
  
    // The tryWith operator.  
    // This is boilerplate in terms of "result", "catch", and "bind".  
    let tryWith exn handler =  
        catch exn  
        |> bind (function Ok value -> result value | Exception exn -> handler exn)  
  
    // The whileLoop operator.  
    // This is boilerplate in terms of "result" and "bind".  
    let rec whileLoop pred body =  
        if pred() then body |> bind (fun _ -> whileLoop pred body)  
        else result ()  
  
    // The sequential composition operator.  
    // This is boilerplate in terms of "result" and "bind".  
    let combine expr1 expr2 =  
        expr1 |> bind (fun () -> expr2)  
  
    // The using operator.  
    let using (resource: #System.IDisposable) func =  
        tryFinally (func resource) (fun () -> resource.Dispose())  
  
    // The forLoop operator.  
    // This is boilerplate in terms of "catch", "result", and "bind".  
    let forLoop (collection:seq<_>) func =  
        let ie = collection.GetEnumerator()  
        tryFinally (whileLoop (fun () -> ie.MoveNext())  
                     (delay (fun () -> let value = ie.Current in func value)))  
                     (fun () -> ie.Dispose())  
  
// The builder class.  
type EventuallyBuilder() =  
    member x.Bind(comp, func) = Eventually.bind func comp  
    member x.Return(value) = Eventually.result value  
    member x.ReturnFrom(value) = value  
    member x.Combine(expr1, expr2) = Eventually.combine expr1 expr2  
    member x.Delay(func) = Eventually.delay func  
    member x.Zero() = Eventually.result ()  
    member x.TryWith(expr, handler) = Eventually.tryWith expr handler  
    member x.TryFinally(expr, compensation) = Eventually.tryFinally expr compensation  
    member x.For(coll:seq<_>, func) = Eventually.forLoop coll func  
    member x.Using(resource, expr) = Eventually.using resource expr  
  
let eventually = new EventuallyBuilder()  
  
let comp =  
    eventually { for x in 1 .. 2 do  
                    printfn " x = %d" x  
                 return 3 + 4 }  
  
// Try the remaining lines in F# interactive to see how this   
// computation expression works in practice.  
let step x = Eventually.step x  
  
// returns "NotYetDone <closure>"  
comp |> step  
  
// prints "x = 1"  
// returns "NotYetDone <closure>"  
comp |> step |> step  
  
// prints "x = 1"  
// prints "x = 2"  
// returns "NotYetDone <closure>"  
comp |> step |> step |> step |> step |> step |> step  
  
// prints "x = 1"  
// prints "x = 2"  
// returns "Done 7"  
comp |> step |> step |> step |> step |> step |> step |> step |> step  
  
```  
  
 A computation expression has an underlying type, which the expression returns. The underlying type may represent a computed result or a delayed computation that can be performed, or it may provide a way to iterate through some type of collection. In the previous example, the underlying type was `Eventually`.For a sequence expression, the underlying type is <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>. For a query expression, the underlying type is <xref:System.Linq.IQueryable`1?qualifyHint=False>. For an asychronous workflow, the underlying type is [Async](../vs140/control.async-class--fsharp-.md). The `Async` object represents the work to be performed to compute the result. For example, you call [Async.RunSynchronously](../vs140/async.runsynchronously--t--method--fsharp-.md) to execute a computation and return the result.  
  
## Custom Operations  
 You can define a custom operation on a computation expression and use a custom operation as an operator in a computation expression. For example, you can include a query operator in a query expression. When you define a custom operation, you must define the Yield and For methods in the computation expression. To define a custom operation, put it in a builder class for the computation expression, and then apply the [CustomOperationAttribute](../vs140/core.customoperationattribute-class--fsharp-.md). This attribute takes a string as an argument, which is the name to be used in a custom operation. This name comes into scope at the start of the opening curly brace of the computation expression. Therefore, you shouldn’t use identifiers that have the same name as a custom operation in this block. For example, avoid the use of identifiers such as `all` or `last` in query expressions.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md)   
 [Sequences (F#)](../vs140/sequences--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)