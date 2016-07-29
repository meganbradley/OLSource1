---
title: "Using Member Properties (MDX)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 26b5ad08-3799-4a5e-89f3-dca25e637d45
caps.latest.revision: 30
manager: mblythe
---
# Using Member Properties (MDX)
Member properties cover the basic information about each member in each tuple. This basic information includes the member name, parent level, the number of children, and so on. Member properties are available for all members at a given level. In terms of organization, member properties are treated as dimensionally organized data, stored on a single dimension.  
  
> [!NOTE]  
>  In [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], member properties are know as attribute relationships. For more information, see [Creating and Using Property Values (MDX)](assetId:///2491422a-4cf5-4b23-b6ab-289222b22ce8).  
  
 Member properties are either *intrinsic* or *custom*:  
  
 Intrinsic member properties  
 All members support intrinsic member properties, such as the formatted value of a member, while dimensions and levels supply additional intrinsic dimension and level member properties, such as the ID of a member.  
  
 For more information, see [Intrinsic Member Properties (MDX)](../../Topics/TopicNameNotContainA/Intrinsic-Member-Properties--MDX-.md).  
  
 User-defined member properties  
 Members often have additional properties associated with them. For example, the Products level may offer the SKU, SRP, Weight, and Volume properties for each product. These properties are not members, but contain additional information about members at the Products level.  
  
 For more information, see [User-Defined Member Properties (MDX)](../../Topics/TopicNameNotContainA/User-Defined-Member-Properties--MDX-.md).  
  
 Both intrinsic and user-defined member properties can be retrieved through the use of the **PROPERTIES** keyword or the [Properties](assetId:///2d8442c5-30c4-4fd1-99ea-9845b6533e41) function.  
  
## Using the PROPERTIES Keyword  
 The **PROPERTIES** keyword specifies the member properties that are to be used for a given axis dimension. The **PROPERTIES** keyword is buried within the `<axis specification>` clause of the MDX [SELECT](assetId:///c0a57214-aa3f-44ce-a369-660c69746f34) statement:  
  
```  
SELECT [<axis_specification>  
       [, <axis_specification>...]]  
  FROM [<cube_specification>]  
[WHERE [<slicer_specification>]]  
```  
  
 The `<axis_specification>` clause includes an optional `<dim_props>` clause, as shown in the following syntax:  
  
```  
<axis_specification> ::= <set> [<dim_props>] ON <axis_name>  
```  
  
> [!NOTE]  
>  For more information about the `<set>` and `<axis_name>` values, see [Specifying the Contents of a Query Axis (MDX)](../../Topics/TopicNameContainA/Specifying-the-Contents-of-a-Query-Axis--MDX-.md).  
  
 The `<dim_props>` clause lets you query dimension, level, and member properties using the **PROPERTIES** keyword. The following syntax shows the formatting of the `<dim_props>` clause:  
  
```  
<dim_props> ::= [DIMENSION] PROPERTIES <property> [,<property>...]  
```  
  
 The breakdown of the `<property>` syntax varies depending on the property that you are querying:  
  
-   Context sensitive intrinsic member properties must be preceded with the name of the dimension or level. However, non-context sensitive intrinsic member properties cannot be qualified by the dimension or level name. For more information about how to use the **PROPERTIES** keyword with intrinsic member properties, see [Intrinsic Member Properties (MDX)](../../Topics/TopicNameNotContainA/Intrinsic-Member-Properties--MDX-.md).  
  
-   User-defined member properties should be preceded by the name of the level in which they reside. For more information about how to use the **PROPERTIES** keyword with user-defined member properties, see [User-Defined Member Properties (MDX)](../../Topics/TopicNameNotContainA/User-Defined-Member-Properties--MDX-.md).  
  
## See Also  
 [Creating and Using Property Values (MDX)](../../Topics/TopicNameNotContainA/Creating-and-Using-Property-Values--MDX-.md)