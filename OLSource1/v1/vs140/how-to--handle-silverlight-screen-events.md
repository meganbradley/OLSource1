---
title: "How to: Handle Silverlight Screen Events"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - screens [Visual Studio LightSwitch], events
  - handling events in a screen [Visual Studio LightSwitch]
  - screens [Visual Studio LightSwitch], handling events
  - screens [Visual Studio LightSwitch], partial methods
ms.assetid: 8559455c-0dd8-4cbc-9209-af0989d10b03
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Handle Silverlight Screen Events
You can customize your application by writing code that runs when certain events happen. For example, you can write code that runs before data is saved to a data source.  
  
 The events you can handle can be grouped into four categories:  
  
-   Button methods that are called when a button is clicked.  
  
-   General methods that are called when data is loaded or saved, or when a screen is closed.  
  
-   Access control methods that are called to verify if a user has permission to perform a task.  
  
-   Collection methods that are called when a collection is modified.  
  
 A description of these methods appears in the tables at the end of this topic.  
  
### To handle a screen event  
  
1.  Open the screen that you want to modify by double clicking it in the **Solution Explorer**.  
  
     The **Screen Designer** opens.  
  
2.  At the top of the **Screen Designer**, click the arrow next to the **Write Code** button, and then select a method. The methods to which you can add custom code appear in the tables below.  
  
     The Code Editor opens.  
  
    > [!NOTE]
    >  The **Collection Methods** only appear in the **Write Code** drop-down list if the collection is selected from the left data pane in the **Screen Designer**.  
  
3.  Place your cursor in the method that was just created and type the code that you want to run when the event occurs.  
  
## List of Screen Event Methods  
 The following table lists screen-related event methods. All of these methods run on the client tier.  
  
|**Button Methods**|Description|  
|------------------------|-----------------|  
|<MyMethodName\>_Execute|Called when the button associated with the method is clicked.|  
  
|**General Methods**|Description|  
|-------------------------|-----------------|  
|<ScreenName\>_Activated|Called just after a screen is activated.|  
|<ScreenName\>_Closing|Called just before the screen closes.|  
|<ScreenName\>_Created|Called just after the screen appears.|  
|<ScreenName\>_InitializeDataWorkspace|Called just before the screen data is retrieved.|  
|<ScreenName\>_Run|Called when a request is made to display the screen.|  
|<ScreenName\>_SaveError|Called when attempting to save the screen results in an error.|  
|<ScreenName\>_Saved|Called just after the screen is saved.|  
|<ScreenName\>_Saving|Called just before the screen is saved.|  
  
|**Access Control Methods**|Description|  
|--------------------------------|-----------------|  
|CanRun<ScreenNam|Called before a screen appears. [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] calls this method to check permissions for the current user.|  
|<MyMethodName\>_CanExecute|Called before a method is runs. [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] calls this method to check permissions for the current user.|  
  
|**Collection Methods**|Description|  
|----------------------------|-----------------|  
|<CollectionName\>_Changed|Called just after the collection has changed.|  
|<CollectionName\>_SelectionChanged|Called just after the currently selected item in the collection is selected.|  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [How to: Handle Entity Events](../vs140/how-to--handle-data-events.md)   
 [How to: Handle Query Events](../vs140/how-to--handle-query-events.md)   
 [How to: Modify a Screen by Using Code](../vs140/how-to--modify-a-silverlight-screen-by-using-code.md)