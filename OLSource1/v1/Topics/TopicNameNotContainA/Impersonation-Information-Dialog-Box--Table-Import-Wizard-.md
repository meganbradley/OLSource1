---
title: Impersonation Information Dialog Box (Table Import Wizard)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bee7eee5-0650-41f1-a372-5076ae97a58c
manager: mblythe
---
# Impersonation Information Dialog Box (Table Import Wizard)
Use the **Impersonation Information** page to specify the credentials that [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] will use to connect to the data source. For more information about credentials impersonation, see [Impersonation (SSAS Tabular)](../../Topics/TopicNameNotContainA/Impersonation--SSAS-Tabular-.md).  
  
## Options  
 **Specific Windows user name and password**  
 Select this option to have the tabular model use the security credentials of a specified Windows user account.  
  
 **User name**  
 Type the domain and name of the user account to be used. Use the following format:  
  
 *<Domain name\>* **\\** *<User account name\>*  
  
 This option is enabled only if **Use a specific name and password** is selected.  
  
 **Password**  
 Type the password of the user account to be used by the Tabular model.  
  
 This option is enabled only if **Use a specific name and password** is selected.  
  
 **Service account**  
 Select this option to use the security credentials associated with the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] service that manages the model.  
  
## See Also  
 [Impersonation (SSAS Tabular)](../../Topics/TopicNameNotContainA/Impersonation--SSAS-Tabular-.md)