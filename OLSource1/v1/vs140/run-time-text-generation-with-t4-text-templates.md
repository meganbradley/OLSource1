---
title: "Run-Time Text Generation with T4 Text Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Preprocessed Text Template project item"
  - "TextTemplatingFilePreprocessor custom tool"
  - "text templates, TransformText() method"
  - "text templates, generating files at run time"
ms.assetid: 79b4b3c6-a9a7-4446-b6fd-e2388fc6b05f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run-Time Text Generation with T4 Text Templates
You can generate text strings in your application at run time by using [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] runtime text templates. The computer where the application executes does not have to have [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Runtime templates are sometimes called "preprocessed text templates" because at compile time, the template generates code that is executed at run time.  
  
 Each template is a mixture of the text as it will appear in the generated string, and fragments of program code. The program fragments supply values for the variable parts of the string, and also control conditional and repeated parts.  
  
 For example, the following template could be used in an application that creates an HTML report.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice that the template is an HTML page in which the variable parts have been replaced with program code. You could begin the design of such a page by writing a static prototype of the HTML page. You could then replace the table and other variable parts with program code that generates the content that varies from one occasion to the next.  
  
 Using a template in your application makes it is easier to see the final form of the output than you could in, for example, a long series of write statements. Making changes to the form of the output is easier and more reliable.  
  
## Creating a Run-Time Text Template in any Application  
  
#### To create a run-time text template  
  
1.  In Solution Explorer, on the shortcut menu of your project, choose **Add**, **New Item**.  
  
2.  In the **Add New Item** dialog box, select **Runtime Text Template**. (In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] look under **Common Items\General**.)  
  
3.  Type a name for your template file.  
  
    > [!NOTE]
    >  The template file name will be used as a class name in the generated code. Therefore, it should not have spaces or punctuation.  
  
4.  Choose **Add**.  
  
     A new file is created that has extension **.tt**. Its **Custom Tool** property is set to **TextTemplatingFilePreprocessor**. It contains the following lines:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Converting an Existing File to a Run-Time Template  
 A good way to create a template is to convert an existing example of the output. For example, if your application will generate HTML files, you can start by creating a plain HTML file. Make sure that it works correctly and that its appearance is correct. Then include it into your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project and convert it to a template.  
  
#### To convert an existing text file to a run-time template  
  
1.  Include the file into your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. In Solution Explorer, on the shortcut menu of the project, choose **Add**, **Existing Item**.  
  
2.  Set the file's **Custom Tools** property to **TextTemplatingFilePreprocessor**. In Solution Explorer, on the shortcut menu of the file, choose **Properties**.  
  
    > [!NOTE]
    >  If the property is already set, make sure that it is **TextTemplatingFilePreprocessor** and not **TextTemplatingFileGenerator**. This can happen if you include a file that already has the extension **.tt**.  
  
3.  Change the file name extension to **.tt**. Although this step is optional, it helps you avoid opening the file in an incorrect editor.  
  
4.  Remove any spaces or punctuation from the main part of the file name. For example "My Web Page.tt" would be incorrect, but "MyWebPage.tt" is correct. The file name will be used as a class name in the generated code.  
  
5.  Insert the following line at the beginning of the file. If you are working in a Visual Basic project, replace "C#" with "VB".  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## The Content of the Run-Time Template  
  
### Template directive  
 Keep the first line of the template as it was when you created the file:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 The language parameter will depend on the language of your project.  
  
### Plain content  
 Edit the **.tt** file to contain the text that you want your application to generate. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Embedded program code  
 You can insert program code between <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Notice that statements are inserted between <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and expressions are inserted between <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [Writing a Text Template](../vs140/writing-a-t4-text-template.md).  
  
## Using the Template  
  
### The code built from the template  
 Whenever you save the **.tt** file, a subsidiary **.cs** or **.vb** file will be generated. To see this file in Solution Explorer, expand the **.tt** file node. In a Visual Basic project, you will be able to expand the node after you click **Show All Files** in the Solution Explorer toolbar.  
  
 Notice that this subsidiary file contains a partial class that contains a method called <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. You can call this method from your application.  
  
