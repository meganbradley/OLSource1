---
title: "Services Page, Project Designer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ProjectPropertiesServices"
helpviewer_keywords: 
  - "Services page in Project Designer"
  - "Project Designer, Services page"
ms.assetid: 6dd9e0fa-acba-4d7d-b081-705b0fc86ff5
caps.latest.revision: 30
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Services Page, Project Designer
Client application services provide simplified access to [!INCLUDE[ajax_current_short](../vs140/includes/ajax_current_short_md.md)] login, roles, and profile services from Windows Forms and Windows Presentation Foundation (WPF) applications. You can use the **Services** page of the **Project Designer** to enable and configure client application services for your project.  
  
 With client application services, you can use a centralized server to authenticate users, determine each user's assigned role or roles, and store per-user application settings that you can share across the network. For more information, see [Client Application Services](assetId:///1487d8df-089e-4f21-abfb-a791a652b58e).  
  
 To access the **Services** page, select a project node in **Solution Explorer**, and then click **Properties** on the **Project** menu. When the **Project Designer** appears, click the **Services** tab.  
  
> [!NOTE]
>  Client application services require the full version of the .NET Framework, and are not supported in the .NET Framework Client Profile. If the **Enable client application services** check box is disabled, verify that the **Target framework** is set to the .NET Framework 3.5 or later. To view the **Target framework** setting in C#, open the Project Designer and then click the **Application** page. To view the **Target framework** setting in Visual Basic, open the Project Designer, click the **Compile** page, and then click **Advanced Compile Options**.  
  
## Task List  
 [How to: Configure Client Application Services](assetId:///34a8688a-a32c-40d3-94be-c8e610c6a4e8)  
  
## UIElement List  
 **Configuration**  
 This control is not editable on this page. For a description of this control, see [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md) or [Build Page, Project Designer (C#)](../vs140/build-page--project-designer--csharp-.md).  
  
 **Platform**  
 This control is not editable on this page. For a description of this control, see [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md) or [Build Page, Project Designer (C#)](../vs140/build-page--project-designer--csharp-.md).  
  
 **Enable client application services**  
 Select to enable client application services. You must specify service locations on the **Services** page to use client application services.  
  
 **Use Windows authentication**  
 Indicates that the authentication provider will use Windows-based authentication, that is, the identity supplied by the Windows operating system.  
  
 **Use Forms authentication**  
 Indicates that the authentication provider will use forms authentication. This means that your application must provide a user interface for login. For more information, see [How to: Implement User Login and Logout with Client Application Services](assetId:///5431a671-eb02-4e18-a651-24764fccec9a).  
  
 **Authentication service location**  
 Used only with forms authentication. Specifies the location of the authentication service.  
  
 **Optional: Credentials provider**  
 Used only with forms authentication. Indicates the <xref:System.Web.ClientServices.Providers.IClientFormsAuthenticationCredentialsProvider*> implementation that the authentication service will use to display a login dialog box when your application calls the `static`[Membership.ValidateUser](assetId:///M:System.Web.Security.Membership.ValidateUser(System.String,System.String)?qualifyHint=True&autoUpgrade=True) method and passes empty strings or `null` for the parameters. If you leave this box blank, you must pass a valid user name and password to the assetId:///M:System.Web.Security.Membership.ValidateUser(System.String,System.String)?qualifyHint=True&autoUpgrade=True method. You must specify the credentials provider as an assembly-qualified type name. For more information, see <xref:System.Type.AssemblyQualifiedName*?displayProperty=fullName> and [Assembly Names](assetId:///8f8c2c90-f15d-400e-87e7-a757e4f04d0e). In its simplest form, an assembly-qualified type name looks similar to the following example: `MyNamespace.MyLoginClass, MyAssembly`  
  
 **Roles service location**  
 Specifies the location of the roles service.  
  
 **Web settings service location**  
 Specifies the location of the profile (Web settings) service.  
  
 **Advanced**  
 Opens the [Advanced Services Settings Dialog Box](../vs140/advanced-settings-for-services-dialog-box.md), which you can use to override default behavior. For example, you can use this dialog box to specify a database for offline storage instead of using the local file system. For more information, see [Advanced Services Settings Dialog Box](../vs140/advanced-settings-for-services-dialog-box.md).  
  
## See Also  
 [Client Application Services](assetId:///1487d8df-089e-4f21-abfb-a791a652b58e)   
 [Advanced Services Settings Dialog Box](../vs140/advanced-settings-for-services-dialog-box.md)   
 [How to: Configure Client Application Services](assetId:///34a8688a-a32c-40d3-94be-c8e610c6a4e8)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)   
 [Build Page, Project Designer (C#)](../vs140/build-page--project-designer--csharp-.md)   
 [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7)