---
title: "Troubleshooting the DataRepeater Control (Visual Studio)"
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
  - DataRepeater, troubleshooting
ms.assetid: c0ab9469-eced-4f52-aa18-4bd8dd4f1a9a
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting the DataRepeater Control (Visual Studio)
This topic lists common issues that may occur when you are working with the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control.  
  
## DataRepeater Keyboard and Mouse Events Are Not Raised  
 Some <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control events, such as keyboard and mouse events, are not raised. This is by design. The <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control itself is a container for <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> objects and cannot be accessed at run time. The <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> does not expose events at design time. Therefore, clicking an item or pressing a key when the item has focus does not raise an event.  
  
 The exception to this is when the <xref:System.Windows.Forms.Control.Padding?qualifyHint=False> property is set to a large enough value to expose the edges of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control. In this case, clicking in the exposed margin will raise mouse events.  
  
 To resolve this issue, add a <xref:System.Windows.Forms.Panel?qualifyHint=False> control to the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate?qualifyHint=False> section of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control, and then add the rest of the controls to the <xref:System.Windows.Forms.Panel?qualifyHint=False>. You can then add code to the <xref:System.Windows.Forms.Panel?qualifyHint=False> control's event handlers for keyboard and mouse events.  
  
## The DataRepeater Is Partially Hidden Behind the Binding Navigator  
 When you first add a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control to a form and then add data-bound controls from the **Data Sources** window, the <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False> control may appear on top of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control. This is a known limitation of the **Data Sources** window and is consistent with the behavior of other controls, such as the <xref:System.Windows.Forms.DataGridView?qualifyHint=False> control.  
  
 You can either move the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> lower than the <xref:System.Windows.Forms.BindingNavigator?qualifyHint=False> control at design time, or add code resembling the following in the `Load` event handler.  
  
```vb#  
DataRepeater1.Top = ProductsBindingNavigator.Height  
```  
  
```c#  
dataRepeater1.Top = productsBindingNavigator.Height;  
```  
  
## Controls Are Not Displayed Correctly at Run Time  
 Some controls in a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control may not be displayed as expected at run time. The process used to clone controls from the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemTemplate?qualifyHint=False> to the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> cannot always determine all the properties of all controls. For example, if you add an unbound <xref:System.Windows.Forms.ListBox?qualifyHint=False> control to a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control at design time and populate its <xref:System.Windows.Forms.ListBox.Items?qualifyHint=False> collection with a list of strings, the <xref:System.Windows.Forms.ListBox?qualifyHint=False> will be empty at run time. This is because the cloning process cannot take into account the <xref:System.Windows.Forms.ListBox.Items?qualifyHint=False> property.  
  
 You can fix problems such as this by restoring the missing properties in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemCloned?qualifyHint=False> event, which occurs after the default cloning is completed. The following example demonstrates how to repair the <xref:System.Windows.Forms.ListBox.Items?qualifyHint=False> collection of a <xref:System.Windows.Forms.ListBox?qualifyHint=False> control in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemCloned?qualifyHint=False> event handler.  
  
 [!code[VbPowerPacksDataRepeaterItemCloned#1](../vs140/codesnippet/CSharp/troubleshooting-the-datarepeater-control--visual-studio-_1.cs)]
[!code[VbPowerPacksDataRepeaterItemCloned#1](../vs140/codesnippet/VisualBasic/troubleshooting-the-datarepeater-control--visual-studio-_1.vb)]
  
  
## The Selection Symbol on the Item Header Is Missing  
 When you change the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.SelectionColor?qualifyHint=False> property of the item header in a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control, some color choices may cause the selection symbol to disappear. Changing the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemHeaderSize?qualifyHint=False> property may also cause the selection symbol to disappear.  
  
 The color and size of the selection symbol cannot be changed.  
  
-   If you set the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.SelectionColor?qualifyHint=False> to <xref:System.Drawing.Color.White?qualifyHint=False>, the selection symbol will not be visible when an item is first selected.  
  
-   If you set the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.SelectionColor?qualifyHint=False> to <xref:System.Drawing.Color.Black?qualifyHint=False>, the selection symbol will not be visible when a control is selected, and the pencil symbol will not be visible when a control is in edit mode.  
  
-   If the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.ItemHeaderSize?qualifyHint=False> property is set to a value that is less than 11, the indicator symbols in the item header will not be displayed.  
  
 You can provide your own item header and selection symbol by using a <xref:System.Windows.Forms.PictureBox?qualifyHint=False> control and monitoring the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem.IsCurrent?qualifyHint=False> property of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem?qualifyHint=False> in the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.DrawItem?qualifyHint=False> event of the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater?qualifyHint=False> control. For more information, see <xref:Microsoft.VisualBasic.PowerPacks.DataRepeaterItem.IsCurrent?qualifyHint=False>.  
  
## See Also  
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [How to: Display Bound Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-bound-data-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Display Unbound Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-unbound-controls-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Change the Layout of a DataRepeater Control (Visual Basic)](../vs140/how-to--change-the-layout-of-a-datarepeater-control--visual-studio-.md)   
 [How to: Change the Appearance of a DataRepeater Control (Visual Basic)](../vs140/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-.md)   
 [How to: Display Item Headers in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-item-headers-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Disable Adding and Deleting DataRepeater Items (Visual Basic)](../vs140/how-to--disable-adding-and-deleting-datarepeater-items--visual-studio-.md)   
 [How to: Search Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--search-data-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Create a Master/Detail Form by Using Two DataRepeater Controls (Visual Basic)](../vs140/how-to--create-a-master-detail-form-by-using-two-datarepeater-controls--visual-studio-.md)