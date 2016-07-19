---
title: Add, Change, or Delete a Report Parameter (Report Builder and SSRS)
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
ms.assetid: d44a8e0a-10cf-4502-9391-09743ffc9bad
manager: mblythe
---
# Add, Change, or Delete a Report Parameter (Report Builder and SSRS)
A report parameter provides a way to choose report data, connect related reports together, and vary the report presentation. You can provide a default value and a list of available values, and the user can change the selection.  
  
 After you publish a report, you can change the default values, the available values, and other properties for a report parameter on the report server. You can provide multiple sets of default parameter values by creating linked reports. For more information, see [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md).  
  
 This article is about adding report parameters to a paginated report in [!INCLUDE[ssRBnoversion](../../Topics/TopicNameContainA/includes/ssRBnoversion_md.md)] or Report Designer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)]. You can also add report parameters to mobile reports in  [!INCLUDE[SS_MobileReptPub_Long](../../Topics/TopicNameContainA/includes/SS_MobileReptPub_Long_md.md)]. See [Create mobile reports with SQL Server Mobile Report Publisher](../../Topics/TopicNameNotContainA/Create-mobile-reports-with-SQL-Server-Mobile-Report-Publisher.md) for more information.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To add or edit a report parameter  
  
1.  In [!INCLUDE[ssRBnoversion](../../Topics/TopicNameContainA/includes/ssRBnoversion_md.md)] or Report Designer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], in the **Report Data** pane, right-click the **Parameters** node and click **Add Parameter**. The **Report Parameter Properties** dialog box opens.  
  
2.  In **Name**, type the name of the parameter or accept the default name.  
  
3.  In **Prompt**, type the text that appears next to the parameter text box when the user runs the report.  
  
4.  In **Data type**, select the data type for the parameter value.  
  
5.  If the parameter can contain a blank value, select **Allow blank value**.  
  
6.  If the parameter can contain a null value, select **Allow null value**.  
  
7.  To allow a user to select more than one value for the parameter, select **Allow multiple values**.  
  
8.  Set the visibility option.  
  
    -   To show the parameter on the toolbar at the top of the report, select **Visible**.  
  
    -   To hide the parameter so that it does not display on the toolbar, select **Hidden**.  
  
    -   To hide the parameter and protect it from being modified on the report server after the report is published, select **Internal**. The report parameter can then only be viewed in the report definition. For this option, you must set a default value or allow the parameter to accept a null value.  
  
9. [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
### To delete a report parameter  
  
1.  In the **Report Data** pane, expand the **Parameters** node.  
  
2.  Right-click the report parameter and click **Delete**.  
  
## See Also  
 [Add, Change, or Delete Available Values for a Report Parameter (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add--Change--or-Delete-Available-Values-for-a-Report-Parameter--Report-Builder-and-SSRS-.md)   
 [Add, Change, or Delete Default Values for a Report Parameter (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add--Change--or-Delete-Default-Values-for-a-Report-Parameter--Report-Builder-and-SSRS-.md)   
 [Change the Order of a Report Parameter (Report Builder and SSRS)](../../Topics/TopicNameContainA/Change-the-Order-of-a-Report-Parameter--Report-Builder-and-SSRS-.md)   
 [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md)   
 [Add Cascading Parameters to a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-Cascading-Parameters-to-a-Report--Report-Builder-and-SSRS-.md)   
 [Tutorial: Adding a Parameter to Your Report (Report Builder)](assetId:///eab34ec4-b3ad-4a76-95cc-07b2f75ee6d7)   
 [Add Dataset Filters, Data Region Filters, and Group Filters (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-Dataset-Filters--Data-Region-Filters--and-Group-Filters--Report-Builder-and-SSRS-.md)   
 [Parameters Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Parameters-Collection-References--Report-Builder-and-SSRS-.md)   
 [Add a multi-value parameter to a Report](../../Topics/TopicNameContainA/Add-a-multi-value-parameter-to-a-Report.md)