---
title: "Convert Data Sources (Report Builder and SSRS)"
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
ms.assetid: 0e099c7e-8c03-43eb-9ea3-76e52d9ebbe3
caps.latest.revision: 17
manager: mblythe
---
# Convert Data Sources (Report Builder and SSRS)
Each data source in the Report Data pane is embedded and specific to the report or is shared. In Report Builder, a shared data source points to a published shared data source on a report server or SharePoint site. In Report Designer, a shared data source points to a shared data source in the **Shared Data Sources** folder in Solution Explorer.  
  
 For more information about the differences between embedded and shared data sources, see [Embedded and Shared Data Connections or Data Sources (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Embedded-and-Shared-Data-Connections-or-Data-Sources--Report-Builder-and-SSRS-.md).  
  
 For more information on how to create a shared data source, see [Create an Embedded or Shared Data Source (SSRS)](../../Topics/TopicNameNotContainA/Create-an-Embedded-or-Shared-Data-Source--SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Report Designer  
  
#### To convert a data source from embedded to shared  
  
-   In the Report Data pane, right-click the data source, and then click **Convert to Shared Data Source**.  
  
    > [!NOTE]  
    >  If the Report Data pane is not visible, on the **View** menu, click **Report Data**. If the pane opens as a floating window, you can dock it. For more information, see [Dock the Report Data Pane in Report Designer (SSRS)](../../Topics/TopicNameNotContainA/Dock-the-Report-Data-Pane-in-Report-Designer--SSRS-.md).  
  
     In the Report Data pane, the data source icon changes to the shared data source icon. In Solution Explorer, a shared data source with the same name appears under the **Shared Data Source** folder.  
  
### To convert a data source from shared to embedded  
  
-   In the Report Data pane, right-click the data source, open the **Data Source Properties** dialog box, and then click **Embedded Connection**. Enter the required information.  
  
     In the Report Data pane, the data source icon changes to the shared data source icon.  
  
## Report Builder  
  
#### To convert a data source from embedded to shared  
  
-   In the Report Data pane, right-click the data source to open the **Data Source Properties** dialog box, and then click **Embedded Connection**. Enter the required information.  
  
     In the Report Data pane, the data source icon changes to the shared data source icon.  
  
#### To convert a data source from shared to embedded  
  
-   In the Report Data pane, right-click the data source, open the **Data Source Properties** dialog box, and then click **Embedded Connection**. Enter the required information.  
  
     In the Report Data pane, the data source icon changes to the shared data source icon.  
  
## See Also  
 [Manage Report Data Sources](../../Topics/TopicNameNotContainA/Manage-Report-Data-Sources.md)   
 [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md)