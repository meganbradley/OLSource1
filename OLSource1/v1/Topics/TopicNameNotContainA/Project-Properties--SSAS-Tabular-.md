---
title: "Project Properties (SSAS Tabular)"
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
ms.assetid: 333c1fc0-361c-415a-bd68-4e057f67bcb7
caps.latest.revision: 28
manager: mblythe
---
# Project Properties (SSAS Tabular)
This topic describes model project properties. Each tabular model project has deployment options and deployment server properties that specify how the project and model is deployed. For example, the server the model will be deployed to and the deployed model database name. These settings are different from model properties, which affect the model workspace database. The project properties described here are in a modal properties dialog box, different from the properties window used to display other types of properties. To display the modal project properties, in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], in **Solution Explorer**, right-click the project, and then click **Properties**.  
  
 Sections in this topic:  
  
-   [Project Properties](#bkmk_proj_properties)  
  
-   [Configure Deployment Options and Deployment Server property settings](#bkmk_conf_proj_settings)  
  
##  <a name="bkmk_proj_properties"></a> Project Properties  
 **Deployment Options**  
  
|Property|Default setting|Description|  
|--------------|---------------------|-----------------|  
|**Processing Option**|**Default**|By default, Analysis Services will determine the type of processing required when changes to objects are deployed. This generally results in the fastest deployment time. However, you can also choose to have either full processing or no processing performed with each deployment.|  
|**Transactional Deployment**|**False**|Specifies whether or not the deployment of the model is transactional. By default, the deployment of all or changed objects is not transactional with the processing of those deployed objects. Deployment can succeed and persist even though processing fails. You can change this to incorporate deployment and processing in a single transaction.|  
|**Query Mode**|**In-Memory**|Specifies the source from which query results are returned. For more information, see [DirectQuery Mode (SSAS Tabular)](../../Topics/TopicNameNotContainA/DirectQuery-Mode--SSAS-Tabular-.md).|  
  
 **Deployment Server**  
  
|Property|Default setting|Description|  
|--------------|---------------------|-----------------|  
|**Server**|**localhost**|Specifies an instance of Analysis Services. By default, models are deployed to the default instance of Analysis Services on the local computer. You can change this setting to specify a named instance on the local computer or any instance on any remote computer on which you have permission to create Analysis Services objects. Typically, Administrator permissions.<br /><br /> The default setting for this property can be changed using the Default Deployment Server property on the Deployment page in Analysis Server settings in the Tools\Options dialog box. For more information, see [Configure Default Data Modeling and Deployment Properties (SSAS Tabular)](../../Topics/TopicNameNotContainA/Configure-Default-Data-Modeling-and-Deployment-Properties--SSAS-Tabular-.md).|  
|**Edition**|**Developer**|Specifies the edition of the Analysis Services server to which the model will be deployed. The server edition defines various features that can be incorporated into the project.|  
|**Database**|**Model**|Specifies the name of the Analysis Services database in which model objects will be instantiated upon deployment. This name will be specified in a data connection or an .rsds data connection file. It is recommended the name reflect the type of analysis that will be performed using the model, for example AdventureWorksSalesModel.<br /><br /> To prevent duplicate names for deployed models, you should change the **Database** property name setting to reflect the purpose of the model. When users connect to the model as a data source, this is the name they will see.|  
|**Cube Name**|**Model**|Specifies the name of the database cube as shown in a reporting client data connection.|  
|**Version**|**13.0**|Version of the Analysis Services instance where the project will be deployed.|  
  
 **DirectQuery Options**  
  
|Property|Default setting|Description|  
|--------------|---------------------|-----------------|  
|**Impersonation Settings**|**Default**|Specifies the credentials used to connect to data sources for a model running in DirectQuery Mode. These credentials are different from impersonation credentials that are used in the default In-Memory mode. For more information, see [Impersonation (SSAS Tabular)](../../Topics/TopicNameNotContainA/Impersonation--SSAS-Tabular-.md).|  
  
##  <a name="bkmk_conf_proj_settings"></a> Configure Deployment Options and Deployment Server property settings  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], in **Solution Explorer**, right-click the project, and then click **Properties**.  
  
2.  In the **Properties** window, click a property, and then type a value or click the down arrow to select a setting option.  
  
## See Also  
 [Configure Default Data Modeling and Deployment Properties (SSAS Tabular)](../../Topics/TopicNameNotContainA/Configure-Default-Data-Modeling-and-Deployment-Properties--SSAS-Tabular-.md)   
 [Model Properties (SSAS Tabular)](../../Topics/TopicNameNotContainA/Model-Properties--SSAS-Tabular-.md)   
 [Tabular Model Solution Deployment (SSAS Tabular)](../../Topics/TopicNameNotContainA/Tabular-Model-Solution-Deployment--SSAS-Tabular-.md)