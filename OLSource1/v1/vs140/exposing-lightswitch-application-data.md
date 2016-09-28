---
title: "Exposing LightSwitch Application Data"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3dea99d7-1c77-4eae-9f72-390b5eb81ce7
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exposing LightSwitch Application Data
You can expose data from a published [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] web application as an Open Data (OData) feed for use by other applications. Any application that supports the standard OData protocol can consume the data from both the intrinsic database and also any attached data source. For example, you might want to view [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application data on a mobile device or in an Excel PivotTable report. For more information about OData, see [OData by Example](http://go.microsoft.com/fwlink/?LinkId=234926).  
  
## LightSwitch Services  
 Application data is exposed as an OData service (.svc) with a separate endpoint for each data source in a published [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application. For example, an application that has two data sources, which are named Publishers and Retailers, would expose the following endpoints:  
  
```  
http://www.contoso.com/Publishers.svc  
http://www.contoso.com/Retailers.svc  
```  
  
 The services are backed by the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] query and update pipelines, so that you can produce customized services for others to consume. All business logic and security implemented in the application remains in effect for anyone who consumes the data. For example, a user who isn’t authorized to view certain information in the application won’t be able to access it through a service. Any updates to the data from an external client are also subject to the validation and concurrency rules that are defined in the application.  
  
 Metadata for the OData service is published on the endpoint and is specific to that data source. Metadata for virtual relationships that are defined outside the data source and metadata for business types aren't exposed.  
  
 Authentication for data that's exposed through an OData service is closely aligned to the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] authentication model, which provides secure access. The following table shows the authorization mapping:  
  
|LightSwitch Authentication Type|OData Authentication Type|  
|-------------------------------------|-------------------------------|  
|None|None|  
|Windows|Windows|  
|Forms|Http Basic|  
  
 Any concurrency or validation errors that occur on a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] service are communicated back to a client as a standard concurrency or validation error. For a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application that consumes a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] service, additional information about the entity and conflicting properties will also be included.  
  
## See Also  
 [Walkthrough: Exposing and Consuming an OData Service in LightSwitch](../vs140/walkthrough--exposing-and-consuming-an-odata-service-in-lightswitch.md)   
 [How to: Connect to Data](../vs140/how-to--connect-to-data.md)   
 [OData by Example](http://go.microsoft.com/fwlink/?LinkId=234926)