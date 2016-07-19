---
title: Logical Architecture (Analysis Services - Data Mining)
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
ms.assetid: 4e0cbf46-cc60-4e91-a292-9a69f29746f0
manager: paulettm
---
# Logical Architecture (Analysis Services - Data Mining)
Data mining is a process that involves the interaction of multiple components.  
  
-   You access sources of data in a SQL Server database or any other data source to use for training, testing, or prediction.  
  
-   You define data mining structures and models by using [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] or Visual Studio.  
  
-   You manage data mining objects and create predictions and queries by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
-   When the solution is complete, you deploy it to an instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)].  
  
 The process of creating these solution objects has already been described elsewhere. For more information, see [Data Mining Solutions](../../Topics/TopicNameNotContainA/Data-Mining-Solutions.md).  
  
 The following sections describe the logical architecture of the objects in a data mining solution.  
  
 [Data Mining Source Data](#bkmk_SourceData)  
  
 [Mining Structures](#bkmk_Structures)  
  
 [Mining Models](#bkmk_Models)  
  
 [Custom Data Mining Objects](#bkmk_CustomObjects)  
  
##  <a name="bkmk_SourceData"></a> Data Mining Source Data  
 The data that you use in data mining is not stored in the data mining solution; only the bindings are stored. The data might reside in a database created in a previous version of SQL Server, a CRM system, or even a flat file. When you train the structure or model by processing, a statistical summary of the data is created and stored in a cache that can be persisted for use in later operations, or deleted after processing. For more information, see [Mining Structures (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Structures--Analysis-Services---Data-Mining-.md).  
  
 You combine disparate data within the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data source view (DSV) object, which provides an abstraction layer on top of your data source. You can specify joins between tables, or add tables that have a many-to-one relationship to create nested table columns. The definition of these objects, the data source and the data source view, are stored within the solution with the file name extensions, *.ds and \*.dsv. For more information about creating and using [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data sources and data source views, see [Supported Data Sources (SSAS - Multidimensional)](../../Topics/TopicNameNotContainA/Supported-Data-Sources--SSAS---Multidimensional-.md).  
  
 You can also define and alter data sources and data source views by using AMO or XMLA. For more information about working with these objects programmatically, see [Logical Architecture Overview](assetId:///1a547bce-dacf-4d32-bc0f-3829f4b026e1).  
  
 [Back to Top](#bkmk_Top)  
  
##  <a name="bkmk_Structures"></a> Mining Structures  
 A data mining structure is a logical data container that defines the data domain from which mining models are built. A single mining structure can support multiple mining models.  
  
 When you need to use the data in the data mining solution, Analysis Services reads the data from the source and generates a cache of aggregates and other information. By default this cache is persisted so that training data can be reused to support additional models. If you need to delete the cache, change the **CacheMode** property on the mining structure object to the value, **ClearAfterProcessing**. For more information, see [AMO Data Mining](assetId:///e4108825-b722-417c-9647-ab30ce35e549).  
  
 [!INCLUDE[ssASCurrent](../../Topics/TopicNameContainA/includes/ssASCurrent_md.md)] also provides the ability to separate your data into training and testing data sets, so that you can test your mining models on a representative, randomly selected set of data. The data is not actually stored separately; rather, case data in the structure cache is marked with a property that indicates whether that particular case is used for training or for testing. If the cache is deleted, that information cannot be retrieved.  
  
 For more information, see [Mining Structures (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Structures--Analysis-Services---Data-Mining-.md).  
  
 A data mining structure can contain nested tables. A nested table provides additional detail about the case that is modeled in the primary data table. For more information, see [Nested Tables (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Nested-Tables--Analysis-Services---Data-Mining-.md)  
  
 [Back to Top](#bkmk_Top)  
  
##  <a name="bkmk_Models"></a> Mining Models  
 Before processing, a data mining model is only a combination of metadata properties. These properties specify a mining structure, specify a data mining algorithm, and a define collection of parameter and filter settings that affect how the data is processed. For more information, see [Mining Models (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Models--Analysis-Services---Data-Mining-.md).  
  
 When you process the model, the training data that was stored in the mining structure cache is used to generate patterns, based both on statistical properties of the data and on heuristics defined by the algorithm and its parameters. This is known as *training* the model.  
  
 The result of training is a set of summary data, contained within the *model content*, which describes the patterns that were found and provides rules by which to generate predictions. For more information, see [Mining Model Content (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Mining-Model-Content--Analysis-Services---Data-Mining-.md).  
  
 In limited cases, the logical structure of the model can also be exported into a file that represents model formulas and data bindings according to a standard format, the Predictive Modeling Markup Language (PMML). This logical structure can be imported into other systems that utilize PMML and the model so described can then be used for prediction. For more information, see [SELECT.model.PMML](assetId:///61e97285-4a06-4434-9a40-38cde5af7c3f).  
  
 [Back to Top](#bkmk_Top)  
  
##  <a name="bkmk_CustomObjects"></a> Custom Data Mining Objects  
 Other objects that you use in the context of a data mining project, such as accuracy charts or prediction queries, are not persisted within the solution, but can be scripted using ASSL or built using AMO.  
  
 Additionally, you can extend the services and features available on an instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] by adding these custom objects:  
  
 **Custom assemblies**  
 .NET assemblies can be defined by using any CLR-or COM-complaint language, and then registered with an instance of SQL Server. Assembly files are loaded from the location defined by the application, and a copy is saved in the server along with the data. The copy of the assembly file is used to load the assembly every time the service is started.  
  
 For more information, see [Multidimensional Model Assemblies Management](../../Topics/TopicNameNotContainA/Multidimensional-Model-Assemblies-Management.md).  
  
 **Custom stored procedures**  
 [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data mining supports the use of stored procedures to work with data mining objects. You can create your own stored procedures to extend functionality and more easily work with data returned by prediction queries and content queries.  
  
 [Defining Stored Procedures](assetId:///f9c57d91-f60f-4f0e-8f7f-d87f4ba97b7c)  
  
 The following stored procedures are supported for use in performing cross-validation.  
  
 [Data Mining Stored Procedures (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Stored-Procedures--Analysis-Services---Data-Mining-.md)  
  
 Additionally, [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] contains many system stored procedures that are used internally for data mining. Although the system stored procedures are for internal use, you might find them useful shortcuts. Microsoft reserves the right to change these stored procedures as needed; therefore, for production use, we recommend that you create queries by using DMX, AMO, or XMLA.  
  
 **Custom plug-in algorithms**  
 [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] provides a mechanism for creating your own algorithms, and then adding the algorithms as a new data mining service to the server instance.  
  
 Analysis Services uses COM interfaces to communicate with plugin algorithms. To learn more about how to implement new algorithms, see [Plugin Algorithms](../../Topics/TopicNameNotContainA/Plugin-Algorithms.md).  
  
 You must register each new algorithm before you can use it. To register an algorithm, you add the required metadata for the algorithms in the .ini file of the instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)]. You must add the information to each instance where you plan to use the new algorithm. After you have added the algorithm, you can restart the instance, and use the MINING_SERVICES schema rowset to view the new algorithm, including the options and providers that the algorithm supports.  
  
 [Back to Top](#bkmk_Top)  
  
## See Also  
 [Processing a multidimensional model (Analysis Services)](../../Topics/TopicNameContainA/Processing-a-multidimensional-model--Analysis-Services-.md)   
 [Data Mining Extensions (DMX) Reference](assetId:///6d85ca20-de67-4e20-b3b5-b734c6cfcece)