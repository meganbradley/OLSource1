---
title: "How to: Publish a Project That Has a Specific Locale"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "publishing, localized projects"
  - "locales, publishing for"
  - "deploying applications [ClickOnce], localized projects"
  - "locales, deploying for"
  - "publishing localized projects"
  - "macros, deploying with"
  - "macros, publishing with"
ms.assetid: 7c4cd83a-f985-4c85-9022-fadb5dbd2b39
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Publish a Project That Has a Specific Locale
It is not uncommon for an application to contain components that have different locales. In this scenario, you would create a solution that has several projects, and then publish separate projects for each locale. This procedure shows how to use a macro to publish the first project in a solution by using the 'en' locale. If you want to try this procedure with a locale other than 'en', make sure to set <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the macro to match the locale that you are using (for example, 'de' or 'de-DE').  
  
> [!NOTE]
>  When you use this macro, the Publish Location should be a valid URL or Universal Naming Convention (UNC) share. Also, Internet Information Services (IIS) has to be installed on your computer. To install IIS, on the **Start** menu, click **Control Panel**. Double-click **Add or Remove Programs**. In **Add or Remove Programs**, click **Add/Remove Windows Components**. In the **Windows Components Wizard**, select the **Internet Information Services (IIS)** check box in the **Components** list. Then click **Finish** to close the wizard.  
  
### To create the publishing macro  
  
1.  To open the Macro Explorer, on the **Tools** menu, point to **Macros**, and then click **Macro Explorer**.  
  
2.  Create a new macro module. In the Macro Explorer, select **MyMacros**. On the **Tools** menu, point to **Macros**, and then click **New Macro Module**. Name the module **PublishSpecificCulture**.  
  
3.  In the Macro Explorer, expand the **MyMacros** node, and then open the **PublishAllProjects** module by double-clicking it (or, from the **Tools** menu, point to **Macros**, and then click **Macros IDE**).  
  
4.  In the Macros IDE, add the following code to the module, after the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  Close the Macros IDE. The focus will return to Visual Studio.  
  
### To publish a project for a specific locale  
  
1.  To create a Visual Basic Windows Application project, on the **File** menu, point to **New**, and then click **Project**.  
  
2.  In the **New Project** dialog box, select **Windows Application** from the **Visual Basic** node. Name the project **PublishLocales**.  
  
3.  Click Form1. In the **Properties** window, under **Design**, change the **Language** property from **(Default)** to **English**. Change the **Text** property of the form to **MyForm**.  
  
     Note that the localized resource DLLs are not created until they are needed. For example, they are created when you change the text of the form or one of its controls after you have specified the new locale.  
  
4.  Publish PublishLocales by using the Visual Studio IDE.  
  
     In **Solution Explorer**, select PublishLocales. On the **Project** menu, select **Properties**. In the Project Designer, on the **Publish** page, specify a publishing location of **http://localhost/PublishLocales**, and then click **Publish Now**.  
  
     When the publish Web page appears, close it. (For this step, you only have to publish the project; you do not have to install it.)  
  
5.  Publish PublishLocales again by invoking the macro in the Visual Studio Command Prompt window. To view the Command Prompt window, on the **View** menu, point to **Other Windows** and then click **Command Window**, or press CTRL+ALT+A. In the Command Prompt window, type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; auto-complete will provide a list of available macros. Select the following macro and press ENTER:  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
6.  When the publish process succeeds, it will generate a message that says "Publish succeeded for PublishLocales\PublishLocales.vbproj. Publish language was 'en'." Click **OK** in the message box. When the publish Web page appears, click **Install**.  
  
7.  Look in C:\Inetpub\wwwroot\PublishLocales\en. You should see the installed files such as the manifests, setup.exe, and the publish Web page file, in addition to the localized resource DLL. (By default ClickOnce appends a .deploy extension on EXEs and DLLs; you can remove this extension after deployment.)  
  
## See Also  
 [Publishing ClickOnce Applications](../vs140/publishing-clickonce-applications.md)   
 [Macros Development Environment](assetId:///d23105d8-34fe-4ad9-8278-fae2c660aeac)   
 [Macro Explorer Window](assetId:///762169e6-f83f-44b4-bffa-d0f107cae9a3)   
 [How to: Edit and Programmatically Create Macros](assetId:///6716f820-1feb-48ad-a718-27eb6b473c5a)