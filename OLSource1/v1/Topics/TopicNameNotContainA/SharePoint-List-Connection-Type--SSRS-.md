---
title: SharePoint List Connection Type (SSRS)
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
ms.assetid: 2c4adf2f-e9c4-4fae-bd3c-97fe64436caf
manager: mblythe
---
# SharePoint List Connection Type (SSRS)
To include data from a Microsoft SharePoint list in your report, you must add or create a dataset that is based on a report data source of type Microsoft SharePoint List. This is a built-in data source type based on the Microsoft SQL Server Reporting Services SharePoint List data extension. Use this data source type to connect to and retrieve list data from [!INCLUDE[SPF2010](../../Topics/TopicNameContainA/includes/SPF2010_md.md)], [!INCLUDE[SPS2010](../../Topics/TopicNameContainA/includes/SPS2010_md.md)], [!INCLUDE[winSPServ](../../Topics/TopicNameContainA/includes/winSPServ_md.md)] 3.0, and [!INCLUDE[offSPServ](../../Topics/TopicNameContainA/includes/offSPServ_md.md)] 2007 sites.  
  
 Use the information in this topic to build a data source. For step-by-step instructions, see [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md).  
  
##  <a name="Connection"></a> Connection String  
 The connection string to a SharePoint list is the URL to the SharePoint site or subsite, for example, `http://MySharePointWeb/MySharePointSite` or `http://MySharePointWeb/MySharePointSite/Subsite`.  
  
 The query designer automatically displays the SharePoint lists that you have sufficient permissions to access.  
  
 For more connection string examples, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md).  
  
##  <a name="Credentials"></a> Credentials  
 Credentials are required to run queries, to preview the report locally, and to preview the report from the report server. After you publish your report, you may need to change the credentials for the data source so that when the report runs on the report server, the permissions to retrieve the data are valid. The types of credentials that can be used with this data extension depend on the SharePoint technology configuration for the SharePoint list that you are using as a data source.  
  
 The following tables outline credential retrieval behavior for the SharePoint list extension, when connecting to a local farm SharePoint list and to a remote SharePoint list.  
  
 **Table 1** is for reports deployed to a legacy Windows SharePoint Site. A legacy Windows site supports only Kerberos, NTLM, and Forms Based Authentication (FBA). **Table 2** is for reports deployed to a Claims-based SharePoint site.  
  
 **Table 1**  
  
||Supported Credentials|Classic Mode Windows Authentication|*Claims Authentication|  
|-|---------------------------|-----------------------------------------|-----------------------------|  
|Local farm SharePoint List|Windows Authentication (integrated) or SharePoint User Token|Yes|Yes|  
||Stored, Prompt, None (with Windows credentials)<br /><br /> Stored and prompt credentials with non-Windows credentials is not supported.|Yes|No|  
|Remote SharePoint List|Windows Authentication (integrated) or SharePoint User Token|Yes|No<br /><br /> Forms-based authentication and Claims authentication are not supported for remote SharePoint lists.|  
||Stored, Prompt, None (with Windows credentials)<br /><br /> Stored and prompt credentials with non-Windows credentials is not supported.|Yes|No<br /><br /> Forms-based authentication and Claims authentication are not supported for remote SharePoint lists.|  
  
 *Windows authentication, Forms Based authentication (FBA), Secure Application Markup Language (SAML) tokens, other identity providers or a combination of more than one of the above mentioned authentication providers.  
  
 **Table 2**  
  
