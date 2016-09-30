---
title: "References to Declared Elements (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "declared elements"
  - "references, declared elements"
  - "qualified names"
ms.assetid: d6301709-f4cc-4b7a-b8ba-80898f14ab46
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# References to Declared Elements (Visual Basic)
When your code refers to a declared element, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler matches the name in your reference to the appropriate declaration of that name. If more than one element is declared with the same name, you can control which of those elements is to be referenced by *qualifying* its name.  
  
 The compiler attempts to match a name reference to a name declaration with the *narrowest scope*. This means it starts with the code making the reference and works outward through successive levels of containing elements.  
  
 The following example shows references to two variables with the same name. The example declares two variables, each named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, at different levels of scope in module <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. When the procedure <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> displays <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> without qualification, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler resolves the reference to the declaration with the narrowest scope, namely the local declaration inside <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. When it qualifies <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with the containing module <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the compiler resolves the reference to the declaration with the broader scope.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Qualifying an Element Name  
 If you want to override this search process and specify a name declared in a broader scope, you must *qualify* the name with the containing element of the broader scope. In some cases, you might also have to qualify the containing element.  
  
 Qualifying a name means preceding it in your source statement with information that identifies where the target element is defined. This information is called a *qualification string*. It can include one or more namespaces and a module, class, or structure.  
  
 The qualification string should unambiguously specify the module, class, or structure containing the target element. The container might in turn be located in another containing element, usually a namespace. You might need to include several containing elements in the qualification string.  
  
#### To access a declared element by qualifying its name  
  
1.  Determine the location in which the element has been defined. This might include a namespace, or even a hierarchy of namespaces. Within the lowest-level namespace, the element must be contained in a module, class, or structure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Determine a qualification path based on the target element's location. Start with the highest-level namespace, proceed to the lowest-level namespace, and end with the module, class, or structure containing the target element. Each element in the path must contain the element that follows it.  
  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> → <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> → <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> → <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
3.  Prepare the qualification string for the target element. Place a period (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) after every element in the path. Your application must have access to every element in your qualification string.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Write the expression or assignment statement referring to the target element in the normal way.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Precede the target element name with the qualification string. The name should immediately follow the period (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) that follows the module, class, or structure that contains the element.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
6.  The compiler uses the qualification string to find a clear, unambiguous declaration to which it can match the target element reference.  
  
 You might also have to qualify a name reference if your application has access to more than one programming element that has the same name. For example, the \<xref:System.Windows.Forms*> and \<xref:System.Web.UI.WebControls*> namespaces both contain a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class (\<xref:System.Windows.Forms.Label*?displayProperty=fullName> and \<xref:System.Web.UI.WebControls.Label*?displayProperty=fullName>). If your application uses both, or if it defines its own <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class, you must distinguish the different <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects. Include the namespace or import alias in the variable declaration. The following example uses the import alias.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Members of Other Containing Elements  
 When you use a nonshared member of another class or structure, you must first qualify the member name with a variable or expression that points to an instance of the class or structure. In the following example, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is an instance of a class named <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 You cannot use the class name itself to qualify a member that is not [Shared](../vs140/shared--visual-basic-.md). You must first create an instance in an object variable (in this case <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>) and then reference it by the variable name.  
  
 If a class or structure has a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> member, you can qualify that member either with the class or structure name or with a variable or expression that points to an instance.  
  
 A module does not have any separate instances, and all its members are <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> by default. Therefore, you qualify a module member with the module name.  
  
 The following example shows qualified references to module member procedures. The example declares two <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> procedures, both named <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, in different modules in a project. Each one can be specified without qualification within its own module but must be qualified if referenced from anywhere else. Because the final reference in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> does not qualify <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, the compiler cannot resolve that reference.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## References to Projects  
 To use [Public](../vs140/public--visual-basic-.md) elements defined in another project, you must first set a *reference* to that project's assembly or type library. To set a reference, click **Add Reference** on the **Project** menu, or use the [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md) command-line compiler option.  
  
 For example, you can use the XML object model of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. If you set a reference to the \<xref:System.Xml*> namespace, you can declare and use any of its classes, such as \<xref:System.Xml.XmlDocument*>. The following example uses \<xref:System.Xml.XmlDocument*>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Importing Containing Elements  
 You can use the [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md) to *import* the namespaces that contain the modules or classes that you want to use. This enables you to refer to the elements defined in an imported namespace without fully qualifying their names. The following example rewrites the previous example to import the \<xref:System.Xml*> namespace.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 In addition, the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement can define an *import alias* for each imported namespace. This can make the source code shorter and easier to read. The following example rewrites the previous example to use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> as an alias for the \<xref:System.Xml*> namespace.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement does not make elements from other projects available to your application. That is, it does not take the place of setting a reference. Importing a namespace just removes the requirement to qualify the names defined in that namespace.  
  
 You can also use the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement to import modules, classes, structures, and enumerations. You can then use the members of such imported elements without qualification. However, you must always qualify nonshared members of classes and structures with a variable or expression that evaluates to an instance of the class or structure.  
  
## Naming Guidelines  
 When you define two or more programming elements that have the same name, a *name ambiguity* can result when the compiler attempts to resolve a reference to that name. If more than one definition is in scope, or if no definition is in scope, the reference is irresolvable. For an example, see "Qualified Reference Example" on this Help page.  
  
 You can avoid name ambiguity by giving all your elements unique names. Then you can make reference to any element without having to qualify its name with a namespace, module, or class. You also reduce the chances of accidentally referring to the wrong element.  
  
## Shadowing  
 When two programming elements share the same name, one of them can hide, or *shadow*, the other one. A shadowed element is not available for reference; instead, when your code uses the shadowed element name, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler resolves it to the shadowing element. For a more detailed explanation with examples, see [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md).  
  
## See Also  
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Declared Element Characteristics](../vs140/declared-element-characteristics--visual-basic-.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)   
 [Variables](../vs140/variables-in-visual-basic.md)   
 [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [New Operator](../vs140/new-operator--visual-basic-.md)   
 [Public](../vs140/public--visual-basic-.md)