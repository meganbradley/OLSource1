---
title: Work with Replication Agent Profiles
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9c290a88-4e9f-4a7e-aab5-4442137a9918
---
# Work with Replication Agent Profiles
  This topic describes how to work with Replication Agent Profiles in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], [!INCLUDE[tsql](../../Token\Other/tsql_md.md)], or Replication Management Objects \(RMO\). The behavior of each replication agent is controlled by a set of parameters that can be set through agent profiles. Each agent has a default profile, and some have additional predefined profiles; at a given time, only one profile is active for an agent.  
  
 **In This Topic**  
  
-   **To work with Replication Agent Profiles, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
    -   Access the Agent Profiles dialog box  
  
    -   Specify a profile for an agent  
  
    -   Create a profile  
  
    -   Modify a profile  
  
    -   Delete a profile  
  
     [Transact\-SQL](#TsqlProcedure)  
  
    -   Create a profile  
  
    -   Modify a profile  
  
    -   Delete a profile  
  
    -   Use agent profiles during synchronization  
  
    -   Transact\-SQL example  
  
     [Replication Management Objects](#RMOProcedure)  
  
    -   Create a profile  
  
    -   Modify a profile  
  
    -   Delete a profile  
  
-   **Follow Up:**  [After Changing Agent Parameters](#FollowUp)  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
###  <a name="Access_SSMS"></a> To access the Agent Profiles dialog box from SQL Server Management Studio  
  
1.  On the **General** page of the **Distributor Properties \- \<Distributor\>** dialog box, click **Profile Defaults**.  
  
#### To access the Agent Profiles dialog box from Replication Monitor  
  
-   To open the dialog box for all agents, right\-click a Publisher, and then click **Agent Profiles**.  
  
-   To open the dialog box for a single agent:  
  
    1.  Expand a Publisher group in the left pane of Replication Monitor, expand a Publisher, and then click a publication.  
  
    2.  For Distribution Agent and Merge Agent profiles, right\-click a subscription on the **All Subscriptions** tab, and then click **Agent Profile**. For other agents, right\-click the agent on the **Agents** tab, and then click **Agent Profile**.  
  
###  <a name="Specify_SSMS"></a> To specify a profile for an agent  
  
1.  If the **Agent Profiles** dialog box displays profiles for more than one agent, select an agent.  
  
2.  Select a profile in the **Default for new** column of the **Agent profiles** grid. By default, the profile is only applied to agents for new publications and subscriptions.  
  
3.  To specify that all agents of the selected type for existing publications or subscriptions should use this profile, click **Change existing agents**.  
  
###  <a name="Modify_SSMS"></a> To view and edit the parameters associated with a profile  
  
1.  If the **Agent Profiles** dialog box displays profiles for more than one agent, select an agent.  
  
2.  Click the properties button \(**…**\) next to a profile.  
  
3.  View the parameters and values in the **\<ProfileName\> Profile Properties** dialog box.  
  
    -   Parameters in user\-defined profiles can be edited; parameters in predefined system profiles cannot.  
  
    -   To view all parameters for an agent, clear the **Show only parameters used in this profile** check box. For information about agent parameters, see the links at the end of this topic.  
  
4.  Click **Close**.  
  
###  <a name="Create_SSMS"></a> To create a user\-defined profile  
  
1.  If the **Agent Profiles** dialog box displays profiles for more than one agent, select an agent.  
  
2.  Click **New**.  
  
3.  In the **New Agent Profile** initialization dialog box, select an existing profile on which to base the new profile.  
  
4.  In the **New Agent Profile** dialog box, enter values in the **Name** and **Description** text boxes.  
  
5.  Modify parameters to tailor the profile. To view all parameters for an agent, clear the **Show only parameters used in this profile** check box. For information about agent parameters, see the links at the end of this topic.  
  
6.  [!INCLUDE[clickOK](../../Token\Other/clickOK_md.md)]  
  
###  <a name="Delete_SSMS"></a> To delete a user\-defined profile  
  
1.  If the **Agent Profiles** dialog box displays profiles for more than one agent, select an agent.  
  
2.  If a profile is associated with one or more agents, change the profile for those agents:  
  
    1.  Select a different profile in the **Agent profiles** grid.  
  
    2.  Click **Change existing agents**.  
  
        > [!NOTE]  
        >  This will change the profile for all agents of the selected type for existing publications or subscriptions, not only the ones using the profile you want to delete.  
  
3.  Select the profile you want to delete, and then click **Delete**.  
  
4.  [!INCLUDE[clickOK](../../Token\Other/clickOK_md.md)]  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
  
###  <a name="Create_tsql"></a> To create a new agent profile  
  
1.  At the Distributor, execute [sp_add_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_add_agent_profile%20\(Transact-SQL\).md). Specify **@name**, a value of **1** for **@profile\_type**, and one of the following values for **@agent\_type**:  
  
    -   **1** \- [Replication Snapshot Agent](../../Topics\TopicNameNotContainA/Replication-Snapshot-Agent.md)  
  
    -   **2** \- [Replication Log Reader Agent](../../Topics\TopicNameNotContainA/Replication-Log-Reader-Agent.md)  
  
    -   **3** \- [Replication Distribution Agent](../../Topics\TopicNameNotContainA/Replication-Distribution-Agent.md)  
  
    -   **4** \- [Replication Merge Agent](../../Topics\TopicNameNotContainA/Replication-Merge-Agent.md)  
  
    -   **9** \- [Replication Queue Reader Agent](../../Topics\TopicNameNotContainA/Replication-Queue-Reader-Agent.md)  
  
     If this profile will become the new default profile for its type of replication agent, specify a value of **1** for **@default**. The identifier for the new profile is returned using the **@profile\_id** output parameter. This creates a new profile with a set of profile parameters based on the default profile for the given agent type.  
  
2.  After the new profile has been created, add, remove, or modify the default parameters to customize the profile.  
  
###  <a name="Modify_tsql"></a> To modify an existing agent profile  
  
1.  At the Distributor, execute [sp_help_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_help_agent_profile%20\(Transact-SQL\).md). Specify one of the following values for **@agent\_type**:  
  
    -   **1** \- [Replication Snapshot Agent](../../Topics\TopicNameNotContainA/Replication-Snapshot-Agent.md)  
  
    -   **2** \- [Replication Log Reader Agent](../../Topics\TopicNameNotContainA/Replication-Log-Reader-Agent.md)  
  
    -   **3** \- [Replication Distribution Agent](../../Topics\TopicNameNotContainA/Replication-Distribution-Agent.md)  
  
    -   **4** \- [Replication Merge Agent](../../Topics\TopicNameNotContainA/Replication-Merge-Agent.md)  
  
    -   **9** \- [Replication Queue Reader Agent](../../Topics\TopicNameNotContainA/Replication-Queue-Reader-Agent.md)  
  
     This returns all profiles for the specified type of agent. Note the value of **profile\_id** in the result set for the profile to change.  
  
2.  At the Distributor, execute [sp_help_agent_parameter &#40;Transact-SQL&#41;](../Topic/sp_help_agent_parameter%20\(Transact-SQL\).md). Specify the profile identifier from step 1 for **@profile\_id**. This returns all parameters for the profile. Note the name of any parameters to modify or remove from the profile.  
  
3.  To change the value of a parameter in a profile, execute [sp_change_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_change_agent_profile%20\(Transact-SQL\).md). Specify the profile identifier from step 1 for **@profile\_id**, the name of the parameter to change for **@property**, and a new value for the parameter for **@value**.  
  
    > [!NOTE]  
    >  You cannot change an existing agent profile to become the default profile for an agent. You must instead create a new profile as the default profile, as shown in the previous procedure.  
  
4.  To remove a parameter from a profile, execute [sp_drop_agent_parameter &#40;Transact-SQL&#41;](../Topic/sp_drop_agent_parameter%20\(Transact-SQL\).md). Specify the profile identifier from step 1 for **@profile\_id** and the name of the parameter to remove for **@parameter\_name**.  
  
5.  To add a new parameter to a profile, you must do the following:  
  
    -   Query the [MSagentparameterlist &#40;Transact-SQL&#41;](../Topic/MSagentparameterlist%20\(Transact-SQL\).md) table at the Distributor to determine which profile parameters can be set for each agent type.  
  
    -   At the Distributor, execute [sp_add_agent_parameter &#40;Transact-SQL&#41;](../Topic/sp_add_agent_parameter%20\(Transact-SQL\).md). Specify the profile identifier from step 1 for **@profile\_id**, the name of a valid parameter to add for **@parameter\_name**, and the value of the parameter for **@parameter\_value**.  
  
###  <a name="Delete_tsql"></a> To delete an agent profile  
  
1.  At the Distributor, execute [sp_help_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_help_agent_profile%20\(Transact-SQL\).md). Specify one of the following values for **@agent\_type**:  
  
    -   **1** \- [Replication Snapshot Agent](../../Topics\TopicNameNotContainA/Replication-Snapshot-Agent.md)  
  
    -   **2** \- [Replication Log Reader Agent](../../Topics\TopicNameNotContainA/Replication-Log-Reader-Agent.md)  
  
    -   **3** \- [Replication Distribution Agent](../../Topics\TopicNameNotContainA/Replication-Distribution-Agent.md)  
  
    -   **4** \- [Replication Merge Agent](../../Topics\TopicNameNotContainA/Replication-Merge-Agent.md)  
  
    -   **9** \- [Replication Queue Reader Agent](../../Topics\TopicNameNotContainA/Replication-Queue-Reader-Agent.md)  
  
     This returns all profiles for the specified type of agent. Note the value of **profile\_id** in the result set for the profile to remove.  
  
2.  At the Distributor, execute [sp_drop_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_drop_agent_profile%20\(Transact-SQL\).md). Specify the profile identifier from step 1 for **@profile\_id**.  
  
###  <a name="Synch_tsql"></a> To use agent profiles during synchronization  
  
1.  At the Distributor, execute [sp_help_agent_profile &#40;Transact-SQL&#41;](../Topic/sp_help_agent_profile%20\(Transact-SQL\).md). Specify one of the following values for **@agent\_type**:  
  
    -   **1** \- [Replication Snapshot Agent](../../Topics\TopicNameNotContainA/Replication-Snapshot-Agent.md)  
  
    -   **2** \- [Replication Log Reader Agent](../../Topics\TopicNameNotContainA/Replication-Log-Reader-Agent.md)  
  
    -   **3** \- [Replication Distribution Agent](../../Topics\TopicNameNotContainA/Replication-Distribution-Agent.md)  
  
    -   **4** \- [Replication Merge Agent](../../Topics\TopicNameNotContainA/Replication-Merge-Agent.md)  
  
    -   **9** \- [Replication Queue Reader Agent](../../Topics\TopicNameNotContainA/Replication-Queue-Reader-Agent.md)  
  
     This returns all profiles for the specified type of agent. Note the value of **profile\_name** in the result set for the profile to use.  
  
2.  If the agent is started from an agent job, edit the job step that starts the agent to specify the value of **profile\_name** obtained in step 1 after the **\-ProfileName** command\-line parameter. For more information, see [View and Modify Replication Agent Command Prompt Parameters &#40;SQL Server Management Studio&#41;](../Topic/View%20and%20Modify%20Replication%20Agent%20Command%20Prompt%20Parameters%20\(SQL%20Server%20Management%20Studio\).md).  
  
3.  When starting the agent from the command prompt, specify the value of **profile\_name** obtained in step 1 after the **\-ProfileName** command\-line parameter.  
  
###  <a name="TsqlExample"></a> Example \(Transact\-SQL\)  
 This example creates a custom profile for the Merge Agent named **custom\_merge**, changes the value of the **\-UploadReadChangesPerBatch** parameter, adds a new **\-ExchangeType** parameter, and returns information on the profile that is created.  
  
 [!CODE [HowTo#sp_addagentprofileparam](../CodeSnippet/SQL15/replication/howto#sp_addagentprofileparam)]  
  
##  <a name="RMOProcedure"></a> Using RMO  
  
###  <a name="Create_RMO"></a> To create a new agent profile  
  
1.  Create a connection to the Distributor by using an instance of the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) class.  
  
2.  Create an instance of the [AgentProfile](assetId:///T:Microsoft.SqlServer.Replication.AgentProfile) class.  
  
3.  Set the following properties on the object:  
  
    -   [Name](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Name) \- the name for the profile.  
  
    -   [AgentType](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.AgentType) \- an [AgentType](assetId:///T:Microsoft.SqlServer.Replication.AgentType) value that specifies the type of replication agent for which the profile is being created.  
  
    -   [ConnectionContext](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.ConnectionContext) \- the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) created in step 1.  
  
    -   \(Optional\) [Description](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Description) \- a description of the profile.  
  
    -   \(Optional\) [Default](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Default) \- set this property to **true** if all new agent jobs for this [AgentType](assetId:///T:Microsoft.SqlServer.Replication.AgentType) will use this profile by default.  
  
4.  Call the [Create](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.Create) method to create the profile on the server.  
  
5.  Once the profile exists on the server, you can customize it by adding, removing, or changing the values of replication agent parameters.  
  
6.  To assign the profile to an existing replication agent job, call the [AssignToAgent](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.AssignToAgent(System.String,System.Int32)) method. Pass the name of the distribution database for *distributionDBName* and the ID of the job for *agentID*.  
  
###  <a name="Modify_RMO"></a> To modify an existing agent profile  
  
1.  Create a connection to the Distributor by using an instance of the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) class.  
  
2.  Create an instance of the [ReplicationServer](assetId:///T:Microsoft.SqlServer.Replication.ReplicationServer) class. Pass the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) object created in step 1.  
  
3.  Call the [LoadProperties](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.LoadProperties) method. If this method returns **false**, verify that the Distributor exists.  
  
4.  Call the [EnumAgentProfiles](assetId:///M:Microsoft.SqlServer.Replication.ReplicationServer.EnumAgentProfiles(Microsoft.SqlServer.Replication.AgentType)) method. Pass an [AgentType](assetId:///T:Microsoft.SqlServer.Replication.AgentType) value to narrow down the returned profiles to a specific type of replication agent.  
  
5.  Get the desired [AgentProfile](assetId:///T:Microsoft.SqlServer.Replication.AgentProfile) object from the returned [ArrayList](assetId:///T:System.Collections.ArrayList), where the [Name](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Name) property of the object matches the profile name.  
  
6.  Call one of the following methods of [AgentProfile](assetId:///T:Microsoft.SqlServer.Replication.AgentProfile) to change the profile:  
  
    -   [AddParameter](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.AddParameter(System.String,System.String)) \- adds a supported parameter to the profile, where *name* is the name of the replication agent parameter and *value* is the specified value. To enumerate all supported agent parameters for a given agent type, call the [EnumParameterInfo](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.EnumParameterInfo) method. This method returns an [ArrayList](assetId:///T:System.Collections.ArrayList) of [AgentProfileParameterInfo](assetId:///T:Microsoft.SqlServer.Replication.AgentProfileParameterInfo) objects that represent all supported parameters.  
  
    -   [RemoveParameter](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.RemoveParameter(System.String)) \- removes an existing parameter from the profile, where *name* is the name of the replication agent parameter. To enumerate all current agent parameters defined for the profile, call the [EnumParameters](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.EnumParameters) method. This method returns an [ArrayList](assetId:///T:System.Collections.ArrayList) of [AgentProfileParameter](assetId:///T:Microsoft.SqlServer.Replication.AgentProfileParameter) objects that represent the existing parameter for this profile.  
  
    -   [ChangeParameter](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.ChangeParameter(System.String,System.String)) \- changes the setting of an existing parameter in the profile, where *name* is the name of the agent parameter and *newValue* is the value to which the parameter is being changed. To enumerate all current agent parameters defined for the profile, call the [EnumParameters](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.EnumParameters) method. This method returns an [ArrayList](assetId:///T:System.Collections.ArrayList) of [AgentProfileParameter](assetId:///T:Microsoft.SqlServer.Replication.AgentProfileParameter) objects that represent the existing parameter for this profile. To enumerate all supported agent parameter settings, call the [EnumParameterInfo](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.EnumParameterInfo) method. This method returns an [ArrayList](assetId:///T:System.Collections.ArrayList) of [AgentProfileParameterInfo](assetId:///T:Microsoft.SqlServer.Replication.AgentProfileParameterInfo) objects that represent the supported values for all parameters.  
  
###  <a name="Delete_RMO"></a> To delete an agent profile  
  
1.  Create a connection to the Distributor by using an instance of the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) class.  
  
2.  Create an instance of the [AgentProfile](assetId:///T:Microsoft.SqlServer.Replication.AgentProfile) class. Set the name of the profile for [Name](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Name) and the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) from step 1 for [ConnectionContext](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.ConnectionContext).  
  
3.  Call the [LoadProperties](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.LoadProperties) method. If this method returns **false**, either the specified name was incorrect or the profile does not exist on the server.  
  
4.  Verify that the [Type](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Type) property is set to [User](assetId:///F:Microsoft.SqlServer.Replication.AgentProfileTypeOption.User), which indicates a customer profile. You should not remove a profile that has a value of [System](assetId:///F:Microsoft.SqlServer.Replication.AgentProfileTypeOption.System) for [Type](assetId:///P:Microsoft.SqlServer.Replication.AgentProfile.Type).  
  
5.  Call the [Remove](assetId:///M:Microsoft.SqlServer.Replication.AgentProfile.Remove) method to remove the user\-defined profile represented by this object from the server.  
  
##  <a name="FollowUp"></a> Follow Up: After Changing Agent Parameters  
 Agent parameter changes take effect the next time the agent is started. If the agent runs continuously, you must stop and restart the agent.  
  
## See Also  
 [Replication Agent Profiles](../../Topics\TopicNameNotContainA/Replication-Agent-Profiles.md)   
 [Replication Snapshot Agent](../../Topics\TopicNameNotContainA/Replication-Snapshot-Agent.md)   
 [Replication Log Reader Agent](../../Topics\TopicNameNotContainA/Replication-Log-Reader-Agent.md)   
 [Replication Distribution Agent](../../Topics\TopicNameNotContainA/Replication-Distribution-Agent.md)   
 [Replication Merge Agent](../../Topics\TopicNameNotContainA/Replication-Merge-Agent.md)   
 [Replication Queue Reader Agent](../../Topics\TopicNameNotContainA/Replication-Queue-Reader-Agent.md)  
  
  