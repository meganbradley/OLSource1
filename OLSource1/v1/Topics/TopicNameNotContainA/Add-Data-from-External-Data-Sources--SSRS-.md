---
title: Add Data from External Data Sources (SSRS)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 924a2ec3-150c-4bb2-83c9-4c7b440e8c03
manager: mblythe
---
# Add Data from External Data Sources (SSRS)
To retrieve data from an external data source, you use a data connection. Data connection information is usually provided by the owner of the external data source, who is responsible for granting permissions and specifying which types of credentials to use. Data connection information is saved as a report data source. The data source type specifies which data extension to use to retrieve the data.  
  
 For more information about data source types, see [In This Section](#InThisSection).  
  
##  <a name="DataAccess"></a> Understanding Data Access Technology  
 To retrieve data for a report dataset requires multiple layers of data access software. The following list provides a simple description of how reports work with data access technologies:  
  
-   **Application and user interface** The Report Builder application that you use to create a data source, add a reference to a shared data source, add a shared dataset, or add a report part that includes the data sources and datasets that it depends on..  
  
-   **Report definition elements** Data sources and datasets are part of the report definition. After a report is published to a report server, shared data sources and shared datasets are managed independently from the report definition.  
  
    -   **Data source and Shared data source** Part of a report definition that includes the information about the type of data processing extension, the connection information, and the authentication.  
  
    -   **Dataset and field collection** Part of a report definition that includes the query, the field collection, and the field data types.  
  
-   **Reporting Services data extensions** Built-in data extensions that are installed with Report Builder. A data extension provides functionality that handles authentication, server aggregates, and multi-value parameters.  
  
-   **Data provider** The software that manages the connection and retrieval of data from the external data source. The data provider defines the connection string syntax. Most data extensions are built on top of a data provider layer.  
  
-   **External data source** Where to retrieve report data from, for example, a database, a file, a cube, or a Web service.  
  
> [!NOTE]  
>  When you are not connected to a report server, you can choose from data extensions that are installed with Report Builder. You access the data as a single user using credentials from your computer. When you are connected to a report server, you can choose from data extensions that are installed on the report server. You access the data as one of multiple users who run the report and you are using credentials on the report server. For more information, see [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md).  
  
##  <a name="ReportData"></a> Understanding Report Data  
 In its simplest form, a report displays data from a report dataset in a data region on the report page, that is, in a single table, chart, matrix, or other type of report data region. The data in a report dataset comes from the first result set that is returned from a single query command that runs from read-only access to an external data source. Each data region expands as needed to display all the data from the dataset.  
  
 Data in a dataset are essentially tabular. Columns are the fields from the dataset query. Rows are from the rows in the result set. You can use the following generalized types of data in a report:  
  
-   Rectangular data. Data from a result set that has the same number of columns in every row.  
  
-   Hierarchical data is supported as a flattened rowset.  
  
    -   Ragged hierarchies, where there is a different number of columns for each row of data, is not supported. For some data extensions, this has some implications.  
  
    -   Data extensions that work with multidimensional data sources use XML for Analysis protocol and retrieve data as a flattened row set and not as a cell set.  
  
    -   The XML data extension automatically flattens XML data to use it in a report. If the first instance of an XML element does not include all attributes or subelements, the data might not be available as report data.  
  
-   Recursive data is supported. A result set that contains a recursive data hierarchy includes all the information about the hierarchy structure in a rectangular result set. For example, the report-to structure in a company can be represented by a table that includes two columns: an employee and a manager. Each manager also is an employee with a manager. The top manager usually contains a null or some other identifier that indicates that this employee has no manager.  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="DataTypes"></a> Working with Data Types  
 When you create a dataset, the data types of the fields are mapped to a subset of common language runtime (CLR) data types from the [!INCLUDE[dnprdnshort](../../Topics/TopicNameContainA/includes/dnprdnshort_md.md)]. Data types that cannot be clearly mapped are returned as strings. For more information about working with field data types, see [Dataset Fields Collection (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection--Report-Builder-and-SSRS-.md). When you create a parameter, the data type must be a supported report definition data type. For more information about mapping data types from the data provider to a report parameter, see [Data Types in Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Types-in-Expressions--Report-Builder-and-SSRS-.md).  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="HowTo"></a> How-To Topics  
 This section contains step-by-step instructions for working with data connections, data sources, and datasets.  
  
 [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md)  
  
 [Create a Shared Dataset or Embedded Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Shared-Dataset-or-Embedded-Dataset--Report-Builder-and-SSRS-.md)  
  
 [Add a Filter to a Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Filter-to-a-Dataset--Report-Builder-and-SSRS-.md)  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="InThisSection"></a> In This Section  
 The following topics provide information about each built-in data extension.  
  
|Topic|Data Source Type|  
|-----------|----------------------|  
|[SQL Server Connection Type (SSRS)](../../Topics/TopicNameNotContainA/SQL-Server-Connection-Type--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]|  
|[Analysis Services Connection Type for MDX (SSRS)](../../Topics/TopicNameNotContainA/Analysis-Services-Connection-Type-for-MDX--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)]|  
|[Power Pivot Connection Type (SSRS)](../../Topics/TopicNameNotContainA/Power-Pivot-Connection-Type--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)]|  
|[SharePoint List Connection Type (SSRS)](../../Topics/TopicNameNotContainA/SharePoint-List-Connection-Type--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] SharePoint List|  
|[SQL Azure Connection Type (SSRS)](../../Topics/TopicNameNotContainA/SQL-Azure-Connection-Type--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssSDS](../../Topics/TopicNameContainA/includes/ssSDS_md.md)]|  
|[SQL Server Parallel Data Warehouse Connection Type (SSRS)](../../Topics/TopicNameNotContainA/SQL-Server-Parallel-Data-Warehouse-Connection-Type--SSRS-.md)|[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssDWfull](../../Topics/TopicNameNotContainA/includes/ssDWfull_md.md)]|  
|[SAP NetWeaver BI Connection Type (SSRS)](../../Topics/TopicNameNotContainA/SAP-NetWeaver-BI-Connection-Type--SSRS-.md)|SAP NetWeaver BI|  
|[Hyperion Essbase Connection Type (SSRS)](../../Topics/TopicNameNotContainA/Hyperion-Essbase-Connection-Type--SSRS-.md)|Hyperion Essbase|  
|[OLE DB Connection Type (SSRS)](../../Topics/TopicNameNotContainA/OLE-DB-Connection-Type--SSRS-.md)|OLE DB|  
|[ODBC Connection Type (SSRS)](../../Topics/TopicNameNotContainA/ODBC-Connection-Type--SSRS-.md)|ODBC|  
|[XML Connection Type (SSRS)](../../Topics/TopicNameNotContainA/XML-Connection-Type--SSRS-.md)|XML|  
|[Report Model Connection (SSRS)](../../Topics/TopicNameNotContainA/Report-Model-Connection--SSRS-.md)|.smdl model|  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Related"></a> Related Sections  
 These sections of the documentation provide in-depth conceptual information about report data, as well as procedural information about how to define, customize, and use parts of a report that are related to data.  
  
|Topic|Description|  
|-----------|-----------------|  
|[Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)|Provides an overview of accessing data for your report.|  
|[Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md)|Provides information about data connections and data sources.|  
|[Report Embedded Datasets and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Embedded-Datasets-and-Shared-Datasets--Report-Builder-and-SSRS-.md)|Provides information about embedded and shared datasets.|  
|[Dataset Fields Collection (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection--Report-Builder-and-SSRS-.md)|Provides information about the dataset field collection generated by the query.|  
|[Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md) in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).|Provides in-depth information about platform and version support for each data extension.|  
|[Data Processing Extensions Overview](assetId:///1d652605-9313-4c75-98b4-ba4dcbbb222d) in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).|Provides in-depth information for advanced users about data extensions.|  
  
 ![Arrow icon used with Back to Top link](../../Topics/TopicNameContainA/media/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
## See Also  
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)   
 [Query Designers (Report Builder)](../../Topics/TopicNameNotContainA/Query-Designers--Report-Builder-.md)