---
title: Change the Attribute Type (MDS Add-in for Excel)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9d3001d9-8d0f-4e4a-8e04-4f666bf0df69
manager: jhubbard
---
# Change the Attribute Type (MDS Add-in for Excel)
In the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)][!INCLUDE[ssMDSXLS](../../Topics/TopicNameContainA/includes/ssMDSXLS_md.md)], administrators can change the attribute type when the data type or number of allowed characters is incorrect.  
  
 If you want to change the attribute type to create a constrained list (domain-based attribute), see [Create a Domain-based Attribute (MDS Add-in for Excel)](../../Topics/TopicNameContainA/Create-a-Domain-based-Attribute--MDS-Add-in-for-Excel-.md).  
  
> [!NOTE]  
>  You cannot update the type or length of the **Name** or **Code** columns.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** and **Explorer** functional areas.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   There must be an existing model, entity, and attribute.  
  
### To change the attribute type  
  
1.  In Excel, load the entity that contains the column (attribute) you want to change. For more information, see [Export Data to Excel from Master Data Services](../../Topics/TopicNameNotContainA/Export-Data-to-Excel-from-Master-Data-Services.md).  
  
2.  Click any cell in the column you want to change.  
  
3.  In the **Build Model** group, click **Attribute Properties**.  
  
4.  In the **Attribute Properties** dialog box, update settings as needed.  
  
5.  Click **OK**.  
  
## What happens when you change the attribute type?  
 If there is any dependency on the attribute, such as the attribute is referenced by any MDS business rule or derived hierarchy, you cannot change the data type of the attribute. You get an error stating that the attribute type cannot be modified because it is referenced by an object.  
  
 If there is any error during data type conversion for the attribute values, MDS does the following.  
  
-   Changes the data type of the attribute.  
  
-   Generates a copy of the attribute with the suffix “_old” that contains the previous values. This is called a deprecated attribute.  
  
## See Also  
 [Attributes (Master Data Services)](../../Topics/TopicNameNotContainA/Attributes--Master-Data-Services-.md)   
 [Building a Model (MDS Add-in for Excel)](../../Topics/TopicNameContainA/Building-a-Model--MDS-Add-in-for-Excel-.md)