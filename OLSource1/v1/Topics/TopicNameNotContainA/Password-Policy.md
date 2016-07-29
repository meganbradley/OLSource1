---
title: "Password Policy"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 2015-09-25
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c0040c0a-a18f-45b9-9c40-0625685649b1
caps.latest.revision: 42
manager: jhubbard
---
# Password Policy
[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] can use Windows password policy mechanisms. The password policy applies to a login that uses [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] authentication, and to a contained database user with password.  
  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] can apply the same complexity and expiration policies used in Windows to passwords used inside [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. This functionality depends on the `NetValidatePasswordPolicy` API.  
  
 [!INCLUDE[ssSDS](../../Topics/TopicNameContainA/includes/ssSDS_md.md)] enforces password complexity. The password expiration and  policy enforcement sections do not apply to [!INCLUDE[ssSDS](../../Topics/TopicNameContainA/includes/ssSDS_md.md)].  
  
## Password Complexity  
 Password complexity policies are designed to deter brute force attacks by increasing the number of possible passwords. When password complexity policy is enforced, new passwords must meet the following guidelines:  
  
-   The password does not contain the account name of the user.  
  
-   The password is at least eight characters long.  
  
-   The password contains characters from three of the following four categories:  
  
    -   Latin uppercase letters (A through Z)  
  
    -   Latin lowercase letters (a through z)  
  
    -   Base 10 digits (0 through 9)  
  
    -   Non-alphanumeric characters such as: exclamation point (!), dollar sign ($), number sign (#), or percent (%).  
  
 Passwords can be up to 128 characters long. You should use passwords that are as long and complex as possible.  
  
## Password Expiration  
 Password expiration policies are used to manage the lifespan of a password. When [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] enforces password expiration policy, users are reminded to change old passwords, and accounts that have expired passwords are disabled.  
  
## Policy Enforcement  
 The enforcement of password policy can be configured separately for each SQL Server login. Use [ALTER LOGIN (Transact-SQL)](assetId:///e247b84e-c99e-4af8-8b50-57586e1cb1c5) to configure the password policy options of a SQL Server login. The following rules apply to the configuration of password policy enforcement:  
  
-   When CHECK_POLICY is changed to ON, the following behaviors occur:  
  
    -   CHECK_EXPIRATION is also set to ON unless it is explicitly set to OFF.  
  
    -   The password history is initialized with the value of the current password hash.  
  
    -   **Account lockout duration**, **account lockout threshold**, and **reset account lockout counter after** are also enabled.  
  
-   When CHECK_POLICY is changed to OFF, the following behaviors occur:  
  
    -   CHECK_EXPIRATION is also set to OFF.  
  
    -   The password history is cleared.  
  
    -   The value of `lockout_time` is reset.  
  
 Some combinations of policy options are not supported.  
  
-   If MUST_CHANGE is specified, CHECK_EXPIRATION and CHECK_POLICY must be set to ON. Otherwise, the statement will fail.  
  
-   If CHECK_POLICY is set to OFF, CHECK_EXPIRATION cannot be set to ON. An ALTER LOGIN statement that has this combination of options will fail.  
  
 Setting CHECK_POLICY = ON will prevent the creation of passwords that are:  
  
-   Null or empty  
  
-   Same as name of computer or login  
  
-   Any of the following: "password", "admin", "administrator", "sa", "sysadmin"  
  
 The security policy might be set in Windows, or might be received from the domain. To view the password policy on the computer, use the Local Security Policy MMC snap-in (**secpol.msc**).  
  
## Related Tasks  
 [CREATE LOGIN (Transact-SQL)](assetId:///eb737149-7c92-4552-946b-91085d8b1b01)  
  
 [ALTER LOGIN (Transact-SQL)](assetId:///e247b84e-c99e-4af8-8b50-57586e1cb1c5)  
  
 [CREATE USER (Transact-SQL)](assetId:///01de7476-4b25-4d58-85b7-1118fe64aa80)  
  
 [ALTER USER (Transact-SQL)](assetId:///344fc6ce-a008-47c8-a02e-47fae66cc590)  
  
 [Create a Login](../../Topics/TopicNameContainA/Create-a-Login.md)  
  
 [Create a Database User](../../Topics/TopicNameContainA/Create-a-Database-User.md)  
  
## Related Content  
 [Strong Passwords](../../Topics/TopicNameNotContainA/Strong-Passwords.md)