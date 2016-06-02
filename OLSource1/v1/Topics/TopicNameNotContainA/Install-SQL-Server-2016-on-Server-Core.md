---
title: Install SQL Server 2016 on Server Core
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1dd294cc-5b69-4d0c-9005-3e307b75678b
---
# Install SQL Server 2016 on Server Core
  You can install [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)]. This topic provides setup\-specific details for installing [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] on Server Core.  
  
 The Server Core installation option for the [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] operating system provides a minimal environment for running specific server roles. This helps to reduce maintenance and management requirements and the attack surface for those server roles. For more information on Server Core as implemented on [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)], see [Server Core for Windows Server 2008 R2](http://go.microsoft.com/fwlink/?LinkId=202439) \(http:\/\/go.microsoft.com\/fwlink\/?LinkId\=202439\). For more information on Server Core as implemented on [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)], see [Server Core for Windows Server 2012](http://msdn.microsoft.com/library/hh846323\(VS.85\).aspx) \(http:\/\/msdn.microsoft.com\/library\/hh846323\(VS.85\).aspx\).  
  
## Prerequisites  
  
|Requirement|How to install|  
|-----------------|--------------------|  
|[!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] 2.0 SP2|Included in Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 and [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)]. If it is not enabled, Setup enables it by default.<br /><br /> It is not possible to run versions 2.0, 3.0, and 3.5 side by side on a computer. When you install the .NET Framework 3.5 SP1, you get the 2.0 and 3.0 layers automatically.|  
|[!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] 3.5 SP1 Full Profile|Included in Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1. If it is not enabled, Setup enables it by default.<br /><br /> On a computer with Windows server operating system you must download and install .NET Framework 3.5 SP1 before you run Setup, to install components dependent on .NET 3.5 SP1.<br /><br /> For more information about the recommendations and guidance on how to acquire and enable .NET Framework 3.5 in [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)], see [Microsoft .NET Framework 3.5 Deployment Considerations](http://msdn.microsoft.com/library/windows/hardware/hh975396) \(http:\/\/msdn.microsoft.com\/library\/windows\/hardware\/hh975396\).|  
|[!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] 4 Server Core Profile|For all editions of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] except [!INCLUDE[ssExpress](../../Token\Other/ssExpress_md.md)], Setup installs the [!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] 4 Server Core Profile as a prerequisite.<br /><br /> For [!INCLUDE[ssExpressEd11](../../Token\Other/ssExpressEd11_md.md)], download the [!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] 4 Server Core Profile from [Microsoft .NET Framework 4 \(Standalone Installer\) for Server Core](http://go.microsoft.com/fwlink/?LinkId=220467) \(http:\/\/go.microsoft.com\/fwlink\/?LinkId\=220467\), and install it before you proceed with the setup.|  
|Windows Installer 4.5|Shipped with Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 and [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].|  
|Windows PowerShell|Shipped with Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 and [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].|  
  
##  <a name="BK_SupportedFeatures"></a> Supported Features  
 Use the following table to find which features are supported in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] on a Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 and [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].  
  
