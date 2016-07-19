---
title: Calculation Tools (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c030c725-7763-4c23-9988-4b274a88fc31
manager: mblythe
---
# Calculation Tools (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)
Use the **Calculation Tools** pane on the **KPIs** tab in Cube Designer to explore metadata, functions, and templates available for use in Key Performance Indicators (KPIs).  
  
> [!NOTE]  
>  This pane is displayed only in form view.  
  
## Options  
 **Metadata**  
 Displays the metadata for the selected cube.  
  
 Drag a selected element to the **KPI Form Editor** pane to include the Multidimensional Expressions (MDX) syntax for that element at the selected location in the pane.  
  
 **Functions**  
 Displays the functions available for expressions and conditions.  
  
 Drag a selected element to the **KPI Form Editor** pane to include the MDX syntax for that element at the selected location in the pane.  
  
> [!NOTE]  
>  In project mode, the **Calculation Tools** dialog box reads information for this option from an XML file named MDXFunctions.xml, included with [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)]. In online mode, information for this option is retrieved from the MDSCHEMA_FUNCTIONS schema rowset for the instance.  
  
 **Templates**  
 Displays the predefined templates available for KPIs.  
  
 Drag a selected element to the **KPI Form Editor** pane to include the MDX syntax for that element at the selected location in the pane.  
  
## Context Menu  
 The following options are available in the context menu displayed by right-clicking an element in the **Calculation Tools** pane:  
  
 **Copy**  
 Select to copy the selected element in **Metadata** or **Functions** to the Clipboard.  
  
> [!NOTE]  
>  This option is not displayed if **Templates** is selected.  
  
> [!NOTE]  
>  This option is disabled if the selected member cannot be copied, such as the **Sets** folder of a dimension displayed in **Metadata** or the function group folder for a function displayed in **Functions**.  
  
 **Filter Members**  
 Select to display the **Filter Members** dialog box and filter members displayed for the selected element in **Metadata**. For more information about the **Filter Members** dialog box, see [Filter Members Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Filter-Members-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).  
  
> [!NOTE]  
>  This option is displayed only if **Metadata** is selected.  
  
> [!NOTE]  
>  This option is enabled only if a level for an attribute is selected in **Metadata**.  
  
 **Add Template**  
 Select to add a new calculated member, named set, or script command based on the selected template to the cube script and display the **KPI Form Editor** in form view.  
  
> [!NOTE]  
>  This option is displayed only if **Metadata** is selected.  
  
## See Also  
 [Cube Designer (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Cube-Designer--Analysis-Services---Multidimensional-Data-.md)   
 [KPIs (Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/KPIs--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)   
 [Toolbar (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Toolbar--KPIs-Tab--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)   
 [KPI Organizer (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/KPI-Organizer--KPIs-Tab--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)   
 [KPI Form Editor (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/KPI-Form-Editor--KPIs-Tab--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)   
 [KPI Browser (KPIs Tab, Cube Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/KPI-Browser--KPIs-Tab--Cube-Designer---Analysis-Services---Multidimensional-Data-.md)