---
title: Toolbar (Browser Tab, Cube Designer) (Analysis Services - Multidimensional Data)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a1c6272d-e514-456b-9995-b73fec0112a2
manager: mblythe
---
# Toolbar (Browser Tab, Cube Designer) (Analysis Services - Multidimensional Data)
Use the features in the **Toolbar** in Cube Designer to perform common operations while designing or browsing a cube or its object, or when creating an MDX query. Operations that are common to both design time and query view include setting the user context, processing objects, and setting the default language.  
  
 The following table lists the **Toolbar** buttons and their functions.  
  
|Button|Description|  
|------------|-----------------|  
|**Edit As Text**|Not enabled for this data source type.|  
|**Import**|Import an existing query from a report definition (.rdl) file on the file system.|  
|![Change to MDX query view](../../Topics/TopicNameNotContainA/media/rsQDIcon_CommandTypeMDX.gif "rsQDIcon_CommandTypeMDX")|Switch to Command Type MDX.|  
|![Refresh result data](../../Topics/TopicNameNotContainA/media/rsQDIcon_Refresh.gif "rsQDIcon_Refresh")|Refresh metadata from the data source.|  
|![Add calculated member](../../Topics/TopicNameNotContainA/media/rsQDIcon_AddCalculatedMember.gif "rsQDIcon_AddCalculatedMember")|Display the **Calculated Member Builder** dialog box.|  
|![Toggle for show empty cells](../../Topics/TopicNameNotContainA/media/rsQDIcon_ShowEmptyCells.gif "rsQDIcon_ShowEmptyCells")|Toggle between showing and not showing empty cells in the Data pane. (This is the equivalent to using the NON EMPTY clause in MDX).|  
|![AutoExecute the query](../../Topics/TopicNameNotContainA/media/rsQDIcon_AutoExecute.gif "rsQDIcon_AutoExecute")|Automatically run the query and show the result every time a change is made. Results are shown in the Data pane.|  
|![Show Aggregations button](../../Topics/TopicNameNotContainA/media/rsQDIcon_ShowAggregations.gif "rsQDIcon_ShowAggregations")|Show aggregations in the Data pane.|  
|![Delete](../../Topics/TopicNameNotContainA/media/rsQDIcon_Delete.gif "rsQDIcon_Delete")|Delete the selected column in the Data pane from the query.|  
|![Icon for the Query Parameters dialog box](../../Topics/TopicNameNotContainA/media/IconQueryParameter.gif "IconQueryParameter")|Display the **Query Parameters** dialog box. When you specify values for a query parameter, a parameter with the same name is automatically created.|  
|![Prepare Query button](../../Topics/TopicNameNotContainA/media/rsQDIcon_PrepareQuery.gif "rsQDIcon_PrepareQuery")|Prepare the query.|  
|![Run the query](../../Topics/TopicNameNotContainA/media/rsQDIcon_Run.gif "rsQDIcon_Run")|Run the query and display the results in the Data pane.|  
|![Cancel the query](../../Topics/TopicNameNotContainA/media/rsQDIcon_Cancel.gif "rsQDIcon_Cancel")|Cancel the query.|  
|![Switch to Design mode](../../Topics/TopicNameNotContainA/media/rsQDIcon_DesignMode.gif "rsQDIcon_DesignMode")|Toggle between Design mode and Query mode.|  
  
 In general, the toolbar buttons are the same for **Design Mode** and **Query Mode**. However, the following buttons are not enabled for Query mode:  
  
-   **Edit As Text**  
  
-   **Add Calculated Member** (![Add calculated member](../../Topics/TopicNameNotContainA/media/rsQDIcon_AddCalculatedMember.gif "rsQDIcon_AddCalculatedMember"))  
  
-   **Show Empty Cells** (![Toggle for show empty cells](../../Topics/TopicNameNotContainA/media/rsQDIcon_ShowEmptyCells.gif "rsQDIcon_ShowEmptyCells"))  
  
-   **AutoExecute** (![AutoExecute the query](../../Topics/TopicNameNotContainA/media/rsQDIcon_AutoExecute.gif "rsQDIcon_AutoExecute"))  
  
-   **Show Aggregations** (![Show Aggregations button](../../Topics/TopicNameNotContainA/media/rsQDIcon_ShowAggregations.gif "rsQDIcon_ShowAggregations"))  
  
## Options  
  
|Option|Description|  
|------------|-----------------|  
|**Process**|Click to display the **Process** dialog box and process the cube. For more information about the **Process** dialog box, see [Process Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Process-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).|  
|**Change User**|Click to display the **Security Context** dialog box and change the user and role used on the **Browser** tab. For more information about the **Security Context** dialog box, see [Security Context Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Security-Context-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).|  
|**Reconnect**|Click to reconnect the **Calculations** tab to the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance and database that contains the cube, if the session for the **Browser** tab is disconnected due to connection loss or timeout.|  
|**Refresh**|Click to refresh the **Metadata** and **Reports** panes.|  
|**Sort Ascending**|Click to sort the siblings of the selected row in the **Report** pane in ascending order for the language specified in **Language**.<br /><br /> Note: This option is enabled only if a cell in the **Reports** pane is selected.|  
|**Sort Descending**|Click to sort the siblings of the selected row in the **Report** pane in descending order for the language specified in **Language**.<br /><br /> Note: This option is enabled only if a cell in the **Reports** pane is selected.|  
|**Auto Filter**|Click to automatically filter the results in the **Result** pane.|  
|**Show Only Top/Bottom**|Select a value or percentage to show only the topmost or bottommost number or percentage of cells in the **Report** pane based on the selected measure.<br /><br /> For more information about this option, see [TopCount (MDX)](assetId:///15026a8f-35c5-4307-8856-348f5c44bfd5), [TopPercent (MDX)](assetId:///a40cfbb8-5bf4-4ae2-8686-df9a07206d56), [BottomCount (MDX)](assetId:///1441dab3-7885-4e92-9d48-21d832286677), and [BottomPercent (MDX)](assetId:///c04866e6-e6dd-4ed1-ae79-c718c194930c).|  
|**Subtotal**|Click to display subtotals.|  
|**All Item Totals**|Click to display the totals for All members in the **Report** pane.|  
|**Show Empty Cells**|Click to display empty cells in the **Report** pane.|  
|**Clear Results**|Click to clear the results in the **Report** pane.|  
|**Commands and Options**|Click to display the **Commands and Options** dialog box and edit advanced properties for the Microsoft Office 11.0 PivotTable control in the **Report** pane. For more information about the **Commands and Options** dialog box, see the Microsoft Office documentation.|  
|**Perspective**|Select the perspective from which to view data and metadata in the **Metadata** and **Report** panes.<br /><br /> To view the cube without using a perspective, select the cube name.|  
|**Language**|Select the language with which to view data and metadata in the **Metadata** and **Report** panes.<br /><br /> To view the cube using the default language, select **Default**.|