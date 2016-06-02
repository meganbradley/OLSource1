---
title: Instance Configuration
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5bf822fc-6dec-4806-a153-e200af28e9a5
---
# Instance Configuration
  Use the **Instance Configuration** page of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Installation Wizard to specify whether to create a default instance or a named instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. If an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] is not already installed, a default instance will be created unless you specify a named instance.  
  
 Each instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] consists of a distinct set of services that have specific settings for collations and other options. The directory structure, registry structure, and service names all reflect the instance name and a specific instance ID created during [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup.  
  
 An instance is either the default instance or a named instance. The default instance name is MSSQLSERVER. It does not require a client to specify the name of the instance to make a connection. A named instance is determined by the user during Setup. You can install [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] as a named instance without installing the default instance first. Only one installation of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], regardless of version, can be the default instance at one time.  
  
> [!NOTE]  
>  With [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] SysPrep, you can specify the instance name when you complete a prepared instance on the **Instance Configuration** page. You can choose to configure the prepared instance you are completing as a default instance if there is no existing default instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on the machine.  
  
## Multiple Instances  
 [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] supports multiple instances of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a single server or processor, but only one instance can be the default instance. All others must be named instances. A computer can run multiple instances of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] concurrently, and each instance runs independently of other instances.  
  
 For more information, see [Maximum Capacity Specifications for SQL Server](../../Topics\TopicNameNotContainA/Maximum-Capacity-Specifications-for-SQL-Server.md).  
  
## Options  
 Failover cluster instances only — Specify the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster network name. This name identifies the failover cluster instance on the network.  
  
 Default or Named instance — Consider the following information when you decide whether to install a default or named instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]:  
  
-   If you plan to install a single instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a database server, it should be a default instance.  
  
-   Use a named instance for situations where you plan to have multiple instances on the same computer. A server can host only one default instance.  
  
-   Any application that installs [!INCLUDE[ssExpress](../../Token\Other/ssExpress_md.md)] should install it as a named instance. This will minimizes conflict when multiple applications are installed on the same computer.  
  
 **Default instance**  
 Select this option to install a default instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. A computer can host only one default instance; all other instances must be named. However, if you have a default instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installed, you can add a default instance of [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] to the same computer.  
  
 **Named instance**  
 Select this option to create a new named instance. Be aware of the following when you name an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]:  
  
-   Instance names are not case sensitive.  
  
-   Instance names cannot start or end with an underscore \(\_\).  
  
-   Instance names cannot contain the term "Default" or other reserved keywords. If a reserved keyword is used in an instance name, a Setup error will occur. For more information, see [Reserved Keywords &#40;Transact-SQL&#41;](../Topic/Reserved%20Keywords%20\(Transact-SQL\).md).  
  
-   If you specify MSSQLServer for the instance name, a default instance will be created.  
  
-   An installation of [!INCLUDE[ssGeminiLong](../../Token\Other/ssGeminiLong_md.md)] is always installed as a named instance of '[!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)]'. You cannot specify a different instance name for this feature role.  
  
-   Instance names are limited to 16 characters.  
  
-   The first character in the instance name must be a letter. Acceptable letters are those defined by the Unicode Standard 2.0. These include Latin characters a\-z, A\-Z, and letter characters from other languages.  
  
-   Subsequent characters can be letters defined by the Unicode Standard 2.0, decimal numbers from Basic Latin or other national scripts, the dollar sign \($\), or an underscore \(\_\).  
  
-   Embedded spaces or other special characters are not allowed in instance names. The backslash \(\\\), comma \(,\), colon \(:\), semi\-colon \(;\), single quote \('\), ampersand \(&\), hyphen \(\-\), and at sign \(@\) are also not allowed.  
  
     Only characters that are valid in the current Windows code page can be used in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance names. If an unsupported Unicode character is used, a Setup error will occur.  
  
 **Detected instances and features**  
 View a list of installed [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instances and components on the computer where [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup is running.  
  
 **Instance ID** \- By default, the instance name is used as the Instance ID. This is used to identify installation directories and registry keys for your instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. This is the case for default instances and named instances. For a default instance, the instance name and instance ID would be MSSQLSERVER. To use a non\-default instance ID, specify it in the **Instance ID** field.  
  
> [!IMPORTANT]  
>  With [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] SysPrep, the Instance ID displayed on this page is the Instance ID specified during the prepare image step of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] SysPrep process. You will not be able to specify a different Instance ID during the complete image step.  
  
> [!NOTE]  
>  Instance IDs that begin with an underscore \(\_\) or that contain the number sign \(\#\) or the dollar sign \($\) are not supported.  
  
 For more information about directories, file locations, and instance ID naming, see [File Locations for Default and Named Instances of SQL Server](../../Topics\TopicNameNotContainA/File-Locations-for-Default-and-Named-Instances-of-SQL-Server.md).  
  
 All components of a given instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] are managed as a unit. All [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service packs and upgrades will apply to every component of an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
 All components of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] that share the same instance name must meet the following criteria:  
  
-   **Same version**  
  
-   **Same edition**  
  
-   **Same language settings**  
  
-   **Same clustered state**  
  
    > [!NOTE]  
    >  [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] is not cluster\-aware.  
  
-   **Same operating system**  
  
  