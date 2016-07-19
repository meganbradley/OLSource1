---
title: Data Mining Queries
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 802806a6-69bb-4c3c-b9aa-d1a1ddfc7fc2
manager: paulettm
---
# Data Mining Queries
Data mining queries are useful for many purposes. You can:  
  
-   Apply the model to new data, to make single or multiple predictions. You can provide input values as parameters, or in a batch.  
  
-   Get a statistical summary of the data used for training.  
  
-   Extract patterns and rules, or generate a profile of the typical case representing a pattern in the model.  
  
-   Extract regression formulas and other calculations that explain patterns.  
  
-   Get the cases that fit a particular pattern.  
  
-   Retrieve details about individual cases used in the model, including data not used in analysis.  
  
-   Retrain a model by adding new data, or perform cross-prediction.  
  
 This section provides an overview of the information you need to get started with data mining queries. It describes the types of queries you can create against data mining objects, introduces the query tools and query languages, and provides links to examples of queries that you can create against models that were built using the algorithms provided in SQL Server Data Mining.  
  
 [Understanding Data Mining Queries](#bkmk_Understand)  
  
 [Query Tools and Interfaces](#bkmk_Interfaces)  
  
 [Queries for Different Model Types](#bkmk_ModelTypes)  
  
 [Requirements](#bkmk_Reqs)  
  
##  <a name="bkmk_Understand"></a> Understanding Data Mining Queries  
 [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] Data Mining supports the following types of queries:  
  
-   [Prediction Queries (Data Mining)](../../Topics/TopicNameNotContainA/Prediction-Queries--Data-Mining-.md)  
  
     Queries that make inferences based on patterns in the model, and from input data.  
  
-   [Content Queries (Data Mining)](../../Topics/TopicNameNotContainA/Content-Queries--Data-Mining-.md)  
  
     Queries that return metadata, statistics, and other information about the model itself.  
  
-   [Drillthrough Queries (Data Mining)](../../Topics/TopicNameNotContainA/Drillthrough-Queries--Data-Mining-.md)  
  
     Queries that can retrieve the underlying case data for the model, or even data from the structure that was not used in the model.  
  
-   [Data Definition Queries (Data Mining)](../../Topics/TopicNameNotContainA/Data-Definition-Queries--Data-Mining-.md)  
  
     Queries that do not return information from the model, but rather are used to build models and structures or to update the data in a model or structure.  
  
 Before you create queries, we recommend that you familiarize yourself with the differences between models created with each of the data mining algorithms provided by SQL Server.  
  
-   Browse and explore each model type by using the custom data mining viewers that are provided for each algorithm type. For more information, see [Mining Model Viewer Tasks and How-tos](../../Topics/TopicNameNotContainA/Mining-Model-Viewer-Tasks-and-How-tos.md).  
  
-   Review the model content for each model type, by using the **Microsoft Generic Content Tree Viewer**. To interpret this information, refer to [Mining Model Content (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Model-Content--Analysis-Services---Data-Mining-.md).  
  
##  <a name="bkmk_Interfaces"></a> Query Tools and Interfaces  
 You can build data mining queries interactively by using one of the query tools provided by SQL Server. The graphical Prediction Query Builder is provided in both [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. If you have not used the Prediction Query Builder before, we recommend that you follow the steps in the [Basic Data Mining Tutorial](assetId:///6602edb6-d160-43fb-83c8-9df5dddfeb9c) to familiarize yourself with the interface. For q quick overview of the steps, see Create a Query using the [Create a Prediction Query Using the Prediction Query Builder](../../Topics/TopicNameContainA/Create-a-Prediction-Query-Using-the-Prediction-Query-Builder.md).  
  
 The Prediction Query Builder is helpful for starting queries that you will customize later. You can easily add data sources and map them to columns, and then switch to DMX view and customize the query by adding a WHERE clause or other functions.  
  
 Once you are familiar with data mining models and how to build queries, you can also write queries directly by using Data Mining Extensions (DMX). DMX is a query language that is similar to Transact-SQL, and that you can use from many different clients. DMX is the tool of choice for creating both custom predictions and complex queries. For an introduction to DMX, see [DMX tutorials](assetId:///145b81a7-c0c3-4ca3-bb32-0b482423b9a0).  
  
 DMX editors are provided in both [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. You can also use the Prediction Query Builder to start your queries, then change the view to the text editor and copy the DMX statement to another client. For more information, see [Data Mining Query Tools](../../Topics/TopicNameNotContainA/Data-Mining-Query-Tools.md).  
  
 You can compose DMX statements programmatically and send them from your client to the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] server by using AMO or XMLA. However, DMX is the language that you must use to create queries against a mining model.  
  
 You can also query the metadata, statistics, and some content of the model by using Dynamic Management Views (DMVs) that are based on the data mining schema rowsets. These DMVs make it easy to retrieve information about the model by typing SELECT statements; however, you cannot create predictions. For more information about DMVs supported by [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)], see [Use Dynamic Management Views (DMVs) to Monitor Analysis Services](../../Topics/TopicNameNotContainA/Use-Dynamic-Management-Views--DMVs--to-Monitor-Analysis-Services.md).  
  
 Finally, you can create data mining queries for use in Integration Services packages, by using the [Data Mining Query Task](../../Topics/TopicNameNotContainA/Data-Mining-Query-Task.md), or the [Data Mining Query Transformation](../../Topics/TopicNameNotContainA/Data-Mining-Query-Transformation.md). The control flow task supports multiple types of DMX queries, whereas the data flow transformation supports only queries that work with data in the data flow, meaning queries that use the PREDICTION JOIN syntax.  
  
##  <a name="bkmk_ModelTypes"></a> Queries for Different Model Types  
 The algorithm that was used when the model was created greatly influences the type of information that you can get from a data mining query. The reason for the differences is that each algorithm processes the data in a different way, and stores different kinds of patterns. For example, some algorithms create clusters; others create trees. Therefore, you might need to use specialized prediction and query functions, depending on the type of model that you are working with.  
  
 The following list provides a summary of the functions that you can use in queries:  
  
-   **General prediction functions:** The **Predict** function is polymorphic, meaning it works with all model types. This function will automatically detect the type of model you are working with and prompt you for additional parameters. For more information, see [PREDICT](assetId:///f02ff4b3-9bd7-409d-ad14-ead67b3206c4).  
  
    > [!WARNING]  
    >  Not all models are used to make predictions. For example, you can create a clustering model that does not have a predictable attribute. However, even if a model does not have a predictable attribute, you can create prediction queries that return other types of useful information from the model.  
  
-   **Custom prediction functions:** Each model type provides a set of prediction functions designed for working with the patterns created by that algorithm.  
  
     For example, the **Lag** function is provided for time series models, to let you view the historical data used for the model. For clustering models, functions such as **ClusterDistance** are more meaningful.  
  
     For more information about the functions that are supported for each model type, see the following links:  
  
    |||  
    |-|-|  
    |[Association Model Query Examples](../../Topics/TopicNameNotContainA/Association-Model-Query-Examples.md)|[Microsoft Naive Bayes Algorithm](../../Topics/TopicNameNotContainA/Microsoft-Naive-Bayes-Algorithm.md)|  
    |[Clustering Model Query Examples](../../Topics/TopicNameNotContainA/Clustering-Model-Query-Examples.md)|[Neural Network Model Query Examples](../../Topics/TopicNameNotContainA/Neural-Network-Model-Query-Examples.md)|  
    |[Decision Trees Model Query Examples](../../Topics/TopicNameNotContainA/Decision-Trees-Model-Query-Examples.md)|[Sequence Clustering Model Query Examples](../../Topics/TopicNameNotContainA/Sequence-Clustering-Model-Query-Examples.md)|  
    |[Linear Regression Model Query Examples](../../Topics/TopicNameNotContainA/Linear-Regression-Model-Query-Examples.md)|[Time Series Model Query Examples](../../Topics/TopicNameNotContainA/Time-Series-Model-Query-Examples.md)|  
    |[Logistic Regression Model Query Examples](../../Topics/TopicNameNotContainA/Logistic-Regression-Model-Query-Examples.md)||  
  
     You can also call VBA functions, or create your own functions. For more information, see [Functions (DMX)](assetId:///75ab6346-f4a4-4699-90f3-66d35f930ed7).  
  
-   **General statistics:** There are a number of functions that can be used with almost any model type, which return a standard set of descriptive statistics, such as standard deviation.  
  
     For example, the **PredictHistogram** function returns a table that lists all the states of the specified column.  
  
     For more information, see [General Prediction Functions](assetId:///e128159a-0458-43c9-bfe9-129cb6cfbe1c).  
  
-   **Custom statistics:** Additional supporting functions are provided for each model type, to generate statistics that are relevant to the specific analytical task.  
  
     For example, when you are working with a clustering model, you can use the function, **PredictCaseLikelihood**, to return the likelihood score associated with a certain case and cluster. However, if you created a linear regression model, you would be more interested in retrieving the coefficient and intercept, which you can do using a content query.  
  
-   **Model content functions:** The *content* of all models is represented in a standardized format that lets you retrieve information with a simple query. You create queries on the model content by using DMX. You can also get some type of model content by using the data mining schema rowsets.  
  
     In the model content, the meaning of each row or node of the table that is returned differs depending on the type of algorithm that was used to build the model, as well as the data type of the column. For more information, see [Content Queries (Data Mining)](../../Topics/TopicNameNotContainA/Content-Queries--Data-Mining-.md).  
  
##  <a name="bkmk_Reqs"></a> Requirements  
 Before you can create a query against a model, the data mining model must have been processed. Processing of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] objects requires special permissions. For more information on processing mining models, see [Processing Requirements and Considerations (Data Mining)](../../Topics/TopicNameNotContainA/Processing-Requirements-and-Considerations--Data-Mining-.md).  
  
 To execute queries against a data mining model requires different levels of permissions, depending on the type of query that you run. For example, drillthrough to case or structure data typically requires additional permissions which can be set on the mining structure object or mining model object.  
  
 However, if your query uses external data, and includes statements such as OPENROWSET or OPENQUERY, the database that you are querying must enable these statements, and you must have permission on the underlying database objects.  
  
 For more information on the security contexts required to run data mining queries, see [Security Overview (Data Mining)](../../Topics/TopicNameNotContainA/Security-Overview--Data-Mining-.md)  
  
## In This Section  
 The topics in this section introduce each type of data mining query in more detail, and provide links to detailed examples of how to create queries against  data mingin models.  
  
 [Prediction Queries (Data Mining)](../../Topics/TopicNameNotContainA/Prediction-Queries--Data-Mining-.md)  
  
 [Content Queries (Data Mining)](../../Topics/TopicNameNotContainA/Content-Queries--Data-Mining-.md)  
  
 [Drillthrough Queries (Data Mining)](../../Topics/TopicNameNotContainA/Drillthrough-Queries--Data-Mining-.md)  
  
 [Data Definition Queries (Data Mining)](../../Topics/TopicNameNotContainA/Data-Definition-Queries--Data-Mining-.md)  
  
 [Data Mining Query Tools](../../Topics/TopicNameNotContainA/Data-Mining-Query-Tools.md)  
  
## Related Tasks  
 Use these links to learn how to create and work with data mining queries.  
  
|Tasks|Links|  
|-----------|-----------|  
|View tutorials and walkthroughs on data mining queries|[Creating Predictions (Basic Data Mining Tutorial)](assetId:///b213cb58-2c40-4c89-b08b-d3c36a4afad3)<br /><br /> [Creating Time Series queries in DMX](assetId:///38ea7c03-4754-4e71-896a-f68cc2c98ce2)|  
|Use data mining query tools in SQL Server Management Studio and [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)]|[Create a DMX Query in SQL Server Management Studio](../../Topics/TopicNameContainA/Create-a-DMX-Query-in-SQL-Server-Management-Studio.md)<br /><br /> [Create a Prediction Query Using the Prediction Query Builder](../../Topics/TopicNameContainA/Create-a-Prediction-Query-Using-the-Prediction-Query-Builder.md)<br /><br /> [Apply Prediction Functions to a Model](../../Topics/TopicNameContainA/Apply-Prediction-Functions-to-a-Model.md)<br /><br /> [Manually Edit a Prediction Query](../../Topics/TopicNameContainA/Manually-Edit-a-Prediction-Query.md)|  
|Work with external data used in prediction queries|[Choose and Map Input Data for a Prediction Query](../../Topics/TopicNameContainA/Choose-and-Map-Input-Data-for-a-Prediction-Query.md)<br /><br /> [Choose and Map Input Data for a Prediction Query](../../Topics/TopicNameContainA/Choose-and-Map-Input-Data-for-a-Prediction-Query.md)|  
|Work with the results of queries|[View and Save the Results of a Prediction Query](../../Topics/TopicNameContainA/View-and-Save-the-Results-of-a-Prediction-Query.md)|  
|Use DMX and XMLA query templates provided in Management Studio|[Create a Singleton Prediction Query from a Template](../../Topics/TopicNameContainA/Create-a-Singleton-Prediction-Query-from-a-Template.md)<br /><br /> [Create a Data Mining Query by Using XMLA](../../Topics/TopicNameContainA/Create-a-Data-Mining-Query-by-Using-XMLA.md)<br /><br /> [Use Analysis Services Templates in SQL Server Management Studio](../../Topics/TopicNameNotContainA/Use-Analysis-Services-Templates-in-SQL-Server-Management-Studio.md)|  
|Learn more about content queries and see examples|[Create a Content Query on a Mining Model](../../Topics/TopicNameContainA/Create-a-Content-Query-on-a-Mining-Model.md)<br /><br /> [Query the Parameters Used to Create a Mining Model](../../Topics/TopicNameContainA/Query-the-Parameters-Used-to-Create-a-Mining-Model.md)<br /><br /> [Content Queries (Data Mining)](../../Topics/TopicNameNotContainA/Content-Queries--Data-Mining-.md)|  
|Set query options and troubleshoot query permissions and problems|[Change the Time-out Value for Data Mining Queries](../../Topics/TopicNameNotContainA/Change-the-Time-out-Value-for-Data-Mining-Queries.md)|  
|Use the data mining components in Integration Services|[Data Mining Query Task](../../Topics/TopicNameNotContainA/Data-Mining-Query-Task.md)<br /><br /> [Data Mining Query Transformation](../../Topics/TopicNameNotContainA/Data-Mining-Query-Transformation.md)|  
  
## See Also  
 [Data Mining Algorithms (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Algorithms--Analysis-Services---Data-Mining-.md)   
 [Mining Model Content (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Model-Content--Analysis-Services---Data-Mining-.md)