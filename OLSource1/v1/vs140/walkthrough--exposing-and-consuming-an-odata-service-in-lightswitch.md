---
title: "Walkthrough: Exposing and Consuming an OData Service in LightSwitch"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 86243a29-1795-48bb-9981-ec8282da8e50
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Exposing and Consuming an OData Service in LightSwitch
LightSwitch applications can expose their data as an Open Data (OData) service that can be consumed by any application that supports the OData protocol. This walkthrough demonstrates how to expose data from one LightSwitch application and then consume that data in a second LightSwitch application.  
  
## Create a Host Application  
 The first step is to create a host application that exposes an OData feed.  
  
#### To create a host application project  
  
1.  On the menu bar, choose **File**, **New Project**.  
  
2.  In the **Installed Templates** list, expand the **Visual Basic** or **Visual C#** node, choose **LightSwitch Application (Visual Basic)** or **LightSwitch Application (Visual C#)**.  
  
3.  In the **Name** field, enter `Contact Host`, and then choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for **Properties** and choose **Open**.  
  
5.  Choose the **Application Type** tab, and, under **Client**, choose **Web**.  
  
     Only web applications can expose their data as a service.  
  
#### To add a data source  
  
1.  In **Solution Explorer**, choose **Data Sources**.  
  
2.  On the **Project**  menu, choose **Add Table**.  
  
3.  In the **Properties** window, choose the **Name** property, and then enter `Contact`.  
  
4.  In the data designer, add the following fields:  
  
    |Name|Type|Required|  
    |----------|----------|--------------|  
    |Name|String|True|  
    |Phone|Phone Number|False|  
    |Email|Email Address|False|  
  
#### To expose the service  
  
1.  On the menu bar, choose **Debug**, **Start Debugging**.  
  
     The Contact Host application opens in a browser window.  
  
2.  Copy the first part of the URL (http://localhost:#####/).  
  
     Leave the application running. It must be running to expose the service.  
  
## Create a Client Application  
 The next step is to create an application that will consume the OData service  
  
#### To create a client project  
  
1.  Open a new instance of [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)].  
  
2.  On the menu bar, choose **File**, **New Project**.  
  
3.  In the **Installed Templates** list, choose **LightSwitch Application (Visual Basic)** or **LightSwitch Application (Visual C#)**.  
  
4.  In the **Name** field, enter `Contact Client`, and then choose the **OK** button.  
  
#### To add a data source  
  
1.  In **Solution Explorer**, choose **Data Sources**.  
  
2.  On the menu bar, choose **Project** , **Add Data Source**.  
  
3.  In the **Attach Data Source Wizard**, choose **OData Service**, and then choose the **Next** button.  
  
4.  In the **OData Source Address** field, paste the URL that you copied from the Contact Host application (http://localhost:#####/), and then enter `ContactData.svc` after the last backslash (http://localhost:#####/ApplicationData.svc).  
  
5.  Choose the **Test Connection** button.  
  
6.  In the **Test Connection** dialog box, choose **Contacts** in the list, and then choose the **Test** button.  
  
     After a brief delay, a **Test connection succeeded** dialog box should appear.  
  
7.  Click the **OK** button, then choose the **Close** button to dismiss the dialog boxes, and then click the **Next** button.  
  
8.  Expand the **Entities** node, choose **Contacts**, and then choose the **Finish** button.  
  
     The data designer opens and displays the schema of the table that you created in the Contact Host project.  
  
#### To add a screen  
  
1.  In **Solution Explorer**, choose **Screens**.  
  
2.  On the menu bar, choose **Project** , **Add Screen**.  
  
3.  In the **Add New Screen** dialog box, choose **Editable Grid Screen**.  
  
4.  In the **Screen Data** list, choose **ApplicationDataData.Contacts**, and then choose the **OK** button.  
  
 At this point, you can run the application and enter data. Any data that you enter is saved in the intrinsic database of the Contact Host project.  
  
## Next Steps  
 This walkthrough demonstrates consuming OData in the design time environment. After you publish the Contact Host application to a server that's running Internet Information Services (IIS) or to Microsoft Azure, you must update the **OData Source Address** for the client application to match the URL for the published application.  
  
> [!NOTE]
>  If you close the Contact Host application in the design time environment and restart it, the LocalHost URL will change, and you will need to update the **OData Source Address** in the client project.  
  
### To update the data source  
  
1.  Open the Contact Client project.  
  
2.  In **Solution Explorer**, choose **ApplicationDataData**.  
  
3.  On the menu bar, choose **Project** , **Update Datasource**.  
  
4.  In the **Attach Data Source Wizard**, choose the **Previous** button.  
  
5.  In the **OData Source Address** text box, enter the new URL for the published Contact Host application (for example, http://www.contoso.com/ApplicationData.svc).  
  
6.  Click the **Next** button, and then click the **Finish** buttton to update the data source.  
  
## See Also  
 [Exposing LightSwitch Application Data](../vs140/exposing-lightswitch-application-data.md)