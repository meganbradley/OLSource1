---
title: "Reference: Screen Designer Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "screens [Visual Studio LightSwitch], properties"
  - "screen properties [Visual Studio LightSwitch]"
  - "screens [Visual Studio LightSwitch], configuring"
  - "screens [Visual Studio LightSwitch], Properties window"
ms.assetid: dd926140-3a99-4093-b193-ae0a4b1f79db
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference: Screen Designer Properties
You can modify the appearance and behavior of a screen by setting the value of properties in the **Properties** window. The following tables describe each property.  
  
## General Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Data Binding**|The source of data for the control.|  
|**Use Read-only Controls**|Indicates whether the sub controls that are contained within the control can be edited by the user. For example, if you select **Use Read-only Controls** for a data grid control, users will not be able to edit the fields that appear in the data grid.|  
|**Description**|The text that appears as a tooltip when users point to the control by using the mouse.|  
|**Display Name**|The name that appears in the screen.|  
|**Query Source**|Applies to collections on a screen only. The data source of a collection on the screen.|  
|**Is Visible**|Indicates whether the control appears in the screen.|  
|**Name**|The name used by [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)], and that you use to refer to this control in custom code.|  
|**Control Type**|The type of control that you want to use. For more information about each control type, see the following sections:<br /><br /> -   [Control Types for a Group](#grouptype)<br />-   [Control Types for a Field](#controltype)|  
|**Property Type**|The type of data that appears in the control.|  
|**Auto Execute Query**|Applies to collections on a screen only. Indicates whether the query that populates the collection runs when the screen that contains the collection is opened.|  
|**Support Paging**|Indicates whether the data in a collection appears as pages of information. If you select this property, set the number of items that appear in a page by setting the **No. of items to display per page** property.|  
|**No. of items to display per page**|Applies to collections on a screen only. The number of items you want a page of information to contain.|  
|**Support Sorting**|Applies to collections on a screen only. Indicates whether you want users to be able to sort information in a collection by clicking column headings in the control that displays the collection.|  
|**Support Search**|Applies to collections on a screen only. Indicates whether you want the search box to appear above a collection in a screen.|  
  
## Appearance Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Label Position**|The location of the label of the control relative to the control. For more information about each label position setting, see [Label Position Settings](../VS_csharp/reference--screen-designer-properties.md#labelposition).|  
|**Rows**|The number of rows that appears in the control.|  
|**Text Alignment**|The position of the text within a control.|  
|**Use Small Button**|Indicates whether to use small buttons for screen commands (For example: the **Save** button).|  
|**Show as Link**|Indicates whether to make a label a hyperlink. Users can click the link to open a page.|  
|**Target Screen**|The screen that opens when the user clicks a label that is formatted as a hyperlink.|  
|**Font Style**|The font style of a label.|  
|**Disable Export to Excel**|Indicates whether to enable users to export the data that appears in a collection. If you select this property, the **Export to Excel** button will not appear above the collection in the running application.|  
|**Horizontal Scroll Enabled**|Specifies whether horizontal scrollbars can appear for the selected group.|  
|**Vertical Scroll Enabled**|Specifies whether vertical scrollbars can appear for the selected group.|  
|**Maximum Label Width**|Specifies the maximum width.|  
|**Image**|Specifies a .png or .jpg file to display as a static image.|  
|**Stretch**|Specifies how an image should be stretched to fit in the available space.|  
|**Show Border**|Specifies whether a border should appear around an image.|  
|**Text**|Specifies the text to appear in a **Static Label**.|  
|**Border Mode**|Specifies how borders will appear in a **Group Box**.|  
|**Show Display Name**|Specifies whether the **Display Name** appears in a **Group Box**.|  
  
##  <a name="grouptype"></a> Control Types for a Group  
  
|Name|Description|  
|----------|-----------------|  
|**Summary**|Displays the data that you specify in rows. Only one field of data is displayed in each row. You can specify which field appears by setting the **Summary Property** property of the entity or table in the data designer.  For more information, see [Reference: Data Designer Properties](../VS_csharp/reference--data-designer-properties.md).|  
|**Modal Window**|Adds a button to the screen that opens a modal window when clicked.|  
|**Rows Layout**|Displays the data you specify in rows.|  
|**Columns Layout**|Displays the data you specify in columns.|  
|**Table Layout**|Displays the data that you specify in a table. Apply the **TableColumn Layout** to groups in a **Table Layout**.|  
|**TableColumn Layout**|Displays data in a group within a **Table Layout**.|  
|**Tabs Layout**|Displays the data you specify in tabs.|  
|**Picture and Text**|Displays a picture on the left, and a title, subtitle, and description to the right of the picture.|  
|**Text and Picture**|Displays a title, subtitle, and description on the left, and a picture to the right of the text.|  
|**Address Viewer**|Displays a street address.|  
|**Address Editor**|Displays a street address that is editable.|  
|**Group Box**|Displays a frame around a group of controls with an optional caption.|  
  
##  <a name="controltype"></a> Control Types for a Field  
  
|Name|Description|  
|----------|-----------------|  
|**Text Box**|A rectangular box in which the user can type text. If the box already contains text, the user can select that default text or delete it and type new text.|  
|**Label**|Text that the user cannot edit.|  
|**Static Label**|Displays text that isn’t bound to a data source.|  
|**Custom Control**|A control created outside of the [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] development environment. For more information, see [How to: Add a Custom Control to a Screen](../VS_csharp/how-to--add-a-custom-control-to-a-silverlight-screen.md).|  
|**Date Time Picker**|Enables the user to select a date and time.|  
|**Date Picker**|Enables the user to select a date|  
|**Date Time Viewer**|Provides a read-only control that displays the date and time.|  
|**Date Viewer**|Provides a read-only control that displays the date.|  
|**Image Editor**|Enables the user to remove an image or select a new image.|  
|**Image Viewer**|Provides a read-only control that displays an image.|  
|**Static Image**|Displays an image that isn’t bound to a data source.|  
  
##  <a name="labelposition"></a> Label Position Settings  
  
|Label position|Description|  
|--------------------|-----------------|  
|**Left-aligned**|The label appears to the left of the control.|  
|**Right-aligned**|The label appears to the right of the control.|  
|**Top**|The label appears above the control.|  
|**Bottom**|The label appears below the control.|  
|**None**|No label appears for the selected data field.|  
|**Collapsed**|The label appears as collapsed.|  
  
##  <a name="contentsize"></a> Sizing Settings  
  
|Content size|Description|  
|------------------|-----------------|  
|**Horizontal Alignment**|The position of the control within the horizontal space that is allocated for the control. **Note:**  When **Alignment** is set to **Stretch**, **Width** settings are ignored. You can still specify a maximum and minimum size.|  
|**Vertical Alignment**|The position of the control within the vertical space that is allocated for the control. **Note:**  When **Alignment** is set to **Stretch**, **Height** settings are ignored. You can still specify a maximum and minimum size.|  
|**Width**|The width of the control. You can specify the width in terms of the number of pixels or the number of characters. You can also enable [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] to use an optimal size by selecting **Auto**. If you select **Auto**, you can provide a maximum and minimum size.|  
|**Height**|The height of the control. You can specify the height in terms of the number of pixels or the number of lines. You can also enable [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] to use an optimal size by selecting **Auto**. If you select **Auto**, you can provide a maximum and minimum size.|  
  
## See Also  
 [Reference: Data Designer Properties](../VS_csharp/reference--data-designer-properties.md)   
 [Reference: Query Designer Properties](../VS_csharp/reference--query-designer-properties.md)   
 [Screens: The User Interface of Your Application](../VS_csharp/screens--the-user-interface-of-your-lightswitch-application.md)