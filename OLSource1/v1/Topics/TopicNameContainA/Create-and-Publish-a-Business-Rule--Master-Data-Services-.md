---
title: Create and Publish a Business Rule (Master Data Services)
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
ms.assetid: 6961d636-4d69-468e-81f7-8d0be6a4a039
manager: jhubbard
---
# Create and Publish a Business Rule (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], create a business rule to ensure the accuracy of your master data. After you create a rule, you must publish it before you can apply it to data.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
### To create and publish a business rule  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  From the menu bar, point to **Manage** and click **Business Rules**.  
  
3.  On the **Business Rule** page, from the **Model** drop-down list, select a model.  
  
4.  From the **Entity** drop-down list, select an entity.  
  
5.  From the **Member Types** drop-down list, select a type of member for the business rule to apply to.  
  
6.  Click **Add**.  
  
7.  In the **Name** box, type a name for the business rule.  
  
8.  Optionally, in the **Description** field, type the business rule description.  
  
9. Optionally, check the **Send Notifications** option and from the drop-down list select a user or group to send the email notification to.  
  
    > [!NOTE]  
    >  Notifications are sent only for rules that include a validation action.  
  
10. Under the **If** block, click **Add**. A panel will be displayed.  
  
11. From the **Attribute** drop-down list, select an attribute.  
  
12. From the **Operator** drop-down list, select a condition.  
  
13. Complete any required fields.  
  
14. Click **Save** button. A new row will be added to the **If** grid.  
  
    > [!TIP]  
    >  You can delete items from your business rule by right-clicking each item and choosing **Delete**.  
  
15. Optionally, add multiple conditions to the rule. For more information, see [Add Multiple Conditions to a Business Rule (Master Data Services)](../../Topics/TopicNameContainA/Add-Multiple-Conditions-to-a-Business-Rule--Master-Data-Services-.md).  
  
16. Under the **Then** block, click **Add** . A panel will be displayed.  
  
17. From the **Attribute** drop-down list, select an attribute.  
  
18. From the **Operator** drop-down list, select an action.  
  
19. Complete any required fields.  
  
20. Click **Save**. A new row will be added to the **Then** grid.  
  
21. Optionally, to add **Else** action, complete the following steps.  
  
    1.  Under the **Else** block, click **Add**. A panel will be displayed.  
  
    2.  From the **Attribute** drop-down list, select an attribute.  
  
    3.  From the **Operator** drop-down list, select an action.  
  
    4.  Complete any required fields.  
  
    5.  Click **Save**. A new row will be added to the **Else** grid.  
  
22. Click **Save**. A new row will be added to the business rules grid.  
  
23. Click **Publish All**.  
  
24. On the confirmation dialog box, click **OK**. The value in the **Business Rule State** column is **Active**.  
  
## Grid Columns  
 For each created business rule, a row with six columns is added to the grid. The following are the columns.  
  
|Name|Description|  
|----------|-----------------|  
|Status|When you click **Save** the following image is displayed that indicates that the business rule is updating.<br /><br /> ![mds&#95;BR&#95;refresh](../../Topics/TopicNameContainA/media/mds_BR_refresh.png "mds_BR_refresh")<br /><br /> If there are errors when creating or editing a business rule, the following image is displayed.<br /><br /> ![mds&#95;br&#95;error](../../Topics/TopicNameContainA/media/mds_BR_error.png "mds_BR_error")<br /><br /> If the status is OK, then the following image is displayed.<br /><br /> ![mds&#95;BR&#95;success](../../Topics/TopicNameContainA/media/mds_BR_success.png "mds_BR_success")|  
|Name|The business rule name.|  
|Description|The business rule description.|  
|Business Rule State|One of the following business rule statuses: : Rule not defined, Active, Excluded, Pending Changes, Pending Exclusion and Pending Deletion.|  
|Excluded|Specifies whether the business rule is excluded.|  
|Notification|Specifies the selected user or group to send the email notification to.|  
  
## Next Steps  
  
-   Apply business rules to data by following one of these procedures:  
  
    -   [Validate Specific Members against Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Validate-Specific-Members-against-Business-Rules--Master-Data-Services-.md)  
  
    -   [Validate a Version against Business Rules (Master Data Services)](../../Topics/TopicNameContainA/Validate-a-Version-against-Business-Rules--Master-Data-Services-.md)  
  
## See Also  
 [Configure Business Rules to Send Notifications (Master Data Services)](../../Topics/TopicNameNotContainA/Configure-Business-Rules-to-Send-Notifications--Master-Data-Services-.md)   
 [Change a Business Rule Name (Master Data Services)](../../Topics/TopicNameContainA/Change-a-Business-Rule-Name--Master-Data-Services-.md)   
 [Add Multiple Conditions to a Business Rule (Master Data Services)](../../Topics/TopicNameContainA/Add-Multiple-Conditions-to-a-Business-Rule--Master-Data-Services-.md)