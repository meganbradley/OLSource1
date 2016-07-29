---
title: "Install Advanced Analytics Extensions"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 2016-04-01
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - r-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f485a588-487b-46c8-b8f6-f84f36ae25bc
caps.latest.revision: 14
manager: paulettm
robots: noindex,nofollow
---
# Install Advanced Analytics Extensions
[!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)] is an optional feature of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] that lets you  execute scripts written in a supported language, such as R, from [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)].  In [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)],  this feature lets you deploy R packages to [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], execute R solutions in the context of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], and easily work with [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] data in R.  
  
 If you are a data scientist developing and running R packages on a local workstation, you do not need to install these extensions or connect to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance. However,  if you want to run R packages in the context of the server you must connect to an instance where the extensions have been enabled as described here.  
  
 You install the extensions by using [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] setup or by using the command line.  
  
## Requirements  
 Microsoft. .NET Framework 3.5 is required. We recommend that you install this feature from Control Panel before beginning SQL Server setup.  
  
## Install Advanced Analytics Extensions using the Setup wizard  
 Run [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] Setup and select the [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)] option. No further configuration is necessary until after the additional components have been installed.  
  
 The following list shows you which pages in the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Installation wizard are used to install the [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)]:  
  
1.  On the **Feature Selection** page, select **Database Engine Services** and [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)].  
  
     ![Feature Selection page for SQL Server R Services setup](../../Topics/TopicNameNotContainA/media/rsql_FeatureSelectionPage.png "rsql_FeatureSelectionPage")  
  
2.  On the **Feature Rules** page, if you have not already installed Microsoft .Net Framework 3.5, stop setup and do so now.  
  
     ![Feature Rules page in SQL Server 2016 setup wizard](../../Topics/TopicNameNotContainA/media/rsql_FeatureRulesPage.png "rsql_FeatureRulesPage")  
  
3.  On the **Server Configuration** page, verify that the service for [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)] starts automatically using the MSSQLLaunchpad account.  
  
     ![Server Configuration page in SQL Server 2016 setup wizard](../../Topics/TopicNameNotContainA/media/rsql_ServerConfigurationPage2.png "rsql_ServerConfigurationPage2")  
  
4.  On the **Database Engine Configuration** page, for **Authentication mode**, select **Mixed Mode (SQL Server authentication and Windows authentication)**.  
  
     Note that mixed mode authentication is not needed if you are only using the server to operationalize R code by running ready-made R code in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. However, mixed mode authentication is required in CTP3 if you are supporting data scientists who will be connecting to the server for data exploration and predictive modeling. Specifically, the RevoScaleR functions must use SQL logins to execute R code using the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] computer as the compute context.  
  
5.  Click **Install**.  
  
6.  When [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] setup is complete, continue to the [Next Steps](#bkmk_NextSteps).  
  
## Install Advanced Analytics Extensions Using the Command Line  
 [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] Setup includes a parameter that specifies whether the extension is enabled and for which languages.  
  
 The following example illustrates a command line setup that installs the database engine, enables the [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)] and the [!INCLUDE[rsql_launchpad](../../Topics/TopicNameNotContainA/includes/rsql_launchpad_md.md)], and changes the  authentication mode of the instance to support SQL authentication.  
  
```  
c:\sqlserver2016Developer\setup.exe   
/Q   
/ACTION=INSTALL   
/FEATURES=SQLENGINE,ADVANCEDANALYTICS, SDK,BOL,SSMS,ADV_SSMS,   
/INSTANCENAME=MSSQLSERVER   
/SECURITYMODE= "Mixed"   
/SAPWD="%password%"         
/SQLSYSADMINACCOUNTS="%userdomain%\%username% "  
/IACCEPTSQLSERVERLICENSETERMS   
/IACCEPTREVOLICENSETERMS  
/PID=<productkey>  
```  
  
 For more information about unattended installation of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], see [Install SQL Server 2016 from the Command Prompt](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016-from-the-Command-Prompt.md).  
  
##  <a name="bkmk_NextSteps"></a> Next Steps  
 After installing [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)], before your users  can begin using R, you must complete the following steps:  
  
-   Install the R  tools and libraries.  
  
     For more information , see [Install R Packages and Providers for SQL Server R Services](../../Topics/TopicNameNotContainA/Install-R-Packages-and-Providers-for-SQL-Server-R-Services.md).  
  
-   Run [sp_configure (Transact-SQL)](assetId:///d18b251d-b37a-4f5f-b50c-502d689594c8) to enable the [!INCLUDE[rsql_extensions](../../Topics/TopicNameNotContainA/includes/rsql_extensions_md.md)].  
  
     You'll also need to add the required user account pool and roles, register the extensions, and ensure that the required services or user accounts have access to the database where R will be run.  
  
     A script has been provided to complete these steps. For more information , see [Post-Installation Server Configuration (SQL Server R Services)](../../Topics/TopicNameNotContainA/Post-Installation-Server-Configuration--SQL-Server-R-Services-.md).  
  
## See Also  
 [SQL Server R Services](../../Topics/TopicNameNotContainA/SQL-Server-R-Services.md)