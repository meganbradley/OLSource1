---
title: Implement a Custom Conflict Resolver for a Merge Article
ms.custom: na
ms.devlang: 
  - TSQL
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 76bd8524-ebc1-4d80-b5a2-4169944d6ac0
---
# Implement a Custom Conflict Resolver for a Merge Article
  This topic describes how to implement custom conflict resolver for a merge article in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] or a [COM\-based custom resolver](../../Topics\TopicNameNotContainA/COM-Based-Custom-Resolvers.md).  
  
 **In This Topic**  
  
-   **To implement custom conflict resolver for a merge article, using:**  
  
     [Transact\-SQL](#TsqlProcedure)  
  
     [COM\-based Resolver](#COM)  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
 You can write your own custom conflict resolver as a [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] stored procedure at each Publisher. During synchronization, this stored procedure is invoked when conflicts are encountered in an article to which the resolver was registered, and information on the conflict row is passed by the Merge Agent to the required parameters of the procedure. Stored procedure\-based custom conflict resolvers are always created at the Publisher.  
  
> [!NOTE]  
>  [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] stored procedure resolvers are only invoked to handle row change\-based conflicts. They cannot be used to handle other types of conflicts such as insert failures due to PRIMARY KEY violations or unique index constraint violations.  
  
#### To create a stored procedure\-based custom conflict resolver  
  
1.  At the Publisher in either the publication or **msdb** database, create a new system stored procedure that implements the following required parameters:  
  
    |Parameter|Data type|Description|  
    |---------------|---------------|-----------------|  
    |**@tableowner**|**sysname**|Name of the owner of the table for which a conflict is being resolved. This is the owner for the table in the publication database.|  
    |**@tablename**|**sysname**|Name of the table for which a conflict is being resolved.|  
    |**@rowguid**|**uniqueidentifier**|Unique identifier for the row having the conflict.|  
    |**@subscriber**|**sysname**|Name of the server from where a conflicting change is being propagated.|  
    |**@subscriber\_db**|**sysname**|Name of the database from where conflicting change is being propagated.|  
    |**@log\_conflict OUTPUT**|**int**|Whether the merge process should log a conflict for later resolution:<br /><br /> **0** \= Do not log the conflict.<br /><br /> **1** \= Subscriber is the conflict loser.<br /><br /> **2** \= Publisher is the conflict loser.|  
    |**@conflict\_message OUTPUT**|**nvarchar\(512\)**|Message to be given about the resolution if the conflict is logged.|  
    |**@destowner**|**sysname**|The owner of the published table at the Subscriber.|  
  
     This stored procedure uses the values passed by the Merge Agent to these parameters to implement your custom conflict resolution logic; it must return a single row result set that is identical in structure to the base table and contains the data values for the winning version of the row.  
  
2.  Grant EXECUTE permissions on the stored procedure to any logins used by Subscribers to connect to the Publisher.  
  
#### To use a custom conflict resolver with a new table article  
  
1.  Execute [sp\_addmergearticle](../Topic/sp_addmergearticle%20\(Transact-SQL\).md) to define an article, specifying a value of **MicrosoftSQL** **Server Stored Procedure Resolver** for the **@article\_resolver** parameter and the name of the stored procedure that implements the conflict resolver logic for the **@resolver\_info** parameter. For more information, see [Define an Article](../../Topics\TopicNameNotContainA/Define-an-Article.md).  
  
#### To use a custom conflict resolver with an existing table article  
  
1.  Execute [sp\_changemergearticle](../Topic/sp_changemergearticle%20\(Transact-SQL\).md), specifying **@publication**, **@article**, a value of **article\_resolver** for **@property**, and a value of **MicrosoftSQL** **Server Stored ProcedureResolver** for **@value**.  
  
2.  Execute [sp\_changemergearticle](../Topic/sp_changemergearticle%20\(Transact-SQL\).md), specifying **@publication**, **@article**, a value of **resolver\_info** for **@property**, and the name of the stored procedure that implements the conflict resolver logic for **@value**.  
  
##  <a name="COM"></a> Using a COM\-based Custom Resolver  
 The [Microsoft.SqlServer.Replication.BusinessLogicSupport](assetId:///N:Microsoft.SqlServer.Replication.BusinessLogicSupport) namespace implements an interface that enables you to write complex business logic to handle events and resolve conflicts that occur during the merge replication synchronization process. For more information, see [Implement a Business Logic Handler for a Merge Article](../../Topics\TopicNameContainA/Implement-a-Business-Logic-Handler-for-a-Merge-Article.md). You can also write your own native code\-based custom business logic to resolve conflicts. This logic is built as a COM component and compiled into dynamic\-link libraries \(DLL\), using products such as [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Visual C\+\+. Such a COM–based custom conflict resolver must implement the **ICustomResolver** interface, which is designed specifically for conflict resolution.  
  
#### To create and register a COM\-based custom conflict resolver  
  
1.  In a COM\-compatible authoring environment, add references to the Custom Conflict Resolver library.  
  
2.  For a Visual C\+\+ project, use the \#import directive to import this library into your project.  
  
3.  Create a class that implements the **ICustomResolver** interface.  
  
4.  Implement certain methods and properties.  
  
5.  Build the project to create the custom conflict resolver library file.  
  
6.  Deploy the library in the directory containing the merge agent executable \(usually \\Microsoft SQL Server\\100\\COM\).  
  
    > [!NOTE]  
    >  A custom conflict resolver must be deployed at the Subscriber for a pull subscription, at the Distributor for a push subscription, or at the Web server used with Web synchronization.  
  
7.  Register the custom conflict resolver library using regsvr32.exe from the deployment directory as follows:  
  
    ```  
    regsvr32.exe mycustomresolver.dll  
    ```  
  
8.  At the Publisher, execute [sp_enumcustomresolvers &#40;Transact-SQL&#41;](../Topic/sp_enumcustomresolvers%20\(Transact-SQL\).md) to verify that the library is not already registered as a custom conflict resolver.  
  
9. To register the library as a custom conflict resolver, execute [sp_registercustomresolver &#40;Transact-SQL&#41;](../Topic/sp_registercustomresolver%20\(Transact-SQL\).md), at the Distributor. Specify the friendly name of the COM object for **@article\_resolver**, the library's ID \(CLSID\) for **@resolver\_clsid**, and a value of **false** for **@is\_dotnet\_assembly**.  
  
    > [!NOTE]  
    >  When no longer needed, a custom conflict resolver can be unregistered using [sp_unregistercustomresolver &#40;Transact-SQL&#41;](../Topic/sp_unregistercustomresolver%20\(Transact-SQL\).md).  
  
10. \(Optional\) On a cluster, repeat steps 5\-8 to register the custom resolver on all nodes of the cluster. This is required to ensure that the custom resolver will be able to properly load the reconciler following a failover.  
  
#### To use a custom conflict resolver with a new table article  
  
1.  At the Publisher, execute [sp_enumcustomresolvers &#40;Transact-SQL&#41;](../Topic/sp_enumcustomresolvers%20\(Transact-SQL\).md) and note the friendly name of the desired resolver.  
  
2.  At the Publisher on the publication database, execute [sp_addmergearticle &#40;Transact-SQL&#41;](../Topic/sp_addmergearticle%20\(Transact-SQL\).md) to define an article. Specify the friendly name of the article resolver from step 1 for **@article\_resolver**. For more information, see [Define an Article](../../Topics\TopicNameNotContainA/Define-an-Article.md).  
  
#### To use a custom conflict resolver with an existing table article  
  
1.  At the Publisher, execute [sp_enumcustomresolvers &#40;Transact-SQL&#41;](../Topic/sp_enumcustomresolvers%20\(Transact-SQL\).md) and note the friendly name of the desired resolver.  
  
2.  Execute [sp_changemergearticle &#40;Transact-SQL&#41;](../Topic/sp_changemergearticle%20\(Transact-SQL\).md), specifying **@publication**, **@article**, a value of **article\_resolver** for **@property**, and the friendly name of the article resolver from step 1 for **@value**.  
  
#### Viewing a Sample Custom Resolver  
  
1.  A sample is available in the SQL Server 2000 sample files. Download the **sql2000samples.cab** from [Updated Samples for SQL Server 2000 Service Pack 3](http://www.microsoft.com/download/details.aspx?id=8560). This downloads 8 files amounting to 6.9 MB.  
  
2.  Extract the files from downloaded compressed .cab file.  
  
3.  Run **setup.exe**  
  
    > [!NOTE]  
    >  When choosing the installation options, it is only necessary to install the **Replication** samples. \(The default installation path is **C:\\Program Files \(x86\)\\Microsoft SQL Server 2000 Samples\\1033\\**\)  
  
4.  Go to installation folder. \(The default folder is **C:\\Program Files \(x86\)\\Microsoft SQL Server 2000 Samples\\1033\\sqlrepl\\unzip\_sqlreplSP3.exe**\)  
  
5.  Run the **unzip\_sqlreplSP3.exe** program.  
  
    > [!NOTE]  
    >  The sample com resolver will install \(by default\) to the **C:\\Program Files \(x86\)\\Microsoft SQL Server 2000 Samples\\1033\\sqlrepl\\resolver\\subspres** folder.  
  
6.  In the **subspres** folder, find all occurrences of **\#include sqlres.h** in all of the source files and replace them with **\#import "replrec.dll" no\_namespace, raw\_interfaces\_only**  
  
## See Also  
 [Advanced Merge Replication Conflict Detection and Resolution](../../Topics\TopicNameNotContainA/Advanced-Merge-Replication-Conflict-Detection-and-Resolution.md)   
 [COM-Based Custom Resolvers](../../Topics\TopicNameNotContainA/COM-Based-Custom-Resolvers.md)   
 [Replication Security Best Practices](../../Topics\TopicNameNotContainA/Replication-Security-Best-Practices.md)  
  
  