|Feature|Supported|Additional Information|  
|-------------|---------------|----------------------------|  
|[!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] Services|Yes||  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Replication|Yes||  
|Full Text Search|Yes||  
|[!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)]|Yes||  
|[!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)]|No||  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Data Tools \(SSDT\)|No||  
|Client Tools Connectivity|Yes||  
|Integration Services Server|Yes|For more information about the new Integration Services Server and its features in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)], see [Integration Services &#40;SSIS&#41; Server](../Topic/Integration%20Services%20\(SSIS\)%20Server.md).|  
|Client Tools Backward Compatibility|No||  
|Client Tools SDK|No||  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Books Online|No||  
|Management Tools \- Basic|Remote Only|Installation of these features on Server Core is not supported. These components can be installed on a different server that is not [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core, and connected to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] services installed on Server Core.|  
|Management Tools – Complete|Remote Only|Installation of these features on Server Core is not supported. These components can be installed on a different server that is not [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core, and connected to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] services installed on Server Core.|  
|Distributed Replay Controller|No||  
|Distributed Replay Client|Remote Only|Installation of these features on Server Core is not supported. These components can be installed on a different server that is not [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core, and connected to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] services installed on Server Core.|  
|SQL Client Connectivity SDK|Yes||  
|Microsoft Sync Framework|Yes|Microsoft Sync Framework is not included in the [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] installation package. You can download the appropriate version of Sync Framework from this [Microsoft Download Center](http://go.microsoft.com/fwlink/?LinkId=221788) \(http:\/\/go.microsoft.com\/fwlink\/?LinkId\=221788\) page and install it on a computer that is running Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].|  
|[!INCLUDE[ssMDSshort](../../Token\Other/ssMDSshort_md.md)]|No||  
|[!INCLUDE[ssDQSnoversion](../../Token\Other/ssDQSnoversion_md.md)]|No||  
  
## Supported Scenario Matrix  
 The following table shows the supported scenario matrix for installing [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] on a Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 and [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].  
  
|||  
|-|-|  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] editions|All [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] 64\-bit editions\*|  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] language|All languages|  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] language on OS language\/locale \(combination\)|ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on JPN \(Japanese\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on GER \(German\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on CHS \(Chinese\-China\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on ARA \(Arabic \(SA\)\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on THA \(Thai\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on TRK \(Turkish\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on pt\-PT \(Portuguese Portugal\) Windows<br /><br /> ENG [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on ENG \(English\) Windows|  
|Windows edition|[!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] 64\-bit x64 Datacenter<br /><br /> [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] 64\-bit x64 Standard<br /><br /> [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 64\-bit x64 Data Center Server Core<br /><br /> [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 64\-bit x64 Enterprise Server Core<br /><br /> [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 64\-bit x64 Standard Server Core<br /><br /> [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 64\-bit x64 Web Server Core|  
  
 \*Installing the 32\-bit version of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] editions is not supported on Server Core.  
  
## Upgrading  
 On Server Core installations, upgrading from [!INCLUDE[ssSQL14](../../Token\Other/ssSQL14_md.md)] to [!INCLUDE[ssSQL15](../../Token\Other/ssSQL15_md.md)] is supported.  
  
## Installation  
 [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] does not support setup by using the installation wizard on the Server Core operating system. When installing on Server Core, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup supports full quiet mode by using the \/Q parameter, or Quiet Simple mode by using the \/QS parameter. For more information, see [Install SQL Server 2016 from the Command Prompt](../../Topics\TopicNameNotContainA/Install-SQL-Server-2016-from-the-Command-Prompt.md).  
  
> [!IMPORTANT]  
>  [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] cannot be installed side\-by\-side with earlier versions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a computer that is running [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core.  
  
 Regardless of the installation method, you are required to confirm acceptance of the software license terms as an individual or on behalf of an entity, unless your use of the software is governed by a separate agreement such as a [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] volume licensing agreement or a third\-party agreement with an ISV or OEM.  
  
 The license terms are displayed for review and acceptance in the Setup user interface. Unattended installations \(using the \/Q or \/QS parameters\) must include the \/IACCEPTSQLSERVERLICENSETERMS parameter. You can review the license terms separately at [Microsoft Software License Terms](http://go.microsoft.com/fwlink/?LinkId=148209).  
  
> [!NOTE]  
>  Depending on how you received the software \(for example, through [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] volume licensing\), your use of the software may be subject to additional terms and conditions.  
  
 To install specific features, use the \/FEATURES parameter and specify the parent feature or feature values. For more information about feature parameters and their use, see the following sections.  
  
### Feature Parameters  
  
|Feature parameter|Description|  
|-----------------------|-----------------|  
|SQLENGINE|Installs only the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].|  
|REPLICATION|Installs the Replication component along with [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].|  
|FULLTEXT|Installs the FullText component along with [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].|  
|AS|Installs all [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] components.|  
|IS|Installs all [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] components.|  
|CONN|Installs the connectivity components.|  
  
 See the following examples of the usage of feature parameters:  
  
|Parameter and values|Description|  
|--------------------------|-----------------|  
|\/FEATURES\=SQLEngine|Installs only the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].|  
|\/FEATURES\=SQLEngine,FullText|Installs the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and full\-text.|  
|\/FEATURES\=SQLEngine,Conn|Installs the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and the connectivity components.|  
|\/FEATURES\=SQLEngine,AS,IS,Conn|Installs the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)], [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)], [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)], and the connectivity components.|  
  
### Installation Options  
 The Setup supports the following installation options while installing [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] on a Server Core operating system:  
  
1.  **Installation from Command Line**  
  
     To install specific features using the command prompt installation option, use the \/FEATURES parameter and specify the parent feature or feature values. The following is an example of using the parameters from the command line:  
  
    ```  
    Setup.exe /qs /ACTION=Install /FEATURES=SQLEngine,Replication /INSTANCENAME=MSSQLSERVER /SQLSVCACCOUNT="<DomainName\UserName>" /SQLSVCPASSWORD="<StrongPassword>" /SQLSYSADMINACCOUNTS="<DomainName\UserName>" /AGTSVCACCOUNT="NT AUTHORITY\Network Service" /TCPENABLED=1 /IACCEPTSQLSERVERLICENSETERMS  
    ```  
  
2.  **Installation using Configuration File**  
  
     Setup supports the use of the configuration file only through the command prompt. The configuration file is a text file with the basic structure of a parameter \(name\/value pair\) and a descriptive comment. The configuration file specified at the command prompt should have an .INI file name extension. See the following examples of ConfigurationFile.INI:  
  
    -   Installing [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)]. The following example shows how to install a new stand\-alone instance that includes the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)][!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)]:  
  
        ```  
        ; ssNoVersion Configuration File  
        [OPTIONS]  
  
        ; Specifies a Setup work flow, like INSTALL, UNINSTALL, or UPGRADE. This is a required parameter.   
  
        ACTION="Install"  
  
        ; Specifies features to install, uninstall, or upgrade. The lists of features include SQLEngine, FullText, Replication, AS, IS, and Conn.   
  
        FEATURES=SQLENGINE  
  
        ; Specify a default or named instance. MSSQLSERVER is the default instance for non-Express editions and SQLExpress for Express editions. This parameter is required when installing the ssNoVersion Database Engine, and Analysis Services (AS).  
  
        INSTANCENAME="MSSQLSERVER"  
  
        ; Specify the Instance ID for the ssNoVersion features you have specified. ssNoVersion directory structure, registry structure, and service names will incorporate the instance ID of the ssNoVersion instance.   
  
        INSTANCEID="MSSQLSERVER"  
  
        ; Account for ssNoVersion service: Domain\User or system account.   
  
        SQLSVCACCOUNT="NT Service\MSSQLSERVER"  
  
        ; Windows account(s) to provision as ssNoVersion system administrators.   
  
        SQLSYSADMINACCOUNTS="<DomainName\UserName>"  
  
        ; Accept the License agreement to continue with Installation  
  
        IAcceptSQLServerLicenseTerms="True"  
  
        ```  
  
    -   Installing connectivity components. The following example shows how to install the connectivity components:  
  
        ```  
        ; ssNoVersion Configuration File  
        [OPTIONS]  
  
        ; Specifies a Setup work flow, like INSTALL, UNINSTALL, or UPGRADE. This is a required parameter.   
  
        ACTION="Install"  
  
        ; Specifies features to install, uninstall, or upgrade. The lists of features include SQLEngine, FullText, Replication, AS, IS, and Conn.   
  
        FEATURES=Conn  
  
        ; Specifies acceptance of License Terms  
  
        IAcceptSQLServerLicenseTerms="True  
  
        ```  
  
    -   Installing all supported features  
  
         . The following example shows how to install all supported features of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] on Server Core:  
  
        ```  
        ; ssNoVersion Configuration File  
        [OPTIONS]  
        ; Specifies a Setup work flow, like INSTALL, UNINSTALL, or UPGRADE. This is a required parameter.   
  
        ACTION="Install"  
  
        ; Specifies features to install, uninstall, or upgrade. The lists of features include SQLEngine, FullText, Replication, AS, IS, and Conn.   
  
        FEATURES=SQLENGINE,FullText,Replication,AS,IS,Conn  
  
        ; Specify a default or named instance. MSSQLSERVER is the default instance for non-Express editions and SQLExpress for Express editions. This parameter is required when installing the ssNoVersion Database Engine (SQL), or Analysis Services (AS).  
  
        INSTANCENAME="MSSQLSERVER"  
  
        ; Specify the Instance ID for the ssNoVersion features you have specified. ssNoVersion directory structure, registry structure, and service names will incorporate the instance ID of the ssNoVersion instance.   
  
        INSTANCEID="MSSQLSERVER"  
  
        ; Account for ssNoVersion service: Domain\User or system account.   
  
        SQLSVCACCOUNT="NT Service\MSSQLSERVER"  
  
        ; Windows account(s) to provision as ssNoVersion system administrators.   
  
        SQLSYSADMINACCOUNTS="<DomainName\UserName>"  
  
        ; The name of the account that the Analysis Services service runs under.   
  
        ASSVCACCOUNT= "NT Service\MSSQLServerOLAPService"  
  
        ; Specifies the list of administrator accounts that need to be provisioned.   
  
        ASSYSADMINACCOUNTS="<DomainName\UserName>"  
  
        ; Specifies the server mode of the Analysis Services instance. Valid values are MULTIDIMENSIONAL, POWERPIVOT or TABULAR. ASSERVERMODE is case-sensitive. All values must be expressed in upper case.   
  
        ASSERVERMODE="MULTIDIMENSIONAL"  
  
        ; Optional value, which specifies the state of the TCP protocol for the ssNoVersion service. Supported values are: 0 to disable the TCP protocol, and 1 to enable the TCP protocol.  
  
        TCPENABLED=1  
  
        ;Specifies acceptance of License Terms  
  
        IAcceptSQLServerLicenseTerms="True"  
        ```  
  
     The following shows how you can launch Setup using a custom or default configuration file:  
  
    -   Launch setup using a custom configuration file:  
  
         To specify the configuration file at the command prompt:  
  
        ```  
        Setup.exe /QS /ConfigurationFile=MyConfigurationFile.INI  
        ```  
  
         To specify passwords at the command prompt instead of in the configuration file:  
  
        ```  
        Setup.exe /QS /SQLSVCPASSWORD="************" /ASSVCPASSWORD="************"  /ConfigurationFile=MyConfigurationFile.INI  
        ```  
  
    -   Launch setup using DefaultSetup.ini:  
  
         If you have the DefaultSetup.ini file in the \\x86 and \\x64 folders at the root level of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] source media, open the DefaultSetup.ini file, and then add the *Features* parameter to the file.  
  
         If the DefaultSetup.ini file does not exist, you can create it and copy it to the \\x86 and \\x64 folders at the root level of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] source media.  
  
