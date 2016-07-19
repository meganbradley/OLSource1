---
title: Overlapping Model and Member Permissions (Master Data Services)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9fd7a555-43bf-4796-a8b6-1ca63a291216
manager: jhubbard
---
# Overlapping Model and Member Permissions (Master Data Services)
Permission assigned to a member can overlap with permission assigned to a model object. When overlaps occur, the more restrictive permission takes effect.  
  
 If a member has permission that is different than its corresponding model object, the following rules apply:  
  
-   **Deny** overrides all other permissions.  
  
-   **Admin** permission on the Model level overrides all other permissions and is changed to All (CRUD) access permission on sub levels.  
  
-   Effective access permission intersects permissions for members and attributes.  
  
     For example, if member permissions include **Create** and **Update**, the permission for attributes is **Update**. The effective permission is **Update**.  
  
 The following image shows which permissions take effect on an individual attribute value when attribute permissions are different than member permissions.  
  
 ![mds&#95;conc&#95;security&#95;member&#95;overlap&#95;table](../../Topics/TopicNameNotContainA/media/mds_conc_security_member_overlap_table.gif "mds_conc_security_member_overlap_table")  
  
## Example 1  
 ![mds&#95;conc&#95;overlap&#95;model&#95;1](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_1.gif "mds_conc_overlap_model_1")  
  
 On the **Models** tab, the Product entity has **Update** permission assigned. All attributes in the entity inherit that permission.  
  
 On the **Hierarchy Members** tab, the Mountain Bikes subcategory node in a derived hierarchy has **Update** permission assigned.  
  
 Result: In **Explorer**, the user has **Update** permission to all attribute values for all members in the Mountain Bikes node. All other members and attributes are hidden.  
  
 ![mds&#95;conc&#95;overlap&#95;model&#95;example&#95;1](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_example_1.gif "mds_conc_overlap_model_example_1")  
  
## Example 2  
 ![mds&#95;conc&#95;overlap&#95;model&#95;2](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_2.gif "mds_conc_overlap_model_2")  
  
 On the **Models** tab, the Subcategory attribute has **Update** permission assigned.  
  
 On the **Hierarchy Members** tab, the Mountain Bikes subcategory node in a derived hierarchy is explicitly assigned **Read** permission.  
  
 Result: In **Explorer**, the user has **Read** permission to the Subcategory attribute values for the members in the Mountain Bikes node. All other members and attributes are hidden.  
  
 ![mds&#95;conc&#95;overlap&#95;model&#95;example&#95;2](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_example_2.gif "mds_conc_overlap_model_example_2")  
  
## Example 3  
 ![mds&#95;conc&#95;overlap&#95;model&#95;3](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_3.gif "mds_conc_overlap_model_3")  
  
 On the **Models** tab, the Subcategory attribute has **Read** permission assigned.  
  
 On the **Hierarchy Members** tab, the Mountain Bikes subcategory in a derived hierarchy is explicitly assigned **Update** permission.  
  
 Result: In **Explorer**, the user has **Read** permission to the attribute values. All other members and attributes are hidden.  
  
 ![mds&#95;conc&#95;overlap&#95;model&#95;example&#95;2](../../Topics/TopicNameNotContainA/media/mds_conc_overlap_model_example_2.gif "mds_conc_overlap_model_example_2")  
  
## See Also  
 [How Permissions Are Determined (Master Data Services)](../../Topics/TopicNameNotContainA/How-Permissions-Are-Determined--Master-Data-Services-.md)   
 [Overlapping User and Group Permissions (Master Data Services)](../../Topics/TopicNameNotContainA/Overlapping-User-and-Group-Permissions--Master-Data-Services-.md)