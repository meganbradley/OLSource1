---
title: "Tutorial: Creating a Type Provider (F#)"
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
  - "type providers [F#], tutorial"
  - "type providers [F#], RegEx type provider"
  - "type providers [F#], CSV type provider"
ms.assetid: 52283e2b-73bd-40a7-b867-07731371fff5
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tutorial: Creating a Type Provider (F#)
The type provider mechanism in F# 3.0 is a significant part of its support for information rich programming. This tutorial explains how to create your own type providers by walking you through the development of several simple type providers to illustrate the basic concepts. For more information about the type provider mechanism in F#, see [Type Providers](../vs140/type-providers.md).  
  
 F# 3.0 contains several built-in type providers for commonly used Internet and enterprise data services. These type providers give simple and regular access to SQL relational databases and network-based OData and WSDL services. These providers also support the use of F# LINQ queries against these data sources.  
  
 Where necessary, you can create custom type providers, or you can reference type providers that others have created. For example, your organization could have a data service that provides a large and growing number of named data sets, each with its own stable data schema. You can create a type provider that reads the schemas and presents the current data sets to the programmer in a strongly typed way.  
  
## Before You Start  
 The type provider mechanism is primarily designed for injecting stable data and service information spaces into the F# programming experience.  
  
 This mechanism isn’t designed for injecting information spaces whose schema changes during program execution in ways that are relevant to program logic. Also, the mechanism isn't designed for intra-language meta-programming, even though that domain contains some valid uses. You should use this mechanism only where necessary and where the development of a type provider yields very high value.  
  
 You should avoid writing a type provider where a schema isn't available. Likewise, you should avoid writing a type provider where an ordinary (or even an existing) .NET library would suffice.  
  
 Before you start, you might ask the following questions:  
  
-   Do you have a schema for your information source? If so, what’s the mapping into the F# and .NET type system?  
  
-   Can you use an existing (dynamically typed) API as a starting point for your implementation?  
  
-   Will you and your organization have enough uses of the type provider to make writing it worthwhile? Would a normal .NET library meet your needs?  
  
-   How much will your schema change?  
  
-   Will it change during coding?  
  
-   Will it change between coding sessions?  
  
-   Will it change during program execution?  
  
 Type providers are best suited to situations where the schema is stable at runtime and during the lifetime of compiled code.  
  
## A Simple Type Provider  
 This sample is Samples.HelloWorldTypeProvider in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> directory of the [F# 3.0 Sample Pack](http://go.microsoft.com/fwlink/?LinkId=236999) on the Codeplex website. The provider makes available a "type space" that contains 100 erased types, as the following code shows by using F# signature syntax and omitting the details for all except <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. For more information about erased types, see [Details About Erased Provided Types](#BK_Erased) later in this topic.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that the set of types and members provided is statically known. This example doesn't leverage the ability of providers to provide types that depend on a schema. The implementation of the type provider is outlined in the following code, and the details are covered in later sections of this topic.  
  
> [!WARNING]
>  There may be some small naming differences between this code and the online samples.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To use this provider, open a separate instance of [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)], create an F# script, and then add a reference to the provider from your script by using #r as the following code shows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Then look for the types under the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> namespace that the type provider generated.  
  
 Before you recompile the provider, make sure that you have closed all instances of Visual Studio and F# Interactive that are using the provider DLL. Otherwise, a build error will occur because the output DLL will be locked.  
  
 To debug this provider by using print statements, make a script that exposes a problem with the provider, and then use the following code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To debug this provider by using Visual Studio, open the Visual Studio command prompt with administrative credentials, and run the following command:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 As an alternative, open Visual Studio, open the Debug menu, choose **Debug/Attach to process…**, and attach to another <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> process where you’re editing your script. By using this method, you can more easily target particular logic in the type provider by interactively typing expressions into the second instance (with full IntelliSense and other features).  
  
 You can disable Just My Code debugging to better identify errors in generated code. For information about how to enable or disable this feature, see [Restrict stepping to Just My Code](../vs140/navigating-through-code-with-the-debugger.md#BKMK_Restrict_stepping_to_Just_My_Code). Also, you can also set first-chance exception catching by opening the **Debug** menu and then choosing **Exceptions** or by choosing the Ctrl+Alt+E keys to open the **Exceptions** dialog box. In that dialog box, under **Common Language Runtime Exceptions**, select the **Thrown** check box.  
  
### Implementation of the Type Provider  
 This section walks you through the principal sections of the type provider implementation. First, you define the type for the custom type provider itself:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This type must be public, and you must mark it with the [TypeProvider](../vs140/compilerservices.typeproviderattribute-class--fsharp-.md) attribute so that the compiler will recognize the type provider when a separate F# project references the assembly that contains the type. The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> parameter is optional, and, if present, contains contextual configuration information for the type provider instance that the F# compiler creates.  
  
 Next, you implement the [ITypeProvider](../vs140/compilerservices.itypeprovider-interface--fsharp-.md) interface. In this case, you use the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> type from the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> API as a base type. This helper type can provide a finite collection of eagerly provided namespaces, each of which directly contains a finite number of fixed, eagerly provided types. In this context, the provider *eagerly* generates types even if they aren't needed or used.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Next, define local private values that specify the namespace for the provided types, and find the type provider assembly itself. This assembly is used later as the logical parent type of the erased types that are provided.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Next, create a function to provide each of the types Type1…Type100. This function is explained in more detail later in this topic.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Next, generate the 100 provided types:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Next, add the types as a provided namespace:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Finally, add an assembly attribute that indicates that you are creating a type provider DLL:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Providing One Type And Its Members  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> function does the real work of providing one of the types.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 This step explains the implementation of this function. First, create the provided type (for example, Type1, when n = 1, or Type57, when n = 57).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 You should note the following points:  
  
-   This provided type is erased.  Because you indicate that the base type is <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, instances will appear as values of type [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) in compiled code.  
  
-   When you specify a non-nested type, you must specify the assembly and namespace. For erased types, the assembly should be the type provider assembly itself.  
  
 Next, add XML documentation to the type. This documentation is delayed, that is, computed on-demand if the host compiler needs it.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Next you add a provided static property to the type:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Getting this property will always evaluate to the string "Hello!". The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> for the property uses an F# quotation, which represents the code that the host compiler generates for getting the property. For more information about quotations, see [Code Quotations (F#)](../vs140/code-quotations--fsharp-.md).  
  
 Add XML documentation to the property.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Now attach the provided property to the provided type. You must attach a provided member to one and only one type. Otherwise, the member will never be accessible.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Now create a provided constructor that takes no parameters.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> for the constructor returns an F# quotation, which represents the code that the host compiler generates when the constructor is called. For example, you can use the following constructor:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An instance of the provided type will be created with underlying data "The object data". The quoted code includes a conversion to [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) because that type is the erasure of this provided type (as you specified when you declared the provided type).  
  
 Add XML documentation to the constructor, and add the provided constructor to the provided type:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Create a second provided constructor that takes one parameter:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> for the constructor again returns an F# quotation, which represents the code that the host compiler generated for a call to the method. For example, you can use the following constructor:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An instance of the provided type is created with underlying data "ten". You may have already noticed that the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function returns a quotation. The input to this function is a list of expressions, one per constructor parameter. In this case, an expression that represents the single parameter value is available in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. The code for a call to the constructor coerces the return value to the erased type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. After you add the second provided constructor to the type, you create a provided instance property:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Getting this property will return the length of the string, which is the representation object. The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> property returns an F# quotation that specifies the code that the host compiler generates to get the property. Like <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> function returns a quotation. The host compiler calls this function with a list of arguments. In this case, the arguments include just the single expression that represents the instance upon which the getter is being called, which you can access by using <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.The implementation of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> then splices into the result quotation at the erased type <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, and a cast is used to satisfy the compiler's mechanism for checking types that the object is a string. The next part of <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> provides an instance method with one parameter.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Finally, create a nested type that contains 100 nested properties. The creation of this nested type and its properties is delayed, that is, computed on-demand.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
###  \<a name="BK_Erased">\</a> Details about Erased Provided Types  
 The example in this section provides only *erased provided types*, which are particularly useful in the following situations:  
  
-   When you are writing a provider for an information space that contains only data and methods.  
  
-   When you are writing a provider where accurate runtime-type semantics aren't critical for practical use of the information space.  
  
-   When you are writing a provider for an information space that is so large and interconnected that it isn’t technically feasible to generate real .NET types for the information space.  
  
 In this example, each provided type is erased to type <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and all uses of the type will appear as type <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> in compiled code. In fact, the underlying objects in these examples are strings, but the type will appear as \<xref:System.Object*> in .NET compiled code. As with all uses of type erasure, you can use explicit boxing, unboxing, and casting to subvert erased types. In this case, a cast exception that isn’t valid may result when the object is used. A provider runtime can define its own private representation type to help protect against false representations. You can’t define erased types in F# itself. Only provided types may be erased. You must understand the ramifications, both practical and semantic, of using either erased types for your type provider or a provider that provides erased types. An erased type has no real .NET type. Therefore, you cannot do accurate reflection over the type, and you might subvert erased types if you use runtime casts and other techniques that rely on exact runtime type semantics. Subversion of erased types frequently results in type cast exceptions at runtime.  
  
### Choosing Representations for Erased Provided Types  
 For some uses of erased provided types, no representation is required. For example, the erased provided type might contain only static properties and members and no constructors, and no methods or properties would return an instance of the type. If you can reach instances of an erased provided type, you must consider the following questions:  
  
-   What is the erasure of a provided type?  
  
    -   The erasure of a provided type is how the type appears in compiled .NET code.  
  
    -   The erasure of a provided erased class type is always the first non-erased base type in the inheritance chain of the type.  
  
    -   The erasure of a provided erased interface type is always \<xref:System.Object*>.  
  
-   What are the representations of a provided type?  
  
    -   The set of possible objects for an erased provided type are called its representations. In the example in this document, the representations of all the erased provided types <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> are always string objects.  
  
 All representations of a provided type must be compatible with the erasure of the provided type. (Otherwise, either the F# compiler will give an error for a use of the type provider, or unverifiable .NET code that isn't valid will be generated. A type provider isn’t valid if it returns code that gives a  representation that isn't valid.)  
  
 You can choose a representation for provided objects by using either of the following approaches, both of which are very common:  
  
-   If you're simply providing a strongly typed wrapper over an existing .NET type, it often makes sense for your type to erase to that type, use instances of that type as representations, or both. This approach is appropriate when most of the existing methods on that type still make sense when using the strongly typed version.  
  
-   If you want to create an API that differs significantly from any existing .NET API, it makes sense to create runtime types that will be the type erasure and representations for the provided types.  
  
 The example in this document uses strings as representations of provided objects. Frequently, it may be appropriate to use other objects for representations. For example, you may use a dictionary as a property bag:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 As an alternative, you may define a type in your type provider that will be used at runtime to form the representation, along with one or more runtime operations:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Provided members can then construct instances of this object type:  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 In this case, you may (optionally) use this type as the type erasure by specifying this type as the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> when constructing the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 **Key Lessons**  
  
 The previous section explained how to create a simple erasing type provider that provides a range of types, properties, and methods. This section also explained the concept of type erasure, including some of the advantages and disadvantages of providing erased types from a type provider, and discussed representations of erased types.  
  
## A Type Provider That Uses Static Parameters  
 The ability to parameterize type providers by static data enables many interesting scenarios, even in cases when the provider doesn't need to access any local or remote data. In this section, you’ll learn some basic techniques for putting together such a provider.  
  
### Type Checked Regex Provider  
 Imagine that you want to implement a type provider for regular expressions that wraps the .NET \<xref:System.Text.RegularExpressions.Regex*> libraries in an interface that provides the following compile-time guarantees:  
  
-   Verifying whether a regular expression is valid.  
  
-   Providing named properties on matches that are based on any group names in the regular expression.  
  
 This section shows you how to use type providers to create a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> type that the regular expression pattern parameterizes to provide these benefits. The compiler will report an error if the supplied pattern isn't valid, and the type provider can extract the groups from the pattern so that you can access them by using named properties on matches. When you design a type provider, you should consider how its exposed API should look to end users and how this design will translate to .NET code. The following example shows how to use such an API to get the components of the area code:  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The following example shows how the type provider translates these calls:  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Note the following points:  
  
-   The standard Regex type represents the parameterized <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> type.  
  
-   The <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> constructor results in a call to the Regex constructor, passing in the static type argument for the pattern.  
  
-   The results of the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method are represented by the standard \<xref:System.Text.RegularExpressions.Match*> type.  
  
-   Each named group results in a provided property, and accessing the property results in a use of an indexer on a match’s <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> collection.  
  
 The following code is the core of the logic to implement such a provider, and this example omits the addition of all members to the provided type. For information about each added member, see the appropriate section later in this topic. For the full code, download the sample from the [F# 3.0 Sample Pack](http://go.microsoft.com/fwlink/?LinkId=236999) on the Codeplex website.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Note the following points:  
  
-   The type provider takes two static parameters: the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, which is mandatory, and the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, which are optional (because a default value is provided).  
  
-   After the static arguments are supplied, you create an instance of the regular expression. This instance will throw an exception if the Regex is malformed, and this error will be reported to users.  
  
-   Within the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> callback, you define the type that will be returned after the arguments are supplied.  
  
-   This code sets <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to true so that the IntelliSense experience will remain streamlined. This attribute causes the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> members to be suppressed from IntelliSense lists for a provided object.  
  
-   You use <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> as the base type of the method, but you’ll use a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object as the runtime representation of this type, as the next example shows.  
  
-   The call to the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> constructor throws a \<xref:System.ArgumentException*> when a regular expression isn’t valid. The compiler catches this exception and reports an error message to the user at compile time or in the Visual Studio editor. This exception enables regular expressions to be validated without running an application.  
  
 The type defined above isn't useful yet because it doesn’t contain any meaningful methods or properties. First, add a static <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The previous code defines a method <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, which takes a string as input and returns a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. The only tricky part is the use of the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> argument within the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> definition. In this example, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is a list of quotations that represents the arguments to this method. If the method is an instance method, the first argument represents the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> argument. However, for a static method, the arguments are all just the explicit arguments to the method. Note that the type of the quoted value should match the specified return type (in this case, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>). Also note that this code uses the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> method to make sure that the provided method also has useful documentation, which you can supply through IntelliSense.  
  
 Next, add an instance Match method. However, this method should return a value of a provided <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> type so that the groups can be accessed in a strongly typed fashion. Thus, you first declare the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> type. Because this type depends on the pattern that was supplied as a static argument, this type must be nested within the parameterized type definition:  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 You then add one property to the Match type for each group. At runtime, a match is represented as a \<xref:System.Text.RegularExpressions.Match*> value, so the quotation that defines the property must use the \<xref:System.Text.RegularExpressions.Match.Groups*> indexed property to get the relevant group.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Again, note that you’re adding XML documentation to the provided property. Also note that a property can be read if a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> function is provided, and the property can be written if a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> function is provided, so the resulting property is read only.  
  
 Now you can create an instance method that returns a value of this <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> type:  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Because you are creating an instance method, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> represents the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> instance on which the method is being called, and <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is the input argument.  
  
 Finally, provide a constructor so that instances of the provided type can be created.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The constructor merely erases to the creation of a standard .NET Regex instance, which is again boxed to an object because <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is the erasure of the provided type. With that change, the sample API usage that specified earlier in the topic works as expected. The following code is complete and final:  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 **Key Lessons**  
  
 This section explained how to create a type provider that operates on its static parameters. The provider checks the static parameter and provides operations based on its value.  
  
## A Type Provider That Is Backed By Local Data  
 Frequently you might want type providers to present APIs based on not only static parameters but also information from local or remote systems. This section discusses type providers that are based on local data, such as local data files.  
  
### Simple CSV File Provider  
 As a simple example, consider a type provider for accessing scientific data in Comma Separated Value (CSV) format. This section assumes that the CSV files contain a header row followed by floating point data, as the following table illustrates:  
  
|Distance (meter)|Time (second)|  
|------------------------|---------------------|  
|50.0|3.7|  
|100.0|5.2|  
|150.0|6.4|  
  
 This section shows how to provide a type that you can use to get rows with a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> property of type <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> property of type <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. For simplicity, the following assumptions are made:  
  
-   Header names are either unit-less or have the form “Name (unit)” and don't contain commas.  
  
-   Units are all Systeme International (SI) units as the [Microsoft.FSharp.Data.UnitSystems.SI.UnitNames Module (F#)](../vs140/si.unitnames-namespace--fsharp-.md) module defines.  
  
-   Units are all simple (for example, meter) rather than compound (for example, meter/second).  
  
-   All columns contain floating point data.  
  
 A more complete provider would loosen these restrictions.  
  
 Again the first step is to consider how the API should look. Given an <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> file with the contents from the previous table (in comma-separated format), users of the provider should be able to write code that resembles the following example:  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 In this case, the compiler should convert these calls into something like the following example:  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The optimal translation will require the type provider to define a real <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> type in the type provider's assembly. Type providers often rely on a few helper types and methods to wrap important logic. Because measures are erased at runtime, you can use a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> as the erased type for a row. The compiler will treat different columns as having different measure types. For example, the first column in our example has type <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, and the second has <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. However, the erased representation can remain quite simple.  
  
 The following code shows the core of the implementation.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Note the following points about the implementation:  
  
-   Overloaded constructors allow either the original file or one that has an identical schema to be read. This pattern is common when you write a type provider for local or remote data sources, and this pattern allows a local file to be used as the template for remote data.  
  
     You can use the [TypeProviderConfig](../vs140/compilerservices.typeproviderconfig-class--fsharp-.md) value that’s passed in to the type provider constructor to resolve relative file names.  
  
-   You can use the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> method to define the location of the provided properties. Therefore, if you use **Go To Definition** on a provided property, the CSV file will open in Visual Studio.  
  
-   You can use the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> type to look up the SI units and to generate the relevant <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> types.  
  
 **Key Lessons**  
  
 This section explained how to create a type provider for a local data source with a simple schema that's contained in the data source itself.  
  
## Going Further  
 The following sections include suggestions for further study.  
  
### A Look at the Compiled Code for Erased Types  
 To give you some idea of how the use of the type provider corresponds to the code that's emitted, look at the following function by using the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> that's used earlier in this topic.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Here’s an image of the resulting code decompiled by using ildasm.exe:  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 As the example shows, all mentions of the type <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> property have been erased, leaving only operations on the runtime types involved.  
  
### Design and Naming Conventions for Type Providers  
 Observe the following conventions when authoring type providers.  
  
-   **Providers for Connectivity Protocols**  
  
     In general, names of most provider DLLs for data and service connectivity protocols, such as OData or SQL connections, should end in <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>. For example, use a DLL name that resembles the following string:  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
     Ensure that your provided types are members of the corresponding namespace, and indicate the connectivity protocol that you implemented:  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
-   **Utility Providers for General Coding**  
  
     For a utility type provider such as that for regular expressions, the type provider may be part of a base library, as the following example shows:  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
     In this case, the provided type would appear at an appropriate point according to normal .NET design conventions:  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
-   **Singleton Data Sources**  
  
     Some type providers connect to a single dedicated data source and provide only data. In this case, you should drop the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> suffix and use normal conventions for .NET naming:  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
     For more information, see the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> design convention that's described later in this topic.  
  
### Design Patterns for Type Providers  
 The following sections describe design patterns you can use when authoring type providers.  
  
#### The GetConnection Design Pattern  
 Most type providers should be written to use the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> pattern that's used by the type providers in FSharp.Data.TypeProviders.dll, as the following example shows:  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
#### Type Providers Backed By Remote Data and Services  
 Before you create a type provider that's backed by remote data and services, you must consider a range of issues that are inherent in connected programming. These issues include the following considerations:  
  
-   schema mapping  
  
-   liveness and invalidation in the presence of schema change  
  
-   schema caching  
  
-   asynchronous implementations of data access operations  
  
-   supporting queries, including LINQ queries  
  
-   credentials and authentication  
  
 This topic doesn't explore these issues further.  
  
### Additional Authoring Techniques  
 When you write your own type providers, you might want to use the following additional techniques.  
  
-   **Creating Types and Members On-Demand**  
  
     The ProvidedType API has delayed versions of AddMember.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
     These versions are used to create on-demand spaces of types.  
  
-   **Providing Array, ByRef, and Pointer types**  
  
     You make provided members (whose signatures include array types, byref types, and instantiations of generic types) by using the normal <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> on any instance of System.Type, including <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
-   **Providing Unit of Measure Annotations**  
  
     The ProvidedTypes API provides helpers for providing measure annotations. For example, to provide the type <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, use the following code:  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
     To provide the type <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>, use the following code:  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
-   **Accessing Project-Local or Script-Local Resources**  
  
     Each instance of a type provider can be given a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> value during construction. This value contains the "resolution folder" for the provider (that is, the project folder for the compilation or the directory that contains a script), the list of referenced assemblies, and other information.  
  
-   **Invalidation**  
  
     Providers can raise invalidation signals to notify the F# language service that the schema assumptions may have changed. When invalidation occurs, a typecheck is redone if the provider is being hosted in Visual Studio. This signal will be ignored when the provider is hosted in F# Interactive or by the F# Compiler (fsc.exe).  
  
-   **Caching Schema Information**  
  
     Providers must often cache access to schema information. The cached data should be stored by using a file name that's given as a static parameter or as user data. An example of schema caching is the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> parameter in the type providers in the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> assembly. In the implementation of these providers, this static parameter directs the type provider to use the schema information in the specified local file instead of accessing the data source over the network. To use cached schema information, you must also set the static parameter <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. You could use a similar technique to enable online and offline data access.  
  
-   **Backing Assembly**  
  
     When you compile a .dll or .exe file, the backing .dll file for generated types is statically linked into the resulting assembly. This link is created by copying the Intermediate Language (IL) type definitions and any managed resources from the backing assembly into the final assembly. When you use F# Interactive, the backing .dll file isn't copied and is instead loaded directly into the F# Interactive process.  
  
-   **Exceptions and Diagnostics from Type Providers**  
  
     All uses of all members from provided types may throw exceptions. In all cases, if a type provider throws an exception, the host compiler attributes the error to a specific type provider.  
  
    -   Type provider exceptions should never result in internal compiler errors.  
  
    -   Type providers can't report warnings.  
  
    -   When a type provider is hosted in the F# compiler, an F# development environment, or F# Interactive, all exceptions from that provider are caught. The Message property is always the error text, and no stack trace appears. If you’re going to throw an exception, you can throw the following examples:  
  
        -   \<xref:System.NotSupportedException*>  
  
        -   \<xref:System.IO.IOException*>  
  
        -   \<xref:System.Exception*>  
  
#### Providing Generated Types  
 So far, this document has explained how provide erased types. You can also use the type provider mechanism in F# to provide generated types, which are added as real .NET type definitions into the users' program. You must refer to generated provided types by using a type definition.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The ProvidedTypes-0.2 helper code that is part of the F# 3.0 release has only limited support for providing generated types. The following statements must be true for a generated type definition:  
  
-   IsErased must be set to <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
-   The provider must have an assembly that has an actual backing .NET .dll file with a matching .dll file on disk.  
  
 You must also call <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> on a root provided type whose nested types form a closed set of generated types. This call emits the given provided type definition and its nested type definitions into an assembly and adjusts the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> property of all provided type definitions to return that assembly. The assembly is emitted only when the Assembly property on the root type is accessed for the first time. The host F# compiler does access this property when it processes a generative type declaration for the type.  
  
## Rules and Limitations  
 When you write type providers, keep the following rules and limitations in mind.  
  
-   **Provided types must be reachable.**  
  
     All provided types should be reachable from the non-nested types. The non-nested types are given in the call to the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> constructor or a call to <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>. For example, if the provider provides a type <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, you must ensure that T is either a non-nested type or nested under one.  
  
     For example, some providers have a static class such as <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> that contain these <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> types. Otherwise, the error says that a reference to type T in assembly A was found, but the type couldn't be found in that assembly. If this error appears, verify that all your subtypes can be reached from the provider types. Note: These <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> types are referred to as the *on-the-fly* types. Remember to put them in an accessible namespace or a parent type.  
  
-   **Limitations of the Type Provider Mechanism**  
  
     The type provider mechanism in F# has the following limitations:  
  
    -   The underlying infrastructure for type providers in F# doesn't support provided generic types or provided generic methods.  
  
    -   The mechanism doesn't support nested types with static parameters.  
  
-   **Limitations of the ProvidedTypes Support Code**  
  
     The <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> support code has the following rules and limitations:  
  
    1.  Provided properties with indexed getters and setters aren't implemented.  
  
    2.  Provided events aren't implemented.  
  
    3.  The provided types and information objects should be used only for the type provider mechanism in F#. They aren't more generally usable as System.Type objects.  
  
    4.  The constructs that you can use in quotations that define method implementations have several limitations. You can refer to the source code for ProvidedTypes-*Version* to see which constructs are supported in quotations.  
  
-   **Type providers must generate output assemblies that are .dll files, not .exe files.**  
  
## Development Tips  
 You might find the following tips helpful during the development process.  
  
-   **Run Two Instances of Visual Studio.** You can develop the type provider in one instance and test the provider in the other because the test IDE will take a lock on the .dll file that prevents the type provider from being rebuilt. Thus, you must close the second instance of Visual Studio while the provider is built in the first instance, and then you must reopen the second instance after the provider is built.  
  
-   **Debug type providers by using invocations of fsc.exe.** You can invoke type providers by using the following tools:  
  
    -   fsc.exe (The F# command line compiler)  
  
    -   fsi.exe (The F# Interactive compiler)  
  
    -   devenv.exe (Visual Studio)  
  
     You can often debug type providers most easily by using fsc.exe on a test script file (for example, script.fsx). You can launch a debugger from a command prompt.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
     You can use print-to-stdout logging.  
  
## See Also  
 [Type Providers](../vs140/type-providers.md)