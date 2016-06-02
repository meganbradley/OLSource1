---
title: Nested Data Regions (Report Builder and SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 15c2bc9b-428a-47ac-9630-8dde925d0595
---
# Nested Data Regions (Report Builder and SSRS)
  You can nest one data region, such as a chart, inside another data region, such as a matrix, typically to display data summaries in a concise manner or to provide a visual display as well as a table or matrix display.  
  
 For example, for a matrix \(also called a *tablix*\) that contains sales orders grouped by Store on rows and by Quarter on columns, you can add a table or chart to the corner cell to summarize the sales for all stores, or add a chart to a matrix column header to show the sales contribution of the data in the column as a percentage of all sales.  
  
 ![rs_NestedDataRegion](../../Images\Image\ImageNotContaina/rs_NestedDataRegion.gif "rs_NestedDataRegion")  
  
 In this illustration, the pie chart in the corner cell and the sparkline charts in the rows are nested data regions.  
  
 By definition, nested data regions are based on the same report dataset. You cannot nest data regions that are based on different datasets. To display data from different datasets, consider using drillthrough reports or subreports. For more information, see [Drillthrough, Drilldown, Subreports, and Nested Data Regions &#40;Report Builder and SSRS&#41;](../Topic/Drillthrough,%20Drilldown,%20Subreports,%20and%20Nested%20Data%20Regions%20\(Report%20Builder%20and%20SSRS\).md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Token\Other/ssRBRDDup_md.md)]  
  
## Understanding Scope for a Nested Data Region  
 The scope for data in a nested data region is automatically defined by its placement in the parent data region. For example, the scope for data for a chart nested in a tablix corner cell is the data from the dataset bound to the tablix data region after the filters are applied for the dataset, the tablix data region, and the chart data region. The scope for a tablix nested in a tablix cell is the same as the scope for the corner cell, but additionally scoped to the row and column group memberships of the cell in which it is nested, with the corresponding group filters applied. For more information about scope, see [Expression Scope for Totals, Aggregates, and Built-in Collections &#40;Report Builder and SSRS&#41;](../Topic/Expression%20Scope%20for%20Totals,%20Aggregates,%20and%20Built-in%20Collections%20\(Report%20Builder%20and%20SSRS\).md).  
  
 The following list describes the scope for cells in the following tablix areas:  
  
-   **Tablix corner** The scope is the data in the data region linked to the tablix data region, after the filter and sort expressions for the dataset and the outer tablix are applied.  
  
-   **Tablix column group** The data in the innermost column group, after the filter and sort expressions for the dataset, the outer tablix, and the column groups are applied.  
  
-   **Tablix row group** The data in the innermost row group, after the filter and sort expressions for the dataset, the outer tablix, and the row groups are applied.  
  
-   **Tablix body** The data in the innermost group represented by the intersection of row groups and column groups, after the filter and sort expressions for the dataset, the outer tablix, and the row and column groups are applied.  
  
 For more information, see [Tablix Data Region Areas &#40;Report Builder and SSRS&#41;](../Topic/Tablix%20Data%20Region%20Areas%20\(Report%20Builder%20and%20SSRS\).md).  
  
## Nesting a Chart, Sparkline, or Data Bar in a Tablix  
 When you add a chart \(including a sparkline or data bar\) to a tablix column group header or group footer row, or to a tablix body cell, the data passed to the chart is scoped to the subset of data for that cell. By default, when you add a chart to a tablix cell, the chart dimensions expand to fill the cell.  
  
> [!NOTE]  
>  To have more control over the size of a chart in a tablix cell, add the chart to a rectangle first, and then add the rectangle to the tablix cell.  
  
 By default, the chart legend colors are determined by the color of the data points in the chart series. To control colors so that nested chart data regions all use the same color for the same category of data, you must use custom colors and set sort expressions on the data. For more information, see [Specify Consistent Colors across Multiple Shape Charts &#40;Report Builder and SSRS&#41;](../Topic/Specify%20Consistent%20Colors%20across%20Multiple%20Shape%20Charts%20\(Report%20Builder%20and%20SSRS\).md) and [Sort Data in a Data Region &#40;Report Builder and SSRS&#41;](../Topic/Sort%20Data%20in%20a%20Data%20Region%20\(Report%20Builder%20and%20SSRS\).md).  
  
## Nesting a Gauge or an Indicator in a Tablix  
 You can nest a gauge or an indicator inside of a table, matrix, or list in order to show a key performance indicator \(KPI\). When you place a gauge or indicator inside of a table, it will be rendered for each row in the tablix. For more information about adding indicators to a tablix, see [Indicators &#40;Report Builder and SSRS&#41;](../Topic/Indicators%20\(Report%20Builder%20and%20SSRS\).md).  
  
### Adding a gauge to a tablix  
 There are two ways to add a gauge to a tablix data region:  
  
-   Click inside the tablix cell and insert a gauge. The **Select Gauge Type** dialog box appears. Once you have selected a gauge type, the Gauge data region is placed inside of the selected tablix cell. You will likely need to resize the tablix in order to format the gauge.  
  
-   Click outside the table and insert a gauge. The **Select Gauge Type** dialog box appears. After you select a gauge type, the Gauge data region is placed in the top\-left corner of the report. After you add data and format this gauge, drag and drop it inside of the tablix cell.  
  
 Like the chart, the dataset passed to the gauge is scoped to the subset of data for that cell. When a gauge is placed inside of a tablix cell, the gauge will always aggregate only one row of data.  
  
 When data in your tablix contains grouping, the Gauge data region that is nested inside the tablix does not automatically inherit this group. You must add a matching group expression to the gauge in order to show the same information that is shown on the tablix. For example, if data in your tablix is grouped by Product, you must add a Product group expression to the gauge to show the same data. For more information, see [Gauges &#40;Report Builder and SSRS&#41;](../Topic/Gauges%20\(Report%20Builder%20and%20SSRS\).md) and [Add or Delete a Group in a Data Region &#40;Report Builder and SSRS&#41;](../Topic/Add%20or%20Delete%20a%20Group%20in%20a%20Data%20Region%20\(Report%20Builder%20and%20SSRS\).md).  
  
 You must set the minimum and maximum values that will be displayed on the gauge scale. To specify the maximum value of the gauge, you can use an expression, such as `=Max!MyField.Value`. However, because this expression will be evaluated within the scope of the data in the cell only, the maximum of each gauge will not be the same for all rows in the tablix. This may make comparisons between gauges in the tablix more difficult to understand. Alternatively, you can specify a static value for the maximum. All rows inside of the tablix will show a gauge with this maximum value. For more information, see [Set a Minimum or Maximum on a Gauge &#40;Report Builder and SSRS&#41;](../Topic/Set%20a%20Minimum%20or%20Maximum%20on%20a%20Gauge%20\(Report%20Builder%20and%20SSRS\).md).  
  
 If the data becomes too large on the gauge, consider using a scale multiplier to reduce the amount of digits displayed. To specify a multiplier, you can right\-click on the scale and select **Scale Properties**. When the **Scale Properties** dialog box opens, specify a value for **Multiplier**.  
  
## Nesting a Table or Matrix and a Chart in a List  
 To nest multiple data regions in a List add a rectangle first, and then add the data regions to the rectangle.  
  
 You can define a group for a List data region, and then add a tablix and a chart to provide different views of the same data. To achieve this effect, you must define identical group and sort expressions for the embedded tablix and chart. By definition, the tablix and chart use data from the dataset of the parent list data region.  
  
> [!NOTE]  
>  By default, when you add a List data region to the design surface, the list includes a detail row. You can change this default by adding a group row and removing the detail row. For more information, see [Exploring the Flexibility of a Tablix Data Region &#40;Report Builder and SSRS&#41;](../Topic/Exploring%20the%20Flexibility%20of%20a%20Tablix%20Data%20Region%20\(Report%20Builder%20and%20SSRS\).md).  
  
 For more information, see [Understanding Groups &#40;Report Builder and SSRS&#41;](../Topic/Understanding%20Groups%20\(Report%20Builder%20and%20SSRS\).md) and [Add, Move, or Delete a Table, Matrix, or List &#40;Report Builder and SSRS&#41;](../Topic/Add,%20Move,%20or%20Delete%20a%20Table,%20Matrix,%20or%20List%20\(Report%20Builder%20and%20SSRS\).md).  
  
## See Also  
 [Filter, Group, and Sort Data &#40;Report Builder and SSRS&#41;](../Topic/Filter,%20Group,%20and%20Sort%20Data%20\(Report%20Builder%20and%20SSRS\).md)   
 [Tables, Matrices, and Lists &#40;Report Builder and SSRS&#41;](../Topic/Tables,%20Matrices,%20and%20Lists%20\(Report%20Builder%20and%20SSRS\).md)   
 [Charts &#40;Report Builder and SSRS&#41;](../Topic/Charts%20\(Report%20Builder%20and%20SSRS\).md)   
 [Gauges &#40;Report Builder and SSRS&#41;](../Topic/Gauges%20\(Report%20Builder%20and%20SSRS\).md)   
 [Expressions &#40;Report Builder and SSRS&#41;](../Topic/Expressions%20\(Report%20Builder%20and%20SSRS\).md)   
 [Formatting Report Items &#40;Report Builder and SSRS&#41;](../Topic/Formatting%20Report%20Items%20\(Report%20Builder%20and%20SSRS\).md)   
 [Tutorial: Adding a KPI to Your Report &#40;Report Builder&#41;](../Topic/Tutorial:%20Adding%20a%20KPI%20to%20Your%20Report%20\(Report%20Builder\).md)   
 [Formatting Scales on a Gauge &#40;Report Builder and SSRS&#41;](../Topic/Formatting%20Scales%20on%20a%20Gauge%20\(Report%20Builder%20and%20SSRS\).md)  
  
  