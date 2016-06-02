---
title: Create a Policy-Based Management Policy
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b28bf963-89f9-4941-b6c1-6004fec347f1
---
# Create a Policy-Based Management Policy
  This topic describes how to create a Policy\-Based Management policy in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)].  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Security](#Security)  
  
-   **To create a policy, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires membership in the PolicyAdministratorRole role in the msdb database.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To create a policy  
  
1.  In **Object Explorer**, click the plus sign to expand the server where you want to create a new a Policy\-Based Management policy.  
  
2.  Click the plus sign to expand the **Management** folder.  
  
3.  Click the plus sign to expand **Policy Management**.  
  
4.  Right\-click the **Policies** folder and select **New Policy**.  
  
5.  In the **Create New Policy** dialog box, in the **Name** box, type the name of the new policy.  
  
6.  If you want the policy to be enabled as soon as it is created, select the **Enabled** check box. If the evaluation mode is **On demand**, the **Enabled** check box is not available.  
  
7.  In the **Check condition** list, select one of the existing conditions, or select **New Condition**. To edit a condition, select the condition and then click the ellipsis \(**...**\). For more information, see [Create a New Policy-Based Management Condition](../../Topics\TopicNameContainA/Create-a-New-Policy-Based-Management-Condition.md) or [View or Modify the Properties of a Policy-Based Management Condition](../../Topics\TopicNameContainA/View-or-Modify-the-Properties-of-a-Policy-Based-Management-Condition.md).  
  
8.  In the **Against targets** box, select one or more target types for this policy. Some conditions and facets can only be applied to certain types of targets. The available target sets appear in the associated box. Expand **Every** to select a filtering condition for some types of the targets. If no targets appear in this box, the check condition is scoped at the server level.  
  
9. In the **Evaluation Mode** box, select how this policy will behave. Different conditions can have different valid evaluation modes. For more information about which evaluation modes are valid, see [Administer Servers by Using Policy-Based Management](../../Topics\TopicNameNotContainA/Administer-Servers-by-Using-Policy-Based-Management.md).  
  
10. If the policy will be evaluated on a schedule, set the evaluation mode to **On schedule**, and then click **Pick** to select a schedule, or click **New** to create a new schedule.  
  
11. To limit the policy to subset of the target types, in the **Server restriction** box, select from limiting conditions or create a new condition.  
  
     For more information on the available options in the **Create New Policy** dialog box, see [Create New Policy or Open Policy Dialog Box, General Page](../../Topics\TopicNameNotContainA/Create-New-Policy-or-Open-Policy-Dialog-Box,-General-Page.md) or [Create New Policy or Open Policy Dialog Box, Description Page](../../Topics\TopicNameNotContainA/Create-New-Policy-or-Open-Policy-Dialog-Box,-Description-Page.md).  
  
12. When finished click **OK**.  
  
  