---
title: "Axis Properties Dialog Box, Axis Options (Report Builder and SSRS)"
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
ms.assetid: b276e210-7a12-48ae-971b-7dabae51df11
caps.latest.revision: 12
manager: mblythe
---
# Axis Properties Dialog Box, Axis Options (Report Builder and SSRS)
Select **Axis Options** on the **Horizontal** or **VerticalAxis Properties** dialog box to define the appearance of the specified axis of the chart. In previous versions of [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)], the chart displayed all labels on the x-axis by default. However, in [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] 2008, the chart skips labels in order to produce a cleaner image on the chart and avoid labeling collisions. For more information, see [Formatting Axis Labels on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Axis-Labels-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
## Options  
 **Enable scale breaks**  
 Select this option to enable the chart to draw a scale breaks when it is deemed necessary. When this option is enabled, the chart will automatically calculate whether there is sufficient difference between the high and low points in the dataset to draw a scale break.  
  
 **Reverse direction**  
 Select this option to reverse the direction of the chart. For example, by default, a column chart displays the y-axis on the left side of the chart and categories from left to right. When this option is selected, the chart displays the y-axis on the right side of the chart and categories from right to left.  
  
 **Use interlacing color**  
 Select this option to add strip lines to the chart, and then select a color or type an expression. Strip lines are shaded bands on the chart area that give the effect of alternating light and dark areas between gridlines. These strip lines are useful for highlighting repeating patterns on an axis.  
  
 **Always include zero**  
 Select this option to always include zero on the axis scale. If this option is not enabled, the chart will not label the zero value on the axis. Including zero values is useful when the dataset includes negative or zero values.  
  
 **Scalar axis**  
 Select this option to display a set of axis values on a continuous scale. For example, if the dataset contains data for January, March, and November, a non-scalar axis displays only those months, whereas a scalar axis displays all of the months in the year.  
  
 **Use logarithmic scale**  
 Select this option to indicate that the axis scale is logarithmic. This option is available only on the y-axis if the axis contains positive numeric values.  
  
 In the box, type the logarithmic base to use when the axis is set to use a logarithmic scale. By default, the chart uses a base of 10 for the logarithmic scale of an axis. This option is available only on the y-axis if the axis is numeric.  
  
 **Minimum**  
 Type an expression or a value for the minimum value for the x-axis. If omitted, the minimum value is determined by the data returned by the dataset.  
  
 **Maximum**  
 Type an expression or a value for the maximum value for the x-axis. If omitted, the maximum value is determined by the data returned by the dataset.  
  
 **Interval**  
 Type an expression or value for the interval between axis labels. For example, type 1 to display each category label on the axis. Type 2 to display every other category label. If omitted, the labels are calculated automatically based on the values in the dataset.  
  
 **Interval type**  
 Type an expression or a value for the interval type of the interval specified. For example, if you want the interval to be two days, you will specify **2** for interval and **Days** for interval type.  
  
 **Side margins**  
 Type an expression or select a value to add or remove a margin between the chart elements and the sides of the chart. If this option is set to **Auto**, a side margins are added.  
  
## See Also  
 [Formatting Axis Labels on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Axis-Labels-on-a-Chart--Report-Builder-and-SSRS-.md)   
 [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md)   
 [Formatting Series Colors on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Series-Colors-on-a-Chart--Report-Builder-and-SSRS-.md)   
 [Specify an Axis Interval (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Specify-an-Axis-Interval--Report-Builder-and-SSRS-.md)   
 [Format Axis Labels as Dates or Currencies (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Format-Axis-Labels-as-Dates-or-Currencies--Report-Builder-and-SSRS-.md)   
 [Plot Data on a Secondary Axis (Report Builder and SSRS)](../../Topics/TopicNameContainA/Plot-Data-on-a-Secondary-Axis--Report-Builder-and-SSRS-.md)   
 [Sparklines and Data Bars (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Sparklines-and-Data-Bars--Report-Builder-and-SSRS-.md)   
 [Add or Remove Margins from a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Remove-Margins-from-a-Chart--Report-Builder-and-SSRS-.md)