---
title: "Walkthrough: Creating a Web Part for SharePoint by Using a Designer"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Web Parts [SharePoint development in Visual Studio], designer"
  - "Web Parts [SharePoint development in Visual Studio], creating"
  - "Web Parts [SharePoint development in Visual Studio], designing"
ms.assetid: 3dd62654-ada2-468f-b7da-eb5704a2ff7a
caps.latest.revision: 34
ms.author: "kempb"
manager: "douge"
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
# Walkthrough: Creating a Web Part for SharePoint by Using a Designer
  If you create web parts for a SharePoint site, your users can directly modify the content, appearance, and behavior of pages in that site by using a browser. This walkthrough shows you how to create a web part visually by using the SharePoint **Visual Web Part** project template in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
 The web part that you'll create displays a monthly calendar view and a check box for each calendar list on the site. Users can specify which calendar lists to include in the monthly calendar view by selecting the check boxes.  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating a web part by using the **Visual Web Part** project template.  
  
-   Designing the web part by using the Visual Web Developer designer in Visual Studio.  
  
-   Adding code to handle the events of controls on the web part.  
  
-   Testing the web part in SharePoint.  
  
    > [!NOTE]  
    >  Your computer might show different names or locations for some elements of the user interface for Visual Studio in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   Supported editions of Windows and SharePoint. See [Requirements for Developing SharePoint Solutions](../VS_officedev/requirements-for-developing-sharepoint-solutions.md).  
  
-   [!INCLUDE[vsPro](../VS_officedev/includes/vspro_md.md)] or greater.  
  
## Creating a web part project  
 First, create a web part project by using the **Visual Web Part** project template.  
  
#### To create a Visual Web Part project  
  
1.  Start [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] by using the **Run as Administrator** option.  
  
2.  On the menu bar, choose **File**, **New**, **Project**.  
  
     The **New Project** dialog box appears.  
  
3.  In the **New Project** dialog box, under either **Visual C#** or **Visual Basic**, expand **Office/SharePoint**, and then choose the **SharePoint Solutions** category.  
  
4.  In the list of templates, choose the **SharePoint 2013 - Visual Web Part** template, and then choose the **OK** button.  
  
     The **SharePoint Customization Wizard** appears. By using this wizard, you can specify the site that you'll use to debug the project and the trust level of the solution.  
  
5.  In the **What is the trust level for this SharePoint solution?** section, choose the **Deploy as a farm solution** option button.  
  
6.  Choose the **Finish** button to accept the default local SharePoint site.  
  
## Designing the web part  
 Design the web part by adding controls from the **Toolbox** to the surface of the Visual Web Developer designer.  
  
#### To design the layout of the web part  
  
1.  On the Visual Web Developer designer, choose the **Design** tab to switch to Design view.  
  
2.  On the menu bar, choose **View**, **Toolbox**.  
  
3.  In the **Standard** node of the **Toolbox**, choose the **CheckBoxList** control, and then perform one of the following steps:  
  
    -   Open the shortcut menu for the **CheckBoxList** control, choose **Copy**, open the shortcut menu for the first line in the designer, and then choose **Paste**.  
  
    -   Drag the **CheckBoxList** control from the **Toolbox**, and connect the control to the first line in the designer.  
  
4.  Repeat the previous step, but move a Button to the next line of the designer.  
  
5.  In the designer, choose the **Button1** button.  
  
6.  On the menu bar, choose **View**, **Properties Window**.  
  
     The **Properties** window opens.  
  
7.  In the **Text** property of the button, enter **Update**.  
  
## Handling the events of controls on the web part  
 Add code that enables the user to add calendars to the master calendar view.  
  
#### To handle events of controls on the web part  
  
1.  Perform one of the following sets of steps:  
  
    -   In the designer, double-click the **Update** button.  
  
    -   In the **Properties** window for the **Update** button, choose the **Events** button. In the **Click** property, enter **Button1_Click**, and then choose the Enter key.  
  
     The user control code file opens in Code Editor and the `Button1_Click` event handler appears. Later, you’ll add code to this event handler.  
  
