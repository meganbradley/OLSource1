---
title: "DataReader Destination"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 56fcc4bf-c901-42c3-a71d-110039293431
caps.latest.revision: 31
manager: jhubbard
---
# DataReader Destination
The DataReader destination exposes the data in a data flow by using the ADO.NET **DataReader** interface. The data can then be consumed by other applications. For example, you can configure the data source of a [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report to use the result of running a [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package. To do this, you create a data flow that implements the DataReader destination.  
  
 For information about accessing and reading values in the DataReader destination programmatically, see [Loading the Output of a Package](assetId:///aba8ecb7-0dcf-40d0-a2a8-64da0da94b93).  
  
## Configuration of the DataReader Destination  
 You can specify a time-out value for the DataReader destination and indicate whether the destination should fail if a time-out occurs. A time-out occurs if the application does not ask for data within the specified time.  
  
 The DataReader destination has one input. It does not support an error output.  
  
 You can set properties through [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer or programmatically.  
  
 For more information about the properties that you can set in the **Advanced Editor** dialog box or programmatically, click one of the following topics:  
  
-   [Common Properties](../../Topics/TopicNameNotContainA/Common-Properties.md)  
  
-   [DataReader Destination Custom Properties](../../Topics/TopicNameNotContainA/DataReader-Destination-Custom-Properties.md)  
  
 For more information about how to set properties, see [Set the Properties of a Data Flow Component](../../Topics/TopicNameContainA/Set-the-Properties-of-a-Data-Flow-Component.md).