---
title: "Virtual Mode in the DataRepeater Control (Visual Studio)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - virtual data binding
  - DataRepeater
  - DataRepeater, virtual mode
ms.assetid: 5fb805dc-2d8b-4139-b1e3-86e4c2667221
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Virtual Mode in the DataRepeater Control (Visual Studio)
When you want to display large quantities of tabular data in a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control, you can improve performance by setting the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.VirtualMode?qualifyHint=False> property to `True` and explicitly managing the control's interaction with its data source. The <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control provides several events that you can handle to interact with your data source and display the data as needed at run time.  
  
## How Virtual Mode Works  
 The most common scenario for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control is to bind the child controls of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate?qualifyHint=False> to a data source at design time and allow the <xref:System.Windows.Forms.BindingSource?qualifyHint=False> to pass data back and forth as needed. When you use virtual mode, the controls are not bound to a data source, and data is passed back and forth to the underlying data source at run time.  
  
 When the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.VirtualMode?qualifyHint=False> property is set to `True`, you create the user interface by adding controls from the **Toolbox** instead of adding bound controls from the **Data Sources** window.  
  
 Events are raised on a control-by-control basis, and you must add code to handle the display of data. When a new <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> is scrolled into view, the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValueNeeded?qualifyHint=False> event is raised one time for each control and you must supply the values for each control in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValueNeeded?qualifyHint=False> event handler.  
  
 If data in one of the controls is changed by the user, the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValuePushed?qualifyHint=False> event is raised and you must validate the data and save it to your data source.  
  
 If the user adds a new item, the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.NewItemNeeded?qualifyHint=False> event is raised. Use this event's handler to create a new record in your data source. To prevent unintended changes, you must also monitor the <xref:System.Windows.Forms.Control.KeyDown?qualifyHint=False> event for each control and call <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.CancelEdit?qualifyHint=False> if the user presses the ESC key.  
  
 If your data source changes, you can refresh the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control by calling the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.BeginResetTemplateItem?qualifyHint=False> and <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.EndResetTemplateItem?qualifyHint=False> methods. Both methods must be called in order.  
  
 Finally, you must implement event handlers for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemsRemoved?qualifyHint=False> event, which occurs when an item is deleted, and optionally for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.UserDeletingItems?qualifyHint=False> and <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.UserDeletedItems?qualifyHint=False> events, which occur whenever a user deletes an item by pressing the DELETE key.  
  
## Implementing Virtual Mode  
 Following are the steps that are required to implement virtual mode.  
  
#### To implement virtual mode  
  
1.  Drag a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control from the **Visual Basic PowerPacks** tab in the **Toolbox** to a form or container control. Set the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.VirtualMode?qualifyHint=False> property to `True`.  
  
2.  Drag controls from the **Toolbox** onto the item template region (the upper region) of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control. You will need one control for each field in your data source that you want to display.  
  
3.  Implement a handler for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValueNeeded?qualifyHint=False> event to provide values for each control. This event is raised when a new <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> is scrolled into view. The code will resemble the following example, which is for a data source named `Employees`.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#1](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_1.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#1](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_1.cs)]
  
  
4.  Implement a handler for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValuePushed?qualifyHint=False> event to store the data. This event is raised when the user commits changes to a child control of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False>. The code will resemble the following example, which is for a data source named `Employees`.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#2](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_2.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#2](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_2.cs)]
  
  
5.  Implement a handler for each child control's <xref:System.Windows.Forms.Control.KeyDown?qualifyHint=False> event and monitor the ESC key. Call the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.CancelEdit?qualifyHint=False> method to prevent the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValuePushed?qualifyHint=False> event from being raised. The code will resemble the following example.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#3](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_3.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#3](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_3.cs)]
  
  
6.  Implement a handler for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.NewItemNeeded?qualifyHint=False> event. This event is raised when the user adds a new item to the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control. The code will resemble the following example, which is for a data source named `Employees`.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#4](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_4.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#4](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_4.cs)]
  
  
7.  Implement a handler for the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemsRemoved?qualifyHint=False> event. This event occurs when a user deletes an existing item. The code will resemble the following example, which is for a data source named `Employees`.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#5](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_5.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#5](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_5.cs)]
  
  
8.  For control-level validation, optionally implement handlers for the <xref:System.Windows.Forms.Control.Validating?qualifyHint=False> events of the child controls. The code will resemble the following example.  
  
     [!code[VbPowerPacksDataRepeaterVirtualMode#6](../vs140/codesnippet/VisualBasic/virtual-mode-in-the-datarepeater-control--visual-studio-_6.vb)]
[!code[VbPowerPacksDataRepeaterVirtualMode#6](../vs140/codesnippet/CSharp/virtual-mode-in-the-datarepeater-control--visual-studio-_6.cs)]
  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValuePushed?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.NewItemNeeded?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemValueNeeded?qualifyHint=False>   
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)