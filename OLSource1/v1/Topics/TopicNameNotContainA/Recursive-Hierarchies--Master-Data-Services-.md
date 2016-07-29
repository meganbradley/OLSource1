---
title: "Recursive Hierarchies (Master Data Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9408c6ea-d9c4-4a0b-8a1b-1457fb6944af
caps.latest.revision: 9
manager: jhubbard
---
# Recursive Hierarchies (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], a recursive hierarchy is a derived hierarchy that includes a recursive relationship. A recursive relationship exists when an entity has a domain-based attribute based on the entity itself.  
  
## Recursive Hierarchy Example  
 A typical recursive hierarchy example is an organizational structure. In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], you would do this by creating an Employee entity with a domain-based attribute called Manager. The Manager attribute is populated from the list of employees. In this sample organization, all employees can be managers.  
  
 ![mds&#95;conc&#95;recursive&#95;table&#95;w&#95;data](../../Topics/TopicNameNotContainA/media/mds_conc_recursive_table_w_data.gif "mds_conc_recursive_table_w_data")  
  
 You can create a derived hierarchy that highlights the relationship between the Employee entity and the Manager domain-based attribute.  
  
 ![mds&#95;conc&#95;recursive&#95;UI&#95;structure](../../Topics/TopicNameNotContainA/media/mds_conc_recursive_UI_structure.gif "mds_conc_recursive_UI_structure")  
  
 To include each member in the hierarchy only once, you can anchor null relationships. When you do, members with blank domain-based attribute values are displayed at the top level of the hierarchy.  
  
 ![mds&#95;conc&#95;recursive&#95;UI&#95;example&#95;anchored](../../Topics/TopicNameNotContainA/media/mds_conc_recursive_UI_example_anchored.gif "mds_conc_recursive_UI_example_anchored")  
  
 If you do not anchor null relationships, members are included multiple times. All members are displayed at the top level. They are also displayed under members of which they are attributes.  
  
 ![mds&#95;conc&#95;recursive&#95;UI&#95;example&#95;nonanchored](../../Topics/TopicNameNotContainA/media/mds_conc_recursive_UI_example_nonanchored.gif "mds_conc_recursive_UI_example_nonanchored")  
  
 In this example, Marcia is at the top level. She is not the manager of any employees because she is not used as a domain-based attribute value for any other Employee members. Robert, in contrast, has a level beneath him because Marcia has Robert as her Manager attribute value.  
  
## Rules  
  
-   A derived hierarchy cannot contain more than one recursive relationship. It can, however, have other derived relationships (for example, a derived hierarchy that contains a recursive Manager to Employee relationship can also have Country to Manager and Employee to Store relationships).  
  
-   You cannot assign member permissions (on the **Hierarchy Members** tab) to members in a recursive hierarchy.  
  
-   Recursive hierarchies cannot include circular relationships. For example, Katherine cannot be Sandeep's manager if Sandeep is her manager. Also, Katherine cannot manage herself.  
  
## Related Tasks  
  
|Task Description|Topic|  
|----------------------|-----------|  
|Create a derived hierarchy.|[Create a Derived Hierarchy (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Derived-Hierarchy--Master-Data-Services-.md)|  
|Change the name of an existing derived hierarchy.|[Change a Derived Hierarchy Name (Master Data Services)](../../Topics/TopicNameContainA/Change-a-Derived-Hierarchy-Name--Master-Data-Services-.md)|  
|Delete an existing derived hierarchy.|[Delete a Derived Hierarchy (Master Data Services)](../../Topics/TopicNameContainA/Delete-a-Derived-Hierarchy--Master-Data-Services-.md)|  
  
## Related Content  
  
-   [Domain-Based Attributes (Master Data Services)](../../Topics/TopicNameNotContainA/Domain-Based-Attributes--Master-Data-Services-.md)  
  
-   [Derived Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Derived-Hierarchies--Master-Data-Services-.md)