## Configuring Remote Access of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Running on Server Core  
 Perform the actions described below to configure remote access of a [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] instance that is running on a Server Core installation of [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)].  
  
### Enable remote connections on the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]  
 To enable remote connections, use SQLCMD.exe locally and execute the following statements against the Server Core instance:  
  
-   `EXEC sys.sp_configure N'remote access', N'1'`  
  
     `GO`  
  
-   `RECONFIGURE WITH OVERRIDE`  
  
     `GO`  
  
### Enable and start the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Browser service  
 By default, the Browser service is disabled.  If it is disabled on an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] running on Server Core, run the following command from the command prompt to enable it:  
  
 `sc config SQLBROWSER start= auto`  
  
 After it is enabled, run the following command from the command prompt to start the service:  
  
 `net start SQLBROWSER`  
  
### Create exceptions in Windows Firewall  
 To create exceptions for [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] access in Windows Firewall, follow the steps specified in [Configure the Windows Firewall to Allow SQL Server Access](../../Topics\TopicNameNotContainA/Configure-the-Windows-Firewall-to-Allow-SQL-Server-Access.md).  
  
### Enable TCP\/IP on the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]  
 The TCP\/IP protocol can be enabled through Windows PowerShell for an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on Server Core. Follow these steps:  
  
1.  On the computer that is running [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core, launch Task Manager.  
  
2.  On the **Applications** tab, click **New Task**.  
  
3.  In the **Create New Task** dialog box, type **sqlps.exe** in the **Open** field and then click **OK**. This opens the **[!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Powershell** window.  
  
4.  In the **Microsoft [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Powershell** window, run the following script to enable the TCP\/IP protocol:  
  
```  
$smo = 'Microsoft.SqlServer.Management.Smo.'  
$wmi = new-object ($smo + 'Wmi.ManagedComputer')  
# Enable the TCP protocol on the default instance.  If the instance is named, replace MSSQLSERVER with the instance name in the following line.  
$uri = "ManagedComputer[@Name='" + (get-item env:\computername).Value + "']/ServerInstance[@Name='MSSQLSERVER']/ServerProtocol[@Name='Tcp']"  
$Tcp = $wmi.GetSmoObject($uri)  
$Tcp.IsEnabled = $true  
$Tcp.Alter()  
$Tcp  
```  
  
## Uninstallation  
 After you log on to a computer that is running [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Server Core SP1 or [!INCLUDE[win8srv](../../Token\Other/win8srv_md.md)] Server Core, you have a limited desktop environment with an Administrator command prompt. You can use this command prompt to initiate uninstallation of an instance of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)]. To uninstall an instance of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)], launch the uninstallation from the command prompt in full quiet mode by using the \/Q parameter, or quiet simple mode by using the \/QS parameter. The \/QS parameter shows progress through the UI, but does not accept any input. \/Q runs in a quiet mode without any user interface.  
  
 To uninstall an existing instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]:  
  