### Generating text at run time  
 In your application code, you can generate the content of your template using a call like this:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To place the generated class in a particular namespace, set the **Custom Tool Namespace** property of the text template file.  
  
### Debugging Runtime Text Templates  
 Debug and test runtime text templates in the same way as ordinary code.  
  
 You can set a breakpoint in a text template. If you start the application in debugging mode from Visual Studio, you can step through the code and evaluate watch expressions in the usual way.  
  
### Passing parameters in the constructor  
 Usually a template must import some data from other parts of the application. To make this easy, the code built by the template is a partial class. You can create another part of the same class in another file in your project. That file can include a constructor with parameters, properties and functions that can accessed both by the code that is embedded in the template, and by the rest of the application.  
  
 For example, you could create a separate file **MyWebPageCode.cs**:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In your template file **MyWebPage.tt**, you could write:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 To use this template in the application:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
#### Constructor parameters in Visual Basic  
 In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], the separate file **MyWebPageCode.vb** contains:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The template file could contain:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 And the template would be invoked by passing the parameter in the constructor:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
#### Passing data in template properties  
 An alternative method of passing data to the template is to add public properties to the template class in a partial class definition. Your application can set the properties before invoking <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 You can also add fields to your template class in a partial definition. This would enable you to pass data between successive executions of the template.  
  
### Use partial classes for code  
 Many developers prefer to avoid writing large bodies of code in templates. Instead, define methods in a partial class that has the same name as the template file. Call those methods from the template. In this way, the template shows you more clearly what the target output string will look like. Discussions about the appearance of the result can be separated from the logic of creating the data that it displays.  
  
### Assemblies and references  
 If you want your template code to reference a .NET or other assembly such as **System.Xml.dll**, you should add it to your project's **References** in the usual manner.  
  
 If you want to import a namespace in the same way as a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement, you can do this with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> directive:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 These directives must be placed at the beginning of the file, immediately after the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> directive.  
  
### Shared content  
 If you have text that is shared between several templates, you can place it in a separate file and include it in each file in which it should appear:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The included content can contain any mixture of program code and plain text, and it can contain other include directives and other directives.  
  
 The include directive can be used anywhere within the text of a template file or an included file.  
  
### Inheritance between Run-Time Text Templates  
 You can share content between run-time templates by writing a base class template, which can be abstract. Use the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> directive to reference another runtime template class.  
  
#### Inheritance pattern: Fragments in Base Methods  
 In the pattern used in the example that follows, notice the following points:  
  
-   The base class <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> defines methods within class feature blocks <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
-   The base class contains no free text. Instead, all its text blocks occur inside the class feature methods.  
  
-   The derived class invokes the methods defined in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
-   The application calls the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method of the derived class, but does not transform the base class <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
-   Both the base and derived classes are runtime text templates: that is, the **Custom Tool** property is set to **TextTemplatingFilePreprocessor**.  
  
 **SharedFragments.tt:**  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 **MyTextTemplate1.tt:**  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 **MyProgram.cs:**  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 **The resulting output:**  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
#### Inheritance Pattern: Text in Base Body  
 In this alternative approach to using template inheritance, the bulk of the text is defined in the base template. The derived templates provide data and text fragments that fit into the base content.  
  
 **AbstractBaseTemplate1.tt:**  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 **DerivedTemplate1.tt:**  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 **Application code:**  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 **Resulting output:**  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
## Related Topics  
 Design Time Templates: If you want to use a template to generate code that becomes part of your application, see [Generating Files in a Visual Studio Solution](../vs140/design-time-code-generation-by-using-t4-text-templates.md).  
  
 Runtime templates can be used in any application where the templates and their content are determined at compile time. But if you want to write a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extension that generates text from templates that change at run time, see [Invoking Text Transformation in a Visual Studio Extension](../vs140/invoking-text-transformation-in-a-vs-extension.md).  
  
## See Also  
 [Generating artifacts by using text templates](../vs140/code-generation-and-t4-text-templates.md)   
 [Writing a Text Template](../vs140/writing-a-t4-text-template.md)   
 [Understanding T4: Preprocessed Text Templates by Oleg Sych](http://www.olegsych.com/2009/09/t4-preprocessed-text-templates/)