---
title: Aggregate Transformation
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2871cf2a-fbd3-41ba-807d-26ffff960e81
---
# Aggregate Transformation
  The Aggregate transformation applies aggregate functions, such as Average, to column values and copies the results to the transformation output. Besides aggregate functions, the transformation provides the GROUP BY clause, which you can use to specify groups to aggregate across.  
  
## Operations  
 The Aggregate transformation supports the following operations.  
  
|Operation|Description|  
|---------------|-----------------|  
|Group by|Divides datasets into groups. Columns of any data type can be used for grouping. For more information, see [GROUP BY &#40;Transact-SQL&#41;](../Topic/GROUP%20BY%20\(Transact-SQL\).md).|  
|Sum|Sums the values in a column. Only columns with numeric data types can be summed. For more information, see [SUM &#40;Transact-SQL&#41;](../Topic/SUM%20\(Transact-SQL\).md).|  
|Average|Returns the average of the column values in a column. Only columns with numeric data types can be averaged. For more information, see [AVG &#40;Transact-SQL&#41;](../Topic/AVG%20\(Transact-SQL\).md).|  
|Count|Returns the number of items in a group. For more information, see [COUNT &#40;Transact-SQL&#41;](../Topic/COUNT%20\(Transact-SQL\).md).|  
|Count distinct|Returns the number of unique nonnull values in a group.|  
|Minimum|Returns the minimum value in a group. For more information, see [MIN &#40;Transact-SQL&#41;](../Topic/MIN%20\(Transact-SQL\).md). In contrast to the Transact\-SQL MIN function, this operation can be used only with numeric, date, and time data types.|  
|Maximum|Returns the maximum value in a group. For more information, see [MAX &#40;Transact-SQL&#41;](../Topic/MAX%20\(Transact-SQL\).md). In contrast to the Transact\-SQL MAX function, this operation can be used only with numeric, date, and time data types.|  
  
 The Aggregate transformation handles null values in the same way as the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] relational database engine. The behavior is defined in the SQL\-92 standard. The following rules apply:  
  
-   In a GROUP BY clause, nulls are treated like other column values. If the grouping column contains more than one null value, the null values are put into a single group.  
  
-   In the COUNT \(column name\) and COUNT \(DISTINCT column name\) functions, nulls are ignored and the result excludes rows that contain null values in the named column.  
  
-   In the COUNT \(\*\) function, all rows are counted, including rows with null values.  
  
## Big Numbers in Aggregates  
 A column may contain numeric values that require special consideration because of their large value or precision requirements. The Aggregation transformation includes the IsBig property, which you can set on output columns to invoke special handling of big or high\-precision numbers. If a column value may exceed 4 billion or a precision beyond a float data type is required, IsBig should be set to 1.  
  
 Setting the IsBig property to 1 affects the output of the aggregation transformation in the following ways:  
  
-   The DT\_R8 data type is used instead of the DT\_R4 data type.  
  
-   Count results are stored as the DT\_UI8 data type.  
  
-   Distinct count results are stored as the DT\_UI4 data type.  
  
> [!NOTE]  
>  You cannot set IsBig to 1 on columns that are used in the GROUP BY, Maximum, or Minimum operations.  
  
## Performance Considerations  
 The Aggregate transformation includes a set of properties that you can set to enhance the performance of the transformation.  
  
-   When performing a **Group by** operation, set the Keys or KeysScale properties of the component and the component outputs. Using Keys, you can specify the exact number of keys the transformation is expected to handle. \(In this context, Keys refers to the number of groups that are expected to result from a **Group by** operation.\) Using KeysScale, you can specify an approximate number of keys. When you specify an appropriate value for Keys or KeyScale, you improve performance because the tranformation is able to allocate adequate memory for the data that the transformation caches.  
  
-   When performing a **Distinct count** operation, set the CountDistinctKeys or CountDistinctScale properties of the component. Using CountDistinctKeys, you can specify the exact number of keys the transformation is expected to handle for a count distinct operation. \(In this context, CountDistinctKeys refers to the number of distinct values that are expected to result from a **Distinct count** operation.\) Using CountDistinctScale, you can specify an approximate number of keys for a count distinct operation. When you specify an appropriate value for CountDistinctKeys or CountDistinctScale, you improve performance because the transformation is able to allocate adequate memory for the data that the transformation caches.  
  
## Aggregate Transformation Configuration  
 You configure the Aggregate transformation at the transformation, output, and column levels.  
  
-   At the transformation level, you configure the Aggregate transformation for performance by specifying the following values:  
  
    -   The number of groups that are expected to result from a **Group by** operation.  
  
    -   The number of distinct values that are expected to result from a **Count distinct** operation.  
  
    -   The percentage by which memory can be extended during the aggregation.  
  
     The Aggregate transformation can also be configured to generate a warning instead of failing when the value of a divisor is zero.  
  
-   At the output level, you configure the Aggregate transformation for performance by specifying the number of groups that are expected to result from a **Group by** operation. The Aggregate transformation supports multiple outputs, and each can be configured differently.  
  
-   At the column level, you specify the following values:  
  
    -   The aggregation that the column performs.  
  
    -   The comparison options of the aggregation.  
  
 You can also configure the Aggregate transformation for performance by specifying these values:  
  
-   The number of groups that are expected to result from a **Group by** operation on the column.  
  
-   The number of distinct values that are expected to result from a **Count distinct** operation on the column.  
  
 You can also identify columns as IsBig if a column contains large numeric values or numeric values with high precision.  
  
 The Aggregate transformation is asynchronous, which means that it does not consume and publish data row by row. Instead it consumes the whole rowset, performs its groupings and aggregations, and then publishes the results.  
  
 This transformation does not pass through any columns, but creates new columns in the data flow for the data it publishes. Only the input columns to which aggregate functions apply or the input columns the transformation uses for grouping are copied to the transformation output. For example, an Aggregate transformation input might have three columns: **CountryRegion**, **City**, and **Population**. The transformation groups by the **CountryRegion** column and applies the Sum function to the **Population** column. Therefore the output does not include the **City** column.  
  
 You can also add multiple outputs to the Aggregate transformation and direct each aggregation to a different output. For example, if the Aggregate transformation applies the Sum and the Average functions, each aggregation can be directed to a different output.  
  
 You can apply multiple aggregations to a single input column. For example, if you want the sum and average values for an input column named **Sales**, you can configure the transformation to apply both the Sum and Average functions to the **Sales** column.  
  
 The Aggregate transformation has one input and one or more outputs. It does not support an error output.  
  
 You can set properties through [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer or programmatically.  
  
 For more information about the properties that you can set in the **Aggregate Transformation Editor** dialog box, click one of the following topics:  
  
-   [Aggregate Transformation Editor &#40;Aggregations Tab&#41;](../Topic/Aggregate%20Transformation%20Editor%20\(Aggregations%20Tab\).md)  
  
-   [Aggregate Transformation Editor &#40;Advanced Tab&#41;](../Topic/Aggregate%20Transformation%20Editor%20\(Advanced%20Tab\).md)  
  
 The **Advanced Editor** dialog box reflects the properties that can be set programmatically. For more information about the properties that you can set in the **Advanced Editor** dialog box or programmatically, click one of the following topics:  
  
-   [Common Properties](../../Topics\TopicNameNotContainA/Common-Properties.md)  
  
-   [Transformation Custom Properties](../../Topics\TopicNameNotContainA/Transformation-Custom-Properties.md)  
  
 For more information about how to set properties, click one of the following topics:  
  
-   [Aggregate Values in a Dataset by Using the Aggregate Transformation](../../Topics\TopicNameContainA/Aggregate-Values-in-a-Dataset-by-Using-the-Aggregate-Transformation.md)  
  
-   [Set the Properties of a Data Flow Component](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Data-Flow-Component.md)  
  
-   [Sort Data for the Merge and Merge Join Transformations](../../Topics\TopicNameNotContainA/Sort-Data-for-the-Merge-and-Merge-Join-Transformations.md)  
  
## Related Tasks  
 [Aggregate Values in a Dataset by Using the Aggregate Transformation](../../Topics\TopicNameContainA/Aggregate-Values-in-a-Dataset-by-Using-the-Aggregate-Transformation.md)  
  
## See Also  
 [Data Flow](../../Topics\TopicNameNotContainA/Data-Flow.md)   
 [Integration Services Transformations](../../Topics\TopicNameNotContainA/Integration-Services-Transformations.md)  
  
  