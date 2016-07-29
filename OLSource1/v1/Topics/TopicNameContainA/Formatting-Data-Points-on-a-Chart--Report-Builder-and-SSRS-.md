---
title: "Formatting Data Points on a Chart (Report Builder and SSRS)"
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
ms.assetid: 08ec3818-f63a-4e89-b52c-750e47f48b85
caps.latest.revision: 8
manager: mblythe
---
# Formatting Data Points on a Chart (Report Builder and SSRS)
A data point is the smallest individual entity on the chart. On non-Shape charts, data points are represented depending on their chart type. For example, a Line series consists of one or more connected data points. On Shape charts, data points are represented by individual slices or segments that add up to the whole chart. For example, on a pie chart, each piece is a data point. For more information, see [Chart Types (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Chart-Types--Report-Builder-and-SSRS-.md).  
  
 One or more data points form a series. By default, all formatting options are applied to all data points in the series. If you want to specify properties for individual data points, you can specify a field or expression on the series that formats individual data point at run time based on the dataset.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Adding ToolTips and Drillthrough Actions to Data Points  
 You can add ToolTips to each data point by setting the value of the **ToolTip** property on the series. By displaying ToolTips, you can give your users the ability to see any information related to the data point, such as the group name, the value of the data point and the percentage of the data point relative to the series total. For more information, see [Show ToolTips on a Series (Report Builder and SSRS)](../../Topics/TopicNameContainA/Show-ToolTips-on-a-Series--Report-Builder-and-SSRS-.md).  
  
 You can also specify a drillthrough action for data points on the series to display another report or a URL. You can pass parameters to show information relating to the data point that has been clicked. For more information, see [Add a Drillthrough Action on a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Drillthrough-Action-on-a-Report--Report-Builder-and-SSRS-.md).  
  
## Highlighting Individual Data Points in a Series  
 On any non-Shape chart, you can highlight individual data points by specifying an expression for the **Color** property. For example, to highlight the highest data point value in a series that is named `MyField` with a different color than the other data points, the expression would be similar to the following:  
  
 `=Iif(Fields!MyField.Value >= Max(Fields!MyField.Value, "MyDataSet"), "Red", "Green")`  
  
 In this example, the highest value for `MyField` will have the color Red and all other data points will have the color Green. When you specify a color for the series using the **Fill** property on the series, the chart overrides the colors that are specified in the palette. For more information, see [Formatting Series Colors on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Series-Colors-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
## Positioning Data Point Labels on a Chart  
 For all chart types, you can show data point labels when you right-click the chart and select **Show Data Labels**. The position of the data point labels is specified depending on the chart type:  
  
-   On a bar chart, you can reposition the data point label using the **BarLabelStyle** custom attribute. There are four possible positions: Outside, Left, Center and Right. When the bar label style is set to Outside, the labels will be positioned outside the bar, as long as it fits in the chart area. If the label cannot be positioned outside the bar and inside the chart area, the label is positioned inside the bar.  
  
-   On a pie chart, you can reposition the data point label using the **PieLabelStyle** custom attribute. There are many considerations when positioning data point labels around a pie chart, including the size of the pie chart, the available space between the pie chart and its corresponding legend, and the size of the labels. For more information, see [Display Data Point Labels Outside a Pie Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Display-Data-Point-Labels-Outside-a-Pie-Chart--Report-Builder-and-SSRS-.md).  
  
-   On a pyramid or funnel chart, you can reposition the data point labels using the **FunnelLabelStyle** and **PyramidLabelStyle** custom attributes. You can set these attributes in the **Properties** pane when you have selected a pyramid or funnel chart type.  
  
-   On stacked charts, data point labels are always positioned inside the series and the **Position** property on the series label is ignored.  
  
-   On all other chart types, you can reposition the data point label using the **Position** property on the series label. By default, the chart automatically calculates the position for data point labels to avoid label collisions. When you set a value for **Position**, all data point labels will be positioned the same way, which may cause the labels to overlap. Consider using this approach only when you have fewer data points.  
  
 For more information, see [Position Labels in a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Position-Labels-in-a-Chart--Report-Builder-and-SSRS-.md).  
  
## Adding Keywords for Data Point Labels, ToolTips, and Legend Text  
 You can use case-sensitive, chart-specific keywords to represent an item that exists in the chart. These keywords are only applicable to ToolTips, custom legend text, and data point label properties. In many cases, a chart keyword has an equivalent simple expression, but the keyword is faster and easier to type. The following is a list of chart keywords.  
  
|Chart Keyword|Description|Applicable to Chart Type|Example of an Equivalent Simple Expression|  
|-------------------|-----------------|------------------------------|------------------------------------------------|  
|#VALY|Y value of the data point.|All|`=Fields!MyDataField.Value`|  
|#VALY2|Y value #2 of data point.|Range, Bubble|None|  
|#VALY3|Y value #3 of data point.|Stock, Candlestick|None|  
|#VALY4|Y value #4 of data point.|Stock, Candlestick|None|  
|#SERIESNAME|Series name.|All|None|  
|#LABEL|Data point label.|All|None|  
|#AXISLABEL|Axis data point label.|Shape|`=Fields!MyDataField.Value`|  
|#INDEX|Data point index.|All|None|  
|#PERCENT|Percentage of the data point Y value.|All|`=FormatPercent(Fields!MyDataField.Value/Sum(Fields!MyDataField.Value, "MyDataSet"),2)`|  
|#TOTAL|Total of all Y values in the series.|All|`=Sum(Fields!MyDataField.Value)`|  
|#LEGENDTEXT|The text that corresponds to the text of the legend item.|All|None|  
|#AVG|Average of all Y values in the series.|All|`=Avg(Fields!MyDataField.Value)`|  
|#MIN|Minimum of all Y values in the series.|All|`=Min(Fields!MyDataField.Value)`|  
|#MAX|Maximum of all Y values in the series.|All|`=Max(Fields!MyDataField.Value)`|  
|#FIRST|First of all Y values in the series.|All|`=First(Fields!MyDataField.Value)`|  
  
 To format the keyword, enclose a [!INCLUDE[dnprdnshort](../../Topics/TopicNameContainA/includes/dnprdnshort_md.md)] format string in parentheses. For example, to specify the value of the data point in a ToolTip as a number with two decimal places, include the format string "N2" in braces, such as "#VALY{N2}" for the **ToolTip** property on the series. For more information about [!INCLUDE[dnprdnshort](../../Topics/TopicNameContainA/includes/dnprdnshort_md.md)] format strings, see [Formatting Types](http://go.microsoft.com/fwlink/?LinkId=112024) on MSDN. For more information about formatting numbers in [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)], see [Formatting Numbers and Dates (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Formatting-Numbers-and-Dates--Report-Builder-and-SSRS-.md).  
  
 For more information about adding keywords to a chart, see [Show ToolTips on a Series (Report Builder and SSRS)](../../Topics/TopicNameContainA/Show-ToolTips-on-a-Series--Report-Builder-and-SSRS-.md), [Change the Text of a Legend Item (Report Builder and SSRS)](../../Topics/TopicNameContainA/Change-the-Text-of-a-Legend-Item--Report-Builder-and-SSRS-.md).  
  
## Increasing Readability in a Chart with Multiple Data Points  
 If you have multiple series on your chart, it may reduce the readability of the chart data points. When adding multiple series to the chart, consider using a technique that distinguishes how to read and understand each series in the chart effectively. For more information, see [Multiple Series on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Multiple-Series-on-a-Chart--Report-Builder-and-SSRS-.md).  
  
 For simplicity, when you are using a Shape chart, consider adding only one data field and one category field. For more information, see [Shape Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Shape-Charts--Report-Builder-and-SSRS-.md). If your chart needs more than one data field and category field, consider changing the chart type. You can right-click the series and select **Change Chart Type**.  
  
## Inserting Data Point Markers  
 A data point marker is a visual indicator used to draw attention to each data point in a series. On a scatter chart, the marker is used to determine the shape and size of the individual data points. The size of the marker is specified based on the chart type. You can change the size, color, or style of the marker. Markers are not available for range and shape chart types, or any stacked subtypes.  
  
## In This Section  
 [Show ToolTips on a Series (Report Builder and SSRS)](../../Topics/TopicNameContainA/Show-ToolTips-on-a-Series--Report-Builder-and-SSRS-.md)  
  
 [Display Data Point Labels Outside a Pie Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Display-Data-Point-Labels-Outside-a-Pie-Chart--Report-Builder-and-SSRS-.md)  
  
 [Display Percentage Values on a Pie Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Display-Percentage-Values-on-a-Pie-Chart--Report-Builder-and-SSRS-.md)  
  
## See Also  
 [Formatting a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-a-Chart--Report-Builder-and-SSRS-.md)   
 [Formatting Axis Labels on a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Formatting-Axis-Labels-on-a-Chart--Report-Builder-and-SSRS-.md)   
 [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md)   
 [Format Axis Labels as Dates or Currencies (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Format-Axis-Labels-as-Dates-or-Currencies--Report-Builder-and-SSRS-.md)   
 [Tutorial: Adding a Pie Chart to a Report](assetId:///eaadf7bf-c312-428a-b214-0a1fbf959c3f)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)   
 [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md)