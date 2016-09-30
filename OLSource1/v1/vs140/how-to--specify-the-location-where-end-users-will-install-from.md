---
title: "How to: Specify the Location Where End Users Will Install From"
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
  - "deploying applications [ClickOnce], specifying an installation URL"
  - "URLs, specifying an installation URL"
  - "installation, specifying installation an URL"
  - "Installation URL property"
ms.assetid: 04a804bf-ed55-4a7a-a1e6-f63ed99c0276
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify the Location Where End Users Will Install From
When publishing a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application, the location where users go to download and install the application is not necessarily the location where you initially publish the application. For example, in some organizations a developer might publish an application to a staging server, and then an administrator would move the application to a Web server.  
  
 In this case, you can use the `Installation URL` property to specify the Web server where users will go to download the application. This is necessary so that the application manifest knows where to look for updates.  
  
 The `Installation URL` property can be set on the **Publish** page of the **Project Designer**.  
  
 **Note** The `Installation URL` property can also be set using the **PublishWizard**. For more information, see [How to: Publish a ClickOnce Application](../vs140/how-to--publish-a-clickonce-application-using-the-publish-wizard.md).  
  
### To specify an Installation URL  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In the Installation URL field, enter the installation location using a fully qualified URL using the format http://www.microsoft.com/ApplicationName, or a UNC path using the format \\\Server\ApplicationName.  
  
## See Also  
 [How to: Specify a Publishing Location](../vs140/how-to--specify-where-visual-studio-copies-the-files.md)   
 [Publishing ClickOnce Applications](../vs140/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application](../vs140/how-to--publish-a-clickonce-application-using-the-publish-wizard.md)