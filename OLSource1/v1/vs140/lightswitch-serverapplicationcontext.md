---
title: "LightSwitch ServerApplicationContext"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1130c822-8e92-4ca9-b062-a6f339dbe63a
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LightSwitch ServerApplicationContext
The `ServerApplicationContext` API allows you to call custom business logic on the LightSwitch **Server** tier. Unlike accessing LightSwitch as an OData data source, the `ServerApplicationContext` API lets you accomplish tasks such as:  
  
-   Start a workflow or process on the LightSwitch **Server** tier from a client application.  
  
-   Retrieve non-entity data from the LightSwitch **Server** tier.  
  
-   Upload a file to the **Server** tier from a client application and store it in a remote location  
  
-   Create a standalone user interface (for example, an .aspx page) that reads and writes LightSwitch data.  
  
 The `ServerApplicationContext` can be called from within your own web service endpoints. You can add any of the normal ASP.NET web assets to your **Server** project and create new ways of interacting with the LightSwitch server. For example, you could create an ASP.NET Web Form, a WCF Service, or a Web API endpoint. You decide the appropriate way you'd like to expose a new service, using the normal Visual Studio gestures for adding and working with those assets.  
  
## See Also  
 [Walkthrough: Inserting Data with the ServerApplicationContext](../vs140/walkthrough--inserting-data-with-the-serverapplicationcontext.md)   
 [ServerApplicationContext API Reference](../vs140/serverapplicationcontext-api-reference.md)   
 [LightSwitch as a Data Source](../vs140/lightswitch-as-a-data-source.md)