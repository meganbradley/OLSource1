---
title: "Retrieve Data from a Data Mining Model (DMX) (SSRS)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d9cd3624-1594-4707-8887-55437dd7e07c
caps.latest.revision: 19
manager: mblythe
---
# Retrieve Data from a Data Mining Model (DMX) (SSRS)
To use data from a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data mining model in your report, you must define a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source and one or more report datasets. When you create the data source definition, you must specify a connection string and credentials so that you can access the data source from your client computer.  
  
 You can create an embedded data source definition for use by a single report or a shared data source definition that can be used by multiple reports. The procedures in this topic describe how to create an embedded data source. For more information about shared data sources, see [Embedded and Shared Data Connections or Data Sources (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Embedded-and-Shared-Data-Connections-or-Data-Sources--Report-Builder-and-SSRS-.md) and [Create, Modify, and Delete Shared Data Sources (SSRS)](../../Topics/TopicNameNotContainA/Create--Modify--and-Delete-Shared-Data-Sources--SSRS-.md).  
  
 After you create a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source, you can create one or more datasets. For each dataset, you use a Data Mining Prediction Expression (DMX) query designer to create a DMX query that specifies the field collection. For more information, see [Analysis Services DMX Query Designer User Interface](../../Topics/TopicNameNotContainA/Analysis-Services-DMX-Query-Designer-User-Interface.md).  
  
 After you create a dataset, the name of the dataset appears in the Report Data pane as a node under its data source.  
  
 After you publish your report, you may need to change the credentials for the data source so that when the report runs on the report server, the permissions to retrieve the data are valid.  
  
### To create an embedded Microsoft SQL Server Analysis Services data source  
  
1.  On the toolbar in the Report Data pane, click **New**, and then click **Data Source**.  
  
2.  In the **Data Source Properties** dialog box, type a name in the **Name** text box, or accept the default name.  
  
3.  Verify that **Embedded connection** is selected.  
  
4.  From the **Type** drop-down list, select **Microsoft SQL Server Analysis Services**.  
  
5.  Specify a connection string that works with your [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source.  
  
     Contact your database administrator for connection information and for the credentials to use to connect to the data source. The following connection string example specifies the sample [!INCLUDE[ssSampleDBDWobject](../../Topics/TopicNameContainA/includes/ssSampleDBDWobject_md.md)] database on the local client.  
  
    ```  
    Data Source=localhost;Initial Catalog=AdventureWorksDW2012  
    ```  
  
6.  Click **Credentials**.  
  
     Set the credentials to use to connect to the data source. For more information, see [Specify Credential and Connection Information for Report Data Sources](../../Topics/TopicNameNotContainA/Specify-Credential-and-Connection-Information-for-Report-Data-Sources.md).  
  
    > [!NOTE]  
    >  To test the data source connection, click **Edit**. In the **Connection Properties** dialog box, click **Test Connection**. If the test is successful, you will see the information message "Test connection succeeded." If the test fails, you will see a warning message with more information about why the test was not successful.  
  
7.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
     The data source appears in the Report Data pane.  
  
### To create a dataset for a Microsoft SQL Server Analysis Services  
  
1.  In the **Report Data** pane, right-click the name of the data source that connects to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source, and then click **Add Dataset**.  
  
2.  In the **Dataset Properties** dialog box, type a name in the **Name** text box.  
  
3.  In the **Data source box**, verify that the name is the name of a data source that connects to an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source.  
  
4.  Click **Query Designer** to open the graphical query designer to build a query interactively. If the query designer opens in MDX mode, click **Command Type DMX** (![Change to DMX query language view](../../Topics/TopicNameContainA/media/rsQDIcon_CommandTypeDMX.gif "rsQDIcon_CommandTypeDMX")) on the toolbar to switch to the data mining query designer. For more information, see [Analysis Services DMX Query Designer User Interface](../../Topics/TopicNameNotContainA/Analysis-Services-DMX-Query-Designer-User-Interface.md).  
  
     Alternatively, to import an existing DMX query from another report, click **Import**, and then navigate to the .rdl file with the DMX query. Importing a query from an .dmx file is not supported.  
  
5.  After you create and run your query to see sample results, click **OK**.  
  
6.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
     The dataset and its field collection appear in the Report Data pane under the data source node.  
  
## See Also  
 [Analysis Services Connection Type for DMX (SSRS)](../../Topics/TopicNameNotContainA/Analysis-Services-Connection-Type-for-DMX--SSRS-.md)   
 [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md)   
 [Dataset Fields Collection (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection--Report-Builder-and-SSRS-.md)   
 [Report Embedded Datasets and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Embedded-Datasets-and-Shared-Datasets--Report-Builder-and-SSRS-.md)