---
title: "Change Publication and Article Properties"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f7df51ef-c088-4efc-b247-f91fb2c6ff32
caps.latest.revision: 21
manager: jhubbard
---
# Change Publication and Article Properties
After a publication has been created, most publication and article properties can be changed, but some require that the snapshot be regenerated and/or subscriptions be reinitialized. This topic provides information about all properties that require one or both of these actions if they are changed.  
  
## Publication Properties for Snapshot and Transactional Replication  
  
|Description|Stored procedure|Properties|Requirements|  
|-----------------|----------------------|----------------|------------------|  
|Change snapshot format.|**sp_changepublication**|**sync_method**|New snapshot.|  
|Change snapshot location.|**sp_changepublication**|**alt_snapshot_folder**<br /><br /> **snapshot_in_defaultfolder**|New snapshot.|  
|Change snapshot location.|**sp_changedistpublisher**|**working_directory**|New snapshot.|  
|Change snapshot compression.|**sp_changepublication**|**compress_snapshot**|New snapshot.|  
|Change any File Transfer Protocol (FTP) snapshot options.|**sp_changepublication**|**enabled_for_internet**<br /><br /> **ftp_address**<br /><br /> **ftp_login**<br /><br /> **ftp_password**<br /><br /> **ftp_port**<br /><br /> **ftp_subdirectory**|New snapshot.|  
|Change pre- or post-snapshot script location.|**sp_changepublication**|**pre_snapshot_script**<br /><br /> **post_snapshot_script**|New snapshot (also required if you change the script contents).<br /><br /> Reinitialization is required to apply the new script to the Subscriber.|  
|Enable or disable support for non-[!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers.|**sp_changepublication**|**is_enabled_for_het_sub**|New snapshot.|  
|Change conflict reporting for queued updating subscriptions|**sp_changepublication**|**centralized_conflicts**|Can only be changed if there are no active subscriptions.|  
|Change conflict resolution policy for queued updating subscriptions.|**sp_changepublication**|**conflict_policy**|Can only be changed if there are no active subscriptions.|  
  
## Article Properties for Snapshot and Transactional Replication  
  
|Description|Stored procedure|Properties|Requirements|  
|-----------------|----------------------|----------------|------------------|  
|Drop an article|**sp_droparticle**|All parameters.|Articles can be dropped prior to subscriptions being created. Using stored procedures, it is possible to drop a subscription to an article; using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], the entire subscription must be dropped, recreated, and synchronized. For more information, see [Add Articles to and Drop Articles from Existing Publications](../../Topics/TopicNameNotContainA/Add-Articles-to-and-Drop-Articles-from-Existing-Publications.md).|  
|Change a column filter.|**sp_articlecolumn**|**@column**<br /><br /> **@operation**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Add a row filter.|**sp_articlefilter**|All parameters.|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Drop a row filter.|**sp_articlefilter**|**@article**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change a row filter.|**sp_articlefilter**|**@filter_clause**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change a row filter.|**sp_changearticle**|**filter**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change schema options.|**sp_changearticle**|**schema_option**|New snapshot.|  
|Change how tables at the Subscriber are handled prior to applying the snapshot.|**sp_changearticle**|**pre_creation_cmd**|New snapshot.|  
|Change article status|**sp_changearticle**|**status**|New snapshot.|  
|Change INSERT, UPDATE or DELETE commands.|**sp_changearticle**|**ins_cmd**<br /><br /> **upd_cmd**<br /><br /> **del_cmd**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change destination table name|**sp_changearticle**|**dest_table**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change destination table owner (schema).|**sp_changearticle**|**destination_owner**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change data type mappings (applies to Oracle publishing only).|**sp_changearticlecolumndatatype**|**@type**<br /><br /> **@length**<br /><br /> **@precision**<br /><br /> **@scale**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
  
## Publication Properties for Merge Replication  
  
|Description|Stored procedure|Properties|Requirements|  
|-----------------|----------------------|----------------|------------------|  
|Change snapshot format|**sp_changemergepublication**|**sync_mode**|New snapshot.|  
|Change snapshot location.|**sp_changemergepublication**|**alt_snapshot_folder**<br /><br /> **snapshot_in_defaultfolder**|New snapshot.|  
|Change snapshot location.|**sp_changedistpublisher**|**working_directory**|New snapshot.|  
|Change snapshot compression|**sp_changemergepublication**|**compress_snapshot**|New snapshot.|  
|Change any FTP snapshot options|**sp_changemergepublication**|**enabled_for_internet**<br /><br /> **ftp_address**<br /><br /> **ftp_login**<br /><br /> **ftp_password**<br /><br /> **ftp_port**<br /><br /> **ftp_subdirectory**|New snapshot.|  
|Change pre- or post-snapshot scripts.|**sp_changemergepublication**|**pre_snapshot_script**<br /><br /> **post_snapshot_script**|New snapshot (also required if you change the script contents).<br /><br /> Reinitialization is required to apply the new script to the Subscriber.|  
|Add a join filter or logical record.|**sp_addmergefilter**|All parameters.|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Drop a join filter or logical record.|**sp_dropmergefilter**|All parameters.|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change a join filter or logical record.|**sp_changemergefilter**|**@property**<br /><br /> **@value**|New snapshot<br /><br /> Reinitialize subscriptions.|  
|Disable the use of parameterized filters (enabling parameterized filters does not require any special actions).|**sp_changemergepublication**|A value of **false** for **dynamic_filters**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Enable or disable the use of precomputed partitions.|**sp_changemergepublication**|**use_partition_groups**|New snapshot.|  
|Enable or disable [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssVersion2000](../../Topics/TopicNameContainA/includes/ssVersion2000_md.md)] partition optimization.|**sp_changemergepublication**|**keep_partition_changes**|Reinitialize subscriptions.|  
|Enable or disable Subscriber partition validation.|**sp_changemergepublication**|**validate_subscriber_info**|Reinitialize subscriptions.|  
|Change the publication compatibility level to 80sp3 or lower.|**sp_changemergepublication**|**publication_compatibility_level**|New snapshot.|  
  
