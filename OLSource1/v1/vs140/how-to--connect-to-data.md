---
title: "How to: Connect to Data"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ls.DataSourceDesigner
helpviewer_keywords: 
  - data [Visual Studio LightSwitch], adding
  - data [Visual Studio LightSwitch], referencing
  - referencing data [Visual Studio LightSwitch]
  - data [Visual Studio LightSwitch], connecting to
ms.assetid: 8d2c014a-d383-4709-b96d-6736efb6dbe4
caps.latest.revision: 31
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Connect to Data
You can reference data that is provided by a [!INCLUDE[ssNoVersion](../vs140/includes/ssnoversion_md.md)] database, a SharePoint list, an Open Data Protocol (OData) service, an SAP NetWeaver Gateway, or a Windows Communication Foundation (WCF) Rich Internet Application (RIA) service. Then, you can then use this data to create screens and queries in LightSwitch.  
  
 This topic shows how to accomplish the following tasks:  
  
-   [Connect to a SQL Server Database](#SQL)  
  
-   [Connect to a SharePoint List](#SharePoint)  
  
-   [Connect to an OData Service](#OData)  
  
-   [Connect to an SAP NetWeaver Gateway](#SAP)  
  
-   [Connect to a WCF RIA Service](#WCF)  
  
-   [Refresh a Data Source](#Refresh)  
  
##  <a name="SQL"></a> Connect to a SQL Server Database  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Data Source**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  In the **Choose a data Source Type** page, click **Database**, and then click **Next**.  
  
4.  If the **Choose Data Source** dialog box appears, click **Microsoft SQL Server**, and then click **OK**.  
  
5.  In the **Connection Properties** dialog box, make sure that **Microsoft SQL Server (SqlClient)** appears as selected in the **Data source** box.  
  
    > [!NOTE]
    >  If **Microsoft SQL Server (SqlClient)** does not appear in the **Data source** box, click the **Change** button to open the **Change Data Source** dialog box. Then, in the **Change Data Source** dialog box, specify **Microsoft SQL Server** and the **.NET Framework Data Provider for SQL Server**. Click **OK** to return to the **Connection Properties** dialog box.  
  
6.  In the **Server** name box of the **Connection Properties** dialog box, type the name of the [!INCLUDE[ssNoVersion](../vs140/includes/ssnoversion_md.md)] instance that you want to connect to.  
  
    > [!NOTE]
    >  If [!INCLUDE[ssNoVersion](../vs140/includes/ssnoversion_md.md)] is running on the same machine as LightSwitch, you can type `localhost` into the **Server** name box.  
  
7.  If your database is set up to use Windows authentication, click **Use Windows Authentication**. Otherwise, click **Use SQL Server Authentication**, and then provide the user name and password of a user who has access to the database.  
  
8.  Click **Select or enter a database name**. Then, in the **Select or enter a database name** list, select or type the name of the database that you want to connect to, and then click **Ok**.  
  
9. The **Choose Your Database Objects** page appears.  
  
10. In the **Choose your Database Objects** page, select the tables and views that you want to use in your LightSwitch application, and then click **Finish**.  
  
 The database, tables, and views that you selected appear in **Solution Explorer** as sub nodes of the **Data Sources** node.  
  
 LightSwitch refers to tables and views as *entities*. You can edit entities in LightSwitch by using the data designer. For more information, see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
 There are additional steps that you may want to take if you’ve selected SQL views. SQL views don’t have primary keys, so all required fields are marked as primary keys in the LightSwitch entity. You can review these fields and disable the **Is Key** property for any fields that don’t need to be part of the primary key.  
  
 SQL views can be modified only if they meet certain conditions, which are defined in the “Updatable Views” section of the article [CREATE VIEW (Transact-SQL)](http://msdn.microsoft.com/library/ms187956.aspx). LightSwitch entities that represent views aren’t editable by default. If you determine that a view meets the updatability conditions listed in that article, you can enable the **Is Editable** property for the entity.  
  
#### To disable a primary key in a SQL view  
  
1.  In the Entity Designer, on the **Perspective** bar, choose **Server**.  
  
2.  Choose the primary key field that you want to disable.  
  
3.  In the **Properties** window, clear the **Is Key** check box.  
  
#### To make a SQL view editable  
  
1.  In the Entity Designer, choose the title bar for the entity.  
  
2.  In the **Properties** window, select the **Is Editable** check box.  
  
##  <a name="SharePoint"></a> Connect to a SharePoint List  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Data Source…**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  In the **Choose a Data Source Type** page, click **SharePoint**, and then click **Next**.  
  
4.  In the **SharePoint Site Address** box, type the URL of the SharePoint site that contains the list that you want to connect to. For example, if the URL of your list is `http://sharepoint/sites/mysite/Lists/Customers/AllItems.aspx`, type `http://sharepoint/sites/mysite/` into the **SharePoint Site Address** box.  
  
    > [!NOTE]
    >  You can reference lists in a SharePoint 2010 site only.  
  
5.  Click either **Windows Credentials** or **Other Credentials**.  
  
     If you select **Other Credentials**, provide a valid user name and password in the appropriate boxes, and then click **Next**.  
  
6.  In the **Choose your Database Objects** page, select the lists that you want to use in your LightSwitch application, and then click **Finish**.  
  
 The lists that you selected now appear underneath **Data Sources** in **Solution Explorer**.  
  
 The lists that you selected appear in **Solution Explorer** as sub nodes of the **Data Sources** node.  
  
 LightSwitch refers to lists as *entities*. You can edit entities in LightSwitch by using the data designer. For more information, see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
##  <a name="OData"></a> Connect to an OData Service  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Data Source…**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  On the **Choose a Data Source Type** page, click **OData Service**, and then click **Next**.  
  
4.  In the **OData Source Address** field on the **Enter Connection Information** page, type the full URL address for the service (for example, http://services.odata.org/Northwind/Northwind.svc/).  
  
     Click **Next**.  
  
5.  Under **Login Information**, specify the type of authentication that the service uses.  
  
     If you specify **Other Credentials**, enter a valid **User name** and **Password**, which are typically supplied by the owner of the service.  
  
     Click **Next**.  
  
6.  On the **Choose your Entities** page, specify the entities that you want to use in your LightSwitch application, and then click **Finish**.  
  
    > [!NOTE]
    >  A **Warnings** dialog box may appear if the service contains relationships to entities that you did not specify. Click **Continue** to automatically include the related entities, or click **Back** to change your selection.  
  
 The entities that you specified appear in **Solution Explorer** as sub-nodes under the **Data Sources** node.  
  
 LightSwitch refers to tables and views as *entities*, and you can edit them in LightSwitch by using the data designer. For more information, see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
##  <a name="SAP"></a> Connect to an SAP NetWeaver Gateway  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Data Source…**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  On the **Choose a Data Source Type** page, click **SAP**, and then click **Next**.  
  
4.  In the **Specify the OData service endpoint** field on the **Enter Connection Information** page, type the full URL address for the service.  
  
5.  Under **Specify the authentication type**, specify the type of authentication that the service uses.  
  
     If you specify **Basic authentication**, enter a valid **User name** and **Password**, which are typically supplied by the owner of the service.  
  
     Click **Next**.  
  
6.  On the **Choose your Entities** page, specify the entities that you want to use in your LightSwitch application, and then click **Finish**.  
  
 The entities that you specified appear in **Solution Explorer** as sub-nodes under the **Data Sources** node.  
  
 LightSwitch refers to tables and views as *entities*, and you can edit them in LightSwitch by using the data designer. For more information, see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
##  <a name="WCF"></a> Connect to a WCF RIA Service  
 You can connect to a WCF RIA service that provides data from other types of data sources.  For more information about creating WCF RIA services for LightSwitch, see [Guidelines for Creating WCF RIA Services for LightSwitch](../vs140/guidelines-for-creating-wcf-ria-services-for-lightswitch.md).  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Data Source…**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  In the **Choose a Data Source Type** page, click **WCF RIA Service**, and then click **Next**.  
  
4.  In the **Available WCF Ria Service Classes** list of the **Choose a WCF Ria Service** dialog box, select the desired WCF RIA Service class to import. If the class that you want to import does not appear on this page, click **Add Reference**, and then select the assembly or project that contains the service class.  
  
     Click **Next**.  
  
5.  Under **Which data source objects do you want to import?**, select the data source objects that you want to import.  
  
6.  In the **Connection String** box, add the connection string to the data source used by the WCF RIA service.  
  
    > [!NOTE]
    >  You only have to provide a connection string if the WCF RIA service consumes a connection string from the web.config file of the LightSwitch application. In most cases, the author of the WCF RIA service provides tip text that appears in the **Connection String** box. This text describes the expected format of the connection string. For more information, see [Guidelines for Creating WCF RIA Services for LightSwitch](../vs140/guidelines-for-creating-wcf-ria-services-for-lightswitch.md).  
  
7.  Click **Finish**.  
  
 The data source objects that you selected appear in **Solution Explorer** as sub nodes of the **Data Sources** node.  
  
 LightSwitch refers to the data source objects as *entities*. You can edit entities in LightSwitch by using the data designer. For more information, see [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
##  <a name="Refresh"></a> Refresh a Data Source  
 If a data source has been changed (For example: a new table has been added, or fields in a SharePoint list have changed on the server), you can refresh the data source definition in LightSwitch. This enables you to model your queries and screens by using the most current version of a data source.  
  
#### To refresh a data source  
  
1.  In **Solution Explorer**, select a data source.  
  
2.  On the **Project** menu, click **Update Datasource**.  
  
     The **Attach Data Source Wizard** appears.  
  
3.  Select the objects that you want to import. Click **Finish** to import the data.  
  
     The data definition described by entities in your model matches the data definition of the data source.  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)   
 [Connecting to Data](../vs140/connecting-to-data-in-a-lightswitch-application.md)   
 [How to: Define Data Fields](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md)   
 [Guidelines for Creating WCF RIA Services for LightSwitch](../vs140/guidelines-for-creating-wcf-ria-services-for-lightswitch.md)