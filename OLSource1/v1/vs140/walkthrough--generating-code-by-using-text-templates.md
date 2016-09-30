---
title: "Walkthrough: Generating Code by using Text Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "walkthroughs [text templates], generating application code"
  - "walkthroughs [text templates]"
ms.assetid: 24602ade-baca-425e-a6ce-be09a2c7f7e1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Generating Code by using Text Templates
Code generation allows you to produce program code that is strongly typed, and yet can be easily changed when the source model changes. Contrast this with the alternative technique of writing a completely generic program that accepts a configuration file, which is more flexible, but results in code that is neither so easy to read and change, nor has such good performance. This walkthrough demonstrates this benefit.  
  
## Typed code for reading XML  
 The System.Xml namespace provides comprehensive tools for loading an XML document and then navigating it freely in memory. Unfortunately, all the nodes have the same type, XmlNode. It is therefore very easy to make programming mistakes such as expecting the wrong type of child node, or the wrong attributes.  
  
 In this example project, a template reads a sample XML file, and generates classes that correspond to each type of node. In the hand-written code, you can use these classes to navigate the XML file. You can also run your application on any other files that use the same node types. The purpose of the sample XML file is to provide examples of all the node types that you want your application to deal with.  
  
> [!NOTE]
>  The application [xsd.exe](http://go.microsoft.com/fwlink/?LinkId=178765), which is included with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], can generate strongly-typed classes from XML files. The template shown here is provided as an example.  
  
 Here is the sample file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the project that this walkthrough constructs, you can write code such as the following, and IntelliSense prompts you with the correct attribute and child names as you type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contrast this with the untyped code that you might write without the template:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the strongly typed version, a change to the XML schema will result in changes to the classes. The compiler will highlight the parts of the application code that must be changed. In the untyped version that uses generic XML code, there is no such support.  
  
 In this project, a single template file is used to generate the classes that make the typed version possible.  
  
## Setting up the Project  
  
### Create or open a C# project  
 You can apply this technique to any code project. This walkthrough uses a C# project, and for the purposes of testing we use a console application.  
  
##### To create the project  
  
1.  On the **File** menu click **New** and then click **Project**.  
  
2.  Click the **Visual C#** node, and then in the **Templates** pane, click **Console Application.**  
  
### Add a prototype XML file to the project  
 The purpose of this file is to provide samples of the XML node types that you want your application to be able to read. It could be a file that will be used for testing your application. The template will produce a C# class for each node type in this file.  
  
 The file should be part of the project so that the template can read it, but it will not be built into the compiled application.  
  
##### To add an XML file  
  
1.  In **Solution Explorer**, right-click the project, click **Add** and then Click **New Item**.  
  
2.  In the **Add New Item** dialog box, select **XML File** from the **Templates** pane.  
  
3.  Add your sample content to the file.  
  
4.  For this walkthrough, name the file <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Set the content of the file to be the XML shown in the previous section.  
  
 ..  
  
### Add a test code file  
 Add a C# file to your project and write in it a sample of the code that you want to be able to write. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 At this stage, this code will fail to compile. As you write the template, you will generate classes that allow it to succeed.  
  
 A more comprehensive test could check the output of this test function against the known content of the example XML file. But in this walkthrough, we will be satisfied when the test method compiles.  
  
### Add a text template file  
 Add a text template file, and set the output extension to ".cs".  
  
##### To add a text template file to your project  
  
1.  In **Solution Explorer**, right-click the project, click **Add**, and then click **New Item**.  
  
2.  In the **Add New Item** dialog box select **Text Template** from the **Templates** pane.  
  
    > [!NOTE]
    >  Make sure that you add a Text Template, and not a Preprocessed Text Template.  
  
3.  In the file, in the template directive, change the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
     This change will enable the template code to gain access to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] services.  
  
4.  In the output directive, change the extension attribute to ".cs", so that the template generates a C# file. In a Visual Basic project, you would change it to ".vb".  
  
5.  Save the file. At this stage, the text template file should contain these lines:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 .  
  
 Notice that a .cs file appears in Solution Explorer as a subsidiary of the template file. You can see it by clicking [+] next to the name of the template file. This file is generated from the template file whenever you save or move the focus away from the template file. The generated file will be compiled as part of your project.  
  
 For convenience while you develop the template file, arrange the windows of the template file and the generated file so that you can see them next to each other. This lets you see immediately the output of your template. You will also notice that when your template generates invalid C# code, errors will appear in the error message window.  
  
 Any edits you perform directly in the generated file will be lost whenever you save the template file. You should therefore either avoid editing the generated file, or edit it only for short experiments. It is sometimes useful to try a short fragment of code in the generated file, where IntelliSense is in operation, and then copy it to the template file.  
  
