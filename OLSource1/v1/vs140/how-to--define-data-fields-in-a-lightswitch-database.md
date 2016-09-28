---
title: "How to: Define Data Fields in a LightSwitch Database"
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
  - "data [Visual Studio LightSwitch], adding fields"
  - "defining data [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], defining data"
ms.assetid: 354694d6-266b-4e5c-b84d-223153616fd6
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define Data Fields in a LightSwitch Database
You can add fields to an entity or a table in the LightSwitch database and modify the appearance and behavior of these fields.  
  
 This topic contains the following sections:  
  
-   [Adding a Data Field](#Adding).  
  
-   [Modifying a Field](#Modifying).  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Format Data on a Screen in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205126).  
  
##  <a name="Adding"></a> Adding a Data Field  
 You can add fields to a table. In an entity that's generated from an external data source, you can add computed fields only.  
  
 See [How to: Add a Computed Field](../vs140/how-to--add-a-computed-field-in-a-lightswitch-database.md).  
  
#### To add a data field  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity or table, and then choose **Open**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
     The entity or table opens in the **Data Designer**.  
  
2.  In the **Name** column, enter a name for the field.  
  
3.  In **Type** column, choose a data type for the new field. The following table describes each type.  
  
    |Type|Visual Basic Type|C# Type|Range|Remarks|  
    |----------|-----------------------|--------------|-----------|-------------|  
    |**Binary**|Byte()|byte[]|-128 to 127.|An array of bytes that has a variable length.|  
    |**Boolean**|Boolean|bool|True or false.||  
    |**Date**|DateTime|DateTime||A DateTime that's treated as a date only.|  
    |**DateTime**|DateTime|DateTime|12:00:00 AM, Jan 1, 0001 through 11:59:59 PM, Dec 31, 9999.||  
    |**DateTimeOffset**|DateTime|DateTime||A value that represents a date and time in Coordinated Universal Time (UTC) format.|  
    |**Decimal**|Decimal|decimal|±1.0 × 10<sup\>−28</sup\> to ±7.9 × 10<sup\>28</sup\>.|A fixed decimal point with 28-29 significant digits; good for accounting numbers.|  
    |**Double**|Double|double|±5.0e−324 to ±1.7e308.|A floating decimal point with 15-16 digits precision; good for scientific numbers.|  
    |**Email Address**|String|string||A string that's treated as an email address.|  
    |**Guid**|String|string||A string that's formatted as a globally unique identifier (GUID). The value is automatically generated for each record.|  
    |**Image**|Byte()|Byte[]||A binary that's treated as an image.|  
    |**Short Integer**|Short|short|-32,768 to 32,767.|A signed 16-bit integer.|  
    |**Integer**|Integer|int|-2147483647 to 2147483647.|A signed 32-bit integer.|  
    |**Long Integer**|Long|long|-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.|A signed 64-bit integer.|  
    |**Money**|Decimal|decimal||A decimal that's treated as a monetary value.|  
    |**Percent**|Decimal|decimal||A decimal that's treated as a percentage.|  
    |**Person**|String|String||A string that’s treated as a user identity.|  
    |**Phone Number**|String|string||A string that's treated as a phone number.|  
    |**String**|String|string||A sequence of zero or more Unicode characters that has a variable length.|  
    |**Web Address**|String|string||A string that's treated as a web address (URL).|  
  
4.  If you want to require users to provide a value for this field, select the **Required** check box.  
  
##  <a name="Modifying"></a> Modifying a Field  
 You can modify a field by editing its properties in the **Properties** window.  
  
 If the entity was generated from an external data source, you won't be able to edit some field properties because they reflect configuration settings of the data source.  
  
 You can't override those settings by changing field properties. You must make changes to these fields on the server and then import those changes into LightSwitch by refreshing the data source.  
  
#### To modify a field  
  
1.  In the **Data Designer**, choose the field that you want to modify.  
  
2.  In the **Properties** window, set property values.  
  
     See [Reference: Data Designer Properties](../vs140/reference--data-designer-properties.md).  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)   
 [How to: Validate Entities](../vs140/how-to--validate-data-in-a-lightswitch-application.md)   
 [How to: Create a Choice List for an Entity Field](../vs140/how-to--create-a-list-of-values-for-a-field-in-a-lightswitch-application.md)   
 [How to: Add a Computed Field](../vs140/how-to--add-a-computed-field-in-a-lightswitch-database.md)