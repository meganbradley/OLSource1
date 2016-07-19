---
title: Change the Order of a Report Parameter (Report Builder and SSRS)
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
ms.assetid: abd61e19-dba3-423c-a26c-e8bc43197d3f
manager: mblythe
---
# Change the Order of a Report Parameter (Report Builder and SSRS)
Change the order of report parameters when you have a dependent parameter that is listed before the parameter it is dependent on. Parameter order is important when you have cascading parameters, or when you want to show users the default value for one parameter before they choose values for other parameters. A dependent report parameter contains a reference, in either its default values query or valid values query, to a query parameter that points to a report parameter that is after it in the parameter list in the **Report Data** pane.  
  
 The order that you see parameters display on the report viewer toolbar when you run the report, is determined by the order of the parameters in the **Report Data** pane and the location of the parameters in the custom parameters pane. For more information, see [Customize the Parameters Pane in a Report (Report Builder)](../../Topics/TopicNameContainA/Customize-the-Parameters-Pane-in-a-Report--Report-Builder-.md)  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To change the order of report parameters do one of the following  
  
-   Click a parameter in the **Report Data** pane, and use the up and down arrow buttons to move the parameter higher or lower in the list, as shown in the following image.  When you change the order of the parameter in the **Report Data** pane, the location of the parameter in the parameters pane is changed.  
  
     ![Change the order of the parameters in the Report Data pane](../../Topics/TopicNameContainA/media/ssrs_ChangeOrderofParameters_ReportData.png "ssrs_ChangeOrderofParameters_ReportData")  
  
-   In the parameters pane, drag the parameter to a new column or row in the pane. When you change the location of the parameter in the pane, the parameter order changes in the **Report Data** pane. For more information about moving parameters in the pane, see [Customize the Parameters Pane in a Report (Report Builder)](../../Topics/TopicNameContainA/Customize-the-Parameters-Pane-in-a-Report--Report-Builder-.md).  
  
## See Also  
 [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md)   
 [Report Builder Help for Dialog Boxes, Panes, and Wizards](assetId:///2da24891-0b6d-4d3c-8b18-81b98752642f)   
 [Add Cascading Parameters to a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-Cascading-Parameters-to-a-Report--Report-Builder-and-SSRS-.md)   
 [Tutorial: Adding a Parameter to Your Report (Report Builder)](assetId:///eab34ec4-b3ad-4a76-95cc-07b2f75ee6d7)   
 [Add Dataset Filters, Data Region Filters, and Group Filters (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-Dataset-Filters--Data-Region-Filters--and-Group-Filters--Report-Builder-and-SSRS-.md)   
 [Parameters Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Parameters-Collection-References--Report-Builder-and-SSRS-.md)