---
title: Displaying a Series with Multiple Data Ranges on a Chart (Report Builder and SSRS)
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
ms.assetid: 45da3d39-278e-4760-a4b3-9932c9547cf2
manager: mblythe
---
# Displaying a Series with Multiple Data Ranges on a Chart (Report Builder and SSRS)
Chart will use the minimum and maximum values of a series to calculate the axis scale. When a series on your chart contains more than one range of data, the data points can become obscured, and only a few data points to be seen easily on the chart. For example, suppose a report displays daily sales totals over a period of 30 days.  
  
 ![Chart with multiple data ranges](../../Topics/TopicNameContainA/media/rs_MultipleDataRangesChart.gif "rs_MultipleDataRangesChart")  
  
 For most of the month, the sales are between 10 and 40. However, a one-week sales marketing campaign has caused a sudden sales increase at the beginning of April. This change in sales data produces an uneven distribution of data points that reduces the overall readability of the chart.  
  
 There are different ways to improve readability:  
  
-   **Enable scale breaks**. If your data forms two or more sets of data ranges, use a scale break to remove the gap between the ranges. A scale break is a stripe drawn across the plotting area to denote a break between the high and low values of a series.  
  
-   **Filter out unnecessary values**. If you have data points that are obscuring the important data range to be displayed on the chart, remove the unwanted points using a report filter. For information on how to add a filter to the chart in [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)], see [Add Dataset Filters, Data Region Filters, and Group Filters (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-Dataset-Filters--Data-Region-Filters--and-Group-Filters--Report-Builder-and-SSRS-.md).  
  
-   **Plot each data range as a separate series for multiple series comparison**. If you have more than two data ranges, consider separating the data ranges into separate series. For more information, see [Multiple Series on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Multiple-Series-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Displaying Multiple Data Ranges Using Scale Breaks  
 When you enable a scale break, the chart calculates where to draw a line across the chart. You must have sufficient separation between ranges to draw a scale break. By default, a scale break can be added only if there is a separation between the data ranges of at least 25% of the chart.  
  
 ![Chart with scale break](../../Topics/TopicNameContainA/media/rs_MultipleDataRangesChart_ScaleBreak.gif "rs_MultipleDataRangesChart_ScaleBreak")  
  
> [!NOTE]  
>  You cannot specify where to place a scale break on a chart. You can, however, modify how the scale break is calculated, described later in this topic.  
  
 If you enable a scale break but it does not appear, even though there is sufficient distance between the data ranges, you can set the **CollapsibleSpaceThreshold** property to a value less than 25. The **CollapsibleSpaceThreshold** specifies the percent of collapsible space required between the data ranges. For more information, see [Add Scale Breaks to a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-Scale-Breaks-to-a-Chart--Report-Builder-and-SSRS-.md).  
  
 Charts support up to five scale breaks per chart; however, displaying more than one scale break can cause the chart to become unreadable. If you have more than two data ranges, consider using a different method for displaying this data. For more information, see [Multiple Series on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Multiple-Series-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
## Unsupported Scale Break Scenarios  
 Scale breaks are not supported in the following chart scenarios:  
  
-   The chart is 3-D enabled.  
  
-   A logarithmic value axis has been specified.  
  
-   The value axis minimum or maximum has been explicitly set.  
  
-   The chart type is polar, radar, pie, doughnut, funnel, pyramid, or any stacked chart.  
  
 An example of chart with scale breaks is available as a sample report. For more information about downloading this sample report and others, see [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)][Report Builder and Report Designer sample reports](http://go.microsoft.com/fwlink/?LinkId=198283).  
  
## See Also  
 [Multiple Series on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Multiple-Series-on-a-Chart--Report-Builder-and-SSRS-.md)   
 [Formatting a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-a-Chart--Report-Builder-and-SSRS-.md)   
 [3D, Bevel, and Other Effects in a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/3D--Bevel--and-Other-Effects-in-a-Chart--Report-Builder-and-SSRS-.md)   
 [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md)   
 [Axis Properties Dialog Box, Axis Options (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Axis-Properties-Dialog-Box--Axis-Options--Report-Builder-and-SSRS-.md)   
 [Collect Small Slices on a Pie Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Collect-Small-Slices-on-a-Pie-Chart--Report-Builder-and-SSRS-.md)