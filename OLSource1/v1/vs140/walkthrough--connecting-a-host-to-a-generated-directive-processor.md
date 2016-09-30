---
title: "Walkthrough: Connecting a Host to a Generated Directive Processor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "walkthroughs [text templates], connecting host to processor"
  - "text templates, custom directive hosts"
ms.assetid: 254540d9-90d6-42de-8c1c-068affd56e83
caps.latest.revision: 51
---
# Walkthrough: Connecting a Host to a Generated Directive Processor
You can write your own host that processes text templates. A basic custom host is demonstrated in [Walkthrough: Creating a Text Template Host](../vs140/walkthrough--creating-a-custom-text-template-host.md). You could extend that host to add functions such as generating multiple output files.  
  
 In this walkthrough, you expand your custom host so that it supports text templates that call directive processors. When you define a domain-specific language, it generates a *directive processor* for the domain model. The directive processor makes it easier for users to write templates that access the model, reducing the need to write assembly and import directives in the templates.  
  
> [!WARNING]
>  This walkthrough builds on [Walkthrough: Creating a Text Template Host](../vs140/walkthrough--creating-a-custom-text-template-host.md). Perform that walkthrough first.  
  
 This walkthrough includes the following tasks:  
  
-   Using [!INCLUDE[dsl](../vs140/includes/dsl_md.md)] to generate a directive processor that is based on a domain model.  
  
-   Connecting a custom text template host to the generated directive processor.  
  
-   Testing the custom host with the generated directive processor.  
  
## Prerequisites  
 To define a DSL, you must have installed the following components:  
  
|||  
|-|-|  
|[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]|[http://go.microsoft.com/fwlink/?LinkId=185579](http://go.microsoft.com/fwlink/?LinkId=185579)|  
|[!INCLUDE[vssdk_current_short](../vs140/includes/vssdk_current_short_md.md)]|[http://go.microsoft.com/fwlink/?LinkId=185580](http://go.microsoft.com/fwlink/?LinkId=185580)|  
|Visual Studio Visualization and Modeling SDK|[http://go.microsoft.com/fwlink/?LinkID=186128](http://go.microsoft.com/fwlink/?LinkID=186128)|  
  
 In addition, you must have the custom text template transformation created in [Walkthrough: Creating a Text Template Host](../vs140/walkthrough--creating-a-custom-text-template-host.md).  
  
## Using Domain-Specific Language Tools to Generate a Directive Processor  
 In this walkthrough, you use the Domain-Specific Language Designer Wizard to create a domain-specific language for the solution DSLMinimalTest.  
  
#### To use Domain-Specific Language Tools to generate a directive processor that is based on a domain model  
  
1.  Create a domain-specific language solution that has the following characteristics:  
  
    -   Name: DSLMinimalTest  
  
    -   Solution template: Minimal Language  
  
    -   File extension: min  
  
    -   Company name: Fabrikam  
  
     For more information about creating a domain-specific language solution, see [Walkthrough: Creating a Domain-Specific Language Solution](../vs140/how-to--create-a-domain-specific-language-solution.md).  
  
2.  On the **Build** menu, click **Build Solution**.  
  
    > [!IMPORTANT]
    >  This step generates the directive processor and adds the key for it in the registry.  
  
3.  On the **Debug** menu, click **Start Debugging**.  
  
     A second instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] opens.  
  
4.  In the experimental build, in **Solution Explorer**, double-click the file **sample.min**.  
  
     The file opens in the designer. Notice that the model has two elements, ExampleElement1 and ExampleElement2, and a link between them.  
  
5.  Close the second instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
6.  Save the solution, and then close the Domain-Specific Language Designer.  
  
## Connecting a Custom Text Template Host to a Directive Processor  
 After you generate the directive processor, you connect the directive processor and the custom text template host that you created in [Walkthrough: Creating a Text Template Host](../vs140/walkthrough--creating-a-custom-text-template-host.md).  
  
#### To connect a custom text template host to the generated directive processor  
  
1.  Open the CustomHost solution.  
  
2.  On the **Project** menu, click **Add Reference**.  
  
     The **Add Reference** dialog box opens with the **.NET** tab displayed.  
  
3.  Add the following references:  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.11.0  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.Diagrams.11.0  
  
    -   Microsoft.VisualStudio.TextTemplating.11.0  
  
    -   Microsoft.VisualStudio.TextTemplating.Interfaces.11.0  
  
    -   Microsoft.VisualStudio.TextTemplating.Modeling.11.0  
  
    -   Microsoft.VisualStudio.TextTemplating.VSHost.11.0  
  
4.  At the top of Program.cs or Module1.vb, add the following line of code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Locate the code for the property <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and replace it with the following code:  
  
    > [!NOTE]
    >  In this step, you add references to the assemblies that are required by the generated directive processor that your host will support.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  Locate the code for the function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and replace it with the following code:  
  
    > [!IMPORTANT]
    >  This code contains hard-coded references to the name of the generated directive processor to which you want to connect. You could easily make this more general, in which case it looks for all directive processors listed in the registry and tries to find a match. In that case, the host would work with any generated directive processor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  On the **File** menu, click **Save All**.  
  
8.  On the **Build** menu, click **Build Solution**.  
  
## Testing the Custom Host with the Directive Processor  
 To test the custom text template host, first you must write a text template that calls the generated directive processor. Then you run the custom host, pass to it the name of the text template, and verify that the directive is processed correctly.  
  
#### To create a text template to test the custom host  
  
1.  Create a text file, and name it <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You can use any text editor, such as Notepad, to create the file.  
  
2.  Add the following to the text file:  
  
    > [!NOTE]
    >  The programming language of the text template does not need to match that of the custom host.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  In the code, replace \<YOUR PATH> with the path of the Sample.min file from the design-specific language you created in the first procedure.  
  
4.  Save and close the file.  
  
#### To test the custom host  
  
1.  Open a Command Prompt window.  
  
2.  Type the path of the executable file for the custom host, but do not press ENTER yet.  
  
     For example, type:  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  Instead of typing the address, you can browse to the file CustomHost.exe in **Windows Explorer**, and then drag the file into the Command Prompt window.  
  
3.  Type a space.  
  
4.  Type the path of the text template file, and then press ENTER.  
  
     For example, type:  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  Instead of typing the address, you can browse to the file TestTemplateWithDP.txt in **Windows Explorer**, and then drag the file into the Command Prompt window.  
  
     The custom host application runs and starts the text template transformation process.  
  
5.  In **Windows Explorer**, browse to the folder that contains the file TestTemplateWithDP.txt.  
  
     The folder also contains the file TestTemplateWithDP1.txt.  
  
6.  Open this file to see the results of the text template transformation.  
  
     The results of the generated text output appears and should look like this:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Walkthrough: Creating a Text Template Host](../vs140/walkthrough--creating-a-custom-text-template-host.md)