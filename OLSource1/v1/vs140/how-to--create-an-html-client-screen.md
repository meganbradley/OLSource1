---
title: "How to: Create an HTML Client Screen"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 86191a04-0706-4c69-9aaa-cc4f2a1347a6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create an HTML Client Screen
Create a screen or set of screens to display or collect information on a mobile device.  
  
##  \<a name="CreatingASCreen">\</a> To create a screen  
  
1.  In **Solution Explorer**, choose the **HTML Client** project node.  
  
2.  On the menu bar, choose **Project**, **Add Screen**.  
  
     The **Add New Screen** dialog box appears.  
  
3.  Under **Select a screen template**, choose the type of screen that you want to create.  
  
     For more information, see [Choosing  an HTML Client Screen Type](../vs140/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md).  
  
4.  In the **Screen Name** text box, name the screen.  
  
5.  In the **Screen Data** list, choose the entity or query that will specify what data appears on the screen.  
  
6.  If the **Additional Data to Include** section appears, select the check boxes for any related data that you want to display on the screen.  
  
    > [!NOTE]
    >  The **Additional Data to Include** section appears only if you’re creating a **View Details Screen** or a **Add/Edit Details Screen** screen.  
  
     This section lists entities or tables that relate to the data that you specified in the previous step. If you selected the check box for a query in the previous step, this section lists entities or tables that relate to the source data of the query that you selected. For more information about related data, see [How to: Define Data Relationships](../vs140/how-to--define-data-relationships-in-lightswitch.md).  
  
7.  Choose the **OK** button to close the **Add New Screen** dialog box.  
  
     Your new screen appears in the screen designer.  
  
##  \<a name="CreatingASCreenSet">\</a> To create a screen set  
  
1.  In **Solution Explorer**, choose the **HTML Client** project node.  
  
2.  On the menu bar, choose **Project**, **Add Screen**.  
  
     The **Add New Screen** dialog box appears.  
  
3.  Under **Select a screen template**, choose **Common Screen Set**.  
  
     For more information, see [Choosing  an HTML Client Screen Type](../vs140/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md).  
  
4.  In the **Screen Name** text box, name the screen.  
  
5.  In the **Screen Data** list, choose the entity or query that will specify what data appears on the screens.  
  
6.  If the **Additional Data to Include** section appears, select the check boxes for any related data that you want to display on the screens.  
  
     This section lists entities or tables that relate to the data that you specified in the previous step. If you selected the check box for a query in the previous step, this section lists entities or tables that relate to the source data of the query that you selected. For more information about related data, see [How to: Define Data Relationships](../vs140/how-to--define-data-relationships-in-lightswitch.md).  
  
7.  Choose the **OK** button to close the **Add New Screen** dialog box.  
  
     Your new **Browse** screen appears in the screen designer. A new node for your screen set appears in **Solution Explorer** with nodes for the new **AddEdit**, **Browse**, and **View** screens.  
  
## See Also  
 [Choosing  an HTML Client Screen Type](../vs140/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md)   
 [HTML Client Applications in LightSwitch](../vs140/html-client-screens-for-lightswitch-apps.md)