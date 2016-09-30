---
title: "Lists (F#)"
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
  - "lists [F#]"
ms.assetid: 83102799-f251-42e1-93ef-64232e8c5b1d
caps.latest.revision: 47
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lists (F#)
A list in F# is an ordered, immutable series of elements of the same type. To perform basic operations on lists, use the functions in the [List module](../vs140/collections.list-module--fsharp-.md).  
  
## Creating and Initializing Lists  
 You can define a list by explicitly listing out the elements, separated by semicolons and enclosed in square brackets, as shown in the following line of code.  
  
 [!code[FsLangRef1#1301](../vs140/codesnippet/FSharp/lists--fsharp-_1.fs)]  
  
 You can also put line breaks between elements, in which case the semicolons are optional. The latter syntax can result in more readable code when the element initialization expressions are longer, or when you want to include a comment for each element.  
  
 [!code[FsLangRef1#13011](../vs140/codesnippet/FSharp/lists--fsharp-_2.fs)]  
  
 Normally, all list elements must be the same type. An exception is that a list in which the elements are specified to be a base type can have elements that are derived types. Thus the following is acceptable, because both <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> derive from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef1#13012](../vs140/codesnippet/FSharp/lists--fsharp-_3.fs)]  
  
 You can also define list elements by using a range indicated by integers separated by the range operator (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>), as shown in the following code.  
  
 [!code[FsLangRef1#1302](../vs140/codesnippet/FSharp/lists--fsharp-_4.fs)]  
  
 You can also define a list by using a looping construct, as in the following code.  
  
 [!code[FsLangRef1#1303](../vs140/codesnippet/FSharp/lists--fsharp-_5.fs)]  
  
 An empty list is specified by a pair of square brackets with nothing in between them.  
  
 [!code[FsLangRef1#1304](../vs140/codesnippet/FSharp/lists--fsharp-_6.fs)]  
  
 You can also use a sequence expression to create a list. See "Sequence Expressions" in [Sequences](../vs140/sequences--fsharp-.md). For example, the following code creates a list of squares of integers from 1 to 10.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Operators for Working with Lists  
 You can attach elements to a list by using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (cons) operator. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the following code creates <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef1#1305](../vs140/codesnippet/FSharp/lists--fsharp-_7.fs)]  
  
 You can concatenate lists that have compatible types by using the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator, as in the following code. If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, this code creates <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef1#1306](../vs140/codesnippet/FSharp/lists--fsharp-_8.fs)]  
  
 Functions for performing operations on lists are available in the [List module](../vs140/collections.list-module--fsharp-.md).  
  
 Because lists in F# are immutable, any modifying operations generate new lists instead of modifying existing lists.  
  
 Lists in F# are implemented as singly linked lists, which means that operations that access only the head of the list are O(1), and element access is O(*n*).  
  
## Properties  
 The list type supports the following properties:  
  
|Property|Type|Description|  
|--------------|----------|-----------------|  
|[Head](../vs140/list.head--t--property--fsharp-.md)|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The first element.|  
|[Empty](../vs140/empty--t--property--fsharp-.md)|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|A static property that returns an empty list of the appropriate type.|  
|[IsEmpty](../vs140/list.isempty--t--property--fsharp-.md)|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if the list has no elements.|  
|[Item](../vs140/list.item--t--property--fsharp-.md)|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|The element at the specified index (zero-based).|  
|[Length](../vs140/list.length--t--property--fsharp-.md)|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The number of elements.|  
|[Tail](../vs140/list.tail--t--property--fsharp-.md)|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The list without the first element.|  
  
 Following are some examples of using these properties.  
  
 [!code[FsLangRef1#1307](../vs140/codesnippet/FSharp/lists--fsharp-_9.fs)]  
  
## Using Lists  
 Programming with lists enables you to perform complex operations with a small amount of code. This section describes common operations on lists that are important to functional programming.  
  
### Recursion with Lists  
 Lists are uniquely suited to recursive programming techniques. Consider an operation that must be performed on every element of a list. You can do this recursively by operating on the head of the list and then passing the tail of the list, which is a smaller list that consists of the original list without the first element, back again to the next level of recursion.  
  
 To write such a recursive function, you use the cons operator (<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>) in pattern matching, which enables you to separate the head of a list from the tail.  
  
 The following code example shows how to use pattern matching to implement a recursive function that performs operations on a list.  
  
 [!code[FsLangRef1#13071](../vs140/codesnippet/FSharp/lists--fsharp-_10.fs)]  
  
 The previous code works well for small lists, but for larger lists, it could overflow the stack. The following code improves on this code by using an accumulator argument, a standard technique for working with recursive functions. The use of the accumulator argument makes the function tail recursive, which saves stack space.  
  
 [!code[FsLangRef1#13072](../vs140/codesnippet/FSharp/lists--fsharp-_11.fs)]  
  
 The function <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is a recursive function that takes two lists. The first list contains the numbers whose multiples will be removed, and the second list is the list from which to remove the numbers. The code in the following example uses this recursive function to eliminate all the non-prime numbers from a list, leaving a list of prime numbers as the result.  
  
 [!code[FsLangRef1#1308](../vs140/codesnippet/FSharp/lists--fsharp-_12.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Module Functions  
 The [List module](../vs140/collections.list-module--fsharp-.md) provides functions that access the elements of a list. The head element is the fastest and easiest to access. Use the property [Head](../vs140/list.head--t--property--fsharp-.md) or the module function [List.head](../vs140/list.head--t--function--fsharp-.md). You can access the tail of a list by using the [Tail](../vs140/list.tail--t--property--fsharp-.md) property or the [List.tail](../vs140/list.tail--t--function--fsharp-.md) function. To find an element by index, use the [List.nth](../vs140/list.nth--t--function--fsharp-.md) function. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> traverses the list. Therefore, it is O(*n*). If your code uses <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> frequently, you might want to consider using an array instead of a list. Element access in arrays is O(1).  
  
### Boolean Operations on Lists  
 The [List.isEmpty](../vs140/list.isempty--t--function--fsharp-.md) function determines whether a list has any elements.  
  
 The [List.exists](../vs140/list.exists--t--function--fsharp-.md) function applies a Boolean test to elements of a list and returns <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if any element satisfies the test. [List.exists2](../vs140/list.exists2--t1--t2--function--fsharp-.md) is similar but operates on successive pairs of elements in two lists.  
  
 The following code demonstrates the use of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#1](../vs140/codesnippet/FSharp/lists--fsharp-_13.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example demonstrates the use of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#2](../vs140/codesnippet/FSharp/lists--fsharp-_14.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can use [List.forall](../vs140/list.forall--t--function--fsharp-.md) if you want to test whether all the elements of a list meet a condition.  
  
 [!code[FsLists#3](../vs140/codesnippet/FSharp/lists--fsharp-_15.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Similarly, [List.forall2](../vs140/list.forall2--t1--t2--function--fsharp-.md) determines whether all elements in the corresponding positions in two lists satisfy a Boolean expression that involves each pair of elements.  
  
 [!code[FsLists#4](../vs140/codesnippet/FSharp/lists--fsharp-_16.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Sort Operations on Lists  
 The [List.sort](../vs140/list.sort--t--function--fsharp-.md), [List.sortBy](../vs140/list.sortby--t--key--function--fsharp-.md), and [List.sortWith](../vs140/list.sortwith--t--function--fsharp-.md) functions sort lists. The sorting function determines which of these three functions to use. <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> uses default generic comparison. Generic comparison uses global operators based on the generic compare function to compare values. It works efficiently with a wide variety of element types, such as simple numeric types, tuples, records, discriminated unions, lists, arrays, and any type that implements \<xref:System.IComparable*>. For types that implement \<xref:System.IComparable*>, generic comparison uses the <xref:System.IComparable<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>1.CompareTo*> method.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> takes a function that returns a value that is used as the sort criterion, and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> takes a comparison function as an argument. These latter two functions are useful when you are working with types that do not support comparison, or when the comparison requires more complex comparison semantics, as in the case of culture-aware strings.  
  
 The following example demonstrates the use of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#5](../vs140/codesnippet/FSharp/lists--fsharp-_17.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following example demonstrates the use of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#6](../vs140/codesnippet/FSharp/lists--fsharp-_18.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The next example demonstrates the use of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. In this example, the custom comparison function <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is used to first compare one field of a custom type, and then another when the values of the first field are equal.  
  
 [!code[FsLists#7](../vs140/codesnippet/FSharp/lists--fsharp-_19.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Search Operations on Lists  
 Numerous search operations are supported for lists. The simplest, [List.find](../vs140/list.find--t--function--fsharp-.md), enables you to find the first element that matches a given condition.  
  
 The following code example demonstrates the use of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to find the first number that is divisible by 5 in a list.  
  
 [!code[FsLists#8](../vs140/codesnippet/FSharp/lists--fsharp-_20.fs)]  
  
 The result is 5.  
  
 If the elements must be transformed first, call [List.pick](../vs140/list.pick--t--u--function--fsharp-.md), which takes a function that returns an option, and looks for the first option value that is <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Instead of returning the element, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> returns the result <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. If no matching element is found, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> throws \<xref:System.Collections.Generic.KeyNotFoundException*>. The following code shows the use of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#9](../vs140/codesnippet/FSharp/lists--fsharp-_21.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Another group of search operations, [List.tryFind](../vs140/list.tryfind--t--function--fsharp-.md) and related functions, return an option value. The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function returns the first element of a list that satisfies a condition if such an element exists, but the option value <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if not. The variation [List.tryFindIndex](../vs140/list.tryfindindex--t--function--fsharp-.md) returns the index of the element, if one is found, rather than the element itself. These functions are illustrated in the following code.  
  
 [!code[FsLists#10](../vs140/codesnippet/FSharp/lists--fsharp-_22.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Arithmetic Operations on Lists  
 Common arithmetic operations such as sum and average are built into the [List module](../vs140/collections.list-module--fsharp-.md). To work with [List.sum](../vs140/list.sum-^t--function--fsharp-.md), the list element type must support the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> operator and have a zero value. All built-in arithmetic types satisfy these conditions. To work with [List.average](../vs140/list.average-^t--function--fsharp-.md), the element type must support division without a remainder, which excludes integral types but allows for floating point types. The [List.sumBy](../vs140/list.sumby--t-^u--function--fsharp-.md) and [List.averageBy](../vs140/list.averageby--t-^u--function--fsharp-.md) functions take a function as a parameter, and this function's results are used to calculate the values for the sum or average.  
  
 The following code demonstrates the use of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#11](../vs140/codesnippet/FSharp/lists--fsharp-_23.fs)]  
  
 The output is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 The following code shows the use of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#12](../vs140/codesnippet/FSharp/lists--fsharp-_24.fs)]  
  
 The output is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Lists and Tuples  
 Lists that contain tuples can be manipulated by zip and unzip functions. These functions combine two lists of single values into one list of tuples or separate one list of tuples into two lists of single values. The simplest [List.zip](../vs140/list.zip--t1--t2--function--fsharp-.md) function takes two lists of single elements and produces a single list of tuple pairs. Another version, [List.zip3](../vs140/list.zip3--t1--t2--t3--function--fsharp-.md), takes three lists of single elements and produces a single list of tuples that have three elements. The following code example demonstrates the use of <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#13](../vs140/codesnippet/FSharp/lists--fsharp-_25.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The following code example demonstrates the use of <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#14](../vs140/codesnippet/FSharp/lists--fsharp-_26.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The corresponding unzip versions, [List.unzip](../vs140/list.unzip--t1--t2--function--fsharp-.md) and [List.unzip3](../vs140/list.unzip3--t1--t2--t3--function--fsharp-.md), take lists of tuples and return lists in a tuple, where the first list contains all the elements that were first in each tuple, and the second list contains the second element of each tuple, and so on.  
  
 The following code example demonstrates the use of [List.unzip](../vs140/list.unzip--t1--t2--function--fsharp-.md).  
  
 [!code[FsLists#15](../vs140/codesnippet/FSharp/lists--fsharp-_27.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The following code example demonstrates the use of [List.unzip3](../vs140/list.unzip3--t1--t2--t3--function--fsharp-.md).  
  
 [!code[FsLists#16](../vs140/codesnippet/FSharp/lists--fsharp-_28.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Operating on List Elements  
 F# supports a variety of operations on list elements. The simplest is [List.iter](../vs140/list.iter--t--function--fsharp-.md), which enables you to call a function on every element of a list. Variations include [List.iter2](../vs140/list.iter2--t1--t2--function--fsharp-.md), which enables you to perform an operation on elements of two lists, [List.iteri](../vs140/list.iteri--t--function--fsharp-.md), which is like <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> except that the index of each element is passed as an argument to the function that is called for each element, and [List.iteri2](../vs140/list.iteri2--t1--t2--function--fsharp-.md), which is a combination of the functionality of <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. The following code example illustrates these functions.  
  
 [!code[FsLists#17](../vs140/codesnippet/FSharp/lists--fsharp-_29.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Another frequently used function that transforms list elements is [List.map](../vs140/list.map--t--u--function--fsharp-.md), which enables you to apply a function to each element of a list and put all the results into a new list. [List.map2](../vs140/list.map2--t1--t2--u--function--fsharp-.md) and [List.map3](../vs140/list.map3--t1--t2--t3--u--function--fsharp-.md) are variations that take multiple lists. You can also use [List.mapi](../vs140/list.mapi--t--u--function--fsharp-.md) and [List.mapi2](../vs140/list.mapi2--t1--t2--u--function--fsharp-.md), if, in addition to the element, the function needs to be passed the index of each element. The only difference between <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> works with two lists. The following example illustrates [List.map](../vs140/list.map--t--u--function--fsharp-.md).  
  
 [!code[FsLists#18](../vs140/codesnippet/FSharp/lists--fsharp-_30.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The following example shows the use of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#19](../vs140/codesnippet/FSharp/lists--fsharp-_31.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The following example shows the use of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#20](../vs140/codesnippet/FSharp/lists--fsharp-_32.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The following example shows the use of <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#21](../vs140/codesnippet/FSharp/lists--fsharp-_33.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The following example shows the use of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#22](../vs140/codesnippet/FSharp/lists--fsharp-_34.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [List.collect](../vs140/list.collect--t--u--function--fsharp-.md) is like <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, except that each element produces a list and all these lists are concatenated into a final list. In the following code, each element of the list generates three numbers. These are all collected into one list.  
  
 [!code[FsLists#23](../vs140/codesnippet/FSharp/lists--fsharp-_35.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 You can also use [List.filter](../vs140/list.filter--t--function--fsharp-.md), which takes a Boolean condition and produces a new list that consists only of elements that satisfy the given condition.  
  
 [!code[FsLists#24](../vs140/codesnippet/FSharp/lists--fsharp-_36.fs)]  
  
 The resulting list is <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
 A combination of map and filter, [List.choose](../vs140/list.choose--t--u--function--fsharp-.md) enables you to transform and select elements at the same time. <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> applies a function that returns an option to each element of a list, and returns a new list of the results for elements when the function returns the option value <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 The following code demonstrates the use of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to select capitalized words out of a list of words.  
  
 [!code[FsLists#25](../vs140/codesnippet/FSharp/lists--fsharp-_37.fs)]  
  
 The output is as follows:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Operating on Multiple Lists  
 Lists can be joined together. To join two lists into one, use [List.append](../vs140/list.append--t--function--fsharp-.md). To join more than two lists, use [List.concat](../vs140/list.concat--t--function--fsharp-.md).  
  
 [!code[FsLists#26](../vs140/codesnippet/FSharp/lists--fsharp-_38.fs)]  
  
### Fold and Scan Operations  
 Some list operations involve interdependencies between all of the list elements. The fold and scan operations are like <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> in that you invoke a function on each element, but these operations provide an additional parameter called the *accumulator* that carries information through the computation.  
  
 Use <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to perform a calculation on a list.  
  
 The following code example demonstrates the use of [List.fold](../vs140/list.fold--t--state--function--fsharp-.md) to perform various operations.  
  
 The list is traversed; the accumulator <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is a value that is passed along as the calculation proceeds. The first argument takes the accumulator and the list element, and returns the interim result of the calculation for that list element. The second argument is the initial value of the accumulator.  
  
 [!code[FsLists#27](../vs140/codesnippet/FSharp/lists--fsharp-_39.fs)]  
  
 The versions of these functions that have a digit in the function name operate on more than one list. For example, [List.fold2](../vs140/list.fold2--t1--t2--state--function--fsharp-.md) performs computations on two lists.  
  
 The following example demonstrates the use of <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#28](../vs140/codesnippet/FSharp/lists--fsharp-_40.fs)]  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> and [List.scan](../vs140/list.scan--t--state--function--fsharp-.md) differ in that <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> returns the final value of the extra parameter, but <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> returns the list of the intermediate values (along with the final value) of the extra parameter.  
  
 Each of these functions includes a reverse variation, for example, [List.foldBack](../vs140/list.foldback--t--state--function--fsharp-.md), which differs in the order in which the list is traversed and the order of the arguments. Also, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> have variations, [List.fold2](../vs140/list.fold2--t1--t2--state--function--fsharp-.md) and [List.foldBack2](../vs140/list.foldback2--t1--t2--state--function--fsharp-.md), that take two lists of equal length. The function that executes on each element can use corresponding elements of both lists to perform some action. The element types of the two lists can be different, as in the following example, in which one list contains transaction amounts for a bank account, and the other list contains the type of transaction: deposit or withdrawal.  
  
 [!code[FsLists#29](../vs140/codesnippet/FSharp/lists--fsharp-_41.fs)]  
  
 For a calculation like summation, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> have the same effect because the result does not depend on the order of traversal. In the following example, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is used to add the elements in a list.  
  
 [!code[FsLists#30](../vs140/codesnippet/FSharp/lists--fsharp-_42.fs)]  
  
 The following example returns to the bank account example. This time a new transaction type is added: an interest calculation. The ending balance now depends on the order of transactions.  
  
 [!code[FsLists#34](../vs140/codesnippet/FSharp/lists--fsharp-_43.fs)]  
  
 The function [List.reduce](../vs140/list.reduce--t--function--fsharp-.md) is somewhat like <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, except that instead of passing around a separate accumulator, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> takes a function that takes two arguments of the element type instead of just one, and one of those arguments acts as the accumulator, meaning that it stores the intermediate result of the computation. <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> starts by operating on the first two list elements, and then uses the result of the operation along with the next element. Because there is not a separate accumulator that has its own type, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> can be used in place of <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> only when the accumulator and the element type have the same type. The following code demonstrates the use of <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> throws an exception if the list provided has no elements.  
  
 In the following code, the first call to the lambda expression is given the arguments 2 and 4, and returns 6, and the next call is given the arguments 6 and 10, so the result is 16.  
  
 [!code[FsLists#33](../vs140/codesnippet/FSharp/lists--fsharp-_44.fs)]  
  
### Converting Between Lists and Other Collection Types  
 The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> module provides functions for converting to and from both sequences and arrays. To convert to or from a sequence, use [List.toSeq](../vs140/list.toseq--t--function--fsharp-.md) or [List.ofSeq](../vs140/list.ofseq--t--function--fsharp-.md). To convert to or from an array, use [List.toArray](../vs140/list.toarray--t--function--fsharp-.md) or [List.ofArray](../vs140/list.ofarray--t--function--fsharp-.md).  
  
### Additional Operations  
 For information about additional operations on lists, see the library reference topic [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [F# Types](../vs140/fsharp-types.md)   
 [Sequences](../vs140/sequences--fsharp-.md)   
 [Arrays](../vs140/arrays--fsharp-.md)   
 [Options (F#)](../vs140/options--fsharp-.md)