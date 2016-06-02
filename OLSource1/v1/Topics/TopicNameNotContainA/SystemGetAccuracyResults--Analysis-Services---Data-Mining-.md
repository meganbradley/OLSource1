---
title: SystemGetAccuracyResults (Analysis Services - Data Mining)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 54ff584c-c6ce-4c31-9515-0a645719bd1a
---
# SystemGetAccuracyResults (Analysis Services - Data Mining)
  Returns cross\-validation accuracy metrics for a mining structure and all related models, excluding clustering models.  
  
 This stored procedure returns metrics for the whole data set as a single partition. To partition the dataset into cross\-sections and return metrics for each partition, use [SystemGetCrossValidationResults &#40;Analysis Services - Data Mining&#41;](../Topic/SystemGetCrossValidationResults%20\(Analysis%20Services%20-%20Data%20Mining\).md).  
  
> [!NOTE]  
>  This stored procedure is not supported for models that are built by using the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Time Series algorithm or the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Sequence Clustering algorithm. Also, for clustering models, use the separate stored procedure, [SystemGetClusterAccuracyResults &#40;Analysis Services - Data Mining&#41;](../Topic/SystemGetClusterAccuracyResults%20\(Analysis%20Services%20-%20Data%20Mining\).md).  
  
## Syntax  
  
```  
  
SystemGetAccuracyResults(<mining structure>,   
[,<mining model list>]  
,<data set>  
,<target attribute>  
[,<target state>]  
[,<target threshold>]  
[,<test list>])  
```  
  
## Arguments  
 *mining structure*  
 Name of a mining structure in the current database.  
  
 \(Required\)  
  
 *model list*  
 Comma\-separated list of models to validate.  
  
 The default is **null**. This means that all applicable models are used. When the default is used, clustering models are automatically excluded from the list of candidates for processing.  
  
 \(Optional\)  
  
 *data set*  
 A integer value that indicates which partition in the mining structure is used for testing. The value is derived from a bitmask that represents the sum of the following values, where any single value is optional:  
  
|||  
|-|-|  
|Training cases|0x0001|  
|Test cases|0x0002|  
|Model filter|0x0004|  
  
 For a complete list of possible values, see the Remarks section of this topic.  
  
 \(required\)  
  
 *target attribute*  
 String that contains the name of a predictable object. A predictable object can be a column, nested table column, or nested table key column of a mining model.  
  
 \(required\)  
  
 *target state*  
 String that contains a specific value to predict.  
  
 If a value is specified, the metrics are collected for that specific state.  
  
 If no value is specified, or if null is specified, the metrics are computed for the most probable state for each prediction.  
  
 The default is **null**.  
  
 \(optional\)  
  
 *target threshold*  
 Number between 0.0 and 1 that specifies the minimum probability in which the prediction value is counted as correct.  
  
 The default is **null**, which means that all predictions are counted as correct.  
  
 \(optional\)  
  
 *test list*  
 A string that specifies testing options. This parameter is reserved for future use.  
  
 \(optional\)  
  
## Return Type  
 The rowset that is returned contains scores for each partition and aggregates for all models.  
  
 The following table lists the columns returned by **GetValidationResults**.  
  
|Column Name|Description|  
|-----------------|-----------------|  
|Model|The name of the model that was tested. **All** indicates that the result is an aggregate for all models.|  
|AttributeName|The name of the predictable column.|  
|AttributeState|A target value in the predictable column.<br /><br /> If this column contains a value, metrics are collected for the specified state only.<br /><br /> If this value is not specified, or is null, the metrics are computed for the most probable state for each prediction.|  
|PartitionIndex|Denotes the partition to which the result applies.<br /><br /> For this procedure, always 0.|  
|PartitionCases|An integer that indicates the number of rows in the case set, based on the *\<data set\>* parameter.|  
|Test|The type of test that was performed.|  
|Measure|The name of the measure returned by the test. Measures for each model depend on the model type, and the type of the predictable value.<br /><br /> For a list of measures returned for each predictable type, see [Measures in the Cross-Validation Report](../../Topics\TopicNameNotContainA/Measures-in-the-Cross-Validation-Report.md).<br /><br /> For a definition of each measure, see [Cross-Validation &#40;Analysis Services - Data Mining&#41;](../Topic/Cross-Validation%20\(Analysis%20Services%20-%20Data%20Mining\).md).|  
|Value|The value for the specified measure.|  
  
## Remarks  
 The following table provides examples of the values that you can use to specify the data in the mining structure that is used for cross\-validation. If you want to use test cases for cross\-validation, the mining structure must already contain a testing data set. For information about how to define a testing data set when you create a mining structure, see [Training and Testing Data Sets](../../Topics\TopicNameNotContainA/Training-and-Testing-Data-Sets.md).  
  
|Integer Value|Description|  
|-------------------|-----------------|  
|1|Only training cases are used.|  
|2|Only test cases are used.|  
|3|Both the training cases and testing cases are used.|  
|4|Invalid combination.|  
|5|Only training cases are used, and the model filter is applied.|  
|6|Only test cases are used, and the model filter is applied.|  
|7|Both the training and testing cases are used, and the model filter is applied.|  
  
 For more information about the scenarios in which you would use cross\-validation, see [Testing and Validation &#40;Data Mining&#41;](../Topic/Testing%20and%20Validation%20\(Data%20Mining\).md).  
  
## Examples  
 This example returns accuracy measures for a single decision tree model, `v Target Mail DT`, that is associated with the `vTargetMail` mining structure. The code on line four indicates that the results should be based on the testing cases, filtered for each model by the filter specific to that model.  `[Bike Buyer]` specifies the column that is to be predicted, and the 1 on the following line indicates that the model is to be evaluated only for the specific value 1, meaning "Yes, will buy".  
  
 The final line of the code specifies that the state threshold value is 0.5. This means that predictions that have a probability greater than 50 percent should be counted as "good" predictions when calculating accuracy.  
  
```  
CALL SystemGetAccuracyResults (  
[vTargetMail],  
[vTargetMail DT],  
6,  
'Bike Buyer',  
1,  
0.5  
)  
```  
  
 Sample Results:  
  
|ModelName|AttributeName|AttributeState|PartitionIndex|PartitionSize|Test|Measure|Value|  
|---------------|-------------------|--------------------|--------------------|-------------------|----------|-------------|-----------|  
|v Target Mail DT|Bike Buyer|1|0|1638|Classification|True Positive|605|  
|v Target Mail DT|Bike Buyer|1|0|1638|Classification|False Positive|177|  
|v Target Mail DT|Bike Buyer|1|0|1638|Classification|True Negative|501|  
|v Target Mail DT|Bike Buyer|1|0|1638|Classification|False Negative|355|  
|v Target Mail DT|Bike Buyer|1|0|1638|Likelihood|Log Score|\-0.598454638753028|  
|v Target Mail DT|Bike Buyer|1|0|1638|Likelihood|Lift|0.0936717116894395|  
|v Target Mail DT|Bike Buyer|1|0|1638|Likelihood|Root Mean Square Error|0.361630800104946|  
  
## Requirements  
 Cross\-validation is available only in [!INCLUDE[ssEnterprise](../../Token\Other/ssEnterprise_md.md)] beginning with [!INCLUDE[ssKatmai](../../Token\Other/ssKatmai_md.md)].  
  
## See Also  
 [SystemGetCrossValidationResults &#40;Analysis Services - Data Mining&#41;](../Topic/SystemGetCrossValidationResults%20\(Analysis%20Services%20-%20Data%20Mining\).md)   
 [SystemGetAccuracyResults](../Topic/SystemGetAccuracyResults%20\(Analysis%20Services%20-%20Data%20Mining\).md)   
 [SystemGetClusterCrossValidationResults &#40;Analysis Services - Data Mining&#41;](../Topic/SystemGetClusterCrossValidationResults%20\(Analysis%20Services%20-%20Data%20Mining\).md)   
 [SystemGetClusterAccuracyResults &#40;Analysis Services - Data Mining&#41;](../Topic/SystemGetClusterAccuracyResults%20\(Analysis%20Services%20-%20Data%20Mining\).md)  
  
  