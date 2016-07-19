---
title: How To: Create a Resource Pool for R
ms.custom: na
ms.date: 07/04/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - r-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c7f7f6e4-774d-4b45-b94a-f06c51718475
---
# How To: Create a Resource Pool for R
This topic describes how you can create a resource pool specifically for managing R workloads in [!INCLUDE[rsql_productname](../../Topics/TopicNameContainA/includes/rsql_productname_md.md)]. It assumes that you have already installed R Services (In-Database) and want to reconfigure the [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] instance to support more fine-grained management of the resources used by R.  
  
 For more information about managing server resources, see [Resource Governor](../../Topics/TopicNameNotContainA/Resource-Governor.md) and [Resource Governor Related Dynamic Management Views (Transact-SQL)](assetId:///fae5d600-586d-45fa-9d6d-03224cc13304).  
  
 **Steps**  
  
1.  Review status of existing resource pools  
  
2.  Modify server resource pools  
  
3.  Create a new resource pool for external processes  
  
4.  Create a classification function to identify R requests  
  
5.  Verify that new external resource pool is capturing R jobs  
  
##  <a name="bkmk_ReviewStatus"></a> To review the status of existing resource pools  
  
1.  First, check the resources allocated to the default pool for the server.  
  
    ```  
    SELECT * FROM sys.resource_governor_resource_pools WHERE name = 'default'  
    ```  
  
    ||||||||||  
    |-|-|-|-|-|-|-|-|-|  
    |pool_id|name|min_cpu_percent|max_cpu_percent|min_memory_percent|max_memory_percent|cap_cpu_percent|min_iops_per_volume|max_iops_per_volume|  
    |2|default|0|100|0|100|100|0|0|  
  
2.  Check the resources allocated to the default **external** resource pool.  
  
    ```  
    SELECT * FROM sys.resource_governor_external_resource_pools WHERE name = 'default'  
    ```  
  
    |||||||  
    |-|-|-|-|-|-|  
    |external_pool_id|name|max_cpu_percent|max_memory_percent|max_processes|version|  
    |2|default|100|20|0|2|  
  
3.  Under these server default settings,  the R runtime will probably have insufficient resources to complete most tasks. To change this, you must modify the server resource usage as follows:  
  
    -   Reduce the maximum computer memory that can be used by [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]  
  
    -   increase the  maximum computer memory that can be used by the external process  
  
### To modify server resource usage  
  
1.  In [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)], run the following statement to limit [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] memory usage to **60%** of the value in the 'max server memory' setting.  
  
    ```  
    ALTER RESOURCE POOL 'default' WITH (max_memory_percent = 60);  
    ```  
  
2.  Similarly, run the following statement to limit the use of memory by external processes to **40%** of total computer resources.  
  
    ```  
    ALTER EXTERNAL RESOURCE POOL 'default' WITH (max_memory_percent = 40);  
    ```  
  
3.  To enforce these changes, you must reconfigure and restart Resource Governor as follows:  
  
    ```  
    ALTER RESOURCE GOVERNOR reconfigure;  
    ```  
  
    > [!NOTE]  
    >  These are just suggested settings to start with; you should evaluate R requirements against other server processes to determine the correct balance for your environment and workload.  
  
### To create a user-defined external resource pool  
  
1.  Any changes to the configuration of Resource Governor are enforced across the server as a whole and affect  workloads that use the default pools for the server, as well as workloads that use the external pools.  
  
     Therefore, to provide more fine-grained control over which workloads should have precedence, you can create a new user-defined external resource pool. You should also define a classification function and assign it to the external resource pool.  
  
     Begin by creating a new *user-defined external resource pool*. In the following example, the pool is named **ds_ep**.  
  
    ```  
    CREATE EXTERNAL RESOURCE POOL ds_ep WITH (max_memory_percent = 40);  
    ```  
  
     Note the new **EXTERNAL** keyword.  
  
