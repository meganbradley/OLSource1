---
title: Data Definition Queries (Data Mining)
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
ms.assetid: 49e02de1-4ffa-401c-8eee-471a9c25b86a
---
# Data Definition Queries (Data Mining)
  For data mining, the category *data definition query* means DMX statements or XMLA commands that do the following:  
  
-   Create, alter, or manipulate data mining objects, such as a model.  
  
-   Define the source of data to be used in training or for prediction.  
  
-   Export or import mining models and mining structures.  
  
 [Creating Data Definition Queries](#bkmk_Create)  
  
-   [Data Definition Queries in SQL Server Data Tools](#bkmk_ssdt)  
  
-   [Data Definition Queries in SQL Server Management Studio](#bkmk_SSMS)  
  
 [Scripting Data Definition Statements](#bkmk_Scripts)  
  
 [Scripting Data Definition Statements](#bkmk_Export)  
  
##  <a name="bkmk_Create"></a> Creating Data Definition Queries  
 You can create data definition queries \(statements\) by using the Prediction Query Builder in [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)] and [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], or by using the DMX Query window in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)]. Data definition statements in DMX are part of the Analysis Services data definition language \(DDL\).  
  
 For information about the syntax of specific data definition statements, see [Data Mining Extensions &#40;DMX&#41; Reference](../Topic/Data%20Mining%20Extensions%20\(DMX\)%20Reference.md).  
  
###  <a name="bkmk_ssdt"></a> Data Definition Queries in SQL Server Data Tools  
 The Data Mining Wizard is the preferred tool in [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)] for creating and modifying mining models and mining structures, and for defining the data sources that are used in prediction queries and for training.  
  
 However, if you want to know what statements are being sent to the server by the wizard to create data structures or mining models, you can use SQL Server Profiler to capture the data definition statements. For more information, see [Use SQL Server Profiler to Monitor Analysis Services](../../Topics\TopicNameNotContainA/Use-SQL-Server-Profiler-to-Monitor-Analysis-Services.md).  
  
 To view the statements used for defining data sources used for training or prediction, you can use the **SQL View** in the Prediction Query Builder. Sometimes it can be helpful to build basic queries for training and testing models by using Prediction Query Builder, to establish the correct syntax. You can then switch to **SQL View** and manually edit the query. For more information, see [Manually Edit a Prediction Query](../../Topics\TopicNameContainA/Manually-Edit-a-Prediction-Query.md).  
  
###  <a name="bkmk_SSMS"></a> Data Definition Queries in SQL Server Management Studio  
 For data mining objects, you can use data definition queries to perform the following actions:  
  
-   Create specific types of models, such as a clustering model or decision tree model, by using [CREATE MINING MODEL &#40;DMX&#41;](../Topic/CREATE%20MINING%20MODEL%20\(DMX\).md).  
  
-   Alter an existing mining structure by adding a model or by changing the columns, by using [ALTER MINING STRUCTURE &#40;DMX&#41;](../Topic/ALTER%20MINING%20STRUCTURE%20\(DMX\).md). Note that you cannot alter a mining model by using DMX; you only add new models to an existing structure.  
  
-   Make a copy of a mining model and then alter it, by using [SELECT INTO &#40;DMX&#41;](../Topic/SELECT%20INTO%20\(DMX\).md).  
  
-   Define the data set used for training a model, by using [INSERT INTO &#40;DMX&#41;](../Topic/INSERT%20INTO%20\(DMX\).md) together with a data source query such as OPENROWSET.  
  
 [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] provides query templates that can help you create data definition queries. For more information, see [Use Analysis Services Templates in SQL Server Management Studio](../../Topics\TopicNameNotContainA/Use-Analysis-Services-Templates-in-SQL-Server-Management-Studio.md).  
  
 In general, the templates that are provided for [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] contain only the general syntax definition, which you must customize, either by typing in the **Query** window, or by using the dialog box provided for entering parameters.  
  
 For an example of how to enter parameters using the interface, see [Create a Singleton Prediction Query from a Template](../../Topics\TopicNameContainA/Create-a-Singleton-Prediction-Query-from-a-Template.md).  
  
###  <a name="bkmk_Scripts"></a> Scripting Data Definition Statements  
 [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] provides multiple scripting and programming languages that you can use to create or alter data mining objects, or to define data sources.  Although DMX is designed for expediting data mining tasks, you can also use both XMLA and AMO to manipulate objects in scripts or in custom code.  
  
 The Data Mining Add\-in for Excel also includes many query templates, and provides the **Advanced Query Editor**, which helps you compose complex DMX statements. You can build a query interactively and then switch to SQL View to capture the DMX statement.  
  
##  <a name="bkmk_Export"></a> Exporting and Importing Models  
 You can use data definition statements in DMX to export the definition of a model and its required structure and data sources, and then import that definition into a different server. Using export and import is the fastest and easiest way to move data mining models and mining structures between instances of [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)]. For more information, see [Management of Data Mining Solutions and Objects](../../Topics\TopicNameNotContainA/Management-of-Data-Mining-Solutions-and-Objects.md).  
  
> [!WARNING]  
>  If your model is based on data from a cube data srouce, you cannot use DMX to export the model, and should use backup and restore instead.  
  
##  <a name="bkmk_Tasks"></a> Related Tasks  
 The following table provides links to tasks that are related to data definition queries.  
  
|||  
|-|-|  
|Work with templates for DMX queries.|[Use Analysis Services Templates in SQL Server Management Studio](../../Topics\TopicNameNotContainA/Use-Analysis-Services-Templates-in-SQL-Server-Management-Studio.md)|  
|Design queries of all kinds, using Prediction Query Builder.|[Create a Prediction Query Using the Prediction Query Builder](../../Topics\TopicNameContainA/Create-a-Prediction-Query-Using-the-Prediction-Query-Builder.md)|  
|Capture query definitions by using SQL Server Profiler, and use traces to monitor [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)].|[Use SQL Server Profiler to Monitor Analysis Services](../../Topics\TopicNameNotContainA/Use-SQL-Server-Profiler-to-Monitor-Analysis-Services.md)|  
|Learn more about the scripting languages and programming languages provided for [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)].|[XML for Analysis  &#40;XMLA&#41; Reference](../Topic/XML%20for%20Analysis%20%20\(XMLA\)%20Reference.md)<br /><br /> [Developing with Analysis Management Objects &#40;AMO&#41;](../Topic/Developing%20with%20Analysis%20Management%20Objects%20\(AMO\).md)|  
|Learn how to manage models in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] and [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)].|[Export and Import Data Mining Objects](../../Topics\TopicNameNotContainA/Export-and-Import-Data-Mining-Objects.md)<br /><br /> [EXPORT &#40;DMX&#41;](../Topic/EXPORT%20\(DMX\).md)<br /><br /> [IMPORT &#40;DMX&#41;](../Topic/IMPORT%20\(DMX\).md)|  
|Learn more about OPENROWSET and other ways to query external data.|[&#60;source data query&#62;](../Topic/%3Csource%20data%20query%3E.md).|  
  
## See Also  
 [Data Mining Wizard &#40;Analysis Services - Data Mining&#41;](../Topic/Data%20Mining%20Wizard%20\(Analysis%20Services%20-%20Data%20Mining\).md)  
  
  