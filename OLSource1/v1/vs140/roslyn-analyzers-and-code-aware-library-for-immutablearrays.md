---
title: "Roslyn Analyzers and Code-aware Library for ImmutableArrays"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0b0afa22-3fca-4d59-908e-352464c1d903
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Roslyn Analyzers and Code-aware Library for ImmutableArrays
The [.NET Compiler Platform](https://github.com/dotnet/roslyn) (“Roslyn”) helps you build code-aware libraries.  A code-aware library provides functionality you can use and tooling (Roslyn analyzers) to help you use the library in the best way or to avoid errors.  This topic shows you how to build a real world Roslyn analyzer to catch common errors when using the [Immutable Collections](assetId:///33f4449d-7078-450a-8d60-d9229f66bbca) NuGet package.  The example also demonstrates how to provide a code fix for a code issue found by the analyzer.  Users see code fixes in the Visual Studio light bulb UI and can apply a fix for the code automatically.  
  
## Getting Started  
 You need the following to build this example:  
  
-   Visual Studio 2015 (not an Express Edition) or a later version.  You can use the free [Visual Studio Community Edition](https://www.visualstudio.com/products/visual-studio-community-vs)  
  
-   [Visual Studio SDK](../vs140/visual-studio-sdk.md).  You can also, when installing Visual Studio, check Visual Studio Extensibility Tools under Common Tools to install the SDK at the same time.  If you have already installed Visual Studio, you can also install this SDK by going to the main menu **File &#124; New &#124;Project …**, choosing C# in the left navigation pane, and then choosing Extensibility.  When you choose the “**Install the Visual Studio Extensibility Tools**” breadcrumb project template, it prompts you to download and install the SDK.  
  
-   [.NET Compiler Platform (“Roslyn”) SDK](http://aka.ms/roslynsdktemplates).  You can also install this SDK by going to the main menu **File &#124; New &#124; Project …**, choosing **C#** in the left navigation pane, and then choosing **Extensibility**.  When you choose “**Download the .NET Compiler Platform SDK**” breadcrumb project template, it prompts you to download and install the SDK.  This SDK includes the [Roslyn Syntax Visualizer](https://github.com/dotnet/roslyn/wiki/Syntax%20Visualizer).  This extremely useful tool helps you figure out what code model types you should look for in your analyzer.  The analyzer infrastructure calls into your code for specific code model types, so your code only executes when necessary and can focus only on analyzing relevant code.  
  
## What’s the Problem?  
 Imagine you provide a library with ImmutableArray (for example, <xref:System.Collections.Immutable.ImmutableArray<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>default(T)<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>b1.Length<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>ImmutableArray<int>.Empty<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>b2<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Add()<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>b2<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>ImmutableArray.CreateRange(new int[] {1, 2, 3, 4, 5})<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>b1<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>LocalDeclarationStatement<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>VariableDeclaration<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>VariableDeclarator<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>EqualsValueClause<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>ObjectCreationExpression<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>DiagnosticAnalyzer<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>DiagnosticAnalyzerAttribute<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>DiagnosticAnalyzer<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>Initialize<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>AnalysisContext<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>Register…<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>RegisterCodeBlockAction<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>RegisterCompilationStartAction<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>using<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>AnalyzeObjectCreation<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>"Naming"<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>"API Guidance"<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>“Don’t use ImmutableArray<T> constructor”<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>Diagnostic.Create()<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>AnalyzeObjectCreation<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>AnalysisContext<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>SyntaxNodeAnalysisContext<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>CancellationToken<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>ImmutableArray<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>using<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>ImmutableArray<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>using<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>AnalyzeObjectCreation<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>objectCreation<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>“objectCreation.ToString()”<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>"new ImmutableArray<int>()"<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) and the number of generic parameters.  That is why you do not see “…ImmutableArray\<T>” in the metadata name.  
  
 The semantic model has many useful things on it that let you ask questions about symbols, data flow, variable lifetime, etc.  Roslyn separates syntax nodes from the semantic model for various engineering reasons (performance, modeling erroneous code, etc.).  You want the compilation model to look up information contained in references for accurate comparison.  
  
 You can drag the yellow execution pointer on the left side of the editor window.  Drag it up to the line that sets the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> variable and step over your new line of code using **F10**.  If you hover the mouse pointer over the variable <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, you see that we found the exact type in the semantic model.  
  
 **Get the object creation expression’s type.** “Type” is used in a few ways in this article, but this means if you have “new Foo” expression, you need to get a model of Foo.  You need to get the type of the object creation expression to see if it is the ImmutableArray\<T> type.  Use the semantic model again to get symbol information for the type symbol (ImmutableArray) in the object creation expression.  Enter the following line of code at the end of the function:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Because your analyzer needs to handle incomplete or incorrect code in editor buffers (for example, there is a missing <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement), you should check for <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> being <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  You need to get a named type (INamedTypeSymbol) from the symbol information object to finish the analysis.  
  
 **Compare the Types.** Because there is an open generic type of T that we are looking for, and the type in the code is a concrete generic type, you query the symbol information for what the type is constructed from (an open generic type) and compare that result with <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  Enter the following at the end of the method:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 **Report the Diagnostic.** Reporting the diagnostic is pretty easy.  You use the Rule created for you in the project template, which is defined before the Initialize method.  Because this situation in the code is an error, you can change the line that initialized Rule to replace <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> (green squiggle) with <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (red squiggle).  The rest of the Rule initializes from the resources you edited near the beginning of the walkthrough.  You also need to report the location for the squiggle, which is the location of the object creation expresssion’s type specification.  Enter this code in the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> block:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Your function should look like this (perhaps formatted differently):  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Remove the breakpoint so that you can see your analyzer working (and stop returning to the first instance of Visual Studio).  Drag the execution pointer to the beginning of your method, and press **F5** to continue execution.  When you switch back to the second instance of Visual Studio, the compiler will start to examine the code again, and it will call into your analyzer.  You can see a squiggle under <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
## Adding a “Code Fix” for the Code Issue  
 Before you begin, close the second instance of Visual Studio and stop debugging in the first instance of Visual Studio (where you are developing the analyzer).  
  
 **Add a new class.** Use the shortcut menu (right pointer button) on your project node in the Solution Explorer and choose to add a new item.  Add a class called <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  This class needs to derive from <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, and you will need to use **CTRL+.** (period) to invoke the code fix that adds the correct <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> statement.  This class also needs to be annotated with <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> attribute, and you will need to add a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> statement to resolve the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> enum.  You should have a class file with the following code in it:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 **Stub out derived members.** Now, place the editor’s caret in the identifier <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and press **CTRL+.** (period) to stub out the implementation for this abstract base class.  This generates a property and a method for you.  
  
 **Implement the property.** Fill in the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> property’s <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> body with the following code:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Roslyn brings together diagnostics and fixes by matching these identifiers, which are just strings.  The project template generated a diagnostic ID for you, and you are free to change it.  The code in the property just returns the ID from the analyzer class.  
  
 **The RegisterCodeFixAsync method takes a context.** The context is important because a code fix can apply to multiple diagnostics, or there could be more than one issue on a line of code.  If you type “context.” in the body of the method, the Intellisense completion list will show you some useful members.  There’s a CancellationToken member that you can check to see if something wants to cancel the fix.  There’s a Document member that has lots of useful members and lets you get to the project and solution model objects.  There’s a Span member that is the start and end of the code location specified when you reported the diagnostic.  
  
 **Make the method be async.** The first thing you need to do is fix the generated method declaration to be an <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> method.  The code fix for stubbing out the implementation of an abstract class doesn’t include the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> keyword even though the method returns a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
 **Get the root of the syntax tree.** To modify code you need to produce a new syntax tree with the changes your code fix makes.  You need the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> from the context to call <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  This is an async method because there is unknown work to get the syntax tree, possibly including getting the file from disk, parsing it, and building the Roslyn code model for it.  The Visual Studio UI should be responsive during this time, which using <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> enables.  Replace the line of code in the method with the following:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 **Find the node with the issue.** You pass in the context’s span, but the node you find may not be the code you have to change.  The reported diagnostic only provided the span for the type identifier (where the squiggle belonged), but you need to replace the entire object creation expression, including the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> keywoard at the beginning and the parentheses at the end.  Add the following code to your method (and use **CTRL+.** to add a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> statement for <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>):  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 **Register your code fix for the light bulb UI.** When you register your code fix, Roslyn plugs into the Visual Studio light bulb UI automatically.  End users will see they can use **CTRL+.** (period) when your analyzer squiggles a bad <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> constructor use.  Because your code fix provider only executes when there is an issue, you can assume you have the object creation expression you were looking for.  From the context parameter, you can register the new code fix by adding the following code to the end of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 You need to place the editor’s caret in the identifier, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, then use **CTRL+.** (period) to add the appropriate <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> statement for this type.  
  
 Then place the editor’s caret in the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> identifier and use **CTRL+.** again to generate this method stub for you.  
  
 This last code snippet you added registers the code fix by passing a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and the diagnostic ID for the kind of issue found.  In this example, there is only one diagnostic ID that this code provides fixes for, so you can just pass the first element of the diagnostic IDs array.  When you create the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, you pass in the text that the light bulb UI should use as a description of the code fix.  You also pass in a function that takes a CancellationToken and returns a new Document.  The new Document has a new syntax tree that includes your patched code that calls <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  This code snippet uses a lambda so that it can close over the objectCreation node and the context’s Document.  
  
 **Construct the new syntax tree.** In the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> method whose stub you generated earlier, enter the line of code: <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  If you view the Syntax Visualizer tool window again, you can see this syntax is a SimpleMemberAccessExpression node.  That’s what this method needs to construct and return in a new Document.  
  
 The first change to <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is to add <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> because the code generators cannot assume the method should be async.  
  
 Fill in the body with the following code so that your method looks similar to the following:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 You will need to put the editor’s caret in the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> identifier and use **CTRL+.** (period) to add the appropriate <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> statement for this type.  
  
 This code uses <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, which is a very useful type for constructing new code.  After getting a generator for the document that has the code issue, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, passing the type that has the member we want to access and passing the name of the member as a string.  
  
 Next, the method fetches the root of the document, and because this can involve arbitrary work in the general case, the code awaits this call and passes the cancellation token.  Roslyn code models are immutable, like working with a .NET string; when you update the string, you get a new string object in return.  When you call <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, you get back a new root node.  Most of the syntax tree is shared (because it is immutable), but the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> node is replaced with the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> node, as well as all the parent nodes up to the syntax tree root.  
  
## Trying Your Code Fix  
 You can now press **F5** to execute your analyzer in a second instance of Visual Studio.  Open the console project you used before.  Now you should see the light bulb appear where your new object creation expression is for <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  If you press **CTRL+.** (period), then you will see your code fix, and you will see an automatically generated code difference preview in the light bulb UI.  Roslyn creates this for you.  
  
 Pro Tip: If you launch the second instance of Visual Studio, and you don’t see the light bulb with your code fix, then you may need to clear the Visual Studio component cache.  Clearing the cache forces Visual Studio to re-examine the components, so Visual Studio should then pick up your latest component.  First, shut down the second instance of Visual Studio.  Then in Windows Explorer, go to your user directory (c:\users\\<userid\>) and find AppData\Local\Microsoft\VisualStudio\14.0Roslyn\\.  In this directory, delete the sub directory ComponentModelCache.  The “14” changes version to version with Visual Studio.  
  
## Talk Video and Finish Code Project  
 You can see this example developed and discussed further in [this talk](http://channel9.msdn.com/events/Build/2015/3-725).  The talk demonstrates the working analyzer and walks you through building it.  
  
 You can see all the finished code [here](https://github.com/DustinCampbell/CoreFxAnalyzers/tree/master/Source/CoreFxAnalyzers).  The sub folders DoNotUseImmutableArrayCollectionInitializer and DoNotUseImmutableArrayCtor each have a C# file for finding issues and a C# file that implements the code fixes that show up in the Visual Studio light bulb UI.  Note, the finished code has a little more abstraction to avoid fetching the ImmutableArray\<T> type object over and over.  It uses nested registered actions to save the type object in a context that is available whenever the sub actions (analyze object creation and analyze collection initializations) execute.  
  
## See Also  
 [\\\Build 2015 talk](http://channel9.msdn.com/events/Build/2015/3-725)   
 [Completed code on github](https://github.com/DustinCampbell/CoreFxAnalyzers/tree/master/Source/CoreFxAnalyzers)   
 [Several examples on github, grouped into three kinds of analyzers](https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Analyzer%20Samples.md)   
 [Other docs on the github OSS site](https://github.com/dotnet/roslyn/tree/master/docs/analyzers)   
 [FxCop rules implemented with Roslyn analyzers on github](https://github.com/dotnet/roslyn/tree/master/src/Diagnostics/FxCop)