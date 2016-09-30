---
title: "Arrays (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "arrays [F#]"
ms.assetid: 70ad71f0-f4bf-42d7-b1a9-44a2f4bd2c6f
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays (F#)
Arrays are fixed-size, zero-based, mutable collections of consecutive data elements that are all of the same type.  
  
## Creating Arrays  
 You can create arrays in several ways. You can create a small array by listing consecutive values between [&#124; and &#124;] and separated by semicolons, as shown in the following examples.  
  
 [!code[FsArrays#1](../vs140/codesnippet/FSharp/arrays--fsharp-_1.fs)]  
  
 You can also put each element on a separate line, in which case the semicolon separator is optional.  
  
 [!code[FsArrays#2](../vs140/codesnippet/FSharp/arrays--fsharp-_2.fs)]  
  
 The type of the array elements is inferred from the literals used and must be consistent. The following code causes an error because 1.0 is a float and 2 and 3 are integers.  
  
```f#  
// Causes an error.  
// let array2 = [| 1.0; 2; 3 |]   
```  
  
 You can also use sequence expressions to create arrays. Following is an example that creates an array of squares of integers from 1 to 10.  
  
 [!code[FsArrays#3](../vs140/codesnippet/FSharp/arrays--fsharp-_3.fs)]  
  
 To create an array in which all the elements are initialized to zero, use `Array.zeroCreate`.  
  
 [!code[FsArrays#4](../vs140/codesnippet/FSharp/arrays--fsharp-_4.fs)]  
  
## Accessing Elements  
 You can access array elements by using a dot operator (.) and brackets ([ and ]).  
  
 [!code[FsArrays#5](../vs140/codesnippet/FSharp/arrays--fsharp-_5.fs)]  
  
 Array indices start at 0.  
  
 You can also access array elements by using slice notation, which enables you to specify a subrange of the array. Examples of slice notation follow.  
  
 [!code[FsArrays#51](../vs140/codesnippet/FSharp/arrays--fsharp-_6.fs)]  
  
 When slice notation is used, a new copy of the array is created.  
  
## Array Types and Modules  
 The type of all F# arrays is the .NET Framework type \<xref:System.Array*>. Therefore, F# arrays support all the functionality available in \<xref:System.Array*>.  
  
 The library module [Microsoft.FSharp.Collections.Array](../vs140/collections.array-module--fsharp-.md) supports operations on one-dimensional arrays. The modules `Array2D`, `Array3D`, and `Array4D` contain functions that support operations on arrays of two, three, and four dimensions, respectively. You can create arrays of rank greater than four by using \<xref:System.Array*>.  
  
### Simple Functions  
 [Array.get](../vs140/array.get--t--function--fsharp-.md) gets an element. [Array.length](../vs140/array.length--t--function--fsharp-.md) gives the length of an array. [Array.set](../vs140/array.set--t--function--fsharp-.md) sets an element to a specified value. The following code example illustrates the use of these functions.  
  
 [!code[FsArrays#9](../vs140/codesnippet/FSharp/arrays--fsharp-_7.fs)]  
  
 The output is as follows.  
  
```  
0 1 2 3 4 5 6 7 8 9  
```  
  
### Functions That Create Arrays  
 Several functions create arrays without requiring an existing array. [Array.empty](../vs140/array.empty--t--type-function--fsharp-.md) creates a new array that does not contain any elements. [Array.create](../vs140/array.create--t--function--fsharp-.md) creates an array of a specified size and sets all the elements to provided values. [Array.init](../vs140/array.init--t--function--fsharp-.md) creates an array, given a dimension and a function to generate the elements. [Array.zeroCreate](../vs140/array.zerocreate--t--function--fsharp-.md) creates an array in which all the elements are initialized to the zero value for the array's type. The following code demonstrates these functions.  
  
 [!code[FsArrays#91](../vs140/codesnippet/FSharp/arrays--fsharp-_8.fs)]  
  
 The output is as follows.  
  
```  
Length of empty array: 0  
Area of floats set to 5.0: [|5.0; 5.0; 5.0; 5.0; 5.0; 5.0; 5.0; 5.0; 5.0; 5.0|]  
Array of squares: [|0; 1; 4; 9; 16; 25; 36; 49; 64; 81|]  
```  
  
 [Array.copy](../vs140/array.copy--t--function--fsharp-.md) creates a new array that contains elements that are copied from an existing array. Note that the copy is a shallow copy, which means that if the element type is a reference type, only the reference is copied, not the underlying object. The following code example illustrates this.  
  
 [!code[FsArrays#11](../vs140/codesnippet/FSharp/arrays--fsharp-_9.fs)]  
  
 The output of the preceding code is as follows:  
  
```  
[|Test1; Test2; |]  
[|; Test2; |]  
```  
  
 The string `Test1` appears only in the first array because the operation of creating a new element overwrites the reference in `firstArray` but does not affect the original reference to an empty string that is still present in `secondArray`. The string `Test2` appears in both arrays because the `Insert` operation on the \<xref:System.Text.StringBuilder*> type affects the underlying \<xref:System.Text.StringBuilder*> object, which is referenced in both arrays.  
  
 [Array.sub](../vs140/array.sub--t--function--fsharp-.md) generates a new array from a subrange of an array. You specify the subrange by providing the starting index and the length. The following code demonstrates the use of `Array.sub`.  
  
 [!code[FsArrays#12](../vs140/codesnippet/FSharp/arrays--fsharp-_10.fs)]  
  
 The output shows that the subarray starts at element 5 and contains 10 elements.  
  
```  
[|5; 6; 7; 8; 9; 10; 11; 12; 13; 14|]  
```  
  
 [Array.append](../vs140/array.append--t--function--fsharp-.md) creates a new array by combining two existing arrays.  
  
 The following code demonstrates `Array.append`.  
  
 [!code[FsArrays#13](../vs140/codesnippet/FSharp/arrays--fsharp-_11.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
[|1; 2; 3; 4; 5; 6|]  
```  
  
 [Array.choose](../vs140/array.choose--t--u--function--fsharp-.md) selects elements of an array to include in a new array. The following code demonstrates `Array.choose`. Note that the element type of the array does not have to match the type of the value returned in the option type. In this example, the element type is `int` and the option is the result of a polynomial function, `elem*elem - 1`, as a floating point number.  
  
 [!code[FsArrays#14](../vs140/codesnippet/FSharp/arrays--fsharp-_12.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
[|3.0; 15.0; 35.0; 63.0; 99.0|]  
```  
  
 [Array.collect](../vs140/array.collect--t--u--function--fsharp-.md) runs a specified function on each array element of an existing array and then collects the elements generated by the function and combines them into a new array. The following code demonstrates `Array.collect`.  
  
 [!code[FsArrays#15](../vs140/codesnippet/FSharp/arrays--fsharp-_13.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
[|0; 1; 0; 1; 2; 3; 4; 5; 0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]  
```  
  
 [Array.concat](../vs140/array.concat--t--function--fsharp-.md) takes a sequence of arrays and combines them into a single array. The following code demonstrates `Array.concat`.  
  
 [!code[FsArrays#16](../vs140/codesnippet/FSharp/arrays--fsharp-_14.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
[|(1, 1, 1); (1, 2, 2); (1, 3, 3); (2, 1, 2); (2, 2, 4); (2, 3, 6); (3, 1, 3);  
  (3, 2, 6); (3, 3, 9)|]  
```  
  
 [Array.filter](../vs140/array.filter--t--function--fsharp-.md) takes a Boolean condition function and generates a new array that contains only those elements from the input array for which the condition is true. The following code demonstrates `Array.filter`.  
  
 [!code[FsArrays#17](../vs140/codesnippet/FSharp/arrays--fsharp-_15.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
[|2; 4; 6; 8; 10|]  
```  
  
 [Array.rev](../vs140/array.rev--t--function--fsharp-.md) generates a new array by reversing the order of an existing array. The following code demonstrates `Array.rev`.  
  
 [!code[FsArrays#18](../vs140/codesnippet/FSharp/arrays--fsharp-_16.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
"Hello world!"  
```  
  
 You can easily combine functions in the array module that transform arrays by using the pipeline operator (&#124;>), as shown in the following example.  
  
 [!code[FsArrays#19](../vs140/codesnippet/FSharp/arrays--fsharp-_17.fs)]  
  
 The output is  
  
```  
[|100; 36; 16; 4|]  
```  
  
### Multidimensional Arrays  
 A multidimensional array can be created, but there is no syntax for writing a multidimensional array literal. Use the operator [array2D](../vs140/extratopleveloperators.array2d--t--function--fsharp-.md) to create an array from a sequence of sequences of array elements. The sequences can be array or list literals. For example, the following code creates a two-dimensional array.  
  
 [!code[FsArrays#20](../vs140/codesnippet/FSharp/arrays--fsharp-_18.fs)]  
  
 You can also use the function [Array2D.init](../vs140/array2d.init--t--function--fsharp-.md) to initialize arrays of two dimensions, and similar functions are available for arrays of three and four dimensions. These functions take a function that is used to create the elements. To create a two-dimensional array that contains elements set to an initial value instead of specifying a function, use the [Array2D.create](../vs140/array2d.create--t--function--fsharp-.md) function, which is also available for arrays up to four dimensions. The following code example first shows how to create an array of arrays that contain the desired elements, and then uses `Array2D.init` to generate the desired two-dimensional array.  
  
 [!code[FsArrays#21](../vs140/codesnippet/FSharp/arrays--fsharp-_19.fs)]  
  
 Array indexing and slicing syntax is supported for arrays up to rank 4. When you specify an index in multiple dimensions, you use commas to separate the indices, as illustrated in the following code example.  
  
 [!code[FsArrays#22](../vs140/codesnippet/FSharp/arrays--fsharp-_20.fs)]  
  
 The type of a two-dimensional array is written out as `<type>[,]` (for example, `int[,]`, `double[,]`), and the type of a three-dimensional array is written as `<type>[,,]`, and so on for arrays of higher dimensions.  
  
 Only a subset of the functions available for one-dimensional arrays is also available for multidimensional arrays. For more information, see [Collections.Array Module](../vs140/collections.array-module--fsharp-.md), [Collections.Array2D Module](../vs140/collections.array2d-module--fsharp-.md), [Collections.Array3D Module](../vs140/collections.array3d-module--fsharp-.md), and [Collections.Array4D Module](../vs140/collections.array4d-module--fsharp-.md).  
  
### Array Slicing and Multidimensional Arrays  
 In a two-dimensional array (a matrix), you can extract a sub-matrix by specifying ranges and using a wildcard (*) character to specify whole rows or columns.  
  
```f#  
  
// Get rows 1 to N from an NxM matrix (returns a matrix):  
matrix.[1.., *]  
  
// Get rows 1 to 3 from a matrix (returns a matrix):  
matrix.[1..3, *]  
  
// Get columns 1 to 3 from a matrix (returns a matrix):  
matrix.[*, 1..3]  
  
// Get a 3x3 submatrix:  
matrix.[1..3, 1..3]  
```  
  
 As of F# 3.1, you can decompose a multidimensional array into subarrays of the same or lower dimension. For example, you can obtain a vector from a matrix by specifying a single row or column.  
  
```f#  
  
// Get row 3 from a matrix as a vector:  
matrix.[3, *]  
  
// Get column 3 from a matrix as a vector:  
matrix.[*, 3]  
```  
  
 You can use this slicing syntax for types that implement the element access operators and overloaded `GetSlice` methods. For example, the following code creates a Matrix type that wraps the F# 2D array, implements an Item property to provide support for array indexing, and implements three versions of `GetSlice`. If you can use this code as a template for your matrix types, you can use all the slicing operations that this section describes.  
  
```f#  
type Matrix<'T>(N: int, M: int) =  
    let internalArray = Array2D.zeroCreate<'T> N M  
  
    member this.Item  
        with get(a: int, b: int) = internalArray.[a, b]  
        and set(a: int, b: int) (value:'T) = internalArray.[a, b] <- value  
  
    member this.GetSlice(rowStart: int option, rowFinish : int option,  
                         colStart: int option, colFinish : int option) =  
           let rowStart = match rowStart with  
                          | Some(v) -> v  
                          | None -> 0  
           let rowFinish = match rowFinish with  
                           | Some(v) -> v  
                           | None -> internalArray.GetLength(0) - 1  
           let colStart = match colStart with  
                          | Some(v) -> v  
                          | None -> 0  
           let colFinish = match colFinish with  
                           | Some(v) -> v  
                           | None -> internalArray.GetLength(1) - 1  
           internalArray.[rowStart..rowFinish, colStart..colFinish]  
  
    member this.GetSlice(row: int, colStart: int option, colFinish: int option) =  
           let colStart = match colStart with  
                          | Some(v) -> v  
                          | None -> 0  
           let colFinish = match colFinish with  
                           | Some(v) -> v  
                           | None -> internalArray.GetLength(1) - 1  
           internalArray.[row, colStart..colFinish]  
  
    member this.GetSlice(rowStart: int option, rowFinish: int option, col: int) =  
           let rowStart = match rowStart with  
                          | Some(v) -> v  
                          | None -> 0  
           let rowFinish = match rowFinish with  
                           | Some(v) -> v  
                           | None -> internalArray.GetLength(0) - 1  
           internalArray.[rowStart..rowFinish, col]  
  
module test =  
  
    let generateTestMatrix x y =  
        let matrix = new Matrix<float>(3, 3);  
        for i in 0..2 do  
           for j in 0..2 do  
               matrix.[i, j] <- float(i) * x - float(j) * y  
        matrix  
  
    let test1 = generateTestMatrix 2.3 1.1  
    let submatrix = test1.[0..1, 0..1]  
    printfn "%A" submatrix  
  
    let firstRow = test1.[0,*]  
    let secondRow = test1.[1,*]  
    let firstCol = test1.[*,0]  
    printfn "%A" firstCol  
  
```  
  
### Boolean Functions on Arrays  
 The functions [Array.exists](../vs140/array.exists--t--function--fsharp-.md) and [Array.exists2](../vs140/array.exists2--t1--t2--function--fsharp-.md) test elements in either one or two arrays, respectively. These functions take a test function and return `true` if there is an element (or element pair for `Array.exists2`) that satisfies the condition.  
  
 The following code demonstrates the use of `Array.exists` and `Array.exists2`. In these examples, new functions are created by applying only one of the arguments, in these cases, the function argument.  
  
 [!code[FsArrays#23](../vs140/codesnippet/FSharp/arrays--fsharp-_21.fs)]  
  
 The output of the preceding code is as follows.  
  
```  
true  
false  
false  
true  
```  
  
 Similarly, the function [Array.forall](../vs140/array.forall--t--function--fsharp-.md) tests an array to determine whether every element satisfies a Boolean condition. The variation [Array.forall2](../vs140/array.forall2--t1--t2--function--fsharp-.md) does the same thing by using a Boolean function that involves elements of two arrays of equal length. The following code illustrates the use of these functions.  
  
 [!code[FsArrays#24](../vs140/codesnippet/FSharp/arrays--fsharp-_22.fs)]  
  
 The output for these examples is as follows.  
  
```  
false  
true  
true  
false  
```  
  
### Searching Arrays  
 [Array.find](../vs140/array.find--t--function--fsharp-.md) takes a Boolean function and returns the first element for which the function returns `true`, or raises a \<xref:System.Collections.Generic.KeyNotFoundException*> if no element that satisfies the condition is found. [Array.findIndex](../vs140/array.findindex--t--function--fsharp-.md) is like `Array.find`, except that it returns the index of the element instead of the element itself.  
  
 The following code uses `Array.find` and `Array.findIndex` to locate a number that is both a perfect square and perfect cube.  
  
 [!code[FsArrays#25](../vs140/codesnippet/FSharp/arrays--fsharp-_23.fs)]  
  
 The output is as follows.  
  
```  
The first element that is both a square and a cube is 64 and its index is 62.  
```  
  
 [Array.tryFind](../vs140/array.tryfind--t--function--fsharp-.md) is like `Array.find`, except that its result is an option type, and it returns `None` if no element is found. `Array.tryFind` should be used instead of `Array.find` when you do not know whether a matching element is in the array. Similarly, [Array.tryFindIndex](../vs140/array.tryfindindex--t--function--fsharp-.md) is like [Array.findIndex](../vs140/array.findindex--t--function--fsharp-.md) except that the option type is the return value. If no element is found, the option is `None`.  
  
 The following code demonstrates the use of `Array.tryFind`. This code depends on the previous code.  
  
 [!code[FsArrays#26](../vs140/codesnippet/FSharp/arrays--fsharp-_24.fs)]  
  
 The output is as follows.  
  
```  
Found an element: 1  
Found an element: 729  
```  
  
 Use [Array.tryPick](../vs140/array.trypick--t--u--function--fsharp-.md) when you need to transform an element in addition to finding it. The result is the first element for which the function returns the transformed element as an option value, or `None` if no such element is found.  
  
 The following code shows the use of `Array.tryPick`. In this case, instead of a lambda expression, several local helper functions are defined to simplify the code.  
  
 [!code[FsArrays#27](../vs140/codesnippet/FSharp/arrays--fsharp-_25.fs)]  
  
 The output is as follows.  
  
```  
Found an element 1 with square root 1 and cube root 1.  
Found an element 64 with square root 8 and cube root 4.  
Found an element 729 with square root 27 and cube root 9.  
Found an element 4096 with square root 64 and cube root 16.  
```  
  
### Performing Computations on Arrays  
 The [Array.average](../vs140/array.average-^t--function--fsharp-.md) function returns the average of each element in an array. It is limited to element types that support exact division by an integer, which includes floating point types but not integral types. The [Array.averageBy](../vs140/array.averageby--t-^u--function--fsharp-.md) function returns the average of the results of calling a function on each element. For an array of integral type, you can use `Array.averageBy` and have the function convert each element to a floating point type for the computation.  
  
 Use [Array.max](../vs140/array.max--t--function--fsharp-.md) or [Array.min](../vs140/array.min--t--function--fsharp-.md) to get the maximum or minimum element, if the element type supports it. Similarly, [Array.maxBy](../vs140/array.maxby--t--u--function--fsharp-.md) and [Array.minBy](../vs140/array.minby--t--u--function--fsharp-.md) allow a function to be executed first, perhaps to transform to a type that supports comparison.  
  
 [Array.sum](../vs140/array.sum-^t--function--fsharp-.md) adds the elements of an array, and [Array.sumBy](../vs140/array.sumby--t-^u--function--fsharp-.md) calls a function on each element and adds the results together.  
  
 To execute a function on each element in an array without storing the return values, use [Array.iter](../vs140/array.iter--t--function--fsharp-.md). For a function involving two arrays of equal length, use [Array.iter2](../vs140/array.iter2--t1--t2--function--fsharp-.md). If you also need to keep an array of the results of the function, use [Array.map](../vs140/array.map--t--u--function--fsharp-.md) or [Array.map2](../vs140/array.map2--t1--t2--u--function--fsharp-.md), which operates on two arrays at a time.  
  
 The variations [Array.iteri](../vs140/array.iteri--t--function--fsharp-.md) and [Array.iteri2](../vs140/array.iteri2--t1--t2--function--fsharp-.md) allow the index of the element to be involved in the computation; the same is true for [Array.mapi](../vs140/array.mapi--t--u--function--fsharp-.md) and [Array.mapi2](../vs140/array.mapi2--t1--t2--u--function--fsharp-.md).  
  
 The functions [Array.fold](../vs140/array.fold--t--state--function--fsharp-.md), [Array.foldBack](../vs140/array.foldback--t--state--function--fsharp-.md), [Array.reduce](../vs140/array.reduce--t--function--fsharp-.md), [Array.reduceBack](../vs140/array.reduceback--t--function--fsharp-.md), [Array.scan](../vs140/array.scan--t--state--function--fsharp-.md), and [Array.scanBack](../vs140/array.scanback--t--state--function--fsharp-.md) execute algorithms that involve all the elements of an array. Similarly, the variations [Array.fold2](../vs140/array.fold2--t1--t2--state--function--fsharp-.md) and [Array.foldBack2](../vs140/array.foldback2--t1--t2--state--function--fsharp-.md) perform computations on two arrays.  
  
 These functions for performing computations correspond to the functions of the same name in the [List module](../vs140/collections.list-module--fsharp-.md). For usage examples, see [Lists (F#)](../vs140/lists--fsharp-.md).  
  
### Modifying Arrays  
 [Array.set](../vs140/array.set--t--function--fsharp-.md) sets an element to a specified value. [Array.fill](../vs140/array.fill--t--function--fsharp-.md) sets a range of elements in an array to a specified value. The following code provides an example of `Array.fill`.  
  
 [!code[FsArrays#28](../vs140/codesnippet/FSharp/arrays--fsharp-_26.fs)]  
  
 The output is as follows.  
  
```  
[|1; 2; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 23; 24; 25|]  
```  
  
 You can use [Array.blit](../vs140/array.blit--t--function--fsharp-.md) to copy a subsection of one array to another array.  
  
### Converting to and from Other Types  
 [Array.ofList](../vs140/array.oflist--t--function--fsharp-.md) creates an array from a list. [Array.ofSeq](../vs140/array.ofseq--t--function--fsharp-.md) creates an array from a sequence. [Array.toList](../vs140/array.tolist--t--function--fsharp-.md) and [Array.toSeq](../vs140/array.toseq--t--function--fsharp-.md) convert to these other collection types from the array type.  
  
### Sorting Arrays  
 Use [Array.sort](../vs140/array.sort--t--function--fsharp-.md) to sort an array by using the generic comparison function. Use [Array.sortBy](../vs140/array.sortby--t--key--function--fsharp-.md) to specify a function that generates a value, referred to as a *key*, to sort by using the generic comparison function on the key. Use [Array.sortWith](../vs140/array.sortwith--t--function--fsharp-.md) if you want to provide a custom comparison function. `Array.sort`, `Array.sortBy`, and `Array.sortWith` all return the sorted array as a new array. The variations [Array.sortInPlace](../vs140/array.sortinplace--t--function--fsharp-.md), [Array.sortInPlaceBy](../vs140/array.sortinplaceby--t--key--function--fsharp-.md), and [Array.sortInPlaceWith](../vs140/array.sortinplacewith--t--function--fsharp-.md) modify the existing array instead of returning a new one.  
  
### Arrays and Tuples  
 The functions [Array.zip](../vs140/array.zip--t1--t2--function--fsharp-.md) and [Array.unzip](../vs140/array.unzip--t1--t2--function--fsharp-.md) convert arrays of tuple pairs to tuples of arrays and vice versa. [Array.zip3](../vs140/array.zip3--t1--t2--t3--function--fsharp-.md) and [Array.unzip3](../vs140/array.unzip3--t1--t2--t3--function--fsharp-.md) are similar except that they work with tuples of three elements or tuples of three arrays.  
  
## Parallel Computations on Arrays  
 The module [Array.Parallel](../vs140/array.parallel-module--fsharp-.md) contains functions for performing parallel computations on arrays. This module is not available in applications that target versions of the .NET Framework prior to version 4.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [F# Types](../vs140/fsharp-types.md)