2.  Create a workload group named `ds_wg` to use in managing session requests. For SQL queries you'll use the default pool; for all external process queries will use the `ds_ep` pool.  
  
    ```  
    CREATE WORKLOAD GROUP ds_wg WITH (importance = medium) USING "default", EXTERNAL "ds_ep";  
    ```  
  
     Requests are assigned to the default group whenever the request cannot be classified, or if there is any other classification failure.  
  
     For more information, see [Resource Governor Workload Group](../../Topics/TopicNameNotContainA/Resource-Governor-Workload-Group.md) and [CREATE WORKLOAD GROUP (Transact-SQL)](assetId:///d949e540-9517-4bca-8117-ad8358848baa).  
  
### Create a classification function for R  
  
1.  A classification function examines incoming tasks and determines whether the task is one that can be run using the current resource pool. Tasks that do not meet the criteria of the classification function are assigned back to the server's default resource pool.  
  
     Begin by specifying that a classifier function should be used  by Resource Governor to determine resource pools. You can assign a null as a placeholder for the classifier function.  
  
    ```  
    ALTER RESOURCE GOVERNOR WITH (classifier_function = NULL);  
    ALTER RESOURCE GOVERNOR reconfigure;  
    ```  
  
     For more information, see [ALTER RESOURCE GOVERNOR (Transact-SQL)](assetId:///442c54bf-a0a6-4108-ad20-db910ffa6e3c).  
  
2.  In the classifier function for each resource pool, you define the type of statements or incoming requests that should be assigned to the resource pool.  
  
     For example, the following function returns the name of the schema assigned to the user-defined external resource pool if the application that sent the request is either 'Microsoft R Host' or 'RStudio'; otherwise it returns the default resource pool.  
  
    ```  
    USE master  
    GO  
    CREATE FUNCTION is_ds_apps()  
    RETURNS sysname  
    WITH schemabinding  
    AS  
    BEGIN  
        IF program_name() in ('Microsoft R Host', 'RStudio') RETURN 'ds_wg';  
        RETURN 'default'  
        END;  
    GO  
    ```  
  
3.  When the function has been created, reconfigure the resource group to assign the new classifier function to the external resource group that you defined earlier.  
  
    ```  
    ALTER RESOURCE GOVERNOR WITH  (classifier_function = dbo.is_ds_apps);  
    ALTER RESOURCE GOVERNOR WITH reconfigure;  
    go  
    ```  
  
### To verify new pools and affinity  
  
1.  To verify that the changes have been made, check the configuration of server memory and CPU for each of the workload groups associated with all instance resource pools: the default pool for the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] server, the default resource pool for external processes, and the user-defined pool for external processes.  
  
    ```  
    SELECT * FROM sys.resource_governor_workload_groups;  
    ```  
  
    |||||||||||  
    |-|-|-|-|-|-|-|-|-|-|  
    |group_id|name|importance|request_max_memory_grant_percent|request_max_cpu_time_sec|request_memory_grant_timeout_sec|max_dop|group_max_requests pool_id|pool_idd|external_pool_idd|  
    |1|internal|Medium|25|0|0|0|0|1|2|  
    |2|default|Medium|25|0|0|0|0|2|2|  
    |256|ds_wg|Medium|25|0|0|0|0|2|256|  
  
2.  You can use the new catalog view, [sys.resource_governor_external_resource_pools (Transact-SQL)](assetId:///75063e36-a91b-496f-9936-88f3d57bd447), to view all external resource pools.  
  
    ```  
    SELECT * FROM sys.resource_governor_external_resource_pools;  
    ```  
  
    |||||||  
    |-|-|-|-|-|-|  
    |external_pool_id|name|max_cpu_percent|max_memory_percent|max_processes|version|  
    |2|default|100|20|0|2|  
    |256|ds_ep|100|40|0|1|  
  
     For more information, see [Resource Governor Catalog Views (Transact-SQL)](assetId:///bb0a38e0-4eb2-49bf-bba8-750fb706d06e).  
  
3.  The following statement returns information about the computer resources that are affinitized to the external resource pool.  
  
    ```  
    SELECT * FROM sys.resource_governor_external_resource_pool_affinity;  
    ```  
  
     In this case, because the pools were created with an affinity of AUTO, no information is displayed. For more information, see [sys.dm_resource_governor_resource_pool_affinity (Transact-SQL)](assetId:///a197ec19-a2ba-44f5-a4f2-3eee33ebd77d).  
  
## See Also  
 [Resource Governor](../../Topics/TopicNameNotContainA/Resource-Governor.md)   
 [Resource Governance for R Services](../../Topics/TopicNameNotContainA/Resource-Governance-for-R-Services.md)