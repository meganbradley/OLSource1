---
title: SSIS Catalog
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 24bd987e-164a-48fd-b4f2-cbe16a3cd95e
---
# SSIS Catalog
  The **SSISDB** catalog is the central point for working with [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] \(SSIS\) projects that you’ve deployed to the [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] server. For example, you set project and package parameters, configure environments to specify runtime values for packages, execute and troubleshoot packages, and manage [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] server operations.  
  
 The objects that are stored in the **SSISDB** catalog include projects, packages, parameters, environments, and operational history.  
  
 You inspect objects, settings, and operational data that are stored in the **SSISDB** catalog, by querying the views in the **SSISDB** database. You manage the objects by calling stored procedures in the **SSISDB** database or by using the UI of the **SSISDB** catalog. In many cases, the same task can be performed in the UI or by calling a stored procedure.  
  
 To maintain the **SSISDB** database, it is recommended that you apply standard enterprise policies for managing user databases. For information about creating maintenance plans, see [Maintenance Plans](../../Topics\TopicNameNotContainA/Maintenance-Plans.md).  
  
 The **SSISDB** catalog and the **SSISDB** database support Windows PowerShell. For more information about using SQL Server with Windows PowerShell, see [SQL Server PowerShell](../../Topics\TopicNameNotContainA/SQL-Server-PowerShell.md). For examples of how to use Windows PowerShell to complete tasks such as deploying a project, see the blog entry, [SSIS and PowerShell in SQL Server 2012](http://go.microsoft.com/fwlink/?LinkId=242539), on blogs.msdn.com.  
  
 For more information about viewing operations data, see [Monitoring for Package Executions and Other Operations](../../Topics\TopicNameNotContainA/Monitoring-for-Package-Executions-and-Other-Operations.md).  
  
 You access the **SSISDB** catalog in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] by connecting to the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Database Engine and then expanding the **Integration Services Catalogs** node in Object Explorer. You access the **SSISDB** database in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] by expanding the Databases node in Object Explorer.  
  
> [!NOTE]  
>  You cannot rename the **SSISDB** database.  
  
> [!NOTE]  
>  If the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance that the **SSISDB** database is attached to, stops or does not respond, the ISServerExec.exe process ends. A message is written to a Windows Event log.  
>   
>  If the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] resources failover as part of a cluster failover, the running packages do not restart. You can use checkpoints to restart packages. For more information, see [Restart Packages by Using Checkpoints](../../Topics\TopicNameNotContainA/Restart-Packages-by-Using-Checkpoints.md).  
  
## In this topic  
  
