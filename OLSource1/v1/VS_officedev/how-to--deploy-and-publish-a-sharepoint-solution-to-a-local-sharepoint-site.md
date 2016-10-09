---
title: "How to: Deploy and Publish a SharePoint Solution to a Local SharePoint Site"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "deploying [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, deploying"
ms.assetid: 73f8d6a9-4c64-4bba-ae0e-9474baf8df26
caps.latest.revision: 18
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
# How to: Deploy and Publish a SharePoint Solution to a Local SharePoint Site
  You can deploy or publish SharePoint solutions to a local SharePoint server on your development computer. The deployment process copies the .wsp file to the SharePoint server, installs the solution, and then activates the features. The publishing process only copies the .wsp file to the SharePoint server and installs it. You must manually activate it to enable it in SharePoint.  
  
## To deploy a SharePoint solution to the local SharePoint server  
  
1.  In **Solution Explorer**, choose the project that you want to deploy.  
  
2.  On the menu bar, choose **Build**, **Deploy Solution**.  
  
     The .wsp file is created and installed on the local SharePoint server. Also, the features are activated.  
  
## To publish a SharePoint solution to a local SharePoint server  
  
1.  In **Solution Explorer**, open the shortcut menu for the SharePoint project that you want to publish and then choose **Publish**.  
  
2.  In the **Publish** dialog box, choose the **Publish to File System** option button.  
  
3.  In the **Target Location** text box, enter a local path, and then choose the **Publish** button.  
  
     The publishing progress appears in the Visual Studio **Output** window. When the process is finished, the solution (.wsp) file is installed on the local SharePoint server. However, it must still be activated to be used in SharePoint. If the solution file already exists, an error occurs and asks whether you want to overwrite the existing file. For information on upgrading the package, see the section on upgrading remote packages in [How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server](../VS_officedev/how-to--deploy--publish--and-upgrade-sharepoint-solutions-on-a-remote-server.md).  
  
## See Also  
 [How to: Deploy, Publish, and Upgrade SharePoint Solutions on a Remote Server](../VS_officedev/how-to--deploy--publish--and-upgrade-sharepoint-solutions-on-a-remote-server.md)   
 [Creating SharePoint Solution Packages](../VS_officedev/creating-sharepoint-solution-packages.md)   
 [How to: Customize a SharePoint Solution Package](../VS_officedev/how-to--customize-a-sharepoint-solution-package.md)   
 [How to: Add and Remove Features and Items to a Package by Using the Package Designer](../VS_officedev/how-to--add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md)  
  
  