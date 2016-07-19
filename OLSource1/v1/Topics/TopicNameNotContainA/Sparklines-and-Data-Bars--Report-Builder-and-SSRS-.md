---
title: Sparklines and Data Bars (Report Builder and SSRS)
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
ms.assetid: b287436b-fa48-4970-a1a7-1dbcb86e7411
manager: mblythe
---
# Sparklines and Data Bars (Report Builder and SSRS)
Sparklines and data bars are small, simple charts that convey a lot of information in a little space, often inline with text. Sparklines and data bars are often used in tables and matrices. Their impact comes from viewing many of them together and being able to quickly compare them one above the other, rather than viewing them singly. They make it easy to see the outliers, the rows that are not performing like the others. Although they are small, each sparkline often represents multiple data points, often over time. Data bars can represent multiple data points, but typically illustrate only one. Each sparkline typically presents a single series. You cannot add a sparkline to a detail group in a table. Because sparklines display aggregated data, they must go in a cell associated with a group. Sparklines and data bars have the same basic chart elements of categories, series, and values, but they have no legend, axis lines, labels, or tick marks.  
  
 ![rs&#95;SparklineExample](../../Topics/TopicNameNotContainA/media/rs_SparklineExample.gif "rs_SparklineExample")  
  
 To quickly get started with sparklines, see [Tutorial: Creating a Sparkline Report (Report Builder)](assetId:///18c90a36-48bf-4805-a960-2d1e8f00c2dc) and the videos [How to: Create a Sparkline in a Table](http://go.microsoft.com/fwlink/?LinkId=197092) and [Sparklines, Bar Charts, and Indicators in Report Builder](http://technet.microsoft.com/bi/video/ff877165) .  
  
> [!NOTE]  
>  You can publish sparklines and data bars with their parent table, matrix, or list, separately from a report as a report part. [!INCLUDE[ssRBrptparts](../../Topics/TopicNameContainA/includes/ssRBrptparts_md.md)]  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
##  <a name="KindsofSparklines"></a> Types of Sparklines  
 You can create almost as many types of sparklines as there are regular charts. In general, you cannot make 3D sparklines. You can make sparkline versions of these full charts:  
  
-   [Column Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Column-Charts--Report-Builder-and-SSRS-.md): The basic, stacked, and 100% stacked column charts.  
  
-   [Line Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Line-Charts--Report-Builder-and-SSRS-.md): All except the 3D line chart.  
  
-   [Area Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Area-Charts--Report-Builder-and-SSRS-.md): All except the 3D area charts  
  
-   [Pie Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Pie-Charts--Report-Builder-and-SSRS-.md): And doughnut charts, both flat and 3D, but not the other shapes such as funnel and pyramid charts.  
  
-   [Range Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Range-Charts--Report-Builder-and-SSRS-.md): The stock, candlestick, error bar, and box plot charts.  
  
##  <a name="DataBars"></a> Data Bars  
 Data bars typically represent a single data point, though they can represent multiple data points, just like regular bar charts. They often contain several series with no category, or have series grouping.  
  
 ![rs&#95;DataBars](../../Topics/TopicNameNotContainA/media/rs_DataBars.gif "rs_DataBars")  
  
 In this example using stacked data bars, each data bar, although only one bar, illustrates more than one data point. For example, the three different colors of the bar could represent tasks of three levels of priority with the length of the bar representing the total number of tasks assigned to each person. If you made these 100% stacked data bars instead, each bar would fill the cell, and the different colors would represent the percentage of the whole for each priority level.  
  
 You can make data bar versions of these full charts:  
  
-   [Bar Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Bar-Charts--Report-Builder-and-SSRS-.md): Basic, stacked, and 100% stacked bar charts.  
  
-   [Column Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Column-Charts--Report-Builder-and-SSRS-.md): Basic, stacked, and 100% stacked column charts. Column charts can be either sparklines or data bars.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="AlignDatainTableMatrix"></a> Aligning Sparkline Data in a Table or Matrix  
 When you insert a sparkline in a table or matrix, it is usually important for the data points in each sparkline to align with the data points of the other sparklines in that column. Otherwise it is hard to compare the data in the different rows. For example, when you compare sales data by month for different salespeople in your company, you would want the months to align. If an employee was out for the month of April, there would be no data for that employee for that month. You would want to see a gap for that month, and see the data for subsequent months align with the data for the other employees. You can do this by aligning the horizontal axis. For more information, see the section about sparklines in [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md), and see [Align the Data in a Chart in a Table or Matrix (Report Builder and SSRS)](../../Topics/TopicNameContainA/Align-the-Data-in-a-Chart-in-a-Table-or-Matrix--Report-Builder-and-SSRS-.md).  
  
 Likewise, to be comparable across rows, data must also align vertically, meaning that the height of the bars or lines in one sparkline or data bar must be relative to the height of the bars and lines in all the other sparklines or data bars. Otherwise, you can't compare the rows to each other.  
  
 ![rs&#95;SparklineAlignData](../../Topics/TopicNameContainA/media/rs_SparklineAlignData.gif "rs_SparklineAlignData")  
  
 In this image, the column chart shows daily sales for each employee. Note that for days that an employee has no sales, the chart leaves a blank and aligns subsequent days. This is an example of horizontal alignment. Also note that for some employees, every bar is short, and no bar reaches the top of the cell. This is an example of vertical alignment; without it, in the rows with no tall bars, the short bars would expand to fill the height of the cell.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="UnderstandScope"></a> Understanding the Data Supplied to a Sparkline or Data Bar  
 When you add a sparkline or data bar to a table or matrix, this is referred to as *nesting* one data region inside another. Nesting means that the data supplied to the sparkline or data bar is controlled by the dataset that the table or matrix is based on, and by where you put it in the table or matrix. For more information, see [Nested Data Regions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Nested-Data-Regions--Report-Builder-and-SSRS-.md).  
  
##  <a name="ConvertSparklinetoChart"></a> Converting a Sparkline or Data Bar to a Full Chart  
 Because sparklines and data bars are just a kind of chart, if you decide you would rather have the full chart functionality, you can convert one to a full chart by right-clicking the chart and clicking **Convert to Full Chart**. When you do, the axis lines, labels, tick marks, and legend are added automatically.  
  
> [!NOTE]  
>  You cannot convert a full chart to a sparkline or data bar with one click. However, you can make a sparkline or data bar from a full chart just by deleting all the chart elements that are not in sparklines and data bars.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="HowTo"></a> How-to Topics  
 [Add Sparklines and Data Bars (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-Sparklines-and-Data-Bars--Report-Builder-and-SSRS-.md)  
  
 [Align the Data in a Chart in a Table or Matrix (Report Builder and SSRS)](../../Topics/TopicNameContainA/Align-the-Data-in-a-Chart-in-a-Table-or-Matrix--Report-Builder-and-SSRS-.md)  
  
### Other how-to topics for charts  
 Because sparklines and data bars are a type of chart, you might also find the following how-to topics for charts helpful and relevant:  
  
 [Add a Chart to a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Chart-to-a-Report--Report-Builder-and-SSRS-.md)  
  
 [Add Empty Points to a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-Empty-Points-to-a-Chart--Report-Builder-and-SSRS-.md)  
  
 [Add or Remove Margins from a Chart (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-or-Remove-Margins-from-a-Chart--Report-Builder-and-SSRS-.md)  
  
 [Change a Chart Type (Report Builder and SSRS)](../../Topics/TopicNameContainA/Change-a-Chart-Type--Report-Builder-and-SSRS-.md)  
  
 [Define Colors on a Chart Using a Palette (Report Builder and SSRS)](../../Topics/TopicNameContainA/Define-Colors-on-a-Chart-Using-a-Palette--Report-Builder-and-SSRS-.md)  
  
 [Show ToolTips on a Series (Report Builder and SSRS)](../../Topics/TopicNameContainA/Show-ToolTips-on-a-Series--Report-Builder-and-SSRS-.md)  
  
 [Specify a Logarithmic Scale (Report Builder and SSRS)](../../Topics/TopicNameContainA/Specify-a-Logarithmic-Scale--Report-Builder-and-SSRS-.md)  
  
 [Specify an Axis Interval (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Specify-an-Axis-Interval--Report-Builder-and-SSRS-.md)  
  
 [Specify Consistent Colors across Multiple Shape Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Specify-Consistent-Colors-across-Multiple-Shape-Charts--Report-Builder-and-SSRS-.md)  
  
## See Also  
 [Charts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Charts--Report-Builder-and-SSRS-.md)   
 [Tutorial: Creating a Sparkline Report (Report Builder)](assetId:///18c90a36-48bf-4805-a960-2d1e8f00c2dc)   
 [Sparklines, Bar Charts, and Indicators in Report Builder (video)](http://technet.microsoft.com/bi/video/ff877165)   
 [How to: Create a Sparkline in a Table (video)](http://go.microsoft.com/fwlink/?LinkId=197092)