---
title: Naive Bayes Model Query Examples
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e642bd7d-5afa-4dfb-8cca-4f84aadf61b0
---
# Naive Bayes Model Query Examples
  When you create a query against a data mining model, you can create either a content query, which provides details about the patterns discovered in analysis, or you can create a prediction query, which uses the patterns in the model to make predictions for new data. You can also retrieve metadata about the model by using a query against the data mining schema rowset. This section explains how to create these queries for models that are based on the Microsoft Naive Bayes algorithm.  
  
 **Content Queries**  
  
 [Getting model metadata by using DMX](#bkmk_Query1)  
  
 [Retrieving a summary of training data](#bkmk_Query2)  
  
 [Finding more information about attributes](#bkmk_Query3)  
  
 [Using system stored procedures](#bkmk_Query4)  
  
 **Prediction Queries**  
  
 [Predicting outcomes using a singleton query](#bkmk_Query5)  
  
 [Getting predictions with probability and support values](#bkmk_Query6)  
  
 [Predicting associations](#bkmk_Query7)  
  
## Finding Information about a Naive Bayes Model  
 The model content of a Naive Bayes model provides aggregated information about the distribution of values in the training data. You can also retrieve information about the metadata of the model by creating queries against the data mining schema rowsets.  
  
###  <a name="bkmk_Query1"></a> Sample Query 1: Getting Model Metadata by Using DMX  
 By querying the data mining schema rowset, you can find metadata for the model. This might include when the model was created, when the model was last processed, the name of the mining structure that the model is based on, and the name of the columns used as the predictable attribute. You can also return the parameters that were used when the model was created.  
  
```  
SELECT MODEL_CATALOG, MODEL_NAME, DATE_CREATED, LAST_PROCESSED,  
SERVICE_NAME, PREDICTION_ENTITY, FILTER  
FROM $system.DMSCHEMA_MINING_MODELS  
WHERE MODEL_NAME = 'TM_NaiveBayes_Filtered'  
```  
  
 Sample results:  
  
|||  
|-|-|  
|MODEL\_CATALOG|AdventureWorks|  
|MODEL\_NAME|TM\_NaiveBayes\_Filtered|  
|DATE\_CREATED|3\/1\/2008 19:15|  
|LAST\_PROCESSED|3\/2\/2008 20:00|  
|SERVICE\_NAME|Microsoft\_Naive\_Bayes|  
|PREDICTION\_ENTITY|Bike Buyer,Yearly Income|  
|FILTER|\[Region\] \= 'Europe' OR \[Region\] \= 'North America'|  
  
 The model used for this example is based on the Naive Bayes model you create in the [Basic Data Mining Tutorial](../Topic/Basic%20Data%20Mining%20Tutorial.md), but was modified by adding a second predictable attribute and applying a filter to the training data.  
  
###  <a name="bkmk_Query2"></a> Sample Query 2: Retrieving a Summary of Training Data  
 In a Naive Bayes model, the marginal statistics node stores aggregated information about the distribution of values in the training data. This summary is convenient and saves you from having to create SQL queries against the training data to find the same information.  
  
 The following example uses a DMX content query to retrieve the data from the node \(NODE\_TYPE \= 24\). Because the statistics are stored in a nested table, the FLATTENED keyword is used to make the results easier to view.  
  
```  
SELECT FLATTENED MODEL_NAME,  
(SELECT ATTRIBUTE_NAME, ATTRIBUTE_VALUE, [SUPPORT], [PROBABILITY], VALUETYPE FROM NODE_DISTRIBUTION) AS t  
FROM TM_NaiveBayes.CONTENT  
WHERE NODE_TYPE = 26  
```  
  
> [!NOTE]  
>  You must enclose the name of the columns, SUPPORT and PROBABILITY, in brackets to distinguish them from the Multidimensional Expressions \(MDX\) reserved keywords of the same names.  
  
 Partial results:  
  
|MODEL\_NAME|t.ATTRIBUTE\_NAME|t.ATTRIBUTE\_VALUE|t.SUPPORT|t.PROBABILITY|t.VALUETYPE|  
|-----------------|-----------------------|------------------------|---------------|-------------------|-----------------|  
|TM\_NaiveBayes|Bike Buyer|Missing|0|0|1|  
|TM\_NaiveBayes|Bike Buyer|0|8869|0.507263784|4|  
|TM\_NaiveBayes|Bike Buyer|1|8615|0.492736216|4|  
|TM\_NaiveBayes|Gender|Missing|0|0|1|  
|TM\_NaiveBayes|Gender|F|8656|0.495081217|4|  
|TM\_NaiveBayes|Gender|M|8828|0.504918783|4|  
  
 For example, these results tell you the number of training cases for each discrete value \(VALUETYPE \= 4\), together with the computed probability, adjusted for missing values \(VALUETYPE \= 1\).  
  
 For a definition of the values provided in the NODE\_DISTRIBUTION table in a Naive Bayes model, see [Mining Model Content for Naive Bayes Models &#40;Analysis Services - Data Mining&#41;](../Topic/Mining%20Model%20Content%20for%20Naive%20Bayes%20Models%20\(Analysis%20Services%20-%20Data%20Mining\).md). For more information about how support and probability calculations are affected by missing values, see [Missing Values &#40;Analysis Services - Data Mining&#41;](../Topic/Missing%20Values%20\(Analysis%20Services%20-%20Data%20Mining\).md).  
  
###  <a name="bkmk_Query3"></a> Sample Query 3: Finding More Information about Attributes  
 Because a Naive Bayes model often contains complex information about the relationships among different attributes, the easiest way to view these relationships is to use the [Microsoft Naive Bayes Viewer](../../Topics\TopicNameContainA/Browse-a-Model-Using-the-Microsoft-Naive-Bayes-Viewer.md). However, you can create DMX queries to return the data.  
  
 The following example shows how to return information from the model about a particular attribute, `Region`.  
  
```  
SELECT NODE_TYPE, NODE_CAPTION,   
NODE_PROBABILITY, NODE_SUPPORT, MSOLAP_NODE_SCORE  
FROM TM_NaiveBayes.CONTENT  
WHERE ATTRIBUTE_NAME = 'Region'  
```  
  
 This query returns two types of nodes: the node that represents the input attribute \(NODE\_TYPE \= 10\), and nodes for each value of the attribute \(NODE\_TYPE \= 11\). The node caption is used to identify the node, rather than the node name, because the caption shows both the attribute name and attribute value.  
  
|NODE\_TYPE|NODE\_CAPTION|NODE\_PROBABILITY|NODE\_SUPPORT|MSOLAP\_NODE\_SCORE|NODE\_TYPE|  
|----------------|-------------------|-----------------------|-------------------|-------------------------|----------------|  
|10|Bike Buyer \-\> Region|1|17484|84.51555875|10|  
|11|Bike Buyer \-\> Region \= Missing|0|0|0|11|  
|11|Bike Buyer \-\> Region \= North America|0.508236102|8886|0|11|  
|11|Bike Buyer \-\> Region \= Pacific|0.193891558|3390|0|11|  
|11|Bike Buyer \-\> Region \= Europe|0.29787234|5208|0|11|  
  
 Some of the columns stored in the nodes are the same that you can get from the marginal statistics nodes, such as the node probability score and the node support values. However, the MSOLAP\_NODE\_SCORE is a special value provided only for the input attribute nodes, and indicates the relative importance of this attribute in the model. You can see much the same information in the Dependency Network pane of the viewer; however, the viewer does not provide scores.  
  
 The following query returns the importance scores of all attributes in the model:  
  
```  
SELECT NODE_CAPTION, MSOLAP_NODE_SCORE  
FROM TM_NaiveBayes.CONTENT  
WHERE NODE_TYPE = 10  
ORDER BY MSOLAP_NODE_SCORE DESC  
```  
  
 Sample results:  
  
|NODE\_CAPTION|MSOLAP\_NODE\_SCORE|  
|-------------------|-------------------------|  
|Bike Buyer \-\> Total Children|181.3654836|  
|Bike Buyer \-\> Commute Distance|179.8419482|  
|Bike Buyer \-\> English Education|156.9841928|  
|Bike Buyer \-\> Number Children At Home|111.8122599|  
|Bike Buyer \-\> Region|84.51555875|  
|Bike Buyer \-\> Marital Status|23.13297354|  
|Bike Buyer \-\> English Occupation|2.832069191|  
  
 By browsing the model content in the [Microsoft Generic Content Tree Viewer](../../Topics\TopicNameContainA/Browse-a-Model-Using-the-Microsoft-Generic-Content-Tree-Viewer.md), you will get a better idea of what statistics might be interesting. Some simple examples were demonstrated here; more often you may need to execute multiple queries or store the results and process them on the client.  
  
###  <a name="bkmk_Query4"></a> Sample Query 4: Using System Stored Procedures  
 In addition to writing your own content queries, you can use some Analysis Services system stored procedures to explore the results. To use a system stored procedure, prefix the stored procedure name with the CALL keyword:  
  
```  
CALL GetPredictableAttributes ('TM_NaiveBayes')  
```  
  
 Partial results:  
  
|ATTRIBUTE\_NAME|NODE\_UNIQUE\_NAME|  
|---------------------|------------------------|  
|Bike Buyer|100000001|  
  
> [!NOTE]  
>  These system stored procedures are for internal communication between the Analysis Services server and the client and should only be used for convenience when developing and testing mining models. When you create queries for a production system, you should always write your own queries by using DMX.  
  
 For more information about Analysis Services system stored procedures, see [Data Mining Stored Procedures &#40;Analysis Services - Data Mining&#41;](../Topic/Data%20Mining%20Stored%20Procedures%20\(Analysis%20Services%20-%20Data%20Mining\).md).  
  
## Using a Naive Bayes Model to Make Predictions  
 The Microsoft Naive Bayes algorithm is typically used less for prediction than it is for exploration of relationships among the input and predictable attributes. However, the model supports the use of prediction functions for both prediction and association.  
  
###  <a name="bkmk_Query5"></a> Sample Query 5: Predicting Outcomes using a Singleton Query  
 The following query uses a singleton query to provide a new value and predict, based on the model, whether a customer with these characteristics is likely to buy a bike. The easiest way to create a singleton query on a regression model is by using the **Singleton Query Input** dialog box. For example, you can build the following DMX query by selecting the `TM_NaiveBayes` model, choosing **Singleton Query**, and selecting values from the dropdown lists for `[Commute Distance]` and `Gender`.  
  
```  
SELECT  
  Predict([TM_NaiveBayes].[Bike Buyer])  
FROM  
  [TM_NaiveBayes]  
NATURAL PREDICTION JOIN  
(SELECT '5-10 Miles' AS [Commute Distance],  
  'F' AS [Gender]) AS t  
```  
  
 Example results:  
  
|Expression|  
|----------------|  
|0|  
  
 The prediction function returns the most likely value, in this case, 0, which means this type of customer is unlikely to purchase a bike.  
  
###  <a name="bkmk_Query6"></a> Sample Query 6: Getting Predictions with Probability and Support Values  
 In addition to predicting an outcome, you often want to know how strong the prediction is. The following query uses the same singleton query as the previous example, but adds the prediction function, [PredictHistogram &#40;DMX&#41;](../Topic/PredictHistogram%20\(DMX\).md), to return a nested table that contains statistics in support of the prediction.  
  
```  
SELECT  
  Predict([TM_NaiveBayes].[Bike Buyer]),  
  PredictHistogram([TM_NaiveBayes].[Bike Buyer])  
FROM  
  [TM_NaiveBayes]  
NATURAL PREDICTION JOIN  
(SELECT '5-10 Miles' AS [Commute Distance],  
  'F' AS [Gender]) AS t  
```  
  
 Example results:  
  
|Bike Buyer|$SUPPORT|$PROBABILITY|$ADJUSTEDPROBABILITY|$VARIANCE|$STDEV|  
|----------------|--------------|------------------|--------------------------|---------------|------------|  
|0|10161.5714|0.581192599|0.010530981|0|0|  
|1|7321.428768|0.418750215|0.008945684|0|0|  
||0.999828444|5.72E\-05|5.72E\-05|0|0|  
  
 The final row in the table shows the adjustments to support and probability for the missing value. Variance and standard deviation values are always 0, because Naive Bayes models cannot model continuous values.  
  
###  <a name="bkmk_Query7"></a> Sample Query 7: Predicting Associations  
 The Microsoft Naive Bayes algorithm can be used for association analysis, if the mining structure contains a nested table with the predictable attribute as the key. For example, you could build a Naive Bayes model by using the mining structure created in [Lesson 3: Building a Market Basket Scenario &#40;Intermediate Data Mining Tutorial&#41;](../Topic/Lesson%203:%20Building%20a%20Market%20Basket%20Scenario%20\(Intermediate%20Data%20Mining%20Tutorial\).md) of the data mining tutorial. The model used in this example was modified to add information about income and customer region in the case table.  
  
 The following query example shows a singleton query that predicts products that are related to purchases of the product, `'Road Tire Tube'`. You might use this information to recommend products to a specific type of customer.  
  
```  
SELECT   PredictAssociation([Association].[v Assoc Seq Line Items])  
FROM [Association_NB]  
NATURAL PREDICTION JOIN  
(SELECT 'High' AS [Income Group],  
  'Europe' AS [Region],  
  (SELECT 'Road Tire Tube' AS [Model])   
AS [v Assoc Seq Line Items])   
AS t  
```  
  
 Partial results:  
  
|Model|  
|-----------|  
|Women's Mountain Shorts|  
|Water Bottle|  
|Touring\-3000|  
|Touring\-2000|  
|Touring\-1000|  
  
## Function List  
 All [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] algorithms support a common set of functions. However, the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Naive Bayes algorithm supports the additional functions that are listed in the following table.  
  
|||  
|-|-|  
|Prediction Function|Usage|  
|[IsDescendant &#40;DMX&#41;](../Topic/IsDescendant%20\(DMX\).md)|Determines whether one node is a child of another node in the model.|  
|[Predict &#40;DMX&#41;](../Topic/Predict%20\(DMX\).md)|Returns a predicted value, or set of values, for a specified column.|  
|[PredictAdjustedProbability &#40;DMX&#41;](../Topic/PredictAdjustedProbability%20\(DMX\).md)|Returns the weighted probability.|  
|[PredictAssociation &#40;DMX&#41;](../Topic/PredictAssociation%20\(DMX\).md)|Predicts membership in an associative dataset.|  
|[PredictNodeId &#40;DMX&#41;](../Topic/PredictNodeId%20\(DMX\).md)|Returns the Node\_ID for each case.|  
|[PredictProbability &#40;DMX&#41;](../Topic/PredictProbability%20\(DMX\).md)|Returns probability for the predicted value.|  
|[PredictSupport &#40;DMX&#41;](../Topic/PredictSupport%20\(DMX\).md)|Returns the support value for a specified state.|  
  
 To see  the syntax of specific functions, see [Data Mining Extensions &#40;DMX&#41; Function Reference](../Topic/Data%20Mining%20Extensions%20\(DMX\)%20Function%20Reference.md).  
  
## See Also  
 [Microsoft Naive Bayes Algorithm Technical Reference](../../Topics\TopicNameNotContainA/Microsoft-Naive-Bayes-Algorithm-Technical-Reference.md)   
 [Microsoft Naive Bayes Algorithm](../../Topics\TopicNameNotContainA/Microsoft-Naive-Bayes-Algorithm.md)   
 [Mining Model Content for Naive Bayes Models &#40;Analysis Services - Data Mining&#41;](../Topic/Mining%20Model%20Content%20for%20Naive%20Bayes%20Models%20\(Analysis%20Services%20-%20Data%20Mining\).md)  
  
  