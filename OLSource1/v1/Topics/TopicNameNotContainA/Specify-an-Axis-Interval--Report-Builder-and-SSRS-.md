---
title: Specify an Axis Interval (Report Builder and SSRS)
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
ms.assetid: ae46712d-a5bf-44c0-9929-e30ccc1e7e33
manager: mblythe
---
# Specify an Axis Interval (Report Builder and SSRS)
The axis interval defines the number of labels and accompanying tick marks on an axis. On the value axis, axis intervals provide a consistent measure of the data points on the chart. However, on the category axis, this functionality can cause categories to appear without axis labels. You can specify the number of intervals you want in the axis **Interval** property. [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] calculates the number of intervals at run time, based on the data in the result set. For more information about how axis intervals are calculated, see [Formatting Axis Labels on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Axis-Labels-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
 This topic is not applicable for date or time values on the category axis. Be default, **DateTime** values appear as days. To specify a different date or time interval, such as a month or time interval, you must format the axis labels and set the axis to display instances of **DateTime** types instead of **String** types. In addition, you must set the **Interval** property. For more information, see [Format Axis Labels as Dates or Currencies (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Format-Axis-Labels-as-Dates-or-Currencies--Report-Builder-and-SSRS-.md).  
  
 This topic does not apply to pie, doughnut, funnel or pyramid charts, which do not have axes.  
  
> [!NOTE]  
>  The category axis is usually the horizontal or x-axis. However, for bar charts, the category axis is the vertical or y-axis.  
  
 An example of a chart specifying different axis intervals is available as a sample report. For more information about downloading this sample report and others, see [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)][Report Builder and Report Designer sample reports](http://go.microsoft.com/fwlink/?LinkId=198283).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To show all category labels on the x-axis  
  
1.  Right-click the category axis and click **Axis Properties**. The **Axis Properties** dialog box opens.  
  
2.  In **Axis Options**, set **Interval** to **1**. Every category group label is displayed. If you want to show every other category group label on the x-axis, type **2**.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
    > [!NOTE]  
    >  When an axis interval is set, all automatic labeling is disabled. If you specify a value for the axis interval, you may experience unpredictable labeling behavior depending on how many categories are on the category axis.  
  
### To enable a variable interval calculation on an axis  
  
1.  Right-click the chart axis that you want to change, and then click **Axis Properties**. The **Axis Properties** dialog box opens.  
  
2.  In **Axis Options**, set **Interval** to **Auto**. The chart will display the optimal number of category labels that can fit along the axis.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Formatting a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-a-Chart--Report-Builder-and-SSRS-.md)   
 [Formatting Data Points on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Data-Points-on-a-Chart--Report-Builder-and-SSRS-.md)   
 [Sort Data in a Data Region (Report Builder and SSRS)](../../Topics/TopicNameContainA/Sort-Data-in-a-Data-Region--Report-Builder-and-SSRS-.md)   
 [Axis Properties Dialog Box, Axis Options (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Axis-Properties-Dialog-Box--Axis-Options--Report-Builder-and-SSRS-.md)   
 [Specify a Logarithmic Scale (Report Builder and SSRS)](../../Topics/TopicNameContainA/Specify-a-Logarithmic-Scale--Report-Builder-and-SSRS-.md)   
 [Plot Data on a Secondary Axis (Report Builder and SSRS)](../../Topics/TopicNameContainA/Plot-Data-on-a-Secondary-Axis--Report-Builder-and-SSRS-.md)