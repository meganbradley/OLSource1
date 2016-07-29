---
title: "TCP/IP Properties (IP Addresses Tab)"
ms.custom: na
ms.date: 2016-02-29
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4c17ed45-9da7-4bec-bce6-970109fe7365
caps.latest.revision: 46
manager: jhubbard
---
# TCP/IP Properties (IP Addresses Tab)
  Use the **TCP/IP Properties (IP Addresses Tab)** dialog box to configure the TCP/IP protocol options for a specific IP address. Only **TCP Dynamic Ports** and **TCP Port** can be configured for all addresses at once by selecting **IP All**.  
  
 Changes take effect when [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is restarted. For information about starting and stopping the SQL Server Browser service, see How to: Start and Stop the SQL Server Browser Service in Books Online.  
  
## Static vs. Dynamic Ports  
 The default instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] listens for incoming connections on port 1433. The port can be changed for security reasons or because of a client application requirement. By default, named instances (including SQL Server Express) are configured to listen on dynamic ports. To configure a static port, leave the **TCP Dynamic Ports** box blank and provide an available port number in the **TCP Port** box. For more information about opening ports in the firewall, see Configuring the Windows Firewall to Allow SQL Server Access in Books Online.  
  
## Dynamic Ports  
 At startup, when an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is configured to listen on dynamic ports, it checks with the operating system for an available port, and opens an endpoint for that port. Incoming connections must specify that port number to connect. Since the port number can change each time [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] starts, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] provides the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Browser Service, to monitor the ports, and direct incoming connections to the current port for that instance. Using dynamic ports complicates connecting [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] through a firewall because the port number may change when [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is restarted, requiring changes to the firewall settings. To avoid connection problems through a firewall, configure [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] to use a static port.  
  
## Options  
 **Active**  
 Indicates that the IP address is active on the computer. Not available for **IPAll**.  
  
 **Enabled**  
 If the **Listen All** property on the **TCP/IP Properties (Protocol Tab)** is set to **No**, this property indicates whether SQL Server is listening on the IP address. If the **Listen All** property on the **TCP/IP Properties (Protocol Tab)** is set to **Yes**, the property is disregarded. Not available for **IPAll**.  
  
 **IP Address**  
 View or change the IP address used by this connection. Lists the IP address used by the computer, and the IP loopback address, 127.0.0.1. Not available for **IPAll**. The IP address can be in either IPv4 or IPv6 format.  
  
 **TCP Dynamic Ports**  
 Blank, if dynamic ports are not enabled. To use dynamic ports, set to 0.  
  
 For **IPAll**, displays the port number of the dynamic port used.  
  
 **TCP Port**  
 View or change the port on which [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] listens. By default, the default instance of [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] listens on port 1433.  
  
 [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] can listen on multiple ports on the same IP address, list the ports, separated by commas, in the format 1433,1500,1501. This field is limited to 2047 characters.  
  
 To configure a single IP address to listen on multiple ports, the **Listen All** parameter must also be set to **No**, on the **Protocols Tab** of the **TCP/IP Properties** dialog box. For more information, see "How to: Configure the Database Engine to Listen on Multiple TCP Ports" in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Books Online.  
  
## Adding or Removing IP Addresses  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager displays the IP addresses that were available at the time [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] was installed. The available IP addresses can change when network cards are added or removed, when a dynamically assigned IP address expires, when the network structure is reconfigured, or when the computer changes its physical location such as a laptop computer connecting to the network in a different building. To change an IP address, edit the **IP Address** box, and then restart [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
## Additional topics in Books Online  
 Search MSDN for topics such as **Configure a Server to Listen on a Specific TCP Port (SQL Server Configuration Manager)** and **Configure the Database Engine to Listen on Multiple TCP Ports**.  
  
## See Also  
 [Choosing a Network Protocol](../Topic/Choosing%20a%20Network%20Protocol.md)   
 [Creating a Valid Connection String Using TCP IP](../../Topics/TopicNameContainA/Creating-a-Valid-Connection-String-Using-TCP-IP.md)   
 [SQL Server Browser Service](../../Topics/TopicNameNotContainA/SQL-Server-Browser-Service.md)  
  
  