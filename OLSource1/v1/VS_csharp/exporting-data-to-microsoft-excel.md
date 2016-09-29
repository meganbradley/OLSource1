---
title: "Exporting Data to Microsoft Excel"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "exporting data [Visual Studio LightSwitch]"
  - "Visual Studio LightSwitch, exporting data"
  - "Visual Studio LightSwitch, reporting"
  - "reporting [Visual Studio LightSwitch]"
ms.assetid: 5282ca9f-41e3-46be-a686-ac1bffc1af5b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exporting Data to Microsoft Excel
By default, users can export to Microsoft Office Excel any list of data that appears in a screen.  Then, users can create charts, reports, and PivotTables by using features in Excel.  If you want to prevent users from exporting data to Excel, you can disable this feature in the Screen Designer of your project.  
  
> [!NOTE]
>  Export to Excel functionality is only enabled for desktop applications. Web applications cannot access local resources or files due to security restrictions.  
  
## Exporting Data  
 Users of your application can export data to Excel by clicking the **Export to Excel** button that appears in a screen. Users can only export collections of data. Therefore, the **Export to Excel** button appears above collection of data records only (For example: A customer **List** or products **GridView**).  The **Export to Excel** button does not appear above areas in the screen that display the details of a data item.  
  
 When users click **Export to Excel**, the application opens an Excel worksheet, and then populates the worksheet by using data from the collection that appears on the screen.  Data that does not appear on the screen is not exported. If paging is enabled for the collection, and you want to export additional rows of data, you must increase the number of rows shown in a page or disable paging entirely before you export the data. For more information, see [How to: Design a Screen by Using the Screen Designer](../VS_csharp/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md).  
  
 After users export data to Excel, they can create reports, charts, and PivotTables by using features in Excel.  
  
## Disabling the Ability to Export Data  
 If your users do not have Excel installed on their computers, or you do not want users to export some collection of data, you can disable this feature.  
  
> [!NOTE]
>  If a user clicks **Export to Excel**, but Excel is not installed on their computer, an error message will appear.  
  
 In the Screen Designer, select any **DataGrid** or **List**. Then, in the **Properties** window, select the **Disable exporting data to Excel checkbox**. You must disable the ability to export data for each **DataGrid** or **List** control individually.  In the running application, the **Export to Excel** button will not appear above any collection to which you have applied the **Disable exporting data to Excel** setting.  
  
## See Also  
 [Reporting and Printing in LightSwitch](../VS_csharp/reporting-and-printing-in-lightswitch.md)   
 [Walkthrough: Consuming LightSwitch Services in Excel Using PowerPivot](../VS_csharp/walkthrough--consuming-lightswitch-services-in-excel-using-powerpivot.md)   
 [Report Templates](http://go.microsoft.com/fwlink/?LinkID=196177)