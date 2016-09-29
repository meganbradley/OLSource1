---
title: "How to: Define Data Relationships in LightSwitch"
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
  - "data [Visual Studio LightSwitch], relationships"
  - "data [Visual Studio LightSwitch], relating"
  - "relating data [Visual Studio LightSwitch]"
  - "relationships [Visual Studio LightSwitch]"
  - "connecting data [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], connecting"
ms.assetid: d07ad933-7325-4025-9054-337743087f80
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define Data Relationships in LightSwitch
You can create, modify, or delete relationships between data by using the data designer in LightSwitch. By using relationships, you can create screens in which the related data work together (for example, a screen that shows both customers and their orders).  
  
 This document contains the following sections:  
  
-   [Adding a relationship between tables or entities from the same data source](#Same)  
  
-   [Adding a relationship between tables or entities from separate data sources](#Different)  
  
-   [Modifying a relationship](#Modifying)  
  
-   [Multiplicity settings](#Multiplicity)  
  
-   [Deletion behavior settings](#Deletion)  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Define My Data in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205102).  
  
##  <a name="Same"></a> Adding a Relationship Between Tables or Entities From the Same Data Source  
 You can use the LightSwitch data designer to add a relationship between two tables in the LightSwitch internal database. In some cases, you can also use the data designer to add a relationship between entities from the same external data source. Otherwise, you must create those relationships on the server and then refresh the data connection in LightSwitch. For more information about how to refresh a connection to a data source, see [How to: Connect to Data](../vs140/how-to--connect-to-data.md).  
  
#### To add a relationship between tables in the LightSwitch internal database  
  
1.  In **Solution Explorer**, open the shortcut menu for one of the tables that you want to use in the relationship, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, on the command bar, choose the **Relationship** button.  
  
3.  In the **Add New Relationship** dialog box, in the **Name** row, choose the two tables to which you want to apply a relationship (for example, Customers and Orders).  
  
4.  In the **Multiplicity** row, specify how you want these tables to be related.  
  
     See [Multiplicity Settings](#Multiplicity).  
  
5.  In the **On Delete Behavior** row, specify what you want your application to do if a user tries to delete a record in one table but data still exists in the related record in the other table (for example, if a user tries to delete a customer but orders placed by the customer still exist).  
  
     See [Delete Behavior Settings](#Deletion).  
  
6.  In the **Navigation Property** row, enter a name for each navigation property, and then choose the **OK** button.  
  
     Navigation properties help users navigate between areas of a screen that display related data. Navigation properties also appear as objects in IntelliSense, and you can use them to construct LINQ expressions in code.  
  
#### To add a relationship between tables in an attached database  
  
1.  In **Solution Explorer**, open the shortcut menu for one of the tables that you want to use in the relationship, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, on the command bar, choose the **Relationship** button.  
  
     The **Add New Relationship** dialog box opens.  
  
3.  In the **To** column of the **Name** row, choose the table to which you want to apply a relationship.  
  
     The table must contain a primary key that will be used on the primary side of the relationship.  
  
4.  In the **Multiplicity** row, specify how you want these tables to be related.  
  
     See [Multiplicity Settings](#Multiplicity).  
  
5.  In the data grid that appears near the bottom of the **Add New Relationship** dialog box, choose a property from the **Foreign** side of the relationship.  
  
     This property must match the data type of the **Primary** key property.  
  
    > [!NOTE]
    >  If the table contains a composite primary key, all foreign key data types must match.  
  
    > [!NOTE]
    >  For a zero or one-to-many relationship, the **Foreign** key property can’t be a required field. For a one-to-many relationship, the **Foreign** key property must be a required field. For a zero or one-to-one relationship, the primary key values must be used on both sides of the relationship.  
  
6.  Choose the **OK** button.  
  
##  <a name="Different"></a> Adding a Relationship Between Tables or Entities from Separate Data Sources  
 You can use the LightSwitch data designer to add a relationship between tables or entities from separate data sources. For example, you can add a relationship between a table in the internal database for LightSwitch and an entity from a SharePoint list.  
  
#### To add a relationship between two tables or entities from separate data sources  
  
1.  In **Solution Explorer**, open the shortcut menu for one of the tables that you want to use in the relationship, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, on the command bar, choose the **Relationship** button.  
  
     The **Add New Relationship** dialog box opens.  
  
3.  In the **Name** row, choose the tables or entities to which you want to apply a relationship (for example, Customers and Orders).  
  
4.  In the **Multiplicity** row, specify how you want these table or entities to be related.  
  
     See [Multiplicity Settings](#Multiplicity).  
  
    > [!NOTE]
    >  Notice that the **On Delete Behavior** row isn't enabled for this kind of relationship.  
  
5.  In the **Navigation Property** row, provide a name for each navigation property.  
  
     Navigation properties help users navigate between areas of a screen that display related data. Navigation properties also appear as objects in IntelliSense, and you can use them to construct LINQ expressions in code.  
  
6.  In the data grid that appears near the bottom of the **Add New Relationship** dialog box, choose a property from one table or entity and a related property in the other table or entity, and then choose the **OK** button.  
  
     These properties are where the tables or entities link together. For example, you could choose the **Id** property of a Customer entity and the **CustomerID** property of an Order entity.  
  
##  <a name="Modifying"></a> Modifying a Relationship  
 You can use the data designer in LightSwitch to modify or delete a relationship.  
  
###  <a name="Edit"></a> To modify an existing relationship  
  
1.  In **Solution Explorer**, open the shortcut menu for one of the tables that you're using in the relationship, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, choose the navigation property that represents the relationship to another entity or table.  
  
     For example, a Customer entity might have a property that's named **Orders** and that's used as a navigation property in the Customer-Orders relationship.  
  
3.  In the **Properties** window, choose the **Edit relationship properties** link.  
  
     The **Edit Relationship** dialog box opens.  
  
     To modify the relationship, see the appropriate section later in this topic:  
  
    -   [Adding a Relationship Between Entities From the Same Data Source](#Same).  
  
    -   [Adding a Relationship Between Entities From the Separate Data Sources](#Different).  
  
4.  Choose the **OK** button to close the **Edit Relationship** dialog box.  
  
###  <a name="Delete"></a> To delete a relationship  
  
1.  In **Solution Explorer**, open the shortcut menu for one of the tables that you're using in the relationship, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, open the shortcut menu for the connecting line that represents the relationship to another entity or table, and then choose **Delete Relationship(s)**.  
  
##  <a name="Multiplicity"></a> Multiplicity Settings  
 The following table describes the combinations of multiplicity settings that you can choose in LightSwitch.  
  
|**From** value|**To** value|Description|  
|--------------------|------------------|-----------------|  
|**One**|**Zero or one**|A "From" can have one or no "To", but a "To" must have a "From".|  
|**One**|**Many**|A "From" can have many "To" instances, but a "To" must have a "From".|  
|**Zero or one**|**One**|A "From" must have a "To", but a "To" can have one or no "From".|  
|**Zero or one**|**Many**|A "From" can have many "To" instances, and a "To" can have one or no "From".|  
|**Many**|**One**|A "From" must have a "To", but a "To" can have many "From" instances.|  
|**Many**|**Zero or one**|A "From" can have one or no "To", and a "To" can have many "From" instances.|  
  
> [!NOTE]
>  You can't specify a one-to-one, zero or one-to-zero or one, and many-to-many relationship by using the data designer in LightSwitch.  
  
##  <a name="Deletion"></a> Deletion Behavior Settings  
 The following table describes the options that you can set to govern what happens when a user tries to delete a record that's part of a relationship. Some options aren't available for certain kinds of relationships.  
  
|**On Delete Behavior** Value|Description|  
|----------------------------------|-----------------|  
|**Cascade delete**|When a "Table1" is deleted, delete all related "Table2" instances.|  
|**Restricted**|"Table1" can't be deleted if related "Table2" instances exist.<br /><br /> For example, choose **Restricted** to specify that a customer can't be deleted if the database contains related orders.|  
|**Disassociate**|When "Table1" is deleted, set the reference to "Table1" on related "Table2" instances to `null`.|  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)