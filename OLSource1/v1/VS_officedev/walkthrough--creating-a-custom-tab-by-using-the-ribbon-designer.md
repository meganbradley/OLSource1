---
title: "Walkthrough: Creating a Custom Tab by Using the Ribbon Designer"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "actions panes [Office development in Visual Studio], controlling from Ribbon"
  - "Ribbon [Office development in Visual Studio], customizing"
  - "Ribbon Designer [Office development in Visual Studio]"
  - "customizing the Ribbon, tabs"
  - "custom Ribbon, tabs"
  - "Custom tab [Office development in Visual Studio]"
ms.assetid: 312865e6-950f-46ab-88de-fe7eb8036bfe
caps.latest.revision: 68
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Walkthrough: Creating a Custom Tab by Using the Ribbon Designer
  By using the Ribbon Designer, you can create a custom tab and then add and position controls on it.  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   [Creating Actions Panes](#BKMK_CreateActionsPanes).  
  
-   [Creating a Custom Tab](#BKMK_CreateCustomTab).  
  
-   [Hiding and Showing Actions Panes by Using Buttons on the Custom Tab](#BKMK_HideShowActionsPane).  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   Microsoft Excel  
  
## Creating an Excel Workbook Project  
 The steps for using the Ribbon Designer are almost identical for all Office applications. This example uses an Excel workbook.  
  
#### To create an Excel workbook project  
  
-   Create an Excel workbook project with the name **MyExcelRibbon**. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new workbook in the designer and adds the **MyExcelRibbon** project to **Solution Explorer**.  
  
##  <a name="BKMK_CreateActionsPanes"></a> Creating Actions Panes  
 Add two custom actions panes to the project. You will later add buttons that show and hide these actions panes to the custom tab.  
  
#### To create actions panes  
  
1.  On the **Project** menu, choose **Add New Item**.  
  
2.  In the **Add New Item** dialog box, select **ActionsPaneControl**, and then choose **Add**.  
  
     The **ActionsPaneControl1.cs** or **ActionsPaneControl1.vb** file opens in the designer.  
  
3.  From the **Common Controls** tab of the **Toolbox**, add a label to the designer surface.  
  
4.  In the **Properties** window, set the **Text** property of label1 to **Actions Pane 1**.  
  
5.  Repeat steps 1 through 5 to create a second actions pane and label. Set the **Text** property of the second label to **Actions Pane 2**.  
  
##  <a name="BKMK_CreateCustomTab"></a> Creating a Custom Tab  
 One of the Office application design guidelines is that users should always have control of the Office application UI. To add this capability for the actions panes, you can add buttons that show and hide each actions pane from a custom tab on the ribbon. To create a custom tab, add a **Ribbon (Visual Designer)** item to the project. The designer helps you add and position controls, set control properties, and handle control events.  
  
#### To create a custom tab  
  
1.  On the **Project** menu, choose **Add New Item**.  
  
2.  In the **Add New Item** dialog box, select **Ribbon (Visual Designer)**.  
  
3.  Change the name of the new ribbon to **MyRibbon**, and choose **Add**.  
  
     The **MyRibbon.cs** or **MyRibbon.vb** file opens in the Ribbon Designer and displays a default tab and group.  
  
4.  In the Ribbon Designer, choose the default tab.  
  
5.  In the **Properties** window, expand the **ControlId** property, and then set the **ControlIdType** property to **Custom**.  
  
6.  Set the **Label** property to **My Custom Tab**.  
  
7.  In the Ribbon Designer, choose **group1**.  
  
8.  In the **Properties** window, set **Label** to **Actions Pane Manager**.  
  
9. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a button onto **group1**.  
  
10. Select **button1**.  
  
11. In the **Properties** window, set **Label** to **Show Actions Pane 1**.  
  
12. Add a second button to **group1**, and set the **Label** property to **Show Actions Pane 2**.  
  
13. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a **ToggleButton** control onto **group1**.  
  
14. Set the **Label** property to **Hide Actions Pane**.  
  
##  <a name="BKMK_HideShowActionsPane"></a> Hiding and Showing Actions Panes by Using Buttons on the Custom Tab  
 The last step is to add code that responds to the user. Add event handlers for the \<xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> events of the two buttons and the \<xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click> event of the toggle button. Add code to these event handlers to enable hiding and showing the actions panes.  
  
#### To hide and show actions panes by using buttons in the custom tab  
  
1.  In **Solution Explorer**, open the shortcut menu for MyRibbon.cs or MyRibbon.vb, and then choose **View Code**.  
  
2.  Add the following code to the top of the `MyRibbon` class. This code creates two actions pane objects.  
  
     [!code[Trin_Ribbon_Custom_Tab#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_1.cs)]
[!code[Trin_Ribbon_Custom_Tab#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_1.vb)]  
  
3.  Replace the `MyRibbon_Load` method with the following code. This code adds the actions pane objects to the \<xref:Microsoft.Office.Tools.ActionsPane.Controls*> collection and hides the objects from view. The Visual C# code also attaches delegates to several ribbon control events.  
  
     [!code[Trin_Ribbon_Custom_Tab#2](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_2.cs)]
[!code[Trin_Ribbon_Custom_Tab#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_2.vb)]  
  
4.  Add the following three event handler methods to the `MyRibbon` class. These methods handle the \<xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> events of the two buttons and the \<xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click> event of the toggle button. The event handlers for button1 and button2 show alternate actions panes. The event handler for toggleButton1 shows and hides the active actions pane.  
  
     [!code[Trin_Ribbon_Custom_Tab#3](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_3.cs)]
[!code[Trin_Ribbon_Custom_Tab#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer_3.vb)]  
  
## Testing the Custom Tab  
 When you run the project, Excel starts, and the **My Custom Tab** tab appears on the ribbon. Choose the buttons on **My Custom Tab** to show and hide the actions panes.  
  
#### To test the custom tab  
  
1.  Press F5 to run your project.  
  
2.  Choose the **My Custom Tab** tab.  
  
3.  In the **Custom Actions Pane Manager** group, choose **Show Actions Pane 1**.  
  
     The actions pane appears and displays the label **Actions Pane 1**.  
  
4.  Choose **Show Actions Pane 2**.  
  
     The actions pane appears and displays the label **Actions Pane 2**.  
  
5.  Choose **Hide Actions Pane**.  
  
     The actions panes are no longer visible.  
  
## Next Steps  
 You can learn more about how to customize the Office UI from these topics:  
  
-   Add context-based UI to any document-level customization. For more information, see [Actions Pane Overview](../VS_officedev/actions-pane-overview.md).  
  
-   Extend a standard or custom Microsoft Office Outlook form. For more information, see [Walkthrough: Designing an Outlook Form Region](../VS_officedev/walkthrough--designing-an-outlook-form-region.md).  
  
## See Also  
 [Accessing the Ribbon at Run Time](../VS_officedev/accessing-the-ribbon-at-run-time.md)   
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Customizing a Ribbon for Outlook](../VS_officedev/customizing-a-ribbon-for-outlook.md)   
 [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md)   
 [How to: Change the Position of a Tab on the Ribbon](../VS_officedev/how-to--change-the-position-of-a-tab-on-the-ribbon.md)   
 [How to: Customize a Built-in Tab](../VS_officedev/how-to--customize-a-built-in-tab.md)   
 [How to: Add Controls to the Backstage View](../VS_officedev/how-to--add-controls-to-the-backstage-view.md)   
 [Ribbon Object Model Overview](../VS_officedev/ribbon-object-model-overview.md)  
  
  