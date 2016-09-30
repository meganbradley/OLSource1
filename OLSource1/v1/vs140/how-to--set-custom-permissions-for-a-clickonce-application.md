---
title: "How to: Set Custom Permissions for a ClickOnce Application"
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
  - "ClickOnce applications, permissions"
  - "permissions, ClickOnce applications"
ms.assetid: 660459ca-ef73-44a8-b323-610001f63b93
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Set Custom Permissions for a ClickOnce Application
You can deploy a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application that uses default permissions for the Internet or Local Intranet zones. Alternatively, you can create a custom zone for the specific permissions that the application needs. You can do this by customizing the security permissions on the **Security** page of the **Project Designer**.  
  
### To customize a permission  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Security** tab.  
  
3.  Select the **Enable ClickOnce Security Settings** check box.  
  
4.  Select the **This is a partial trust application** option button.  
  
     The controls in the **ClickOnce security permissions** section are enabled.  
  
5.  From the **Zone your application will be installed from** drop-down list, click **(Custom)**.  
  
6.  Click **Edit Permissions XML**.  
  
     The app.manifest file opens in the XML Editor.  
  
7.  Before the `</applicationRequestMinimum>` element, add XML code for permissions that your application requires.  
  
    > [!NOTE]
    >  You can use the `ToXml` method of a permission set to generate the XML code for the application manifest. For example, to generate the XML for the \<xref:System.Security.Permissions.EnvironmentPermission*> permission set, call the \<xref:System.Security.Permissions.EnvironmentPermission.ToXml*> method. For more information about the structure of the permission set XML, see [NIB: How to: Import a Permission Set by Using an XML File](assetId:///dea16b54-c108-408a-ac36-cdc05f746236).  
  
## See Also  
 [ClickOnce Security](../vs140/securing-clickonce-applications.md)   
 [Code Access Security for ClickOnce Applications](../vs140/code-access-security-for-clickonce-applications.md)   
 [ClickOnce Deployment and Security](../vs140/securing-clickonce-applications.md)