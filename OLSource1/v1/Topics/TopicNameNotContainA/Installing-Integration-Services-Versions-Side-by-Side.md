---
title: Installing Integration Services Versions Side by Side
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: edfbcd56-012f-462e-a542-95491394fda9
---
# Installing Integration Services Versions Side by Side
  You can install   
      [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] Integration Services \(SSIS\) side\-by\-side with earlier versions of SSIS. This topic describes some limitations of side\-by\-side installations.  
  
## Designing and maintaining packages  
 To design and maintain packages that target SQL Server 2016, SQL Server 2014, or SQL Server 2012, use SQL Server Data Tools \(SSDT\) for Visual Studio 2015. To get SSDT, see [Download Latest SQL Server Data Tools](https://msdn.microsoft.com/library/mt204009.aspx).  
  
 In the property pages for an Integration Services project, on the **General** tab of **Configuration Properties**, select the **TargetServerVersion** property and choose SQL Server 2016, SQL Server 2014, or SQL Server 2012.  
  
|Target version of SQL Server|Development environment for SSIS packages|  
|----------------------------------|-----------------------------------------------|  
|2016|SQL Server Data Tools for Visual Studio 2015|  
|2014|SQL Server Data Tools for Visual Studio 2015<br /><br /> or<br /><br /> SQL Server Data Tools \- Business Intelligence for Visual Studio 2013|  
|2012|SQL Server Data Tools for Visual Studio 2015<br /><br /> or<br /><br /> SQL Server Data Tools \- Business Intelligence for Visual Studio 2012|  
|2008|Business Intelligence Development Studio from SQL Server 2008|  
  
 When you add an existing package to an existing project, the package is converted to the format targeted by the project .  
  
## Running packages  
 You can use the [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] version of the **dtexec** utility or of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Agent to run Integration Services packages created by earlier versions of the development tools. When these [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] tools load a package that was developed in an earlier version of the development tools, the tool temporarily converts the package in memory to the package format that [!INCLUDE[ssISCurrent](../../Token\Other/ssISCurrent_md.md)] uses. If the package has issues that prevent a successful conversion, the [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] tool can't run the package until those issues are resolved. For more info, see [Upgrade Integration Services Packages](../../Topics\TopicNameNotContainA/Upgrade-Integration-Services-Packages.md).  
  
  