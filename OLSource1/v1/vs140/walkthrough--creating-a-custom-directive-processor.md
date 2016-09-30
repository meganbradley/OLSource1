---
title: "Walkthrough: Creating a Custom Directive Processor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, custom directive processors"
  - "walkthroughs [text templates], directive processor"
ms.assetid: b8f35a36-14e1-4467-8f5f-e01402af14d5
caps.latest.revision: 78
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Custom Directive Processor
*Directive processors* work by adding code to the *generated transformation class*. If you call a *directive* from a *text template*, the rest of the code that you write in your text template can rely on the functionality that the directive provides.  
  
 You can write your own custom directive processors. This enables you to customize your text templates. To create a custom directive processor, you create a class that inherits from either \<xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor*> or \<xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor*>.  
  
 Tasks that are illustrated in this walkthrough include the following:  
  
-   Creating a custom directive processor  
  
-   Registering the directive processor  
  
-   Testing the directive processor  
  
## Prerequisites  
 To complete this walkthrough, you will need:  
  
-   Visual Studio 2010  
  
-   Visual Studio 2010 SDK  
  
## Creating a Custom Directive Processor  
 In this walkthrough, you create a custom directive processor. You add a custom directive that reads an XML file, stores it in an \<xref:System.Xml.XmlDocument*> variable, and exposes it through a property. In the section "Testing the Directive Processor," you use this property in a text template to access the XML file.  
  
 The call to your custom directive looks like the following:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 The custom directive processor adds the variable and the property to the generated transformation class. The directive that you write uses the \<xref:System.CodeDom*> classes to create the code that the engine adds to the generated transformation class. The \<xref:System.CodeDom*> classes create code in either Visual C# or [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], depending on the language specified in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive. The language of the directive processor and the language of the text template that is accessing the directive processor do not have to match.  
  
 The code that the directive creates looks like the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### To create a custom directive processor  
  
1.  In Visual Studio, create a C# or a Visual Basic class library project named CustomDP.  
  
    > [!NOTE]
    >  If you want to install the directive processor on more than one computer, it is better to use a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension (VSIX) project and include a .pkgdef file in the extension. For more information, see [Deploying a Custom Directive Processor](../vs140/deploying-a-custom-directive-processor.md).  
  
2.  Add  references to these assemblies:  
  
    -   **Microsoft.VisualStudio.TextTemplating.\*.0**  
  
    -   **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0**  
  
3.  Replace the code in **Class1** with the following code. This code defines a CustomDirectiveProcessor class that inherits from the \<xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor*> class and implements the necessary methods.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  For [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] only, open the **Project** menu, and click **CustomDP Properties**. On the **Application** tab, in **Root namespace**, delete the default value, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
5.  On the **File** menu, click **Save All**.  
  
6.  On the **Build** menu, click **Build Solution**.  
  
### Build the Project  
 Build the project. On the **Build** menu, click **Build Solution**.  
  
## Registering the Directive Processor  
 Before you can call a directive from a text template in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you must add a registry key for the directive processor.  
  
> [!NOTE]
>  If you want to install the directive processor on more than one computer, it is better to define a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension (VSIX) that includes a .pkgdef file along with your assembly. For more information, see [Deploying a Custom Directive Processor](../vs140/deploying-a-custom-directive-processor.md).  
  
 Keys for directive processors exist in the registry in the following location:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For 64-bit systems, the registry location is:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In this section, you add a key for your custom directive processor to the registry in the same location.  
  
> [!CAUTION]
>  Incorrectly editing the registry can severely damage your system. Before you make changes to the registry, back up any valuable data that is on the computer.  
  
#### To add a registry key for the directive processor  
  
1.  Run the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> command by using the Start menu or the command line.  
  
2.  Browse to the location **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\\*.0\TextTemplating\DirectiveProcessors**, and click the node.  
  
     On 64-bit systems, use **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\\\*.0\TextTemplating\DirectiveProcessors**  
  
