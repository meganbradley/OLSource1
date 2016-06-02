---
title: Initiate Actions Based on Attribute Value Changes (Master Data Services)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5e4402ce-31db-4774-a2a1-552335f87693
---
# Initiate Actions Based on Attribute Value Changes (Master Data Services)
  In [!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)], create a business rule to initiate actions based on changes to attribute values. For example, when a specific attribute value changes, you may want to change a value, send a notification, or start an external workflow.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators &#40;Master Data Services&#41;](../Topic/Administrators%20\(Master%20Data%20Services\).md).  
  
-   Your attributes must be in a change tracking group. See [Add Attributes to a Change Tracking Group &#40;Master Data Services&#41;](../Topic/Add%20Attributes%20to%20a%20Change%20Tracking%20Group%20\(Master%20Data%20Services\).md) for more information.  
  
### To create a business rule to initiate actions based on attribute value changes  
  
1.  In [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  From the menu bar, point to **Manage** and click **Business Rules**.  
  
3.  On the **Business Rule Maintenance** page, from the **Model** list, select a model.  
  
4.  From the **Entity** list, select an entity.  
  
5.  From the **Member Type** list, select a type of member for the business rule to apply to.  
  
6.  From the **Attribute** list, select an attribute or leave the default of **All**.  
  
7.  Click **Add business rule**.  
  
8.  Click **Edit selected business rule**.  
  
9. In the **Components** pane, expand the **Conditions** node.  
  
10. Under the **Value comparison** node, drag **has changed** to the **IF** pane's **Conditions** label.  
  
11. In the **Edit Condition** pane, in the **Change tracking group** box, type the number of the change tracking group that you assigned as part of the prerequisites.  
  
12. In the **Edit Condition** pane, click **Save item**.  
  
13. In the **Components** pane, expand the **Actions** node.  
  
14. Click an action and drag it to the **THEN** pane's **Action** label.  
  
15. In the **Attributes** pane, click an attribute and drag it to the **Edit Action** pane's **Select attribute** label.  
  
16. In the **Edit Action** pane, complete any required fields.  
  
17. In the **Edit Action** pane, click **Save item**.  
  
18. Click **Back**.  
  
19. Optionally, on the **Business Rules Maintenance** page, for the row that contains your business rule, double\-click a cell in the **Name**, **Description**, or **Notification** column to update the value.  
  
    > [!NOTE]  
    >  Notifications are sent only for rules that include a validation action.  
  
20. Click **Publish business rules**.  
  
21. On the confirmation dialog box, click **OK**. The rule's status changes to **Active**.  
  
## Next Steps  
  
-   Apply business rules to data by following one of these procedures:  
  
    -   [Validate Specific Members against Business Rules &#40;Master Data Services&#41;](../Topic/Validate%20Specific%20Members%20against%20Business%20Rules%20\(Master%20Data%20Services\).md)  
  
    -   [Validate a Version against Business Rules &#40;Master Data Services&#41;](../Topic/Validate%20a%20Version%20against%20Business%20Rules%20\(Master%20Data%20Services\).md)  
  
## See Also  
 [Add Attributes to a Change Tracking Group &#40;Master Data Services&#41;](../Topic/Add%20Attributes%20to%20a%20Change%20Tracking%20Group%20\(Master%20Data%20Services\).md)   
 [Business Rules &#40;Master Data Services&#41;](../Topic/Business%20Rules%20\(Master%20Data%20Services\).md)  
  
  