```  
Setup.exe /Q /Action=Uninstall /FEATURES=SQLEngine,AS,IS /INSTANCENAME=MSSQLSERVER  
```  
  
 To remove a named instance, specify the name of the instance instead of "MSSQLSERVER" in the preceding example.  
  
> [!WARNING]  
>  If you accidentally close the command prompt, you can start a new command prompt by following these steps:  
>   
>  1.  Press Ctrl\+Shift\+Esc to display Task Manager.  
> 2.  On the **Applications** tab, click **New Task**.  
> 3.  In the **Create New Task** dialog box, type **cmd** in the **Open** field and then [!INCLUDE[clickOK](../../Token\Other/clickOK_md.md)].  
  
## See Also  
 [Install SQL Server 2016 Using a Configuration File](../../Topics\TopicNameContainA/Install-SQL-Server-2016-Using-a-Configuration-File.md)   
 [Install SQL Server 2016 from the Command Prompt](../../Topics\TopicNameNotContainA/Install-SQL-Server-2016-from-the-Command-Prompt.md)   
 [Features Supported by the Editions of SQL Server 2016](../../Topics\TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md)   
 [Server Core Installation Option Getting Started Guide](http://go.microsoft.com/fwlink/?LinkId=221422)   
 [Configuring a Server Core installation: Overview](http://go.microsoft.com/fwlink/?LinkId=221423)   
 [Failover Cluster Cmdlets in Windows PowerShell Listed by Task Focus](http://go.microsoft.com/fwlink/?LinkId=221419)   
 [Mapping Cluster.exe Commands to Windows PowerShell Cmdlets for Failover Clusters](http://go.microsoft.com/fwlink/?LinkId=221421)  
  
  