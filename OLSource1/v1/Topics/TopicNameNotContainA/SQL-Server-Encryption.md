---
title: SQL Server Encryption
ms.custom: 
  - SQL2016_New_Updated
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ead0150e-4943-4ad5-84c8-36f85c7278f4
manager: jhubbard
---
# SQL Server Encryption
Encryption is the process of obfuscating data by the use of a key or password. This can make the data useless without the corresponding decryption key or password. Encryption does not solve access control problems. However, it enhances security by limiting data loss even if access controls are bypassed. For example, if the database host computer is misconfigured and a hacker obtains sensitive data, that stolen information might be useless if it is encrypted.  
  
 You can use encryption in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] for connections, data, and stored procedures. The following table contains more information about encryption in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
> [!IMPORTANT]  
>  Although encryption is a valuable tool to help ensure security, it should not be considered for all data or connections. When you are deciding whether to implement encryption, consider how users will access data. If users access data over a public network, data encryption might be required to increase security. However, if all access involves a secure intranet configuration, encryption might not be required. Any use of encryption should also include a maintenance strategy for passwords, keys, and certificates.  
  
> [!NOTE]  
>  The latest information about Transport Level Security (TSL1.2) is available at [TLS 1.2 support for Microsoft SQL Server](https://support.microsoft.com/kb/3135244).  
  
## In This Section  
 [Encryption Hierarchy](../../Topics/TopicNameNotContainA/Encryption-Hierarchy.md)  
 Information about the encryption hierarchy in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 [Choose an Encryption Algorithm](../../Topics/TopicNameNotContainA/Choose-an-Encryption-Algorithm.md)  
 Information about how to select an effective encrypting algorithm.  
  
 [Transparent Data Encryption (TDE)](../../Topics/TopicNameNotContainA/Transparent-Data-Encryption--TDE-.md)  
 General information about how to encrypt data transparently.  
  
 [SQL Server and Database Encryption Keys (Database Engine)](../../Topics/TopicNameNotContainA/SQL-Server-and-Database-Encryption-Keys--Database-Engine-.md)  
 In [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], encryption keys include a combination of public, private, and symmetric keys that are used to protect sensitive data. This section explains how to implement and manage encryption keys.  
  
 [Always Encrypted (Database Engine)](../../Topics/TopicNameNotContainA/Always-Encrypted--Database-Engine-.md)  
 Ensuring on-premises database administrators, cloud database operators, or other high-privileged, but unauthorized users, cannot access the encrypted data.  
  
 [Dynamic Data Masking](../../Topics/TopicNameNotContainA/Dynamic-Data-Masking.md)  
 Limiting sensitive data exposure by masking it to non-privileged users.  
  
 [SQL Server Certificates and Asymmetric Keys](../../Topics/TopicNameNotContainA/SQL-Server-Certificates-and-Asymmetric-Keys.md)  
 Information about using Public Key Cryptography.  
  
## Related Content  
 [Securing SQL Server](../../Topics/TopicNameNotContainA/Securing-SQL-Server.md)  
 Overview of how to help secure the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] platform, and how to work with users and securable objects.  
  
 [Cryptographic Functions (Transact-SQL)](assetId:///0be5626b-5a25-4d8c-9f44-7abbfccf816c)  
 Information about how to implement cryptographic functions.  
  
 [EncryptByPassPhrase (Transact-SQL)](assetId:///f8dbb9e6-94d6-40d7-8b38-6833a409d597)  
 Information about how to use a password to encrypt data.  
  
 [EncryptByKey (Transact-SQL)](assetId:///0e11f8c5-f79d-46c1-ab11-b68ef05d6787)  
 Information about how to use a symmetric key to encrypt data.  
  
 [EncryptByAsymKey (Transact-SQL)](assetId:///86bb2588-ab13-4db2-8f3c-42c9f572a67b)  
 Information about how to use an asymmetric key to encrypt data.  
  
 [EncryptByCert (Transact-SQL)](assetId:///ab66441f-e2d2-4e3a-bcae-bcc09e12f3c1)  
 Information about how to use a certificate to encrypt data.  
  
## External Resources  
 [Microsoft TechNet: SQL Server TechCenter: SQL Server 2005 Security and Protection](https://msdn.microsoft.com/sqlserver/bb895847.aspx)  
 Current information about [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] security.  
  
## See Also  
 [sys.key_encryptions (Transact-SQL)](assetId:///c39cecf8-af63-40b9-98e5-f84a5bf3ae54)   
 [SQL Server and Database Encryption Keys (Database Engine)](../../Topics/TopicNameNotContainA/SQL-Server-and-Database-Encryption-Keys--Database-Engine-.md)   
 [Back Up and Restore Reporting Services Encryption Keys](../../Topics/TopicNameNotContainA/Back-Up-and-Restore-Reporting-Services-Encryption-Keys.md)