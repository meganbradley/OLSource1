---
title: Connect to a Microsoft Excel File (SSAS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 126f7d6b-d270-40e7-b23e-8d114f87065b
manager: mblythe
---
# Connect to a Microsoft Excel File (SSAS)
This page of the **Table Import Wizard** enables you to connect to a Microsoft Excel file stored on the local machine. To access the wizard from the [!INCLUDE[ssBIDevStudio](../../Topics/TopicNameContainA/includes/ssBIDevStudio_md.md)], on the **Model** menu, click **Import from Data Source**.  
  
 To connect to a Microsoft Excel file, you must have the appropriate ACE provider installed on your computer. For more information, see [Data Sources Supported (SSAS Tabular)](../../Topics/TopicNameNotContainA/Data-Sources-Supported--SSAS-Tabular-.md).  
  
> [!NOTE]  
>  The credentials of the current user are used when selecting a file in this page. However, import will not succeed if the user specified in the Impersonation Information page does not have sufficient privileges to read from the selected file.  
  
## UIElement List  
 **Friendly connection name**  
 Type a unique name for this data source connection. This is a required field.  
  
 **Excel File Path**  
 Specify a full path for the Excel file.  
  
 **Browse**  
 Navigate to a location where an Excel file is available.  
  
 **Advanced**  
 Set additional connection properties by using the **Set Advanced Properties** dialog box..  
  
 **Use first row as column headers**  
 Specify whether to use the first data row as the column headers of the destination table.  
  
 **Test Connection**  
 Attempt to establish a connection to the data source using the current settings. A message is displayed indicating whether the connection is successful.