-   [Catalog Object Identifiers](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Catalog Configuration](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Permissions](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Folders](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Projects and Packages](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Parameters](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Server Environments, Server Variables, and Server Environment References](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Executions and Validations](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [AlwaysOn Support](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Related Tasks](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
-   [Related Content](../../Topics\TopicNameNotContainA/SSIS-Catalog.md)  
  
##  <a name="CatalogObjectIdentifiers"></a> Catalog Object Identifiers  
 When you create a new object in the catalog, assign a name to the object. The object name is an identifier. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] defines rules for which characters can be used in an identifier. Names for the following objects must follow identifier rules.  
  
-   Folder  
  
-   Project  
  
-   Environment  
  
-   Parameter  
  
-   Environment Variable  
  
###  <a name="Folder"></a> Folder, Project, Environment  
 Consider the following rules when renaming a folder, project, or environment.  
  
-   Invalid characters include ASCII\/Unicode characters 1 through 31, quote \("\), less than \(\<\), greater than \(\>\), pipe \(|\), backspace \(\\b\), null \(\\0\), and tab \(\\t\).  
  
-   The name might not contain leading or trailing spaces.  
  
-   @ is not allowed as the first character, but subsequent characters might use @.  
  
-   The length of the name must be greater than 0 and less than or equal to 128.  
  
###  <a name="Parameter"></a> Parameter  
 Consider the following rules when naming a parameter.  
  
-   The first character of the name must be a letter as defined in the Unicode Standard 2.0, or an underscore \(\_\).  
  
-   Subsequent characters can be letters or numbers as defined in the Unicode Standard 2.0, or an underscore \(\_\).  
  
###  <a name="EnvironmentVariable"></a> Environment Variable  
 Consider the following rules when naming an environment variable.  
  
-   Invalid characters include ASCII\/Unicode characters 1 through 31, quote \("\), less than \(\<\), greater than \(\>\), pipe \(|\), backspace \(\\b\), null \(\\0\), and tab \(\\t\).  
  
-   The name might not contain leading or trailing spaces.  
  
-   @ is not allowed as the first character, but subsequent characters might use @.  
  
-   The length of the name must be greater than 0 and less than or equal to 128.  
  
-   The first character of the name must be a letter as defined in the Unicode Standard 2.0, or an underscore \(\_\).  
  
-   Subsequent characters can be letters or numbers as defined in the Unicode Standard 2.0, or an underscore \(\_\).  
  
##  <a name="Configuration"></a> Catalog Configuration  
 You fine\-tune how the catalog behaves by adjusting the catalog properties. Catalog properties define how sensitive data is encrypted, and how operations and project versioning data is retained. To set catalog properties, use the **Catalog Properties** dialog box or call the [catalog.configure_catalog &#40;SSISDB Database&#41;](../Topic/catalog.configure_catalog%20\(SSISDB%20Database\).md) stored procedure. To view the properties, use the dialog box or query [catalog.catalog_properties &#40;SSISDB Database&#41;](../Topic/catalog.catalog_properties%20\(SSISDB%20Database\).md). You access the dialog box by right\-clicking **SSISDB** in Object Explorer.  
  
###  <a name="Cleanup"></a> Operations and Project Version Cleanup  
 Status data for many of the operations in the catalog is stored in internal database tables. For example, the catalog tracks the status of package executions and project deployments. To maintain the size of the operations data, the **SSIS Server Maintenance Job** in [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] is used to remove old data. This [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Agent job is created when [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] is installed.  
  
 You can update or redeploy an [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] project by deploying it with the same name to the same folder in the catalog. By default, each time you redeploy a project, the **SSISDB** catalog retains the previous version of the project. To maintain the size of the operations data, the **SSIS Server Maintenance Job** is used to remove old versions of projects.  
  
 The following **SSISDB** catalog properties define how this [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Agent job behaves. You can view and modify the properties by using the **Catalog Properties** dialog box or by using [catalog.catalog_properties &#40;SSISDB Database&#41;](../Topic/catalog.catalog_properties%20\(SSISDB%20Database\).md) and [catalog.configure_catalog &#40;SSISDB Database&#41;](../Topic/catalog.configure_catalog%20\(SSISDB%20Database\).md).  
  
 **Clean Logs Periodically**  
 The job step for operations cleanup runs when this property is set to **True**.  
  
 **Retention Period \(days\)**  
 Defines the maximum age of allowable operations data \(in days\). Older data are removed.  
  
 The minimum value is one day. The maximum value is limited only by the maximum value of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] **int** data. For information about this data type, see [int, bigint, smallint, and tinyint &#40;Transact-SQL&#41;](../Topic/int,%20bigint,%20smallint,%20and%20tinyint%20\(Transact-SQL\).md).  
  
 **Periodically Remove Old Versions**  
 The job step for project version cleanup runs when this property is set to **True**.  
  
 **Maximum Number of Versions per Project**  
 Defines how many versions of a project are stored in the catalog. Older versions of projects are removed.  
  
###  <a name="Encryption"></a> Encryption Algorithm  
 The **Encryption Algorithm** property specifies the type of encryption that is used to encrypt sensitive parameter values. You can choose from the following types of encryption.  
  
-   AES\_256 \(default\)  
  
-   AES\_192  
  
-   AES\_128  
  
-   DESX  
  
-   TRIPLE\_DES\_3KEY  
  
-   TRIPLE\_DES  
  
-   DES  
  
 When you deploy an [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] project to the [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)]server, the catalog automatically encrypts the package data and sensitive values. The catalog also automatically decrypts the data when you retrieve it. The SSISDB catalog uses the **ServerStorage** protection level. For more information, see [Access Control for Sensitive Data in Packages](../../Topics\TopicNameNotContainA/Access-Control-for-Sensitive-Data-in-Packages.md).  
  
 Changing the encryption algorithm is a time\-intensive operation. First, the server has to use the previously specified algorithm to decrypt all configuration values. Then, the server has to use the new algorithm to re\-encrypt the values. During this time, there cannot be other [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] operations on the server. Thus, to enable [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] operations to continue uninterrupted, the encryption algorithm is a read\-only value in the  dialog box in [!INCLUDE[ssManStudio](../../Token\Other/ssManStudio_md.md)].  
  
 To change the **Encryption Algorithm** property setting, set the **SSISDB** database to the single\-user mode and then call the catalog.configure\_catalog stored procedure. Use ENCRYPTION\_ALGORITHM for the *property\_name* argument. For the supported property values, see [catalog.catalog_properties &#40;SSISDB Database&#41;](../Topic/catalog.catalog_properties%20\(SSISDB%20Database\).md). For more information about the stored procedure, see [catalog.configure_catalog &#40;SSISDB Database&#41;](../Topic/catalog.configure_catalog%20\(SSISDB%20Database\).md).  
  
 For more information about single\-user mode, see [Set a Database to Single-user Mode](../../Topics\TopicNameContainA/Set-a-Database-to-Single-user-Mode.md). For information about encryption and encryption algorithms in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], see the topics in the section, [SQL Server Encryption](../../Topics\TopicNameNotContainA/SQL-Server-Encryption.md).  
  
 A database master key is used for the encryption. The key is created when you create the catalog. For more information, see [Create the SSIS Catalog](../../Topics\TopicNameNotContainA/Create-the-SSIS-Catalog.md).  
  
 The following table lists the property names shown in the **Catalog Properties** dialog box and the corresponding properties in the database view.  
  
|Property Name \(**Catalog Properties** dialog box\)|Property Name \(database view\)|  
|---------------------------------------------------------|-------------------------------------|  
|Encryption Algorithm Name|ENCRYPTION\_ALGORITHM|  
|Clean Logs Periodically|OPERATION\_CLEANUP\_ENABLED​|  
|Retention Period \(days\)|RETENTION\_WINDOW|  
|Periodically Remove Old Versions|VERSION\_CLEANUP\_ENABLED|  
|Maximum Number of Versions per Project|MAX\_PROJECT\_VERSIONS|  
|Server\-wide Default Logging Level|SERVER\_LOGGING\_LEVEL|  
  
##  <a name="Permissions"></a> Permissions  
 Projects, environments, and packages are contained in folders that are securable objects. You can grant permissions to a folder, including the MANAGE\_OBJECT\_PERMISSIONS permission. MANAGE\_OBJECT\_PERMISSIONS enables you to delegate the administration of folder contents to a user without having to grant the user membership to the ssis\_admin role. You can also grant permissions to projects, environments, and operations. Operations include initializing [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)], deploying projects, creating and starting executions, validating projects and packages, and configuring the **SSISDB** catalog.  
  
 For more information about database roles, see [Database-Level Roles](../../Topics\TopicNameNotContainA/Database-Level-Roles.md).  
  
 The SSISDB catalog uses a DDL trigger, ddl\_cleanup\_object\_permissions, to enforce the integrity of permissions information for SSIS securables. The trigger fires when a database principal, such as a database user, database role, or a database application role, is removed from the SSISDB database.  
  
 If the principal has granted or denied permissions to other principals, revoke the permissions given by the grantor, before the principal can be removed. Otherwise, an error message is returned when the system tries to remove the principal. The trigger removes all permission records where the database principal is a grantee.  
  
 It is recommended that the trigger is not disabled because it ensures that are no orphaned permission records after a database principal is dropped from the **SSISDB** database.  
  
### Managing Permissions  
 You can manage permissions by using the [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] UI, stored procedures, and the [Microsoft.SqlServer.Management.IntegrationServices](assetId:///N:Microsoft.SqlServer.Management.IntegrationServices) namespace.  
  
 To manage permissions using the [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] UI, use the following dialog boxes.  
  
-   For a folder, use the **Permissions** page of the [Folder Properties Dialog Box](../../Topics\TopicNameNotContainA/Folder-Properties-Dialog-Box.md).  
  
-   For a project, use the **Permissions** page in the [Project Properties Dialog Box](../../Topics\TopicNameNotContainA/Project-Properties-Dialog-Box.md).  
  
-   For an environment, use the **Permissions** page in the [NIB: Environment Properties Dialog Box](assetId:///6a91a8d4-0006-4cfd-9759-3e4295ae452b).  
  
 To manage permissions using Transact\-SQL, call [catalog.grant_permission &#40;SSISDB Database&#41;](../Topic/catalog.grant_permission%20\(SSISDB%20Database\).md), [catalog.deny_permission &#40;SSISDB Database&#41;](../Topic/catalog.deny_permission%20\(SSISDB%20Database\).md) and [catalog.revoke_permission &#40;SSISDB Database&#41;](../Topic/catalog.revoke_permission%20\(SSISDB%20Database\).md). To view effective permissions for the current principal for all objects, query [catalog.effective_object_permissions &#40;SSISDB Database&#41;](../Topic/catalog.effective_object_permissions%20\(SSISDB%20Database\).md). This topic provides descriptions of the different types of permissions. To view permissions that have been explicitly assigned to the user, query [catalog.explicit_object_permissions &#40;SSISDB Database&#41;](../Topic/catalog.explicit_object_permissions%20\(SSISDB%20Database\).md).  
  
##  <a name="Folders"></a> Folders  
 A folder contains one or more projects and environments in the **SSISDB** catalog. You can use the [catalog.folders &#40;SSISDB Database&#41;](../Topic/catalog.folders%20\(SSISDB%20Database\).md) view to access information about folders in the catalog. You can use the following stored procedures to manage folders.  
  
-   [catalog.create_folder &#40;SSISDB Database&#41;](../Topic/catalog.create_folder%20\(SSISDB%20Database\).md)  
  
-   [catalog.delete_folder &#40;SSISDB Database&#41;](../Topic/catalog.delete_folder%20\(SSISDB%20Database\).md)  
  
-   [catalog.rename_folder &#40;SSISDB Database&#41;](../Topic/catalog.rename_folder%20\(SSISDB%20Database\).md)  
  
-   [catalog.set_folder_description &#40;SSISDB Database&#41;](../Topic/catalog.set_folder_description%20\(SSISDB%20Database\).md)  
  
##  <a name="ProjectsAndPackages"></a> Projects and Packages  
 Each project can contain multiple packages. Both projects and packages can contain parameters and references to environments. You can access the parameters and environment references by using the [Configure Dialog Box](../../Topics\TopicNameNotContainA/Configure-Dialog-Box.md).  
  
 You can carry out other project tasks by calling the following stored procedures.  
  
-   [catalog.delete_project &#40;SSISDB Database&#41;](../Topic/catalog.delete_project%20\(SSISDB%20Database\).md)  
  
-   [catalog.deploy_project &#40;SSISDB Database&#41;](../Topic/catalog.deploy_project%20\(SSISDB%20Database\).md)  
  
-   [catalog.get_project &#40;SSISDB Database&#41;](../Topic/catalog.get_project%20\(SSISDB%20Database\).md)  
  
-   [catalog.move_project &#40;&#40;SSISDB Database&#41;](../Topic/catalog.move_project%20\(\(SSISDB%20Database\).md)  
  
-   [catalog.restore_project &#40;SSISDB Database&#41;](../Topic/catalog.restore_project%20\(SSISDB%20Database\).md)  
  
 These views provide details about packages, projects, and project versions.  
  
-   [catalog.projects &#40;SSISDB Database&#41;](../Topic/catalog.projects%20\(SSISDB%20Database\).md)  
  
-   [catalog.packages &#40;SSISDB Database&#41;](../Topic/catalog.packages%20\(SSISDB%20Database\).md)  
  
-   [catalog.object_versions &#40;SSISDB Database&#41;](../Topic/catalog.object_versions%20\(SSISDB%20Database\).md)  
  
##  <a name="Parameters"></a> Parameters  
 You use parameters to assign values to package properties at the time of package execution. To set the value of a package or project parameter and to clear the value, call [catalog.set_object_parameter_value &#40;SSISDB Database&#41;](../Topic/catalog.set_object_parameter_value%20\(SSISDB%20Database\).md) and [catalog.clear_object_parameter_value &#40;SSISDB Database&#41;](../Topic/catalog.clear_object_parameter_value%20\(SSISDB%20Database\).md). To set the value of a parameter for an instance of execution, call [catalog.set_execution_parameter_value &#40;SSISDB Database&#41;](../Topic/catalog.set_execution_parameter_value%20\(SSISDB%20Database\).md). You can retrieve default parameter values by calling [catalog.get_parameter_values &#40;SSISDB Database&#41;](../Topic/catalog.get_parameter_values%20\(SSISDB%20Database\).md).  
  
 These views show the parameters for all packages and projects, and parameter values that are used for an instance of execution.  
  
-   [catalog.object_parameters &#40;SSISDB Database&#41;](../Topic/catalog.object_parameters%20\(SSISDB%20Database\).md)  
  
-   [catalog.execution_parameter_values &#40;SSISDB Database&#41;](../Topic/catalog.execution_parameter_values%20\(SSISDB%20Database\).md)  
  
##  <a name="ServerEnvironments"></a> Server Environments, Server Variables, and Server Environment References  
 Server environments contain server variables. The variable values can be used when a package is executed or validated on the [!INCLUDE[ssISnoversion](../Token/ssISnoversion_md.md)] server.  
  
 The following stored procedures enable you to perform many other management tasks for environments and variables.  
  
-   [catalog.create_environment &#40;SSISDB Database&#41;](../Topic/catalog.create_environment%20\(SSISDB%20Database\).md)  
  
-   [catalog.delete_environment &#40;SSISDB Database&#41;](../Topic/catalog.delete_environment%20\(SSISDB%20Database\).md)  
  
-   [catalog.move_environment &#40;SSISDB Database&#41;](../Topic/catalog.move_environment%20\(SSISDB%20Database\).md)  
  
-   [catalog.rename_environment &#40;SSISDB Database&#41;](../Topic/catalog.rename_environment%20\(SSISDB%20Database\).md)  
  
-   [catalog.set_environment_property &#40;SSISDB Database&#41;](../Topic/catalog.set_environment_property%20\(SSISDB%20Database\).md)  
  
-   [catalog.create_environment_variable &#40;SSISDB Database&#41;](../Topic/catalog.create_environment_variable%20\(SSISDB%20Database\).md)  
  
-   [catalog.delete_environment_variable &#40;SSISDB Database&#41;](../Topic/catalog.delete_environment_variable%20\(SSISDB%20Database\).md)  
  
-   [catalog.set_environment_variable_property &#40;SSISDB Database&#41;](../Topic/catalog.set_environment_variable_property%20\(SSISDB%20Database\).md)  
  
-   [catalog.set_environment_variable_value &#40;SSISDB Database&#41;](../Topic/catalog.set_environment_variable_value%20\(SSISDB%20Database\).md)  
  
 By calling the [catalog.set_environment_variable_protection &#40;SSISDB Database&#41;](../Topic/catalog.set_environment_variable_protection%20\(SSISDB%20Database\).md) stored procedure, you can set the sensitivity bit for a variable.  
  
 To use the value of a server variable, specify the reference between the project and the server environment. You can use the following stored procedures to create and delete references. You can also indicate whether the environment can be located in the same folder as the project or in a different folder.  
  
-   [catalog.create_environment_reference &#40;SSISDB Database&#41;](../Topic/catalog.create_environment_reference%20\(SSISDB%20Database\).md)  
  
-   [catalog.delete_environment_reference &#40;SSISDB Database&#41;](../Topic/catalog.delete_environment_reference%20\(SSISDB%20Database\).md)  
  
-   [catalog.set_environment_reference_type &#40;SSISDB Database&#41;](../Topic/catalog.set_environment_reference_type%20\(SSISDB%20Database\).md)  
  
 For more details about environments and variables, query these views.  
  
-   [catalog.environments &#40;SSISDB Database&#41;](../Topic/catalog.environments%20\(SSISDB%20Database\).md)  
  
-   [catalog.environment_variables &#40;SSISDB Database&#41;](../Topic/catalog.environment_variables%20\(SSISDB%20Database\).md)  
  
-   [catalog.environment_references &#40;SSISDB Database&#41;](../Topic/catalog.environment_references%20\(SSISDB%20Database\).md)  
  
##  <a name="Executions"></a> Executions and Validations  
 An execution is an instance of a package execution. Call [catalog.create_execution &#40;SSISDB Database&#41;](../Topic/catalog.create_execution%20\(SSISDB%20Database\).md) and [catalog.start_execution &#40;SSISDB Database&#41;](../Topic/catalog.start_execution%20\(SSISDB%20Database\).md) to create and start an execution. To stop an execution or a package\/project validation, call [catalog.stop_operation &#40;SSISDB Database&#41;](../Topic/catalog.stop_operation%20\(SSISDB%20Database\).md).  
  
 To cause a running package to pause and create a dump file, call the catalog.create\_execution\_dump stored procedure. A dump file provides information about the execution of a package that can help you troubleshoot execution issues. For more information about generating and configuring dump files, see [Generating Dump Files for Package Execution](../Topic/Generating%20Dump%20Files%20for%20Package%20Execution.md).  
  
 For details about executions, validations, messages that are logged during operations, and contextual information related to errors, query these views.  
  
-   [catalog.executions &#40;SSISDB Database&#41;](../Topic/catalog.executions%20\(SSISDB%20Database\).md)  
  
-   [catalog.operations &#40;SSISDB Database&#41;](../Topic/catalog.operations%20\(SSISDB%20Database\).md)  
  
-   [catalog.operation_messages &#40;SSISDB Database&#41;](../Topic/catalog.operation_messages%20\(SSISDB%20Database\).md)  
  
-   [catalog.extended_operation_info &#40;SSISDB Database&#41;](../Topic/catalog.extended_operation_info%20\(SSISDB%20Database\).md)  
  
-   [catalog.event_messages](../Topic/catalog.event_messages.md)  
  
-   [catalog.event_message_context](../Topic/catalog.event_message_context.md)  
  
 You can validate projects and packages by calling the [catalog.validate_project &#40;SSISDB Database&#41;](../Topic/catalog.validate_project%20\(SSISDB%20Database\).md) and [catalog.validate_package &#40;SSISDB Database&#41;](../Topic/catalog.validate_package%20\(SSISDB%20Database\).md) stored procedures. The [catalog.validations &#40;SSISDB Database&#41;](../Topic/catalog.validations%20\(SSISDB%20Database\).md) view provides details about validations such as the server environment references that are considered in the validation, whether it is a dependency validation or a full validation, and whether the 32\-bit runtime or the 64\-bit runtime is used to run the package.  
  
##  <a name="AlwaysOn"></a> AlwaysOn Support  
 The AlwaysOn Availability Groups feature is a high\-availability and disaster\-recovery solution that provides an enterprise\-level alternative to database mirroring. An availability group supports a failover environment for a discrete set of user databases, known as availability databases that fail over together. For more information, please see [AlwaysOn Availability Groups](https://msdn.microsoft.com/library/hh510230.aspx).  
  
 In [!INCLUDE[ssCurrent](../Token/ssCurrent_md.md)], SQL Server Integration Services \(SSIS\) introduces new capabilities that allow you to easily deploy to a centralized SSIS Catalog \(i.e. SSISDB user database\). In order to provide the high\-availability for the SSISDB database and its contents \(projects, packages, execution logs, etc.\), you can add the SSISDB database \(just the same as any other user database\) to an AlwaysOn Availability Group. When a failover occurs, one of the secondary nodes automatically becomes the new primary node.  
  
 For detailed overview and step\-by\-step instructions for enabling AlwaysOn for SSISDB, see [Always On for SSIS Catalog &#40;SSISDB&#41;](../Topic/Always%20On%20for%20SSIS%20Catalog%20\(SSISDB\).md).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create the SSIS Catalog](../Topic/Create%20the%20SSIS%20Catalog.md)  
  
-   [Backup, Restore, and Move the SSIS Catalog](../Topic/Backup,%20Restore,%20and%20Move%20the%20SSIS%20Catalog.md)  
  
##  <a name="RelatedContent"></a> Related Content  
  
-   Blog entry, [SSIS and PowerShell in SQL Server 2012](http://go.microsoft.com/fwlink/?LinkId=242539), on blogs.msdn.com.  
  
-   Blog entry, [SSIS Catalog Access Control Tips](http://go.microsoft.com/fwlink/?LinkId=246669), on blogs.msdn.com.  
  
-   Blog entry, [A Glimpse of the SSIS Catalog Managed Object Model](http://go.microsoft.com/fwlink/?LinkId=254267), on blogs.msdn.com.  
  
  