---
title: Require Attribute Values (Master Data Services)
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a360ef13-0c34-43b8-a87e-2f5d8732d30e
manager: jhubbard
---
# Require Attribute Values (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], require attribute values when you want to ensure your master data is complete.  
  
> [!NOTE]  
>  Members that are missing domain-based attribute values are not displayed in derived hierarchies that are based on those relationships.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
### To require attribute values  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  From the menu bar, point to **Manage** and click **Business Rules**.  
  
3.  On the **Business Rules** page, from the **Model** drop-down list, select a model.  
  
4.  From the **Entity** drop-down list, select an entity.  
  
5.  From the **Member Types** drop-down list, select a type of member for the business rule to apply to.  
  
6.  Click **Add**.  
  
7.  In the **Name** box, type a name for the business rule.  
  
8.  Optionally, in the **Description** field, type the business rule description.  
  
9. Under the **Then** block, click **Add**. A panel will be displayed.  
  
10. From the **Operator** drop-down list, select **required action**.  
  
11. From the **Attribute** drop-down list, select an attribute.  
  
12. Click **Save**. A new row will be added to the **Then** grid.  
  
13. Click **Save**.  
  
14. Click **Publish All**.  
  
15. On the confirmation dialog box, click **OK**. The value in the **Business Rule State** column is **Active**.  
  
## Next Steps  
  
-   Apply business rules to data by following one of these procedures:  
  
    -   [Validate Specific Members against Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Validate-Specific-Members-against-Business-Rules--Master-Data-Services-.md)  
  
    -   [Validate a Version against Business Rules (Master Data Services)](../../Topics/TopicNameContainA/Validate-a-Version-against-Business-Rules--Master-Data-Services-.md)  
  
## See Also  
 [Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rules--Master-Data-Services-.md)   
 [Derived Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Derived-Hierarchies--Master-Data-Services-.md)