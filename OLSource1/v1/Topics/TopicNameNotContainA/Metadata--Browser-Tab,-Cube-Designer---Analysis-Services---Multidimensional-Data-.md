---
title: Metadata (Browser Tab, Cube Designer) (Analysis Services - Multidimensional Data)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a1ace545-488d-4645-8330-56408a5e8abd
---
# Metadata (Browser Tab, Cube Designer) (Analysis Services - Multidimensional Data)
  Use the **Metadata** pane on the **Browser** tab in Cube Designer to browse the structure of the cube, to see related measures, and to view and create dimensions. You can drill down into hierarchies, view a list of available measures and KPIs, and copy the fully qualified names of objects.  
  
 You can also drag the objects and hierarchies in the **Metadata** pane to the query building area, to create new queries or export data for browsing in Excel.  
  
## Options  
 **Metadata**  
 Displays the metadata available in the current view. You can change the view \(that is, the currently selected perspective or cube\) by clicking the cube icon, and then using the **Cube Selection** dialog box to choose a new cube or perspective. You can also click **Measure Group**, and select a new measure group from the dropdown list to filter the objects that are available in the **Metadata** pane.  
  
 Drag selected items to the filter, data, row, or column areas of the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Office 11.0 PivotTable control in the **Report** pane to display the data for the selected item.  
  
 **Functions**  
 Displays a list of all functions, operators, and constants that can be used to create queries or data views in the **Browser**. To use a function, locate the one you want, and drag it into the query area. The syntax definition is added to the text  
  
> [!WARNING]  
>  The **Function** list is not available when you are working in graphical design view.  
  
 When working with a tabular model, the list of functions includes both MDX functions and DAX functions. Otherwise, the list includes only MDX. A multidimensional model cannot use DAX functions directly, although a DAX expression might be included as part of an object definition.  
  
 Tip: The folders that contain DAX functions are listed in all upper\-case letters. All other folders contain MDX functions. For example, there are two folders for statistical functions: **STATISTICAL** contains the related DAX functions.  
  
## Context Menu  
 The following options are available in the context menu displayed by right\-clicking an element displayed in the **Metadata** pane:  
  
|Option|Description|  
|------------|-----------------|  
|**Add to Query**|Click to add the selected object to the lower pane of the query building area.|  
|**Add to Filter**|Click to add the selected dimension, attribute, hierarchy, or level to the filter area of the **Browser**.<br /><br /> Note: This option is enabled only if a dimension, attribute, hierarchy, or level is selected.|  
|**Copy**|Click to add the selected item to the Clipboard.<br /><br /> Note: This option copies the fully qualified name of the object.|  
  
## See Also  
 [Toolbar &#40;Browser Tab, Cube Designer&#41; &#40;Analysis Services - Multidimensional Data&#41;](../Topic/Toolbar%20\(Browser%20Tab,%20Cube%20Designer\)%20\(Analysis%20Services%20-%20Multidimensional%20Data\).md)   
 [Analyze in Excel &#40;Browser Tab, Cube Designer&#41; &#40;Analysis Services - Multidimensional Data&#41;](../Topic/Analyze%20in%20Excel%20\(Browser%20Tab,%20Cube%20Designer\)%20\(Analysis%20Services%20-%20Multidimensional%20Data\).md)   
 [Query and Filter &#40;Browser Tab, Cube Designer&#41; &#40;Analysis Services - Multidimensional Data&#41;](../Topic/Query%20and%20Filter%20\(Browser%20Tab,%20Cube%20Designer\)%20\(Analysis%20Services%20-%20Multidimensional%20Data\).md)   
 [Browser &#40;Cube Designer&#41; &#40;Analysis Services - Multidimensional Data&#41;](../Topic/Browser%20\(Cube%20Designer\)%20\(Analysis%20Services%20-%20Multidimensional%20Data\).md)  
  
  