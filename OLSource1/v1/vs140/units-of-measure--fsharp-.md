---
title: "Units of Measure (F#)"
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
  - "units of measure [F#]"
ms.assetid: e32d888b-fa25-40bf-943f-e502a80aa198
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Units of Measure (F#)
Floating point and signed integer values in F# can have associated units of measure, which are typically used to indicate length, volume, mass, and so on. By using quantities with units, you enable the compiler to verify that arithmetic relationships have the correct units, which helps prevent programming errors.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The previous syntax defines <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as a unit of measure. The optional part is used to define a new measure in terms of previously defined units. For example, the following line defines the measure <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (centimeter).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following line defines the measure <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (milliliter) as a cubic centimeter (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the previous syntax, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a formula that involves units. In formulas that involve units, integral powers are supported (positive and negative), spaces between units indicate a product of the two units, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> also indicates a product of units, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> indicates a quotient of units. For a reciprocal unit, you can either use a negative integer power or a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that indicates a separation between the numerator and denominator of a unit formula. Multiple units in the denominator should be surrounded by parentheses. Units separated by spaces after a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are interpreted as being part of the denominator, but any units following a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are interpreted as being part of the numerator.  
  
 You can use 1 in unit expressions, either alone to indicate a dimensionless quantity, or together with other units, such as in the numerator. For example, the units for a rate would be written as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> indicates seconds. Parentheses are not used in unit formulas. You do not specify numeric conversion constants in the unit formulas; however, you can define conversion constants with units separately and use them in unit-checked computations.  
  
 Unit formulas that mean the same thing can be written in various equivalent ways. Therefore, the compiler converts unit formulas into a consistent form, which converts negative powers to reciprocals, groups units into a single numerator and a denominator, and alphabetizes the units in the numerator and denominator.  
  
 For example, the unit formulas <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are both converted to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 You use units of measure in floating point expressions. Using floating point numbers together with associated units of measure adds another level of type safety and helps avoid the unit mismatch errors that can occur in formulas when you use weakly typed floating point numbers. If you write a floating point expression that uses units, the units in the expression must match.  
  
 You can annotate literals with a unit formula in angle brackets, as shown in the following examples.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You do not put a space between the number and the angle bracket; however, you can include a literal suffix such as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, as in the following example.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Such an annotation changes the type of the literal from its primitive type (such as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) to a dimensioned type, such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or, in this case, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. A unit annotation of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> indicates a dimensionless quantity, and its type is equivalent to the primitive type without a unit parameter.  
  
 The type of a unit of measure is a floating point or signed integral type together with an extra unit annotation, indicated in brackets. Thus, when you write the type of a conversion from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (grams) to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (kilograms), you describe the types as follows.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Units of measure are used for compile-time unit checking but are not persisted in the run-time environment. Therefore, they do not affect performance.  
  
 Units of measure can be applied to any type, not just floating point types; however, only floating point types, signed integral types, and decimal types support dimensioned quantities. Therefore, it only makes sense to use units of measure on the primitive types and on aggregates that contain these primitive types.  
  
 The following example illustrates the use of units of measure.  
  
 [!code[FsLangRef2#6901](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_1.fs)]  
  
 The following code example illustrates how to convert from a dimensionless floating point number to a dimensioned floating point value. You just multiply by 1.0, applying the dimensions to the 1.0. You can abstract this into a function like <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 Also, when you pass dimensioned values to functions that expect dimensionless floating point numbers, you must cancel out the units or cast to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> by using the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator. In this example, you divide by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> for the arguments to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> expects dimensionless quantities.  
  
 [!code[FsLangRef2#6902](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_2.fs)]  
  
 The following example session shows the outputs from and inputs to this code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Using Generic Units  
 You can write generic functions that operate on data that has an associated unit of measure. You do this by specifying a type together with a generic unit as a type parameter, as shown in the following code example.  
  
 [!code[FsLangRef2#6903](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_3.fs)]  
  
## Creating Aggregate Types with Generic Units  
 The following code shows how to create an aggregate type that consists of individual floating point values that have units that are generic. This enables a single type to be created that works with a variety of units. Also, generic units preserve type safety by ensuring that a generic type that has one set of units is a different type than the same generic type with a different set of units. The basis of this technique is that the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attribute can be applied to the type parameter.  
  
 [!code[FsLangRef2#6904](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_4.fs)]  
  
## Units at Runtime  
 Units of measure are used for static type checking. When floating point values are compiled, the units of measure are eliminated, so the units are lost at run time. Therefore, any attempt to implement functionality that depends on checking the units at run time is not possible. For example, implementing a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> function to print out the units is not possible.  
  
## Conversions  
 To convert a type that has units (for example, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) to a type that does not have units, you can use the standard conversion function. For example, you can use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to convert to a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value that does not have units, as shown in the following code.  
  
 [!code[FsLangRef2#6905](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_5.fs)]  
  
 To convert a unitless value to a value that has units, you can multiply by a 1 or 1.0 value that is annotated with the appropriate units. However, for writing interoperability layers, there are also some explicit functions that you can use to convert unitless values to values with units. These are in the [Microsoft.FSharp.Core.LanguagePrimitives](../vs140/core.languageprimitives-module--fsharp-.md) module. For example, to convert from a unitless <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, use [FloatWithMeasure](../vs140/languageprimitives.floatwithmeasure--measure--function.md), as shown in the following code.  
  
 [!code[FsLangRef2#6906](../vs140/codesnippet/FSharp/units-of-measure--fsharp-_6.fs)]  
  
## Units of Measure in the F# Power Pack  
 A unit library is available in the F# PowerPack. The unit library includes SI units and physical constants.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)