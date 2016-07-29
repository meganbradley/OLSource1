---
title: "Content Types (Data Mining)"
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
ms.assetid: 2dacd968-70e8-4993-88b6-a6d36024a4e4
caps.latest.revision: 43
manager: paulettm
---
# Content Types (Data Mining)
In [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)], you can define the both the physical data type for a column in a mining structure, and a logical content type for the column when used in a model,  
  
 The *data type* determines how algorithms process the data in those columns when you create mining models. Defining the data type of a column gives the algorithm information about the type of data in the columns, and how to process the data. Each data type in [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] supports one or more content types for data mining.  
  
 The *content type* describes the behavior of the content that the column contains. For example, if the content in a column repeats in a specific interval, such as days of the week, you can specify the content type of that column as cyclical.  
  
 Some algorithms require specific data types and specific content types to be able to function correctly. For example, the Microsoft Naive Bayes algorithm cannot use continuous columns as input, and cannot predict continuous values. Some content types, such as Key Sequence, are used only by a specific algorithm. For a list of the algorithms and the content types that each supports, see [Data Mining Algorithms (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Algorithms--Analysis-Services---Data-Mining-.md).  
  
 The following list describes the content types that are used in data mining, and identifies the data types that support each type.  
  
## Discrete  
 *Discrete* means that the column contains a finite number of values with no continuum between values. For example, a gender column is a typical discrete attribute column, in that the data represents a specific number of categories.  
  
 The values in a discrete attribute column cannot imply ordering, even if the values are numeric. Moreover, even if the values used for the discrete column are numeric, fractional values cannot be calculated. Telephone area codes are a good example of discrete data that is numeric.  
  
 The **Discrete** content type is supported by all data mining data types.  
  
## Continuous  
 *Continuous* means that the column contains values that represent numeric data on a scale that allows interim values. Unlike a discrete column, which represents finite, countable data, a continuous column represents scalable measurements, and it is possible for the data to contain an infinite number of fractional values. A column of temperatures is an example of a continuous attribute column.  
  
 When a column contains continuous numeric data, and you know how the data should be distributed, you can potentially improve the accuracy of the analysis by specifying the expected distribution of values. You specify the column distribution at the level of the mining structure. Therefore, the setting applies to all models that are based on the structure, For more information, see [Column Distributions (Data Mining)](../../Topics/TopicNameNotContainA/Column-Distributions--Data-Mining-.md).  
  
 The **Continuous** content type is supported by the following data types: **Date**, **Double**, and **Long**.  
  
## Discretized  
 *Discretization* is the process of putting values of a continuous set of data into buckets so that there are a limited number of possible values. You can discretize only numeric data.  
  
 Thus, the *discretized* content type indicates that the column contains values that represent groups, or buckets, of values that are derived from a continuous column. The buckets are treated as ordered and discrete values.  
  
 You can discretize your data manually, to ensure that you get the buckets you want, or you can use the discretization methods provided in SQL Server Analysis Services. Some algorithms perform discretization automatically. For more information, see [Change the Discretization of a Column in a Mining Model](../../Topics/TopicNameContainA/Change-the-Discretization-of-a-Column-in-a-Mining-Model.md).  
  
 The **Discretized** content type is supported by the following data types: **Date**, **Double**, **Long**, and **Text**.  
  
## Key  
 The *key* content type means that the column uniquely identifies a row. In a case table, typically the key column is a numeric or text identifier. You set the content type to **key** to indicate that the column should not be used for analysis, only for tracking records.  
  
 Nested tables also have keys, but the usage of the nested table key is a little different. You set the content type to **key** in a nested table if the column is the attribute that you want to analyze. The values in the nested table key must be unique for each case but there can be duplicates across the entire set of cases.  
  
 For example, if you are analyzing the products that customers purchase, you would set content type to key for the **CustomerID** column in the case table, and set content type to key again for the **PurchasedProducts** column in the nested table.  
  
> [!NOTE]  
>  Nested tables are available only if you use data from an external data source that has been defined as an Analysis services data source view.  
  
 This content type is supported by the following data types: **Date**, **Double**, **Long**, and **Text**.  
  
## Key Sequence  
 The *key sequence* content type can only be used in sequence clustering models. When you set content type to **key sequence**, it indicates that the column contains values that represent a sequence of events. The values are ordered, but do not have to be an equal distance apart.  
  
 This content type is supported by the following data types: **Double**, **Long**, **Text**, and **Date**.  
  
## Key Time  
 The *key time* content type can only be used in time series models. When you set content type to **key time**, it indicates that the values are ordered and represent a time scale.  
  
 This content type is supported by the following data types: **Double**, **Long**, and **Date**.  
  
## Table  
 The *table* content type indicates that the column contains another data table, with one or more columns and one or more rows. For any particular row in the case table, this column can contain multiple values, all related to the parent case record. For example, if the main case table contains a listing of customers, you could have several columns that contain nested tables, such as a **ProductsPurchased** column, where the nested table lists products bought by this customer in the past, and a **Hobbies** column that lists the interests of the customer.  
  
 The data type of this column is always **Table**.  
  
## Cyclical  
 The *cyclical* content type means that the column contains values that represent a cyclical ordered set. For example, the numbered days of the week is a cyclical ordered set, because day number one follows day number seven.  
  
 Cyclical columns are considered both ordered and discrete in terms of content type.  
  
 This content type is supported by all the data mining data types in [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)]. However, most algorithms treat cyclical values as discrete values and do not perform special processing.  
  
## Ordered  
 The *Ordered* content type also indicates that the column contains values that define a sequence or order. However, in this content type the values used for ordering do not imply any distance or magnitude relationship between values in the set. For example, if an ordered attribute column contains information about skill levels in rank order from one to five, there is no implied information in the distance between skill levels; a skill level of five is not necessarily five times better than a skill level of one.  
  
 Ordered attribute columns are considered to be discrete in terms of content type.  
  
 This content type is supported by all the data mining data types in [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)]. However, however, most algorithms treat ordered values as discrete values and do not perform special processing.  
  
## Classified  
 In addition to the preceding content types that are in common use with all models, for some data types you can use classified columns to define content types. For more information about classified columns, see [Classified Columns (Data Mining)](../../Topics/TopicNameNotContainA/Classified-Columns--Data-Mining-.md).  
  
## See Also  
 [Content Types (DMX)](assetId:///ab9dd887-df8d-4878-96b0-635881892573)   
 [Data Types (Data Mining)](../../Topics/TopicNameNotContainA/Data-Types--Data-Mining-.md)   
 [Data Types (DMX)](assetId:///4d81fe82-b187-4f80-b8ea-fe37423123a6)   
 [Change the Properties of a Mining Structure](../../Topics/TopicNameContainA/Change-the-Properties-of-a-Mining-Structure.md)   
 [Mining Structure Columns](../../Topics/TopicNameNotContainA/Mining-Structure-Columns.md)