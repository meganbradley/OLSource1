---
title: "How to: Enable SharePoint Social Feeds in a LightSwitch App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8c244cc5-4de8-46c2-b951-864ad105b7d8
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Enable SharePoint Social Feeds in a LightSwitch App
You can provide a social collaboration experience for a SharePoint list by incorporating a social feed into a LightSwitch app for SharePoint or a cloud business app. When a user creates or changes an item in a list, a post is automatically added to the feed. Users can like and add comments to any post, and they can follow a social feed for any app.  
  
 When you deploy an app with a social feed to SharePoint, the app web for that app includes a SharePoint Newsfeed. Users can choose the **Newsfeed** tab to view and interact with posts for any item in the app. If you disable the social feed and redeploy the app, any existing threads in the newsfeed are preserved.  
  
> [!NOTE]
>  For LightSwitch apps for SharePoint that contain a Silverlight client, the SharePoint Newsfeed is disabled by default. You can create a social feed by using the SharePoint object model. See [Work with social feeds in SharePoint 2013](http://msdn.microsoft.com/library/sharepoint/jj163237.aspx).  
  
### To enable a social feed  
  
1.  In the entity designer, on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Properties** window, choose the **Social** section, and then select the **Post when Created** check box, the **Post when Updated** check box, or both.  
  
     If you select the **Post when Updated** check box, a **Choose post triggers** link appears in the **Properties** window.  
  
### To update a social feed based on data updates  
  
1.  In the **Properties** window, choose the **Choose post triggers** link.  
  
2.  In the **Choose post triggers** dialog box, select the check boxes for the fields that you want to monitor, and then choose the **OK** button.  
  
     A separate post is created when data changes in any field that you've specified.  
  
## See Also  
 [LightSwitch Apps for SharePoint](../vs140/lightswitch-apps-for-sharepoint.md)