2.  Add the following statements to the top of the user control code file.  
  
     [!code[SP_VisualWebPart#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_1.vb)]
[!code[SP_VisualWebPart#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_1.cs)]  
  
3.  Add the following line of code to the `VisualWebPart1` class. This code declares a monthly calendar view control.  
  
     [!code[SP_VisualWebPart#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_2.vb)]
[!code[SP_VisualWebPart#2](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_2.cs)]  
  
4.  Replace the `Page_Load` method of the `VisualWebPart1` class with the following code. This code performs the following tasks:  
  
    -   Adds a monthly calendar view to the user control.  
  
    -   Adds a check box for each calendar list on the site.  
  
    -   Specifies a template for each type of item that appears in the calendar view.  
  
     [!code[SP_VisualWebPart#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_3.vb)]
[!code[SP_VisualWebPart#3](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_3.cs)]  
  
5.  Replace the `Button1_Click` method of the `VisualWebPart1` class with the following code. This code adds items from each selected calendar to the master calendar view.  
  
     [!code[SP_VisualWebPart#4](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_4.vb)]
[!code[SP_VisualWebPart#4](../VS_officedev/codesnippet/CSharp/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer_4.cs)]  
  
## Testing the web part  
 When you run the project, the SharePoint site opens. The web part is automatically added to the Web Part Gallery in SharePoint. To test this project, you’ll perform the following tasks:  
  
-   Add an event to each of two separate calendar lists.  
  
-   Add the web part to a web part page.  
  
-   Specify the lists to include in the monthly calendar view.  
  
#### To add events to calendar lists on the site  
  
1.  In Visual Studio, choose the F5 key.  
  
     The SharePoint site opens, and the [!INCLUDE[wss_14_long](../VS_officedev/includes/wss_14_long_md.md)] Quick Launch bar appears on the page.  
  
2.  On the Quick Launch bar, under **Lists**, choose the **Calendar** link.  
  
     The **Calendar** page appears.  
  
     If you no Calendar link appears on the Quick Launch bar, choose the **Site Contents** link. If the Site Contents page doesn't show a **Calendar** item, create one.  
  
3.  On the Calendar page, choose a day, and then choose the **Add** link in the selected day to add an event.  
  
4.  In the **Title** box, enter **Event in the default calendar**, and then choose the **Save** button.  
  
5.  Choose the **Site Contents** link, and then choose the **Add an app** tile.  
  
6.  On the **Create** page, choose the **Calendar** type, name the calendar, and then choose the **Create** button.  
  
7.  Add an event to the new calendar, name the event **Event in the custom calendar**, and then choose the **Save** button.  
  
#### To add the web part to a web part page  
  
1.  On the **Site Contents** page, open the **Site Pages** folder.  
  
2.  On the ribbon, choose the **Files** tab, open the **New Document** menu, and then choose the **Web Part Page** command.  
  
3.  On the **New Web Part Page** page, name the page **SampleWebPartPage.aspx**, and then choose the **Create** button.  
  
     The web part page appears.  
  
4.  In the top zone of the web part page, choose the **Insert** tab, and then choose the **Web Part** button.  
  
5.  Choose the **Custom** folder, choose the **VisualWebPart1** web part, and then choose the **Add** button.  
  
     The web part appears on the page. The following controls appear on the web part:  
  
    -   A monthly calendar view.  
  
    -   An **Update** button.  
  
    -   A **Calendar** check box.  
  
    -   A **Custom Calendar** check box.  
  
#### To specify lists to include in the monthly calendar view  
  
1.  In the web part, specify calendars that you want to include in the monthly calendar view, and then choose the **Update** button.  
  
     Events from all calendars that you specified appear in the monthly calendar view.  
  
## See Also  
 [Creating Web Parts for SharePoint](../VS_officedev/creating-web-parts-for-sharepoint.md)   
 [How to: Create a SharePoint Web Part](../VS_officedev/how-to--create-a-sharepoint-web-part.md)   
 [How to: Create a SharePoint Web Part by Using a Designer](../VS_officedev/how-to--create-a-sharepoint-web-part-by-using-a-designer.md)   
 [Walkthrough: Creating a Web Part for SharePoint](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint.md)  
  
  