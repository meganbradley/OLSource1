---
title: Add and Verify a Data Connection (Report Builder and SSRS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1d3b2573-e29d-480d-9dde-d26379c86618
manager: mblythe
---
# Add and Verify a Data Connection (Report Builder and SSRS)
In Report Builder, you can add a shared data source from the report server or create an embedded data source for your report. In Report Designer, you can create a shared data source or an embedded data source and deploy it to a report server.  
  
 To add a shared data source to your report, browse to a report server and select a shared data source. The shared data source in your report points to the shared data source definition on the report server.  
  
 To create an embedded data source, you must have connection information to the external source of data and you must know which permissions you need to access the data. This information usually comes from the owner of the data source. You can test the connection to verify that the credentials that are specified are sufficient.  
  
 For more information, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md) and [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To create a connection to a shared data source in Report Builder  
  
1.  On the toolbar in the Report Data pane, click **New,** and then click **Data Source**. The **Data Source Properties** dialog box opens.  
  
2.  In the **Name** text box, type a name for the data source.  
  
    > [!NOTE]  
    >  This name is saved in the local report definition. This name is not the name of the shared data source on the report server.  
  
3.  Select **Use a shared connection or report model**. The list of recently used shared data sources and report models appears. To select one from a report server, click **Browse** and browse to the folder on the report server where shared data sources are available.  
  
4.  Select the shared data source and then click **Open**.  
  
5.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
 The data source appears in the Report Data pane.  
  
### To verify a data connection  
  
1.  On the toolbar in the Report Data pane, double-click the data source. The **Data Source Properties** dialog box opens.  
  
2.  Click **Test Connection**.  
  
3.  If the connection is successful, the following message appears: "Connection created successfully". [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
4.  If the connection is not successful, the following message appears: "Unable to connect to the data source."  
  
5.  Click **Details**, and use the information to correct the issue.  
  
     For more information, see [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md).  
  
6.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)   
 [Report Embedded Datasets and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Embedded-Datasets-and-Shared-Datasets--Report-Builder-and-SSRS-.md)   
 [Finding, Viewing, and Managing Reports (Report Builder and SSRS )](../../Topics/TopicNameNotContainA/Finding--Viewing--and-Managing-Reports--Report-Builder-and-SSRS--.md)   
 [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md)