---
title: "Controlling Row and Column Headings (Report Builder and SSRS)"
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
ms.assetid: 4be6e836-158e-4bc9-8870-7f394d7c7e11
caps.latest.revision: 9
manager: mblythe
---
# Controlling Row and Column Headings (Report Builder and SSRS)
A table, matrix, or list data region can span multiple pages horizontally or vertically. You can specify whether to repeat row or column headings on each page. In an interactive renderer such as Report Manager or report preview, you can also specify whether to freeze row or column headings to keep them in view when you scroll across or down a report. In a table or matrix, the first row usually contains column headings that label data in each column; the first column usually contains row headings that label the data in each row. For nested groups, you might want to repeat the initial set of row and column headings that contain group labels. By default, a list data region does not include headings.  
  
 How you control whether headings repeat or freeze depends on the following:  
  
-   For column headings that repeat at the top of each page:  
  
    -   Whether the table or matrix has a column group area that expands horizontally.  
  
    -   Whether you want to control all rows that are associated with column groups as a unit.  
  
-   For row headings that repeat along the side of each page:  
  
    -   Whether the table or matrix has a row group area that expands vertically. Row headings are supported only for row groups with a row group header.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Understanding Rows and Columns in a Tablix Data Region  
 A table or matrix is a template for the underlying tablix data region. A tablix data region has four possible areas: the row group area that controls rows that expand down a report, the column group area that controls columns that expand across a report, the body that displays data, and the corner. To understand where to set properties to control repeating or freezing headers, it helps to understand that there are two representations for a tablix data region:  
  
-   **In the report definition** Each row or column in a tablix data region definition is a tablix member of a specific row or column group. A tablix member is static or dynamic. A static tablix member contains labels or subtotals and repeats once per group. A dynamic tablix member contains group values and repeats once per unique value of a group, also known as a group instance.  
  
