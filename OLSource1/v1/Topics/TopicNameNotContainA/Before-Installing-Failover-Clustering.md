---
title: Before Installing Failover Clustering
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a655225d-8c54-4b30-95fd-31f588167899
---
# Before Installing Failover Clustering
  Before you install a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster, you must select the hardware and the operating system on which [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will run. You must also configure Windows Server Failover Clustering \(WSFC\), and review network, security, and considerations for other software that will run on your failover cluster.  
  
 If a Windows cluster has a local disk drive and the same drive letter is also used on one or more cluster nodes as a shared drive, you cannot install [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on that drive.  
  
 You may also want to review the following topics to learn more about [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clustering concepts, features and tasks.  
  
|Topic Description|Topic|  
|-----------------------|-----------|  
|Describes [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clustering concepts, and provides links to associated content and tasks.|[AlwaysOn Failover Cluster Instances &#40;SQL Server&#41;](../Topic/AlwaysOn%20Failover%20Cluster%20Instances%20\(SQL%20Server\).md)|  
|Describes [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover policy concepts, and provides links to configuring the failover policy to suit your organizational requirements.|[Failover Policy for Failover Cluster Instances](../../Topics\TopicNameNotContainA/Failover-Policy-for-Failover-Cluster-Instances.md)|  
|Describes how to maintain and your existing [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster.|[Failover Cluster Instance Administration and Maintenance](../../Topics\TopicNameNotContainA/Failover-Cluster-Instance-Administration-and-Maintenance.md)|  
|Explains how to install [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] on a Windows Server Failover Cluster \(WSFC\).|[How to Cluster SQL Server Analysis Services](http://go.microsoft.com/fwlink/p/?LinkId=396548)|  
  
##  <a name="Top"></a> In this Topic  
  
-   [Best Practices](#BestPractices)  
  
-   [Verify Your Hardware Solution](#Hardware)  
  
-   [Review Security Considerations](#Security)  
  
-   [Review Network, Port, and Firewall Considerations](#Network)  
  
-   [Verify Your Operating System Support](#OS_Support)  
  
-   [Additional Considerations for a Multi\-Subnet Failover Configuration](#MultiSubnet)  
  
-   [Configure your Windows Failover Cluster](#WSFC)  
  
-   [Install and Configure Microsoft Distributed Transaction Coordinator](#MSDTC)  
  
##  <a name="BestPractices"></a> Best Practices  
  
-   Review [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)][Release Notes](http://go.microsoft.com/fwlink/?LinkId=296445)  
  
-   Install prerequisite software. Before running Setup to install or upgrade to [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)], install the following prerequisites to reduce installation time. You can install prerequisite software on each failover cluster node and then restart nodes once before running Setup.  
  
    -   Windows PowerShell is no longer installed by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup. Windows PowerShell is a prerequisite for installing [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)][!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] components and [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)]. If Windows PowerShell is not present on your computer, you can enable it by following the instructions on the [Windows Management Framework](http://go.microsoft.com/fwlink/?LinkId=186214) page.  
  
    -   .NET Framework 3.5 SP1 is no longer installed by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup, but may be required while installing [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on older Windows operating systems. For more information, see [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)][Release Notes](http://go.microsoft.com/fwlink/?LinkId=296445).  
  
    -   **[!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Update package:** To avoid computer restart due to .NET Framework 4 installation during setup, [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] setup requires a [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] update to be installed on the computer.  If you are installing [!INCLUDE[ssSQL14](../../Token\Other/ssSQL14_md.md)] on Windows 7 SP1 or [!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] SP2 this update is included. If you are installing on an older Windows operating system, download it from [Microsoft Update for .NET Framework 4.0 on Windows Vista and Windows Server 2008](http://go.microsoft.com/fwlink/?LinkId=198093).  
  
    -   .NET Framework 4: Setup installs .NET Framework 4 on a clustered operating system. To reduce installation time, you may consider installing .NET Framework 4 before you run Setup.  
  
    -   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup support files. You can install these files by running SqlSupport.msi located on your [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] installation media.  
  
-   Verify that antivirus software is not installed on your WSFC cluster. For more information, see the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Knowledge Base article, [Antivirus software may cause problems with cluster services](http://go.microsoft.com/fwlink/?LinkId=116986).  
  
-   When naming a cluster group for your failover cluster installation, you must not use any of the following characters in the cluster group name:  
  
    -   Less than operator \(\<\)  
  
    -   Greater than operator \(\>\)  
  
    -   Double quote \("\)  
  
    -   Single quote \('\)  
  
    -   Ampersand \(&\)  
  
     Also verify that existing cluster group names do not contain unsupported characters.  
  
-   Ensure that all cluster nodes are configured identically, including COM\+, disk drive letters, and users in the administrators group.  
  
-   Verify that you have cleared the system logs in all nodes and viewed the system logs again. Ensure that the logs are free of any error messages before continuing.  
  
-   Before you install or update a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster, disable all applications and services that might use [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] components during installation, but leave the disk resources online.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup automatically sets dependencies between the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] cluster group and the disks that will be in the failover cluster. Do not set dependencies for disks before Setup.  
  
    -   During [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Failover Cluster installation, computer object \(Active Directory computer accounts\) for the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Network Resource Name is created. In a [!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] cluster, the cluster name account \(computer account of the cluster itself\) needs to have permissions to create computer objects. For more information, see [Configuring Accounts in Active Directory](http://technet.microsoft.com/library/cc731002\(WS.10\).aspx).  
  
    -   If you are using SMB File share as a storage option, the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup account must have SeSecurityPrivilege on the file server. To do this, using the Local Security Policy console on the file server, add the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] setup account to **Manage auditing and security log** rights.  
  
##  <a name="Hardware"></a> Verify Your Hardware Solution  
  
-   If the cluster solution includes geographically dispersed cluster nodes, additional items like network latency and shared disk support must be verified.  
  
    -   For more information about [!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] and [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)], see [Validating Hardware for a failover cluster](http://go.microsoft.com/fwlink/?LinkId=196817) and [Support Policy for Windows Failover Clusters](http://go.microsoft.com/fwlink/?LinkId=196818).  
  
-   Verify that the disk where [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will be installed is not compressed or encrypted. If you attempt to install [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to a compressed drive or an encrypted drive, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup fails.  
  
-   SAN configurations are also supported on [!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] and [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Advanced Server and Datacenter Server editions. The Windows Catalog and Hardware Compatibility List category "Cluster\/Multi\-cluster Device" lists the set of SAN\-capable storage devices that have been tested and are supported as SAN storage units with multiple WSFC clusters attached. Run cluster validation after finding the certified components.  
  
-   SMB File Share is also supported for installing data files. For more information, see [Storage Types for Data Files](../../Topics\TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md).  
  
    > [!WARNING]  
    >  If you are using Windows File Server as a SMB File Share storage, the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup account must have SeSecurityPrivilege on the file server. To do this, using the Local Security Policy console on the file server, add the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] setup account to **Manage auditing and security log** rights.  
    >   
    >  If you are using SMB file share storage other than Windows File server, please consult the storage vendor for an equivalent setting on the file server side.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] supports mount points.  
  
     A mounted volume, or mount point, allows you to use a single drive letter to refer to many disks or volumes. If you have a drive letter D: that refers to a regular disk or volume, you can connect or "mount" additional disks or volumes as directories under drive letter D: without the additional disks or volumes requiring drive letters of their own.  
  
     Additional mount point considerations for [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clustering:  
  
    -   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup requires that the base drive of a mounted drive has an associated drive letter. For failover cluster installations, this base drive must be a clustered drive. Volume GUIDs are not supported in this release.  
  
    -   The base drive, the one with the drive letter, cannot be shared among failover cluster instances. This is a normal restriction for failover clusters, but is not a restriction on stand\-alone, multi\-instance servers.  
  
    -   The clustered installations of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] are limited to the number of available drive letters. Assuming that you use only one drive letter for the operating system, and all other drive letters are available as normal cluster drives or cluster drives hosting mount points, you are limited to a maximum of 25 instances of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] per failover cluster.  
  
        > [!TIP]  
        >  The 25 instance limit can be overcome by using SMB file share option. If you use SMB file share as the storage option, you can install up to 50 [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster instances.  
  
    -   Formatting a drive after mounting additional drives is not supported.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster installation supports Local Disk only for installing the tempdb files. Ensure that the path specified for the tempdb data and log files is valid on all the cluster nodes. During failover, if the tempdb directories are not available on the failover target node, the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] resource will fail to come online. For more information, see [Storage Types for Data Files](../../Topics\TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md) and [Database Engine Configuration - Data Directories](../../Topics\TopicNameNotContainA/Database-Engine-Configuration---Data-Directories.md).  
  
-   If you deploy a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster on iSCSI technology components, we recommend that you use appropriate caution. For more information, see [Support for SQL Server on iSCSI technology components](http://go.microsoft.com/fwlink/?LinkId=116960).  
  
-   For more information, see [SQL Server support policy for Microsoft Clustering](http://go.microsoft.com/fwlink/?LinkId=116958).  
  
-   For more information about proper quorum drive configuration, see [Quorum Drive Configuration Information](http://go.microsoft.com/fwlink/?LinkId=196816).  
  
-   To install a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster when the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] source installation files and the cluster exist on different domains, copy the installation files to the current domain available to the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster.  
  
##  <a name="Security"></a> Review Security Considerations  
  
-   To use encryption, install the server certificate with the fully qualified DNS name of the WSFC cluster on all nodes in the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster. For example, if you have a two\-node cluster, with nodes named "Test1.DomainName.com" and "Test2.DomainName.com" and a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster instance named "Virtsql", you must get a certificate for "Virtsql.DomainName.com" and install the certificate on the test1 and test2 nodes. Then you can select the **Force protocol encryption** check box on the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Configuration Manager to configure your failover cluster for encryption.  
  
    > [!IMPORTANT]  
    >  Do not select the **Force protocol encryption** check box until you have certificates installed on all participating nodes in your failover cluster instance.  
  
-   For [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installations in side\-by\-side configurations with previous versions, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] services must use accounts found only in the global domains group. Additionally, accounts used by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] services must not appear in the local Administrators group. Failure to comply with this guideline will result in unexpected security behavior.  
  
-   To create a failover cluster, you must be a local administrator with permissions to log on as a service, and to act as part of the operating system on all nodes of the failover cluster instance.  
  
-   On [!INCLUDE[nextref_longhorn](../../Token\Other/nextref_longhorn_md.md)], service SIDs are generated automatically for use with [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] services. For [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] failover cluster instances upgraded from previous versions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], existing domain groups and ACL configurations will be preserved.  
  
-   Domain groups must be within the same domain as the machine accounts. For example, if the machine where [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will be installed is in the SQLSVR domain which is a child of MYDOMAIN, you must specify a group in the SQLSVR domain. The SQLSVR domain may contain user accounts from MYDOMAIN.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clustering cannot be installed where cluster nodes are domain controllers.  
  
-   Review content in [Security Considerations for a SQL Server Installation](../../Topics\TopicNameContainA/Security-Considerations-for-a-SQL-Server-Installation.md).  
  
-   To enable Kerberos authentication with [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], see [How to use Kerberos authentication in SQL Server](http://support.microsoft.com/kb/319723) in the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Knowledge Base.  
  
##  <a name="Network"></a> Review Network, Port, and Firewall Considerations  
  
-   Verify that you have disabled NetBIOS for all private network cards before beginning [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup.  
  
-   The network name and IP address of your [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] should not be used for any other purpose, such as file sharing. If you want to create a file share resource, use a different, unique network name and IP address for the resource.  
  
    > [!IMPORTANT]  
    >  We recommend that you do not use file shares on data drives, because they can affect [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] behavior and performance.  
  
-   Even though [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] supports both Named Pipes and TCP\/IP Sockets over TCP\/IP within a cluster, we recommend that you use TCP\/IP Sockets in a clustered configuration.  
  
-   Note that ISA server is not supported on Windows Clustering and consequently is also not supported on [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clusters.  
  
-   The Remote Registry service must be up and running.  
  
-   Remote Administration must be enabled.  
  
-   For the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] port, use [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Configuration Manager to check the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] network configuration for the TCP\/IP protocol for the instance you want to unblock. You must enable the TCP port for IPALL if you want to connect to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] using TCP after installation. By default, SQL Browser listens on UDP port 1434.  
  
-   Failover cluster Setup operations include a rule that checks network binding order. Although binding orders might seem correct, you might have disabled or "ghosted" NIC configurations on the system. "Ghosted" NIC configurations can affect the binding order and cause the binding order rule to issue a warning. To avoid this situation, use the following steps to identify and remove disabled network adapters:  
  
    1.  At a command prompt, type: set devmgr\_Show\_Nonpersistent\_Devices\=1.  
  
    2.  Type and run: start Devmgmt.msc.  
  
    3.  Expand the list of network adapters. Only the physical adapters should be in the list. If you have a disabled network adapter, Setup will report a failure for the network binding order rule. Control Panel\/Network Connections will also show that adapter was disabled. Confirm that Network Settings in Control Panel shows the same list of enabled physical adapters that devmgmt.msc shows.  
  
    4.  Remove disabled network adapters before you run [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup.  
  
    5.  After Setup finishes, return to Network Connections in Control Panel and disable any network adapters that are not currently in use.  
  
##  <a name="OS_Support"></a> Verify Your Operating System  
 Make sure that your operating system is installed properly and is designed to support failover clustering. The following table is a list of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] editions and the operating systems that support them.  
  
|[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] edition|[!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] Enterprise|[!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] Datacenter Server|[!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Enterprise|[!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] Datacenter Server|  
|---------------------------------------|------------------------------------------------|-------------------------------------------------------|----------------------------------------------|-----------------------------------------------------|  
|[!INCLUDE[ssSQL14](../../Token\Other/ssSQL14_md.md)] Enterprise \(64\-bit\) x64\*|Yes|Yes|Yes\*\*|Yes\*\*|  
|[!INCLUDE[ssSQL14](../../Token\Other/ssSQL14_md.md)] Enterprise \(32\-bit\)|Yes|Yes|||  
|[!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] –bit\) Developer \(64|Yes|Yes|Yes\*\*|Yes\*\*|  
|[!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] Developer \(32\-bit\)|Yes|Yes|||  
|[!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] Standard \(64\-bit\)|Yes|Yes|Yes|Yes|  
|[!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] Standard \(32\-bit\)|Yes|Yes|||  
  
 \*[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] clusters are not supported in WOW mode. That includes upgrades from previous versions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover clusters that were originally installed in WOW. For those the only upgrade option is to install the new version side by side and migrate.  
  
 \*\*Supported for [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] multi\-subnet failover clustering.  
  
##  <a name="MultiSubnet"></a> Additional Considerations for Multi\-Subnet Configurations  
 The sections below describe the requirements to keep in mind when installing a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] multi\-subnet failover cluster. A multi\-subnet configuration involves clustering across multiple subnets, therefore involves using multiple IP addresses and changes to IP address resource dependencies.  
  
### [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Edition and Operating System Considerations  
  
-   For information about the editions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] that support a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] multi\-subnet failover cluster, see [Features Supported by the Editions of SQL Server 2016](../../Topics\TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
-   To create a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] multi\-subnet failover cluster, you must first create the [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] multi\-site failover cluster on multiple subnets.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster depends on the Windows Server failover cluster to make sure that the IP dependency conditions are valid if there is a failover.  
  
-   [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] requires that all the cluster servers must be in the same Active Directory domain. Therefore, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] multi\-subnet failover cluster requires that all the cluster nodes be in the same Active Directory domain even if they are in different subnets.  
  
#### IP Address and IP Address Resource Dependencies  
  
1.  The IP Address resource dependency is set to OR in a multi\-subnet configuration. For more information, see [Create a New SQL Server Failover Cluster &#40;Setup&#41;](../Topic/Create%20a%20New%20SQL%20Server%20Failover%20Cluster%20\(Setup\).md)  
  
2.  Mixed AND\-OR IP address dependencies are not supported. For example, \<IP1\> AND \<IP2\> OR \<IP3\> is not supported.  
  
3.  More than one IP address per subnet is not supported.  
  
     If you decide to use more than one IP address configured for the same subnet, you may experience client connection failures during [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] startup.  
  
#### Related Content  
 For more information about [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)] multi\-site failover, see [Windows Server 2008 R2 Failover Clustering Site](http://technet.microsoft.com/library/ff182338\(v=WS.10\).aspx) and [Design for a Clustered Service or Application in a Multi\-Site Failover Cluster](http://go.microsoft.com/fwlink/?LinkId=177873).  
  
##  <a name="WSFC"></a> Configure Windows Server Failover Cluster  
  
-   [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Cluster Service \(WSFC\) must be configured on at least one node of your server cluster. You must also run [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Enterprise, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Business Intelligence, or [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Standard in conjunction with WSFC. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Enterprise support failover clusters with up to 16 nodes. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Business Intelligence and [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Standard supports two\-node failover clusters.  
  
-   The resource DLL for the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service exports two functions used by WSFC Cluster Manager to check for availability of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] resource. For more information, see [Failover Policy for Failover Cluster Instances](../../Topics\TopicNameNotContainA/Failover-Policy-for-Failover-Cluster-Instances.md).  
  
-   WSFC must be able to verify that the failover clustered instance is running by using the IsAlive check. This requires connecting to the server by using a trusted connection. By default, the account that runs the cluster service is not configured as an administrator on nodes in the cluster, and the BUILTIN\\Administrators group does not have permission to log into [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. These settings change only if you change permissions on the cluster nodes.  
  
-   Configure Domain Name Service \(DNS\) or Windows Internet Name Service \(WINS\). A DNS server or WINS server must be running in the environment where your [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] failover cluster will be installed. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup requires dynamic domain name service registration of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] IP interface virtual reference. DNS server configuration should allow cluster nodes to dynamically register an online IP address map to Network Name. If the dynamic registration cannot be completed, Setup fails and the installation is rolled back. For more information, see [this knowledgebase article](http://support.microsoft.com/kb/947048)  
  
##  <a name="MSDTC"></a> Install [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Distributed Transaction Coordinator  
 Before installing [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a failover cluster, determine whether the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Distributed Transaction Coordinator \(MSDTC\) cluster resource must be created. If you are installing only the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)], the MSDTC cluster resource is not required. If you are installing the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and SSIS, Workstation Components, or if you will use distributed transactions, you must install MSDTC. Note that MSDTC is not required for [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)]\-only instances.  
  
 On [!INCLUDE[firstref_longhorn](../../Token\Other/firstref_longhorn_md.md)] and [!INCLUDE[winserver2008r2](../../Token\Other/winserver2008r2_md.md)], you can install multiple instances of MSDTC on a single failover cluster. The first instance of MSDTC that is installed will be the cluster default instance of MSDTC. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will take advantage of an instance of MSDTC installed to the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] local cluster resource group by automatically using the instance of MSDTC. However, individual applications can be mapped to any instance of MSDTC on the cluster.  
  
 The following rules are applied for an instance of MSDTC to be chosen by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]:  
  
-   Use MSDTC installed to the local group, else  
  
-   Use the mapped instance of MSDTC, else  
  
-   Use the cluster's default instance of MSDTC, else  
  
-   Use the local machine’s installed instance of MSDTC  
  
> [!IMPORTANT]  
>  If the MSDTC instance that is installed to the local cluster group of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] fails, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] does not automatically attempt to use the default cluster instance or the local machine instance of MSDTC. You would need to completely remove the failed instance of MSDTC from the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] group to use another instance of MSDTC. Likewise, if you create a mapping for [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] and the mapped instance of MSDTC fails, your distributed transactions will also fail. If you want [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to use a different instance of MSDTC, you must either add an instance of MSDTC to the local cluster group of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] or delete the mapping.  
  
### Configure [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Distributed Transaction Coordinator  
 After you install the operating system and configure your cluster, you must configure MSDTC to work in a cluster by using the Cluster Administrator. Failure to cluster MSDTC will not block [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup, but [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] application functionality may be affected if MSDTC is not properly configured.  
  
## See Also  
 [Hardware and Software Requirements for Installing SQL Server 2016](../../Topics\TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md)   
 [Check Parameters for the System Configuration Checker](../../Topics\TopicNameNotContainA/Check-Parameters-for-the-System-Configuration-Checker.md)   
 [Failover Cluster Instance Administration and Maintenance](../../Topics\TopicNameNotContainA/Failover-Cluster-Instance-Administration-and-Maintenance.md)  
  
  