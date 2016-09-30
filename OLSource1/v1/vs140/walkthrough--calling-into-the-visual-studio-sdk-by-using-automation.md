---
title: "Walkthrough: Calling into the Visual Studio SDK By Using Automation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "walkthroughs [Visual Studio SDK], calling with automation"
ms.assetid: ca4dab48-632c-4c2a-8c84-57c027e37987
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Calling into the Visual Studio SDK By Using Automation
This walkthrough illustrates how to create a Visual Studio add-in that consumes a Visual Studio service. The add-in you create gets a service provider and uses it to obtain a service. You can use this same technique to obtain any proffered Visual Studio service. For more information on services and service providers, see [Visual Studio Services](../vs140/using-and-providing-services.md). The procedures below demonstrate how to create an add-in and then obtain a service from the add-in.  
  
## Creating an Add-In  
 In this section, you create a Visual Studio add-in using the Visual Studio Add-In project template.  
  
#### To create an add-in  
  
1.  Create a new Visual Studio project (**File/New/Project**).  
  
2.  In the left pane of the **New Project** dialog box, expand the **Other Project Types** node and then click the **Extensibility** node. Select **Visual Studio Add-in**.  
  
3.  Create a new add-in project named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
     In the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Add-In wizard, click **Next**.  
  
4.  On the **Select a Programming Language**  page, select **Create an Add-In using Visual C#** or **Create an Add-In using Visual Basic**.  
  
5.  On the **Select an Application Host** page, select **Microsoft Visual Studio \<version>**.  
  
6.  On the **Enter a Name and Description** page, type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the **Name** box and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the **Description** box.  
  
7.  On the **Choose Add-In Options** page, select the option for a Tools menu item under **Would you like to create command bar UI for your Add-In?**. Clear the other check boxes.  
  
8.  Accept all other defaults.  
  
9. Build the solution and verify that it compiles without errors.  
  
## Obtaining a Service from an Add-In  
 The following steps guide you through acquiring a service from your add-in.  
  
#### To obtain a service  
  
1.  Open the file Connect.cs or Connect.vb and add these lines to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (C#) or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (Visual Basic) statements:  
  
     [!code[VSSDKAddin#1](../vs140/codesnippet/CSharp/walkthrough--calling-into-the-visual-studio-sdk-by-using-automation_1.cs)]
[!code[VSSDKAddin#1](../vs140/codesnippet/VisualBasic/walkthrough--calling-into-the-visual-studio-sdk-by-using-automation_1.vb)]  
  
2.  Right-click the project node in **Solution Explorer** and add these .NET references:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Add these lines of code to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method:  
  
     [!code[VSSDKAddin#2](../vs140/codesnippet/CSharp/walkthrough--calling-into-the-visual-studio-sdk-by-using-automation_2.cs)]
[!code[VSSDKAddin#2](../vs140/codesnippet/VisualBasic/walkthrough--calling-into-the-visual-studio-sdk-by-using-automation_2.vb)]  
  
     This code casts the current application object (type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) into an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, then calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to obtain the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell*> service. This service provides an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell*> interface. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowMessageBox*> method displays a message box when the add-in runs.  
  
4.  Build and start the Addin project in debug mode by pressing F5.  
  
     This starts another instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
5.  In the new [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] instance, on the **Tools** menu, click **Addin**. The message box displays this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [How to: Deactivate and Remove an Add-in](assetId:///5d9bc34f-ab3b-4477-950f-79fb820acb8c)