3.  Add a new key named CustomDirectiveProcessor.  
  
    > [!NOTE]
    >  This is the name that you will use in the Processor field of your custom directives. This name does not need to match the name of the directive, the name of the directive processor class, or the directive processor namespace.  
  
4.  Add a new string value named Class that has a value CustomDP.CustomDirectiveProcessor for the name of the new string.  
  
5.  Add a new string value named CodeBase that has a value equal to the path of the CustomDP.dll that you created earlier in this walkthrough.  
  
     For example, the path might look like <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
     Your registry key should have the following values:  
  
    |Name|Type|Data|  
    |----------|----------|----------|  
    |(Default)|REG_SZ|(value not set)|  
    |Class|REG_SZ|CustomDP.CustomDirectiveProcessor|  
    |CodeBase|REG_SZ|**\<Path to Your Solution>**CustomDP\bin\Debug\CustomDP.dll|  
  
     If you have put the assembly in the GAC, the values should look like the following:  
  
    |Name|Type|Data|  
    |----------|----------|----------|  
    |(Default)|REG_SZ|(value not set)|  
    |Class|REG_SZ|CustomDP.CustomDirectiveProcessor|  
    |Assembly|REG_SZ|CustomDP.dll|  
  
6.  Restart Visual Studio.  
  
## Testing the Directive Processor  
 To test the directive processor, you need to write a text template that calls it.  
  
 In this example, the text template calls the directive and passes in the name of an XML file that contains documentation for a class file. For more information, see [XML Documentation Comments](../vs140/xml-documentation-comments--csharp-programming-guide-.md).  
  
 The text template then uses the \<xref:System.Xml.XmlDocument*> property that the directive creates to navigate the XML and print the documentation comments.  
  
#### To create an XML file for use in testing the directive processor  
  
1.  Create a text file named <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> by using any text editor (for example, Notepad).  
  
    > [!NOTE]
    >  You can create this file in any location (for example, C:\Test\DocFile.xml).  
  
2.  Add the following to the text file:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Save and close the file.  
  
#### To create a text template to test the directive processor  
  
1.  In Visual Studio, create a C# or Visual Basic class library project named TemplateTest.  
  
2.  Add a new text template file named TestDP.tt.  
  
3.  Make sure that the **Custom Tool** property of TestDP.tt is set to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
4.  Change the content of  TestDP.tt to the following text.  
  
    > [!NOTE]
    >  Make sure to replace the string <<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with the path to the DocFile.xml file.  
  
     The language of the text template does not have to match the language of the directive processor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  In this example, the value of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The value of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter must match the name of the processor's registry key.  
  
5.  On the **File** menu, click **Save All**.  
  
#### To test the directive processor  
  
1.  In **Solution Explorer**, right-click TestDP.tt and then click **Run Custom Tool**.  
  
     For [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] users, TestDP.txt might not appear in **Solution Explorer** by default. To display all files assigned to the project, open the **Project** menu and click **Show All Files**.  
  
2.  In **Solution Explorer**, expand the TestDP.txt node, and then double-click TestDP.txt to open it in the editor.  
  
     The generated text output appears. The output should look like the following:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Adding HTML to Generated Text  
 After you test your custom directive processor, you might want to add some HTML to your generated text.  
  
#### To add HTML to the generated text  
  
1.  Replace the code in TestDP.tt with the following. The HTML is highlighted. Make sure to replace the string <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> with the path to the DocFile.xml file.  
  
    > [!NOTE]
    >  Additional open \<# and close #> tags separate the statement code from the HTML tags.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
2.  On the **File** menu, click **Save TestDP.txt**.  
  
3.  To view the output in a browser, in **Solution Explorer**, right-click TestDP.htm, and click **View In Browser**.  
  
     Your output should be the same as the original text except it should have the HTML format applied. Each item name should appear in bold.