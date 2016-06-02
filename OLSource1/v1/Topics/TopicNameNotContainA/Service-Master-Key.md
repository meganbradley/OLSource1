---
title: Service Master Key
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 85f2095d-2590-4f59-8a29-7e100edd02bb
---
# Service Master Key
  The Service Master Key is the root of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] encryption hierarchy. It is generated automatically the first time it is needed to encrypt another key. By default, the Service Master Key is encrypted using the Windows data protection API and using the local machine key. The Service Master Key can only be opened by the Windows service account under which it was created or by a principal with access to both the service account name and its password.  
  
 Regenerating or restoring the Service Master Key involves decrypting and re\-encrypting the complete encryption hierarchy. Unless the key has been compromised, this resource\-intensive operation should be scheduled during a period of low demand.  
  
 [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] uses the AES encryption algorithm to protect the service master key \(SMK\) and the database master key \(DMK\). AES is a newer encryption algorithm than 3DES used in earlier versions. After upgrading an instance of the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] to [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] the SMK and DMK should be regenerated in order to upgrade the master keys to AES. For more information about regenerating the SMK, see [ALTER SERVICE MASTER KEY &#40;Transact-SQL&#41;](../Topic/ALTER%20SERVICE%20MASTER%20KEY%20\(Transact-SQL\).md) and [ALTER MASTER KEY &#40;Transact-SQL&#41;](../Topic/ALTER%20MASTER%20KEY%20\(Transact-SQL\).md).  
  
## Best Practice  
 Back up the Service Master Key and store the backed up copy in a secure, off\-site location.  
  
## Related Tasks  
 [BACKUP SERVICE MASTER KEY &#40;Transact-SQL&#41;](../Topic/BACKUP%20SERVICE%20MASTER%20KEY%20\(Transact-SQL\).md)  
  
 [RESTORE SERVICE MASTER KEY &#40;Transact-SQL&#41;](../Topic/RESTORE%20SERVICE%20MASTER%20KEY%20\(Transact-SQL\).md)  
  
 [ALTER SERVICE MASTER KEY &#40;Transact-SQL&#41;](../Topic/ALTER%20SERVICE%20MASTER%20KEY%20\(Transact-SQL\).md)  
  
## See Also  
 [Encryption Hierarchy](../../Topics\TopicNameNotContainA/Encryption-Hierarchy.md)  
  
  