||Supported Credentials|Classic Mode Windows Authentication|*Claims Authentication|  
|-|---------------------------|-----------------------------------------|-----------------------------|  
|Local Farm SharePoint List|Windows Authentication (integrated) or SharePoint User Token|Yes|Yes|  
||Stored, Prompt, None (with Windows credentials)<br /><br /> Stored and prompt credentials with non-Windows credentials is not supported.|No|No|  
|Remote SharePoint List|Windows Authentication (integrated) or SharePoint User Token|Yes|No<br /><br /> Forms-based authentication and Claims authentication are not supported for remote SharePoint lists.|  
||Stored, Prompt, None (with Windows credentials)<br /><br /> Stored and prompt credentials with non-Windows credentials is not supported.|No|No<br /><br /> Forms-based authentication and Claims authentication are not supported for remote SharePoint lists.|  
  
 *Windows authentication, Forms Based authentication (FBA), Secure Application Markup Language (SAML) tokens, other identity providers or a combination of more than one of the above mentioned authentication providers.  
  
 **Windows Authentication**  
 For a SharePoint technology that is configured to work with a report server in Trusted Account mode, this option is not supported. This applies only to releases prior to SQL Server 2012 Reporting Services.  
  
 For a SharePoint technology that is configured to work with a report server in Windows Integrated mode, this option applies to both the current Windows user and the current SharePoint user.  
  
 For a SharePoint technology that is configured to work without a Report Server (local mode), this option is not supported. For more information on local mode, see [Local Mode vs. Connected Mode Reports in the Report Viewer (Reporting Services in SharePoint Mode)](../../Topics/TopicNameNotContainA/Local-Mode-vs.-Connected-Mode-Reports-in-the-Report-Viewer--Reporting-Services-in-SharePoint-Mode-.md).  
  
 **Credentials are not required (Do not use credentials):**  
 To use this option, the unattended execution account must be configured on the report server. For more information, see [Configure the Unattended Execution Account (SSRS Configuration Manager)](../../Topics/TopicNameNotContainA/Configure-the-Unattended-Execution-Account--SSRS-Configuration-Manager-.md).  
  
 For information about Claims authentication support across the Microsoft BI stack, see [Using Claims Authentication across the Microsoft BI Stack](http://social.technet.microsoft.com/wiki/contents/articles/15274.using-claims-authentication-across-the-microsoft-bi-stack.aspx).  
  
 For more information, see [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md), [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md), and [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md).  
  
##  <a name="Query"></a> Queries  
 To design a query, create a new dataset based on the data source, and then open the associated query designer. For more information, see [Create a Shared Dataset or Embedded Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Shared-Dataset-or-Embedded-Dataset--Report-Builder-and-SSRS-.md).  
  
 The SharePoint List graphical query designer displays four panes:  
  
 **SharePoint Lists**  Displays a list of all the SharePoint lists on the site for this data source. Select a list and then select the fields that you want in your query. The names of fields in this pane are the SharePoint friendly names, also known as display names. Hover over an item to display the following properties in the tooltip:  
  
-   **Name** The unique name of the field.  
  
-   **Identifier** The unique identifier of the field.  
  
-   **Field Type** The data type of the field.  
  
-   **Hidden** Whether the field displays in the SharePoint list view.  
  
 Selecting fields from multiple lists is not supported. You can create a dataset for each list and select fields from each dataset. If the lists have a common field, you can use the Lookup function in a tablix data region that is bound to one dataset to retrieve a value from the other dataset that is not bound to the data region. For more information, see [Lookup Function (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Lookup-Function--Report-Builder-and-SSRS-.md).  
  
-   **Selected Fields**  Displays the fields that you have selected. The names of fields in this pane are friendly names that a SharePoint user has specified. When you close the query designer, you see these names in the dataset field collection in the Report Data pane. The relationship between unique names and friendly names is available in the [Dataset Properties Dialog Box, Fields (Report Builder)](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Fields--Report-Builder-.md) page.  
  
-   **Applied Filters**  Limits the data that is returned from the SharePoint list, before the data is returned to the report. Select the field name, operator, and value to use to limit the data that is retrieved in the list. The operators vary depending on the data type of the value that you select.  
  
     You cannot change the sort order or specify groups in the graphical query designer. To do that, set sort expressions on the report dataset, and group expressions on the data regions in the report. Query parameters are not supported. To filter data in the report, use report filters or report parameters that you create. For more information, see [Filter, Group, and Sort Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Filter--Group--and-Sort-Data--Report-Builder-and-SSRS-.md) and [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md).  
  
-   **Query Results**  Displays example rows that are returned when the query runs. If the SharePoint list values change frequently on the SharePoint site, the values that you see in the query results pane might differ from the values that you see in the report.  
  
-   **Selected Fields**  Displays the fields that you have selected. The names of fields in this pane are friendly names that a SharePoint user has specified. When you close the query designer, you see these names in the dataset field collection in the Report Data pane. The relationship between unique names and friendly names is available in the [Dataset Properties Dialog Box, Fields (Report Builder)](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Fields--Report-Builder-.md) page.  
  
-   **Applied Filters**  Limits the data that is returned from the SharePoint list, before the data is returned to the report. Select the field name, operator, and value to use to limit the data that is retrieved in the list. The operators vary depending on the data type of the value that you select.  
  
     You cannot change the sort order or specify groups in the graphical query designer. To do that, set sort expressions on the report dataset, and group expressions on the data regions in the report. Query parameters are not supported. To filter data in the report, use report filters or report parameters that you create. For more information, see [Filter, Group, and Sort Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Filter--Group--and-Sort-Data--Report-Builder-and-SSRS-.md) and [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md).  
  
-   **Query Results**  Displays example rows that are returned when the query runs. If the SharePoint list values change frequently on the SharePoint site, the values that you see in the query results pane might differ from the values that you see in the report.  
  
 For more information, see [SharePoint List Query Designer (Report Builder)](../../Topics/TopicNameNotContainA/SharePoint-List-Query-Designer--Report-Builder-.md).  
  
### Query Text  
 To view the query that is generated by the graphical query designer, switch to the text-based query designer. In this view, you can see the XML that is created by the graphical query designer. The XML includes elements for the list name, the field collection, and the filter.  
  
#### Example 1. Specified fields for a list  
 The following example shows a well-formed SharePoint query:  
  
```  
<RSSharePointList>  
<listName>MyList</listName>  
<viewFields>  
  <FieldRef Name="Field1"/>  
  <FieldRef Name="Field4"/>  
</viewFields>  
<Query>  
  <Where>  
    <And>  
      <Gt>  
        <FieldRef Name="Field1"/>  
        <Value Type="Integer">1</Value>  
      </Gt>  
      <IsNotNull>  
        <FieldRef Name="Field2"/>  
        <Value Type="string"/>  
      </IsNotNull>   
    </And>  
  </Where>  
</Query>  
</RSSharePointList>  
```  
  
 You can edit this view of the query as long as it remains well-formed XML text.  
  
#### Example 2. All fields for a list  
 You can also specify only the name of a list, and all fields, including hidden fields, are returned. The following example retrieves all the fields from a list that is named Tasks:  
  
```  
<RSSharePointList>  
<listName>Tasks</listName>  
</RSSharePointList>  
```  
  
 All fields for the list Tasks are returned in the query results.  
  
##  <a name="Parameters"></a> Parameters  
 Parameters are not supported by this data extension.  
  
##  <a name="HowTo"></a> How-To Topics  
 This section contains step-by-step instructions for working with data connections, data sources, and datasets.  
  
 [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md)  
  
 [Create a Shared Dataset or Embedded Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Create-a-Shared-Dataset-or-Embedded-Dataset--Report-Builder-and-SSRS-.md)  
  
 [Add a Filter to a Dataset (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Filter-to-a-Dataset--Report-Builder-and-SSRS-.md)  
  
##  <a name="Related"></a> Related Sections  
 These sections of the documentation provide in-depth conceptual information about report data, as well as procedural information about how to define, customize, and use parts of a report that are related to data.  
  
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)  
 Provides an overview of accessing data for your report.  
  
 [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md)  
 Provides information about data connections and data sources.  
  
 [Report Embedded Datasets and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Embedded-Datasets-and-Shared-Datasets--Report-Builder-and-SSRS-.md)  
 Provides information about embedded and shared datasets.  
  
 [Dataset Fields Collection (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection--Report-Builder-and-SSRS-.md)  
 Provides information about the dataset field collection generated by the query.  
  
 [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md) in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).  
 Provides in-depth information about platform and version support for each data extension.  
  
## See Also  
 [Report Parameters (Report Builder and Report Designer)](../../Topics/TopicNameNotContainA/Report-Parameters--Report-Builder-and-Report-Designer-.md)   
 [Filter, Group, and Sort Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Filter--Group--and-Sort-Data--Report-Builder-and-SSRS-.md)   
 [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md)