## Developing the Text Template  
 Following the best advice on agile development, we will develop the template in small steps, clearing some of the errors at each increment, until the test code compiles and runs correctly.  
  
### Prototype the code to be generated  
 The test code requires a class for each node in the file. Therefore, some of the compilation errors will go away if you append these lines to the template, and then save it:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This helps you see what is required, but the declarations should be generated from the node types in the sample XML file. Delete these experimental lines from the template.  
  
### Generate application code from the model XML file  
 To read the XML file and generate class declarations, replace the template content with the following template code:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Replace the file path with the correct path for your project.  
  
 Notice the code block delimiters <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. These delimiters bracket a fragment of the program code that generates the text. The expression block delimiters <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> bracket an expression that can be evaluated to a string.  
  
 When you are writing a template that generates source code for your application, you are dealing with two separate program texts. The program inside the code block delimiters runs every time that you save the template or move the focus to another window. The text that it generates, which appears outside the delimiters, is copied to the generated file and becomes part of your application code.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> directive behaves like a reference, making the assembly available to the template code. The list of assemblies seen by the template is separate from the list of References in the application project.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> directive acts like a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement, allowing you to use the short names of classes in the imported namespace.  
  
 Unfortunately, although this template generates code, it produces a class declaration for every node in the example XML file, so that if there are several instances of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> node, several declarations of the class song will appear.  
  
### Read the model file, then generate the code  
 Many text templates follow a pattern in which the first part of the template reads the source file, and the second part generates the template. We need to read all of the example file to summarize the node types that it contains, and then generate the class declarations. Another <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is needed so that we can use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Add an auxiliary method  
 A class feature control block is a block in which you can define auxiliary methods. The block is delimited by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and it must appear as the last block in the file.  
  
 If you prefer class names to begin with an uppercase letter, you can replace the last part of the template with the following template code:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 At this stage, the generated .cs file contains the following declarations:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 More details such as properties for the child nodes, attributes, and inner text can be added using the same approach.  
  
### Accessing the Visual Studio API  
 Setting the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> directive allows the template to obtain access to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] API. The template can use this to obtain the location of the project files, to avoid using an absolute file path in the template code.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Completing the Text Template  
 The following template content generates code that allows the test code to compile and run.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Running the test program  
 In the main of the console application, the following lines will execute the test method. Press F5 to run the program in debug mode:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Writing and updating the application  
 The application can now be written in strongly-typed style, using the generated classes instead of using generic XML code.  
  
 When the XML schema changes, new classes can easily be generated. The compiler will tell the developer where the application code must be updated.  
  
 To regenerate the classes when the example XML file is changed, click **Transform All Templates** in the Solution Explorer toolbar.  
  
## Conclusion  
 This walkthrough demonstrates several techniques and benefits of code generation:  
  
-   *Code generation* is the creation of part of the source code of your application from a *model*. The model contains information in a form suited to the application domain, and may change over the lifetime of the application.  
  
-   Strong typing is one benefit of code generation. While the model represents information in a form more suitable to the user, the generated code allows other parts of the application to deal with the information using a set of types.  
  
-   IntelliSense and the compiler help you create code that adheres to the schema of the model, both when you write new code and when the schema is updated.  
  
-   The addition of a single uncomplicated template file to a project can provide these benefits.  
  
-   A text template can be developed and tested rapidly and incrementally.  
  
 In this walkthrough, the program code is actually generated from an instance of the model, a representative example of the XML files that the application will process. In a more formal approach, the XML schema would be the input to the template, in the form of an .xsd file or a domain-specific language definition. That approach would make it easier for the template to determine characteristics such as the multiplicity of a relationship.  
  
## Troubleshooting the Text Template  
 If you have seen template transformation or compilation errors in the **Error List**, or if the output file was not generated correctly, you can troubleshoot the text template with the techniques described in [Troubleshooting Text Templates](../vs140/generating-files-with-the-texttransform-utility.md).  
  
## See Also  
 [Code Generation in a Visual Studio Project](../vs140/design-time-code-generation-by-using-t4-text-templates.md)   
 [Writing a Text Template](../vs140/writing-a-t4-text-template.md)