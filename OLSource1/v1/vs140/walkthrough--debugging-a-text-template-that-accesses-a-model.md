---
title: "Walkthrough: Debugging a Text Template that Accesses a Model"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: af46a7fe-6b98-4d3d-b816-0bbf8e81e220
caps.latest.revision: 10
---
# Walkthrough: Debugging a Text Template that Accesses a Model
When you modify or add text templates in a domain-specific language solution, you may get errors when the engine transforms the template to source code or when it compiles the generated code. The following walkthrough demonstrates some of the things you can do to debug a text template.  
  
> [!NOTE]
>  For more information about text templates in general, see [Code Generation and Text Templates](../vs140/code-generation-and-t4-text-templates.md). For more information about debugging text templates, see [Walkthrough: Debugging a Text Template](assetId:///5c3fd3b7-c110-4e86-a22f-d5756be6b94f).  
  
## Creating a Domain-Specific Language Solution  
 In this procedure, you create a domain-specific language solution that has the following characteristics:  
  
-   Name: DebuggingTestLanguage  
  
-   Solution template: Minimal Language  
  
-   File extension: .ddd  
  
-   Company name: Fabrikam  
  
 For more information about creating a domain-specific language solution, see [Walkthrough: Creating a Domain-Specific Language Solution](../vs140/how-to--create-a-domain-specific-language-solution.md).  
  
## Creating a text template  
 Add a text template to your solution.  
  
#### To create a text template  
  
1.  Build the solution and start running it in the debugger. (On the **Build** menu, click **Rebuild Solution**, and then on the **Debug** menu, click **Start Debugging**.) A new instance of Visual Studio opens the Debugging project.  
  
2.  Add a text file named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the Debugging project.  
  
3.  Make sure that the **Custom Tool** property of DebugTest.tt is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Debugging directives that access a model from a text template  
 Before you can access a model from the statements and expressions in a text template, you must first call a generated directive processor. Calling the generated directive processor makes the classes in your model available to the text template code as properties. For more information, see [Accessing Models from Text Templates](../vs140/accessing-models-from-text-templates.md).  
  
 In the following procedures, you will debug an incorrect directive name and an incorrect property name.  
  
#### To debug an incorrect directive name  
  
1.  Replace the code in DebugTest.tt with the following code:  
  
    > [!NOTE]
    >  The code contains an error. You are introducing the error in order to debug it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  In **Solution Explorer**, right-click DebugTest.tt, and then click **Run Custom Tool**.  
  
     The **Error List** window displays this error:  
  
     **The processor named 'DebuggingTestLanguageDirectiveProcessor' does not support the directive named 'modelRoot'. The transformation will not be run.**  
  
     In this case, the directive call contains an incorrect directive name. You have specified <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the directive name, but the correct directive name is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
3.  Double-click the error in the **Error List** window to jump to the code.  
  
4.  To correct the code, change the directive name to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
     The change is highlighted.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  In **Solution Explorer**, right-click DebugTest.tt, and then click **Run Custom Tool**.  
  
     Now the system transforms the text template and generates the corresponding output file. You will not see any errors in the **Error List** window.  
  
#### To debug an incorrect property name  
  
1.  Replace the code in DebugTest.tt with the following code:  
  
    > [!NOTE]
    >  The code contains an error. You are introducing the error in order to debug it.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  In the **Solution Explorer**, right-click DebugTest.tt, and then click **Run Custom Tool**.  
  
     The **Error List** window appears and displays one of these errors:  
  
     (C#)  
  
     **Compiling transformation: Microsoft.VisualStudio.TextTemplating\<GUID>. GeneratedTextTransformation' does not contain a definition for 'ExampleModel'**  
  
     (Visual Basic)  
  
     **Compiling transformation: 'ExampleModel' is not a member of 'Microsoft.VisualStudio.TextTemplating\<GUID>.GeneratedTextTransformation'.**  
  
     In this case, the text template code contains an incorrect property name. You have specified <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as the property name, but the correct property name is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. You can find the correct property name in the provides parameter, as shown in the following code:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Double-click the error in the Error List window to jump to the code.  
  
4.  To correct the code, change the property name to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in the text template code.  
  
     The changes are highlighted.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
5.  In **Solution Explorer**, right-click DebugTest.tt, and then click **Run Custom Tool**.  
  
     Now the system transforms the text template and generates the corresponding output file. You will not see any errors in the **Error List** window.