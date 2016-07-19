---
title: Automatically Generate Attribute Values Other Than Code (Master Data Services)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b82f6f81-6e9c-4918-9ea9-4ab5f5d11b15
manager: jhubbard
---
# Automatically Generate Attribute Values Other Than Code (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], automatically generate values for an entity’s attribute values when you want an integer to be automatically assigned as the value each time business rules are applied.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   A numeric attribute must exist. For more information, see [Create a Numeric Attribute (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Numeric-Attribute--Master-Data-Services-.md).  
  
### To automatically generate an attribute value  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  From the menu bar, point to **Manage** and click **Business Rules**.  
  
3.  On the **Business Rule Maintenance** page, from the **Model** list, select a model.  
  
4.  From the **Entity** list, select an entity.  
  
5.  From the **Member Type** list, select a type of member for the business rule to apply to.  
  
6.  From the **Attribute** list, leave the default of **All**.  
  
7.  Click **Add business rule**.  
  
8.  Click **Edit selected business rule**.  
  
9. In the **Components** pane, expand the **Actions** node.  
  
10. In the Default Value node, click **defaults to a generated value** and drag it to the **THEN** pane’s **Actions** label.  
  
11. In the **Attributes** pane, click the attribute with the value you want to generated and drag it to the **Edit Action** pane's **Select attribute** label.  
  
12. Type a value in the **Start with** and **Increment by** boxes. If members already exist, the value will be set based on the highest existing value. For example, if the highest existing value is 299 and you set **Increment by** to **1**, the next member’s value will be set to 300.  
  
13. In the **Edit Action** pane, click **Save item**.  
  
14. Click **Back**.  
  
15. Optionally, on the **Business Rules Maintenance** page, for the row that contains your business rule, double-click a cell in the **Name**, **Description**, or **Notification** column to update the value.  
  
16. Click **Publish business rules**.  
  
17. On the confirmation dialog box, click **OK**. The rule's status changes to **Active**.  
  
## Next Steps  
  
-   [Validate Specific Members against Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Validate-Specific-Members-against-Business-Rules--Master-Data-Services-.md)  
  
-   [Validate a Version against Business Rules (Master Data Services)](../../Topics/TopicNameContainA/Validate-a-Version-against-Business-Rules--Master-Data-Services-.md)  
  
## See Also  
 [Automatic Code Creation (Master Data Services)](../../Topics/TopicNameNotContainA/Automatic-Code-Creation--Master-Data-Services-.md)   
 [Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rules--Master-Data-Services-.md)   
 [Validation (Master Data Services)](../../Topics/TopicNameNotContainA/Validation--Master-Data-Services-.md)