-   **On the design surface** On the design surface, dotted lines divide a tablix data region into the four areas. Each cell in a tablix data region area is organized into rows and columns. Rows and columns are associated with groups, including the details group. For a selected tablix data region, row and column handles and highlight bars indicate group membership. Cells in the row group or column group area represent group headers for tablix members. A single row or column can be associated with multiple groups.  
  
     For more information, see [Tablix Data Region (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tablix-Data-Region--Report-Builder-and-SSRS-.md) and [Tablix Data Region Cells, Rows, and Columns (Report Builder) and SSRS](../../Topics/TopicNameNotContainA/Tablix-Data-Region-Cells--Rows--and-Columns--Report-Builder--and-SSRS.md).  
  
 For tablix data regions with row group or column group areas, control the associated rows and columns by setting properties on tablix data region. For all other cases, control the rows and columns by setting properties in the Properties pane for the selected tablix member. For step-by-step instructions, see [Display Row and Column Headers on Multiple Pages (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Display-Row-and-Column-Headers-on-Multiple-Pages--Report-Builder-and-SSRS-.md) and [Keep Headers Visible When Scrolling Through a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Keep-Headers-Visible-When-Scrolling-Through-a-Report--Report-Builder-and-SSRS-.md).  
  
##  <a name="Top"></a> Examples  
 The most common examples of tablix data regions are for a matrix, a table with no groups, and a table with a row group and a row group header, and a table with a row group but no row group header. To control how to repeat or freeze headers, you must determine if the rows or columns that you want to control are associated with a group header in the row groups or column groups area.  
  
 The following sections provide examples for common layouts for a tablix data region:  
  
-   [Matrix](#Matrix)  
  
-   [Table with no groups](#TableNoGroups)  
  
-   [Table with row groups and row group area](#TableRowGroupsGroupHeader)  
  
-   [Table with row groups but no row group area](#TableRowGroupsNoGroupHeader)  
  
###  <a name="Matrix"></a> Matrix  
 By default, a simple matrix has one row group and one column group. The following figure shows a matrix with a row group that is based on Category and a column group that is based on Geography:  
  
 ![Matrix, Category row and Geography column group](../../Topics/TopicNameContainA/media/rs_BasicMatrixDesign.gif "rs_BasicMatrixDesign")  
  
 The dotted lines show the four tablix areas. The row group area has a row group header that controls the category labels in the first column. Similarly, the column group area has a column group header that controls the geography labels in the first row. In preview, as the matrix expands across the page, the first row displays the column headings, as shown in the following figure:  
  
 ![Preview for rendered matrix with expanded groups](../../Topics/TopicNameContainA/media/rs_BasicMatrixPreview.gif "rs_BasicMatrixPreview")  
  
 To repeat or freeze column headings in the first row, set properties for column headers on the tablix data region. Column headers for nested column groups are automatically included.  
  
 To repeat or freeze row headings in the first column, set properties for row headers on the tablix data region. Row headers for nested row groups are automatically included.  
  
 [Return to top](#Top)  
  
###  <a name="TableNoGroups"></a> Table with no row groups  
 By default, a simple table with no groups does include the details group. The following figure shows a table that displays category, order number, and sales data:  
  
 ![Design, table with one static, one dynamic row](../../Topics/TopicNameNotContainA/media/rs_TableHeaderStaticDesign.gif "rs_TableHeaderStaticDesign")  
  
 There are no dotted lines because the table consists only of the tablix body area. The first row displays column headers, and represents a static tablix member that is not associated with a group. The second row displays detail data, and represents a dynamic tablix member that is associated with the details group. The following figure shows the table in preview:  
  
 ![Preview, table with one static, one dynamic row](../../Topics/TopicNameNotContainA/media/rs_TableHeaderStaticPreview.gif "rs_TableHeaderStaticPreview")  
  
 To repeat or freeze column headings, set properties on the tablix member for static row that is part of the tablix data region definition. To select the static row, you must use the Advanced mode of the Grouping pane. The following figure shows the Row Groups pane:  
  
 ![Row Groups, table with 1 static, 1 dynamic row](../../Topics/TopicNameNotContainA/media/rs_TableHeaderStaticGroupingPaneDefault.gif "rs_TableHeaderStaticGroupingPaneDefault")  
  
 In Advanced mode, the following figure shows the static and dynamic tablix members for the row groups in the table:  
  
 ![Row Groups, Advanced for default table](../../Topics/TopicNameNotContainA/media/rs_TableHeaderStaticGroupingPaneAdvanced.gif "rs_TableHeaderStaticGroupingPaneAdvanced")  
  
 To repeat or freeze column headings for the tablix member, select the static row that is labeled (**Static**). The properties pane displays the properties for the selected tablix member. By setting properties for this tablix member, you can control how the first row repeats or stays in view.  
  
 [Return to top](#Top)  
  
###  <a name="TableRowGroupsGroupHeader"></a> Table with row groups and a row group area  
 If you add a row group to a simple table, a row group area is added to the table on the design surface. The following figure shows a table with a row group that is based on Category:  
  
 ![Design, table with one row group and details](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithGroupHeaderCellDesign.gif "rs_TableHeaderDynamicwithGroupHeaderCellDesign")  
  
 The dotted lines show the tablix row groups area and the tablix body area. The row group area has a row group header but no column group header. The following figure shows this table in preview:  
  
 ![Preview, table with one row group and details](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithGroupHeaderCellPreview.gif "rs_TableHeaderDynamicwithGroupHeaderCellPreview")  
  
 To repeat or freeze column headings, use the same approach as the previous example. The following figure shows the default view of the Row Groups pane:  
  
 ![Row Groups, Default with dynamic members](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicGroupingPaneDefault.gif "rs_TableHeaderDynamicGroupingPaneDefault")  
  
 Use the **Advanced** mode of the Row Groups pane to display the tablix members, as shown in the following figure:  
  
 ![Row Groups, Advanced mode with static members](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithGroupHeaderCellAdvanced.gif "rs_TableHeaderDynamicwithGroupHeaderCellAdvanced")  
  
 For tablix members are listed: **Static**, (**Static**), Category, and (**Details**). A tablix member that includes parentheses () indicates that there is no corresponding group header. To repeat or freeze column headings, select the top Static tablix member, and set properties in the Properties pane.  
  
 [Return to top](#Top)  
  
###  <a name="TableRowGroupsNoGroupHeader"></a> Table with row groups and no row group area  
 A table can have row groups but no row groups area in several ways. Two possible ways for this to happen include:  
  
-   Start with a table with row groups and a row group area and delete the columns for the row group area. Delete the columns only and not the groups. For example, you might want to control the table format to be a simple grid.  
  
-   Upgrade a report that was created for a previous RDL version, before tablix data regions were introduced.  
  
 The following figure shows a table with a row group but no row group area on the design surface:  
  
 ![Design, table has row group but no group header](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithNoGroupHeaderCellDesign.gif "rs_TableHeaderDynamicwithNoGroupHeaderCellDesign")  
  
 The table has three rows. The first row contains column headers. The second row contains the group value and subtotals. The third row contains the detail data. There are no dotted lines because there is only a tablix body area. The following figure shows this table in preview:  
  
 ![Preview, table has row group but no group header](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithNoGroupHeaderCellPreview.gif "rs_TableHeaderDynamicwithNoGroupHeaderCellPreview")  
  
 To control how the rows repeat or stay in view, you must set properties on the tablix member for each row. In default mode, there is no difference between this example and the previous example for a table with a row group and a group header. The following figure shows the Grouping pane in default mode for this table:  
  
 ![Row Groups, Default with dynamic members](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicGroupingPaneDefault.gif "rs_TableHeaderDynamicGroupingPaneDefault")  
  
 However, in advanced mode, this layout structure shows a different set of tablix members. The following figure shows the Grouping pane in advanced mode for this table:  
  
 ![Row Groups, Advanced, no group header.](../../Topics/TopicNameNotContainA/media/rs_TableHeaderDynamicwithNoGroupHeaderCellAdvanced.gif "rs_TableHeaderDynamicwithNoGroupHeaderCellAdvanced")  
  
 In the Row Groups pane, the following tablix members are listed: (**Static**), (Category), (**Static**), and (**Details**). To repeat or freeze column headings, select the top (**Static**) tablix member, and set properties in the Properties pane.  
  
 [Return to top](#Top)  
  
## Renderer Support for Repeating or Freezing Headers  
 Renderers vary in support for repeating or freezing headers.  
  
 Renderers that use physical pages (PDF, Image, Print) support the following features:  
  
-   Repeat row headers when a tablix data region expands horizontally across multiple pages.  
  
-   Repeat column headers when a tablix data region expands vertically down multiple pages.  
  
 In addition, renderers that use soft page breaks (Report Manager, report preview, or the report viewer control) support the following features:  
  
-   Keep row headers in view when you scroll horizontally across a report.  
  
-   Keep column headers in view when you scroll vertically down a report.  
  
 For more information, see [Rendering Behaviors (Report Builder  and SSRS)](../../Topics/TopicNameNotContainA/Rendering-Behaviors--Report-Builder--and-SSRS-.md).  
  
## See Also  
 [Filter, Group, and Sort Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Filter--Group--and-Sort-Data--Report-Builder-and-SSRS-.md)   
 [Tables, Matrices, and Lists (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Tables--Matrices--and-Lists--Report-Builder-and-SSRS-.md)   
 [Pagination in Reporting Services (Report Builder  and SSRS)](../../Topics/TopicNameNotContainA/Pagination-in-Reporting-Services--Report-Builder--and-SSRS-.md)   
 [Export Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Export-Reports--Report-Builder-and-SSRS-.md)