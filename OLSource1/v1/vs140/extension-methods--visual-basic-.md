---
title: "Extension Methods (Visual Basic)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ExtensionMethods"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "extending data types"
  - "extension methods [Visual Basic]"
ms.assetid: b8020aae-374d-46a9-bcb7-8cc2390b93b6
caps.latest.revision: 45
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extension Methods (Visual Basic)
Extension methods enable developers to add custom functionality to data types that are already defined without creating a new derived type. Extension methods make it possible to write a method that can be called as if it were an instance method of the existing type.  
  
## Remarks  
 An extension method can be only a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure or a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure. You cannot define an extension property, field, or event. All extension methods must be marked with the extension attribute <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> from the \<xref:System.Runtime.CompilerServices*?displayProperty=fullName> namespace.  
  
 The first parameter in an extension method definition specifies which data type the method extends. When the method is run, the first parameter is bound to the instance of the data type that invokes the method.  
  
## Example  
  
### Description  
 The following example defines a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> extension to the \<xref:System.String*> data type. The method uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to display a string. The parameter of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, establishes that the method extends the \<xref:System.String*> class.  
  
 [!code[VbVbalrExtensionMethods#1](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_1.vb)]  
  
 Notice that the extension method definition is marked with the extension attribute <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Marking the module in which the method is defined is optional, but each extension method must be marked. \<xref:System.Runtime.CompilerServices*> must be imported in order to access the extension attribute.  
  
 Extension methods can be declared only within modules. Typically, the module in which an extension method is defined is not the same module as the one in which it is called. Instead, the module that contains the extension method is imported, if it needs to be, to bring it into scope. After the module that contains <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is in scope, the method can be called as if it were an ordinary instance method that takes no arguments, such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrExtensionMethods#2](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_2.vb)]  
  
 The next example, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, is also an extension to \<xref:System.String*>, this time defined with two parameters. The first parameter, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, establishes that the extension method extends \<xref:System.String*>. The second parameter, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, is intended to be a string of punctuation marks that is passed in as an argument when the method is called. The method displays the string followed by the punctuation marks.  
  
 [!code[VbVbalrExtensionMethods#3](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_3.vb)]  
  
 The method is called by sending in a string argument for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>: <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 The following example shows <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> defined and called. \<xref:System.Runtime.CompilerServices*> is imported in the definition module in order to enable access to the extension attribute.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Next, the extension methods are brought into scope and called.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Comments  
 All that is required to be able to run these or similar extension methods is that they be in scope. If the module that contains an extension method is in scope, it is visible in IntelliSense and can be called as if it were an ordinary instance method.  
  
 Notice that when the methods are invoked, no argument is sent in for the first parameter. Parameter <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in the previous method definitions is bound to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the instance of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that calls them. The compiler will use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> as the argument sent to the first parameter.  
  
 If an extension method is called for an object that is set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the extension method executes. This does not apply to ordinary instance methods. You can explicitly check for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the extension method.  
  
## Types That Can Be Extended  
 You can define an extension method on most types that can be represented in a Visual Basic parameter list, including the following:  
  
-   Classes (reference types)  
  
-   Structures (value types)  
  
-   Interfaces  
  
-   Delegates  
  
-   ByRef and ByVal arguments  
  
-   Generic method parameters  
  
-   Arrays  
  
 Because the first parameter specifies the data type that the extension method extends, it is required and cannot be optional. For that reason, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameters and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameters cannot be the first parameter in the parameter list.  
  
 Extension methods are not considered in late binding. In the following example, the statement <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> raises a \<xref:System.MissingMemberException*> exception, the same exception you would see if the second <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> extension method definition were deleted.  
  
 [!code[VbVbalrExtensionMethods#9](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_4.vb)]  
  
## Best Practices  
 Extension methods provide a convenient and powerful way to extend an existing type. However, to use them successfully, there are some points to consider. These considerations apply mainly to authors of class libraries, but they might affect any application that uses extension methods.  
  
 Most generally, extension methods that you add to types that you do not own are more vulnerable than extension methods added to types that you control. A number of things can occur in classes you do not own that can interfere with your extension methods.  
  
-   If any accessible instance member exists that has a signature that is compatible with the arguments in the calling statement, with no narrowing conversions required from argument to parameter, the instance method will be used in preference to any extension method. Therefore, if an appropriate instance method is added to a class at some point, an existing extension member that you rely on may become inaccessible.  
  
-   The author of an extension method cannot prevent other programmers from writing conflicting extension methods that may have precedence over the original extension.  
  
-   You can improve robustness by putting extension methods in their own namespace. Consumers of your library can then include a namespace or exclude it, or select among namespaces, separately from the rest of the library.  
  
-   It may be safer to extend interfaces than it is to extend classes, especially if you do not own the interface or class. A change in an interface affects every class that implements it. Therefore, the author may be less likely to add or change methods in an interface. However, if a class implements two interfaces that have extension methods with the same signature, neither extension method is visible.  
  
-   Extend the most specific type you can. In a hierarchy of types, if you select a type from which many other types are derived, there are layers of possibilities for the introduction of instance methods or other extension methods that might interfere with yours.  
  
## Extension Methods, Instance Methods, and Properties  
 When an in-scope instance method has a signature that is compatible with the arguments of a calling statement, the instance method is chosen in preference to any extension method. The instance method has precedence even if the extension method is a better match. In the following example, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> contains an instance method named <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that has one parameter of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. Extension method <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> extends <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and has one parameter of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrExtensionMethods#4](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_5.vb)]  
  
 The first call to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in the following code calls the extension method, because <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and is compatible only with the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter in the extension method. The second call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> argument, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and it calls the instance method.  
  
 [!code[VbVbalrExtensionMethods#5](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_6.vb)]  
  
 Now reverse the data types of the parameters in the two methods:  
  
 [!code[VbVbalrExtensionMethods#6](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_7.vb)]  
  
 This time the code in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> calls the instance method both times. This is because both <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> have a widening conversion to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and the instance method takes precedence over the extension method in both cases.  
  
 [!code[VbVbalrExtensionMethods#7](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_8.vb)]  
  
 Therefore, an extension method cannot replace an existing instance method. However, when an extension method has the same name as an instance method but the signatures do not conflict, both methods can be accessed. For example, if class <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> contains a method named <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> that takes no arguments, extension methods with the same name but different signatures are permitted, as shown in the following code.  
  
 [!code[VbVbalrExtensionMethods#8](../vs140/codesnippet/VisualBasic/extension-methods--visual-basic-_9.vb)]  
  
 The output from this code is as follows:  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 The situation is simpler with properties: if an extension method has the same name as a property of the class it extends, the extension method is not visible and cannot be accessed.  
  
## Extension Method Precedence  
 When two extension methods that have identical signatures are in scope and accessible, the one with higher precedence will be invoked. An extension method's precedence is based on the mechanism used to bring the method into scope. The following list shows the precedence hierarchy, from highest to lowest.  
  
1.  Extension methods defined inside the current module.  
  
2.  Extension methods defined inside data types in the current namespace or any one of its parents, with child namespaces having higher precedence than parent namespaces.  
  
3.  Extension methods defined inside any type imports in the current file.  
  
4.  Extension methods defined inside any namespace imports in the current file.  
  
5.  Extension methods defined inside any project-level type imports.  
  
6.  Extension methods defined inside any project-level namespace imports.  
  
 If precedence does not resolve the ambiguity, you can use the fully qualified name to specify the method that you are calling. If the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> method in the earlier example is defined in a module named <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, the fully qualified name is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.Runtime.CompilerServices*>   
 \<xref:System.Runtime.CompilerServices.ExtensionAttribute*>   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)   
 [Module Statement](../vs140/module-statement.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Optional Parameters](../vs140/optional-parameters--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)