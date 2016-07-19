---
title: Choose an Encryption Algorithm
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
ms.assetid: 8227028c-a9c9-489d-bd27-fbf8242634ae
manager: jhubbard
---
# Choose an Encryption Algorithm
Encryption is one of several defenses-in-depth that are available to the administrator who wants to secure an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 Encryption algorithms define data transformations that cannot be easily reversed by unauthorized users. [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] allows administrators and developers to choose from among several algorithms, including DES, Triple DES, TRIPLE_DES_3KEY, RC2, RC4, 128-bit RC4, DESX, 128-bit AES, 192-bit AES, and 256-bit AES.  
  
> [!NOTE]  
>  Beginning with [!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)], all algorithms other than AES_128, AES_192, and AES_256 are deprecated. To use older algorithms (not recommended) you must set the database to database compatibility level 120 or lower.  
  
 No single algorithm is ideal for all situations, and guidance on the merits of each is beyond the scope of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Books Online. However, the following general principles apply:  
  
-   Strong encryption generally consumes more CPU resources than weak encryption.  
  
-   Long keys generally yield stronger encryption than short keys.  
  
-   Asymmetric encryption is weaker than symmetric encryption using the same key length, but it is relatively slow.  
  
-   Block ciphers with long keys are stronger than stream ciphers.  
  
-   Long, complex passwords are stronger than short passwords.  
  
-   If you are encrypting lots of data, you should encrypt the data using a symmetric key, and encrypt the symmetric key with an asymmetric key.  
  
-   Encrypted data cannot be compressed, but compressed data can be encrypted. If you use compression, you should compress data before encrypting it.  
  
> [!IMPORTANT]  
>  The RC4 algorithm is only supported for backward compatibility. New material can only be encrypted using RC4 or RC4_128 when the database is in compatibility level 90 or 100. (Not recommended.) Use a newer algorithm such as one of the AES algorithms instead. In [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)] and higher material encrypted using RC4 or RC4_128 can be decrypted in any compatibility level.  
>   
>  Repeated use of the same RC4 or RC4_128 KEY_GUID on different blocks of data will result in the same RC4 key because [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] does not provide a salt automatically. Using the same RC4 key repeatedly is a well-known error that will result in very weak encryption. Therefore, we have deprecated the RC4 and RC4_128 keywords. [!INCLUDE[ssNoteDepFutureDontUse](../../Topics/TopicNameContainA/includes/ssNoteDepFutureDontUse_md.md)]  
  
 For more information about encryption algorithms and encryption technology, see [Key Security Concepts](http://go.microsoft.com/fwlink/?LinkId=62082) in the .NET Framework Developer's Guide on MSDN.  
  
 **Clarification regarding DES algorithms:**  
  
-   DESX was incorrectly named. Symmetric keys created with ALGORITHM = DESX actually use the TRIPLE DES cipher with a 192-bit key. The DESX algorithm is not provided. [!INCLUDE[ssNoteDepFutureAvoid](../../Topics/TopicNameContainA/includes/ssNoteDepFutureAvoid_md.md)]  
  
-   Symmetric keys created with ALGORITHM = TRIPLE_DES_3KEY use TRIPLE DES with a 192-bit key.  
  
-   Symmetric keys created with ALGORITHM = TRIPLE_DES use TRIPLE DES with a 128-bit key.  
  
## Related Tasks  
  
|||  
|-|-|  
|Encrypting using a symmetric key.|[CREATE SYMMETRIC KEY (Transact-SQL)](assetId:///b5d23572-b79d-4cf1-9eef-d648fa3b1358)|  
|Encrypting using an asymmetric key.|[CREATE ASYMMETRIC KEY (Transact-SQL)](assetId:///141bc976-7631-49f6-82bd-a235028645b1)|  
|Encrypting using a certificate.|[CREATE CERTIFICATE (Transact-SQL)](assetId:///a4274b2b-4cb0-446a-a956-1c8e6587515d)|  
|Encrypting database files using transparent data encryption.|[Transparent Data Encryption (TDE)](../../Topics/TopicNameNotContainA/Transparent-Data-Encryption--TDE-.md)|  
|How to encrypt one column of a table.|[Encrypt a Column of Data](../../Topics/TopicNameContainA/Encrypt-a-Column-of-Data.md)|  
  
## See Also  
 [SQL Server Encryption](../../Topics/TopicNameNotContainA/SQL-Server-Encryption.md)   
 [Encryption Hierarchy](../../Topics/TopicNameNotContainA/Encryption-Hierarchy.md)