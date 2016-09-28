---
title: "How to: Deploy Content and Resource Items"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "resources [Visual Studio LightSwitch]"
  - "content items [Visual Studio LightSwitch]"
ms.assetid: 97f2dc49-9bb1-4810-b4f7-9bb6acdbbfbf
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Deploy Content and Resource Items
Content and resource items in a LightSwitch project are not deployed with the application by default. You can deploy these items by changing some properties for the file.  
  
> [!NOTE]
>  Content and resource items should only be deployed for desktop clients. Web clients cannot access external resources.  
  
### To add content or resource items  
  
1.  In Solution Explorer, open the context menu for the  **DesktopClient** node and choose **Add Existing Item**.  
  
2.  In the **Add Existing Item – DesktopClient** dialog box, locate the content or resource that you wish to add, and then choose the **Add** button.  
  
     The file is added beneath the **Client** node.  
  
### To deploy content or resource items  
  
1.  In Solution Explorer, expand the **DesktopClient** node and choose the file that you wish to deploy.  
  
2.  In the **Properties** window, choose the **Build Action** property drop-down list and choose **Content**.  
  
3.  Select the **Copy to Output Directory** property drop-down list and choose **Copy Always**.  
  
     The file will be deployed with your application.  
  
## See Also  
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)