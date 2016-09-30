---
title: "Design-Time Code Generation by using T4 Text Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, guidelines for code generation"
  - "text templates, data source model"
  - "TextTemplatingFileGenerator custom tool"
  - "Transform All Templates"
  - "text templates, getting started"
  - "Text Template project item"
  - "text templates, generating code for your application"
ms.assetid: 2774b83d-1adb-4c66-a607-746e019b80c0
caps.latest.revision: 42
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Design-Time Code Generation by using T4 Text Templates
Design-time T4 text templates let you generate program code and other files in your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. Typically, you write the templates so that they vary the code that they generate according to data from a *model*. A model is a file or database that contains key information about your application’s requirements.  
  
 For example, you could have a model that defines a workflow, either as a table or a diagram. From the model, you can generate the software that executes the workflow. When your users’ requirements change, it is easy to discuss the new workflow with the users. Regenerating the code from the workflow is more reliable than updating the code by hand.  
  
> [!NOTE]
>  A *model* is a data source that describes a particular aspect of an application. It can be any form, in any kind of file or database. It does not have to be in any particular form, such as a UML model or Domain-Specific Language model. Typical models are in the form of tables or XML files.  
  
 You are probably already familiar with code generation. When you define resources in a **.resx** file in your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution, a set of classes and methods is generated automatically. The resources file makes it much easier and more reliable to edit the resources than it would be if you had to edit the classes and methods. With text templates, you can generate code in the same manner from a source of your own design.  
  
 A text template contains a mixture of the text that you want to generate, and program code that generates variable parts of the text. The program code and allows you to repeat or conditionally omit parts of the generated text. The generated text can itself be program code that will form part of your application.  
  
## Creating a Design-Time T4 Text Template  
  
#### To create a design-time T4 template in Visual Studio  
  
1.  Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project, or open an existing one.  
  
     For example, on the **File** menu, choose **New**, **Project**.  
  
2.  Add a text template file to your project and give it a name that has the extension **.tt**.  
  
     To do this, in **Solution Explorer**, on the shortcut menu of your project, choose **Add**, **New Item**. In the **Add New Item** dialog box select **Text Template** from the middle pane.  
  
     Notice that the **Custom Tool** property of the file is **TextTemplatingFileGenerator**.  
  
3.  Open the file. It will already contain the following directives:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     If you added the template to a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project, the language attribute will be "<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>".  
  
4.  Add some text at the end of the file. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Save the file.  
  
     You might see a **Security Warning** message box that asks you to confirm that you want to run the template. Click **OK**.  
  
6.  In **Solution Explorer**, expand the template file node and you will find a file that has the extension **.txt**. The file contains the text generated from the template.  
  
    > [!NOTE]
    >  If your project is a Visual Basic project, you must click **Show All Files** in order to see the output file.  
  
### Regenerating the code  
 A template will be executed, generating the subsidiary file, in any of the following cases:  
  
-   Edit the template and then change focus to a different [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] window.  
  
-   Save the template.  
  
-   Click **Transform All Templates** in the **Build** menu. This will transform all the templates in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution.  
  
