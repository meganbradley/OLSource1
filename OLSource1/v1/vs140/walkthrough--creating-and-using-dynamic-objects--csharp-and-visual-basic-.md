---
title: "Walkthrough: Creating and Using Dynamic Objects (C# and Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "dynamic objects [Visual Basic]"
  - "dynamic objects"
  - "dynamic objects [C#]"
ms.assetid: 568f1645-1305-4906-8625-5d77af81e04f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating and Using Dynamic Objects (C# and Visual Basic)
Dynamic objects expose members such as properties and methods at run time, instead of in at compile time. This enables you to create objects to work with structures that do not match a static type or format. For example, you can use a dynamic object to reference the HTML Document Object Model (DOM), which can contain any combination of valid HTML markup elements and attributes. Because each HTML document is unique, the members for a particular HTML document are determined at run time. A common method to reference an attribute of an HTML element is to pass the name of the attribute to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method of the element. To reference the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute of the HTML element <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you first obtain a reference to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element, and then use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If you use a dynamic object, you can reference the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Dynamic objects also provide convenient access to dynamic languages such as IronPython and IronRuby. You can use a dynamic object to refer to a dynamic script that is interpreted at run time.  
  
 You reference a dynamic object by using late binding. In C#, you specify the type of a late-bound object as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], you specify the type of a late-bound object as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [dynamic (C# Reference)](../vs140/dynamic--csharp-reference-.md) and [Early and Late Binding](../vs140/early-and-late-binding--visual-basic-.md).  
  
 You can create custom dynamic objects by using the classes in the \<xref:System.Dynamic*?displayProperty=fullName> namespace. For example, you can create an \<xref:System.Dynamic.ExpandoObject*> and specify the members of that object at run time. You can also create your own type that inherits the \<xref:System.Dynamic.DynamicObject*> class. You can then override the members of the \<xref:System.Dynamic.DynamicObject*> class to provide run-time dynamic functionality.  
  
 In this walkthrough you will perform the following tasks:  
  
-   Create a custom object that dynamically exposes the contents of a text file as properties of an object.  
  
-   Create a project that uses an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> library.  
  
## Prerequisites  
 You need IronPython 2.6.1 for .NET 4.0 to complete this walkthrough. You can download IronPython 2.6.1 for .NET 4.0 from [CodePlex](http://go.microsoft.com/fwlink/?LinkId=187223).  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## Creating a Custom Dynamic Object  
 The first project that you create in this walkthrough defines a custom dynamic object that searches the contents of a text file. Text to search for is specified by the name of a dynamic property. For example, if calling code specifies <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the dynamic class returns a generic list of strings that contains all of the lines from the file that begin with "Sample". The search is case-insensitive. The dynamic class also supports two optional arguments. The first argument is a search option enum value that specifies that the dynamic class should search for matches at the start of the line, the end of the line, or anywhere in the line. The second argument specifies that the dynamic class should trim leading and trailing spaces from each line before searching. For example, if calling code specifies <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the dynamic class searches for "Sample" anywhere in a line. If calling code specifies <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the dynamic class searches for "Sample" at the start of each line, and does not remove leading and trailing spaces. The default behavior of the dynamic class is to search for a match at the start of each line and to remove leading and trailing spaces.  
  
#### To create a custom dynamic class  
  
1.  Start [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New** and then click **Project**.  
  
3.  In the **New Project** dialog box, in the **Project Types** pane, make sure that **Windows** is selected. Select **Console Application** in the **Templates** pane. In the **Name** box, type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and then click **OK**. The new project is created.  
  
4.  Right-click the DynamicSample project and point to **Add**, and then click **Class**. In the **Name** box, type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and then click **OK**. A new file is added that contains the ReadOnlyFile class.  
  
5.  At the top of the ReadOnlyFile.cs or ReadOnlyFile.vb file, add the following code to import the \<xref:System.IO*?displayProperty=fullName> and \<xref:System.Dynamic*?displayProperty=fullName> namespaces.  
  
     [!code[VbDynamicWalkthrough#1](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_1.cs)]
[!code[VbDynamicWalkthrough#1](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_1.vb)]  
  
6.  The custom dynamic object uses an enum to determine the search criteria. Before the class statement, add the following enum definition.  
  
     [!code[VbDynamicWalkthrough#2](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_2.cs)]
[!code[VbDynamicWalkthrough#2](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_2.vb)]  
  
7.  Update the class statement to inherit the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class, as shown in the following code example.  
  
     [!code[VbDynamicWalkthrough#3](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_3.cs)]
[!code[VbDynamicWalkthrough#3](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_3.vb)]  
  
8.  Add the following code to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class to define a private field for the file path and a constructor for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class.  
  
     [!code[VbDynamicWalkthrough#4](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_4.cs)]
[!code[VbDynamicWalkthrough#4](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_4.vb)]  
  
9. Add the following <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method takes, as input, search criteria and returns the lines from a text file that match that search criteria. The dynamic methods provided by the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class call the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method to retrieve their respective results.  
  
     [!code[VbDynamicWalkthrough#5](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_5.cs)]
[!code[VbDynamicWalkthrough#5](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_5.vb)]  
  
10. After the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method, add the following code to override the \<xref:System.Dynamic.DynamicObject.TryGetMember*> method of the \<xref:System.Dynamic.DynamicObject*> class. The \<xref:System.Dynamic.DynamicObject.TryGetMember*> method is called when a member of a dynamic class is requested and no arguments are specified. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument contains information about the referenced member, and the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument references the result returned for the specified member. The \<xref:System.Dynamic.DynamicObject.TryGetMember*> method returns a Boolean value that returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the requested member exists; otherwise it returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
     [!code[VbDynamicWalkthrough#6](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_6.cs)]
[!code[VbDynamicWalkthrough#6](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_6.vb)]  
  
11. After the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method, add the following code to override the \<xref:System.Dynamic.DynamicObject.TryInvokeMember*> method of the \<xref:System.Dynamic.DynamicObject*> class. The \<xref:System.Dynamic.DynamicObject.TryInvokeMember*> method is called when a member of a dynamic class is requested with arguments. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument contains information about the referenced member, and the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> argument references the result returned for the specified member. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument contains an array of the arguments that are passed to the member. The \<xref:System.Dynamic.DynamicObject.TryInvokeMember*> method returns a Boolean value that returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if the requested member exists; otherwise it returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
     The custom version of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method expects the first argument to be a value from the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> enum that you defined in a previous step. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method expects the second argument to be a Boolean value. If one or both arguments are valid values, they are passed to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method to retrieve the results.  
  
     [!code[VbDynamicWalkthrough#7](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_7.cs)]
[!code[VbDynamicWalkthrough#7](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_7.vb)]  
  
12. Save and close the file.  
  
#### To create a sample text file  
  
1.  Right-click the DynamicSample project and point to **Add**, and then click **New Item**. In the **Installed Templates** pane, select **General**, and then select the **Text File** template. Leave the default name of TextFile1.txt in the **Name** box, and then click **Add**. A new text file is added to the project.  
  
2.  Copy the following text to the TextFile1.txt file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Save and close the file.  
  
#### To create a sample application that uses the custom dynamic object  
  
1.  In **Solution Explorer**, double-click the Module1.vb file if you are using [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or the Program.cs file if you are using Visual C#.  
  
2.  Add the following code to the Main procedure to create an instance of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> class for the TextFile1.txt file. The code uses late binding to call dynamic members and retrieve lines of text that contain the string "Customer".  
  
     [!code[VbDynamicWalkthrough#8](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_8.cs)]
[!code[VbDynamicWalkthrough#8](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_8.vb)]  
  
3.  Save the file and press CTRL+F5 to build and run the application.  
  
## Calling a Dynamic Language Library  
 The next project that you create in this walkthrough accesses a library that is written in the dynamic language IronPython. Before you create this project, you must have IronPython 2.6.1 for .NET 4.0 installed. You can download IronPython 2.6.1 for .NET 4.0 from [CodePlex](http://go.microsoft.com/fwlink/?LinkId=187223).  
  
#### To create a custom dynamic class  
  
1.  In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], on the **File** menu, point to **New** and then click **Project**.  
  
2.  In the **New Project** dialog box, in the **Project Types** pane, make sure that **Windows** is selected. Select **Console Application** in the **Templates** pane. In the **Name** box, type <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and then click **OK**. The new project is created.  
  
3.  If you are using [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], right-click the DynamicIronPythonSample project and then click **Properties**. Click the **References** tab. Click the **Add** button. If you are using Visual C#, in **Solution Explorer**, right-click the **References** folder and then click **Add Reference**.  
  
4.  On the **Browse** tab, browse to the folder where the IronPython libraries are installed. For example, C:\Program Files\IronPython 2.6 for .NET 4.0. Select the **IronPython.dll**, **IronPython.Modules.dll**, **Microsoft.Scripting.dll**, and **Microsoft.Dynamic.dll** libraries. Click **OK**.  
  
5.  If you are using [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], edit the Module1.vb file. If you are using Visual C#, edit the Program.cs file.  
  
6.  At the top of the file, add the following code to import the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> namespaces from the IronPython libraries.  
  
     [!code[VbDynamicWalkthroughIronPython#1](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_9.cs)]
[!code[VbDynamicWalkthroughIronPython#1](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_9.vb)]  
  
7.  In the Main method, add the following code to create a new <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object to host the IronPython libraries. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object loads the IronPython library module random.py.  
  
     [!code[VbDynamicWalkthroughIronPython#2](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_10.cs)]
[!code[VbDynamicWalkthroughIronPython#2](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_10.vb)]  
  
8.  After the code to load the random.py module, add the following code to create an array of integers. The array is passed to the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method of the random.py module, which randomly sorts the values in the array.  
  
     [!code[VbDynamicWalkthroughIronPython#3](../vs140/codesnippet/CSharp/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_11.cs)]
[!code[VbDynamicWalkthroughIronPython#3](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-using-dynamic-objects--csharp-and-visual-basic-_11.vb)]  
  
9. Save the file and press CTRL+F5 to build and run the application.  
  
## See Also  
 \<xref:System.Dynamic*?displayProperty=fullName>   
 \<xref:System.Dynamic.DynamicObject*?displayProperty=fullName>   
 [Using Type dynamic (C# Programming Guide)](../vs140/using-type-dynamic--csharp-programming-guide-.md)   
 [Early and Late Binding](../vs140/early-and-late-binding--visual-basic-.md)   
 [dynamic (C# Reference)](../vs140/dynamic--csharp-reference-.md)   
 [Implementing Dynamic Interfaces (external blog)](http://go.microsoft.com/fwlink/?LinkId=230895)