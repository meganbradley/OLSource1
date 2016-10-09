---
title: "How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "remote deployment [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, remote deployment"
  - "deploying [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, deploying"
ms.assetid: d9c67fae-d097-4e26-a2b9-0f72ff800987
caps.latest.revision: 14
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server
  In addition to deploying SharePoint solutions to the local system, you can publish sandboxed SharePoint solutions to remote sites or local SharePoint sites. The remote publishing process copies the .wsp file to the SharePoint server, installs the solution, and then enables you to activate the solution. You can also upgrade a remote SharePoint solution installation after changes are made to it.  
  
## To publish a sandboxed SharePoint solution to a remote SharePoint server  
  
1.  In **Solution Explorer**, open the shortcut menu for the sandboxed SharePoint project that you want to publish, and then choose **Publish**.  
  
2.  In the **Publish** dialog box, choose the **Publish to SharePoint Site** option button, and then enter a URL for an online publishing site, such as the following example: **https://mytestsite.sharepoint.microsoftonline.com**.  
  
3.  Choose the **Open the Solution Gallery page in the browser after publishing** option button to view the list of solutions in the **Solution Gallery** page after publishing.  
  
4.  Choose the **Publish** button.  
  
5.  Log on to the remote server if user authentication is required.  
  
     The publishing progress appears in the Visual Studio **Output** window. When the process is finished, the solution (.wsp) file is installed on the remote SharePoint server. However, it must still be activated before it can be used in SharePoint.  
  
6.  On the **Solution Gallery** page, select the SharePoint application and then on the ribbon, choose the **Activate** button.  
  
7.  In the **Activate Solution** dialog box, on the ribbon, choose the **Activate** button again.  
  
     The **Status** column on the **Solution Gallery** page indicates that the application is active.  
  
## To upgrade a sandboxed SharePoint solution on a remote SharePoint server  
 If a sandboxed SharePoint solution is already published on a remote server, the following process enables you to upgrade it after you make changes to the application in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
1.  Rename the SharePoint package in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)]. To do this, in **Solution Explorer** open the package. It appears in the **Package Explorer**.  
  
2.  In **Package Explorer**, in the **Name** box, change the package name to a unique name.  
  
3.  Save the project.  
  
4.  In **Solution Explorer**, open the shortcut menu for the project, and then choose **Publish**.  
  
5.  In the **Publish** dialog box, choose the **Publish to SharePoint Site** option button, and then, if the URL for the remote server where the solution is saved is missing, enter it.  
  
6.  Choose the **Open the Solution Gallery page in the browser after publishing** option button to view the list of solutions in the **Solution Gallery** page after publishing.  
  
7.  Choose the **Publish** button.  
  
8.  Log on to the remote server if user authentication is required.  
  
     If you logged in to the remote server recently, authentication may not be required.  
  
     If the older version of the application that has the same name still exists on the SharePoint server, you will get an error that a package with the same name already exists on the SharePoint server. You must rename the package to a unique name before publishing.  
  
9. Choose the new application in SharePoint, and then, on the ribbon, choose the **Upgrade** button.  
  
10. In the **Upgrade Solution** dialog box, on the ribbon, choose the **Upgrade** button again. The **Status** column on the **Solution Gallery** page should now indicate that the application is active.  
  
     The old version of the solution is deactivated, the new version of the solution is upgraded with data maintained from the old solution, and the new solution is activated in SharePoint.  
  
## See Also  
 [How to: Deploy and Publish a SharePoint Solution to a Local SharePoint Site](../VS_officedev/how-to--deploy-and-publish-a-sharepoint-solution-to-a-local-sharepoint-site.md)   
 [Creating SharePoint Solution Packages](../VS_officedev/creating-sharepoint-solution-packages.md)   
 [How to: Customize a SharePoint Solution Package](../VS_officedev/how-to--customize-a-sharepoint-solution-package.md)   
 [How to: Add and Remove Features and Items to a Package by Using the Package Designer](../VS_officedev/how-to--add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md)  
  
  