## Article Properties for Merge Replication  
  
|Description|Stored Procedure|Properties|Requirements|  
|-----------------|----------------------|----------------|------------------|  
|Drop an article, where the article has the last parameterized filter in the publication.|**sp_dropmergearticle**|All parameters|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Drop an article, where the article is a parent in a join filter or logical record (this has the side effect of dropping the join).|**sp_dropmergearticle**|All parameters|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Drop an article, all other circumstances.|**sp_dropmergearticle**|All parameters|New snapshot.|  
|Include a column filter that was previously unpublished.|**sp_mergearticlecolumn**|**@column**<br /><br /> **@operation**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Add, drop, or change a row filter.|**sp_changemergearticle**|**subset_filterclause**|New snapshot.<br /><br /> Reinitialize subscriptions.<br /><br /> If you add, drop, or change a parameterized filter, pending changes at the Subscriber cannot be uploaded to the Publisher during reinitialization. If you want to upload pending changes, synchronize all subscriptions before changing the filter.<br /><br /> If an article is not involved in any join filters, you can drop the article and add it again with a different row filter, which does not require the entire subscription to be reinitialized. For more information about adding and dropping articles, see [Add Articles to and Drop Articles from Existing Publications](../../Topics/TopicNameNotContainA/Add-Articles-to-and-Drop-Articles-from-Existing-Publications.md).|  
|Change schema options.|**sp_changemergearticle**|**schema_option**|New snapshot.|  
|Change tracking from column-level to row-level (changing from row-level tracking to column-level tracking does not require any special actions).|**sp_changemergearticle**|A value of **false** for **column_tracking**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Change whether permissions are checked before statements made at the Subscriber are applied at the Publisher.|**sp_changemergearticle**|**check_permissions**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
|Enable or disable download-only subscriptions (changing to or from other upload options does not require any special actions).|**sp_changemergearticle**|Change to or from a value of **2** for **subscriber_upload_options**|Reinitialize subscriptions.|  
|Change destination table owner.|**sp_changemergearticle**|**destination_owner**|New snapshot.<br /><br /> Reinitialize subscriptions.|  
  
## See Also  
 [Administration (Replication)](../../Topics/TopicNameNotContainA/Administration--Replication-.md)   
 [Create and Apply the Snapshot](../../Topics/TopicNameNotContainA/Create-and-Apply-the-Snapshot.md)   
 [Reinitialize Subscriptions](../../Topics/TopicNameNotContainA/Reinitialize-Subscriptions.md)   
 [sp_addmergefilter (Transact-SQL)](assetId:///4c118cb1-2008-44e2-a797-34b7dc34d6b1)   
 [sp_articlecolumn (Transact-SQL)](assetId:///8abaa8c1-d99e-4788-970f-c4752246c577)   
 [sp_articlefilter (Transact-SQL)](assetId:///4c3fee32-a43f-4757-a029-30aef4696afb)   
 [sp_changearticle (Transact-SQL)](assetId:///24c33ca5-f03a-4417-a267-131ca5ba6bb5)   
 [sp_changearticlecolumndatatype (Transact-SQL)](assetId:///0db80e08-fb77-4d0c-aa41-455b13ffa9b4)   
 [sp_changedistpublisher (Transact-SQL)](assetId:///7ef5c89d-faaa-4f8e-aef7-00649ebc8bc9)   
 [sp_changemergearticle (Transact-SQL)](assetId:///0dc3da5c-4af6-45be-b5f0-074da182def2)   
 [sp_changemergefilter (Transact-SQL)](assetId:///e08fdfdd-d242-4e85-817b-9f7a224fe567)   
 [sp_changemergepublication (Transact-SQL)](assetId:///81fe1994-7678-4852-980b-e02fedf1e796)   
 [sp_changepublication (Transact-SQL)](assetId:///c36e5865-25d5-42b7-b045-dc5036225081)   
 [sp_droparticle (Transact-SQL)](assetId:///09fec594-53f4-48a5-8edb-c50731c7adb2)   
 [sp_dropmergearticle (Transact-SQL)](assetId:///5ef1fbf7-c03d-4488-9ab2-64aae296fa4f)   
 [sp_dropmergefilter (Transact-SQL)](assetId:///798586d7-05f3-4a5e-bea8-a34b7b52d0fd)   
 [sp_mergearticlecolumn (Transact-SQL)](assetId:///b4f2b888-e094-4759-a472-d893638995eb)