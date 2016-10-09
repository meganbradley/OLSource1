---
title: "How to: Create an Event Receiver"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.SPE.EventReceiver"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, event receivers"
  - "event receivers [SharePoint development in Visual Studio]"
ms.assetid: 6f90cb48-eb8f-43c2-a3f7-ed4ce81aedf2
caps.latest.revision: 20
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
# How to: Create an Event Receiver
  By creating *event receivers*, you can respond when a user interacts with SharePoint items such as lists or list items. For example, the code in an event receiver can be triggered when a user changes the calendar or deletes a name from a contacts list. By following this topic, you can learn how to add an event receiver to a list instance.  
  
 To complete these steps, you must have installed [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] and supported editions of Windows and SharePoint. For more information, see [Requirements for Developing SharePoint Solutions](../VS_officedev/requirements-for-developing-sharepoint-solutions.md). Because this example requires a SharePoint project, you also must have completed the procedure in the topic [Walkthrough: Create a Site Column, Content Type, and List for SharePoint](../VS_officedev/walkthrough--create-a-site-column--content-type--and-list-for-sharepoint.md).  
  
## Adding an Event Receiver  
 The project that you created in [Walkthrough: Create a Site Column, Content Type, and List for SharePoint](../VS_officedev/walkthrough--create-a-site-column--content-type--and-list-for-sharepoint.md) includes custom site columns, a custom list, and a content type. In the following procedure, you’ll expand this project by adding a simple event handler (an event receiver) to a list instance to show how to handle events that occur in SharePoint items such as lists.  
  
#### To add an event receiver to the list instance  
  
1.  Open the project that you created in [Walkthrough: Create a Site Column, Content Type, and List for SharePoint](../VS_officedev/walkthrough--create-a-site-column--content-type--and-list-for-sharepoint.md).  
  
2.  In **Solution Explorer**, choose the SharePoint project node, which is named **Clinic**.  
  
3.  On the menu bar, choose **Project**, **Add New Item**.  
  
4.  Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** item.  
  
5.  In the **Templates** pane, choose **Event Receiver**, name it **TestEventReceiver1**, and then choose the **OK** button.  
  
     The **SharePoint Customization Wizard** appears.  
  
6.  In the **What type of event receiver do you want?** list, choose **List Item Events**.  
  
7.  In the **What item should be the event source?** list, choose **Patients (Clinic\Patients)**.  
  
8.  In the **Handle the following events** list, select the check box next to **An item was added**, and then choose the **Finish** button.  
  
     The code file for the new event receiver contains a single method that’s named `ItemAdded`. In the next step, you’ll add code to this method so that every contact will be named Scott Brown by default.  
  
9. Replace the existing `ItemAdded` method with the following code, and then choose the F5 key:  
  
     [!code[SP_EventReceiver#1](../VS_officedev/codesnippet/CSharp/how-to--create-an-event-receiver_1.cs)]
[!code[SP_EventReceiver#1](../VS_officedev/codesnippet/VisualBasic/how-to--create-an-event-receiver_1.vb)]  
  
     The code runs, and the SharePoint site appears in the web browser.  
  
10. On the QuickLaunch bar, choose the **Patients** link, and then choose the **Add New Item** link.  
  
     The entry form for new items opens.  
  
11. Enter data in the fields, and then choose the **Save** button.  
  
     After you choose the **Save** button, the **Patient Name** column automatically updates to the name Scott Brown.  
  
## See Also  
 [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md)  
  
  