-   In **Solution Explorer**, on the shortcut menu of any file, choose **Run Custom Tool**. Use this method to transform a selected subset of templates.  
  
 You can also set up a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project so that the templates are executed when the data files that they read have changed. For more information, see [Regenerating the Code Automatically](#Regenerating).  
  
## Generating Variable Text  
 Text templates let you use program code to vary the content of the generated file.  
  
#### To generate text by using program code  
  
1.  Change the content of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  Save the .tt file, and inspect the generated .txt file again. It lists the squares of the numbers from 0 to 10.  
  
 Notice that statements are enclosed within <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and single expressions within <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For more information, see [Writing a Text Template](../vs140/writing-a-t4-text-template.md).  
  
 If you write the generating code in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> directive should contain <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the default.  
  
## Debugging a Design-Time T4 Text Template  
 To debug a text template:  
  
-   Insert <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> directive. For example:  
  
     <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
-   Set breakpoints in the template, in the same way that you would for ordinary code.  
  
-   Choose **Debug T4 Template** from the shortcut menu of the text template file in Solution Explorer.  
  
 The template will run and stop at the breakpoints. You can examine variables and step through the code in the usual way.  
  
> [!TIP]
>  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> makes the generated code map more accurately to the text template, by inserting more line numbering directives into the generated code. If you leave it out, breakpoints might stop the run in the wrong state.  
>   
>  But you can leave the clause in the template directive even when you are not debugging. This causes only a very small drop in performance.  
  
## Generating Code or Resources for Your Solution  
 You can generate program files that vary, depending on a model. A model is an input such as a database, configuration file, UML model, DSL model, or other source. You usually generate several program files are from the same model. To achieve this, you create a template file for each generated program file, and have all the templates read the same model.  
  
#### To generate program code or resources  
  
1.  Change the output directive to generate a file of the appropriate type, such as .cs, .vb, .resx, or .xml.  
  
2.  Insert code that will generate the solution code that you require. For example, if you want to generate three integer field declarations in a class:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Save the file and inspect the generated file, which now contains the following code:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Generating Code and Generated Text  
 When you generate program code, it is most important to avoid confusing the generating code that executes in your template, and the resulting generated code that becomes part of your solution. The two languages do not have to be the same.  
  
 The previous example has two versions. In one version, the generating code is in C#. In the other version, the generating code is Visual Basic. But the text generated by both of them is the same, and it is a C# class.  
  
 In the same way, you could use a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template to generate code in any language. The generated text does not have to be in any particular language, and it does not have to be program code.  
  
### Structuring text templates  
 As a matter of good practice, we tend to separate the template code into two parts:  
  
-   A configuration or data-gathering part, which sets values in variables, but does not contain text blocks. In the previous example, this part is the initialization of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
     This is sometimes called the "model" section, because it constructs an in-store model, and typically reads a model file.  
  
-   The text-generation part (<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in the example), which uses the values of the variables.  
  
 This is not a necessary separation, but it is a style which makes it easier to read the template by reducing the complexity of the part that includes text.  
  
## Reading files or other sources  
 To access a model file or database, your template code can use assemblies such as System.XML. To gain access to these assemblies, you must insert directives such as these:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> directive makes the specified assembly available to your template code, in the same manner as the References section of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. You do not need to include a reference to System.dll, which is referenced automatically. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> directive lets you use types without using their fully qualified names, in the same manner as the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> directive in an ordinary program file.  
  
 For example, after importing **System.IO**, you could write:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Opening a file with a relative pathname  
 To load a file from a location relative to the text template, you can use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. To use this.Host, you must set <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Then you can write, for example:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 You can also use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, which identifies the name of the current template file.  
  
 The type of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> (in VB, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Getting data from [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]  
 To use services provided in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], set the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> attribute and load the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> assembly. You can then use IServiceProvider.GetCOMService() to access DTE and other services. For example:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
> [!TIP]
>  A text template runs in its own app domain, and services are accessed by marshaling. In this circumstance, GetCOMService() is more reliable than GetService().  
  
##  \<a name="Regenerating">\</a> Regenerating the code automatically  
 Typically, several files in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution are generated with one input model. Each file is generated from its own template, but the templates all refer to the same model.  
  
 If the source model changes, you should re-run all the templates in the solution. To do this manually, choose **Transform All Templates** on the **Build** menu.  
  
 If you have installed [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Visualization and Modeling SDK, you can have all the templates transformed automatically whenever you perform a build. To do this, edit your project file (.csproj or .vbproj) in a text editor and add the following lines near the end of the file, after any other <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> statements:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 For more information, see [Code Generation in a Build Process](../vs140/code-generation-in-a-build-process.md).  
  
## Error reporting  
 To place error and warning messages in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] error window, you can use these methods:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="Converting">\</a> Converting an existing file to a template  
 A useful feature of templates is that they look very much like the files that they generate, together with some inserted program code. This suggests a useful method of creating a template. First create an ordinary file as a prototype, such as a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] file, and then gradually introduce generation code that varies the resulting file.  
  
#### To convert an existing file to a design-time template  
  
1.  To your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project, add a file of the type that you want to generate, such as a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> file.  
  
2.  Test the new file to make sure that it works.  
  
3.  In Solution Explorer, change the file name extension to **.tt**.  
  
4.  Verify the following properties of the **.tt** file:  
  
    |||  
    |-|-|  
    |**Custom Tool =**|**TextTemplatingFileGenerator**|  
    |**Build Action =**|**None**|  
  
5.  Insert the following lines at the beginning of the file:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     If you want to write the generating code of your template in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], set the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
     Set the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute to the file name extension for the type of file that you want to generate, for example <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
6.  Save the file.  
  
     A subsidiary file is created, with the specified extension. Its properties are correct for the type of file. For example, the **Build Action** property of a .cs file would be **Compile**.  
  
     Verify that the generated file contains the same content as the original file.  
  
7.  Identify a part of the file that you want to vary. For example, a part that appears only under certain conditions, or a part that is repeated, or where the specific values vary. Insert generating code. Save the file and verify that the subsidiary file is correctly generated. Repeat this step.  
  
## Guidelines for Code Generation  
 Please see [Guidelines for Writing Text Templates](../vs140/guidelines-for-writing-t4-text-templates.md).  
  
## Next steps  
  
|Next step|Topic|  
|---------------|-----------|  
|Write and debug a more advanced text template, with code that uses auxiliary functions, included files, and external data.|[Writing a Text Template](../vs140/writing-a-t4-text-template.md)|  
|Generate documents from templates at run time.|[Generating Files from Templates at Run Time](../vs140/run-time-text-generation-with-t4-text-templates.md)|  
|Run text generation outside [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].|[The Text Transform Executable](../vs140/generating-files-with-the-texttransform-utility.md)|  
|Transform your data in the form of a domain-specific language.|[Using Text Templates in Domain-Specific Language Solutions](../vs140/generating-code-from-a-domain-specific-language.md)|  
|Write directive processors to transform your own data sources.|[Text Template Extensibility](../vs140/customizing-t4-text-transformation.md)|  
  
## See Also  
 [Guidelines for Writing Text Templates](../vs140/guidelines-for-writing-t4-text-templates.md)